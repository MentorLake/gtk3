namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkGesture is the base object for gesture recognition, although this
/// object is quite generalized to serve as a base for multi-touch gestures,
/// it is suitable to implement single-touch and pointer-based gestures (using
/// the special %NULL #GdkEventSequence value for these).
/// </para>
/// <para>
/// The number of touches that a #GtkGesture need to be recognized is controlled
/// by the #GtkGesture:n-points property, if a gesture is keeping track of less
/// or more than that number of sequences, it won&apos;t check wether the gesture
/// is recognized.
/// </para>
/// <para>
/// As soon as the gesture has the expected number of touches, the gesture will
/// run the #GtkGesture::check signal regularly on input events until the gesture
/// is recognized, the criteria to consider a gesture as &quot;recognized&quot; is left to
/// #GtkGesture subclasses.
/// </para>
/// <para>
/// A recognized gesture will then emit the following signals:
/// - #GtkGesture::begin when the gesture is recognized.
/// - A number of #GtkGesture::update, whenever an input event is processed.
/// - #GtkGesture::end when the gesture is no longer recognized.
/// </para>
/// <para>
/// ## Event propagation
/// </para>
/// <para>
/// In order to receive events, a gesture needs to either set a propagation phase
/// through gtk_event_controller_set_propagation_phase(), or feed those manually
/// through gtk_event_controller_handle_event().
/// </para>
/// <para>
/// In the capture phase, events are propagated from the toplevel down to the
/// target widget, and gestures that are attached to containers above the widget
/// get a chance to interact with the event before it reaches the target.
/// </para>
/// <para>
/// After the capture phase, GTK+ emits the traditional #GtkWidget::button-press-event,
/// #GtkWidget::button-release-event, #GtkWidget::touch-event, etc signals. Gestures
/// with the %GTK_PHASE_TARGET phase are fed events from the default #GtkWidget::event
/// handlers.
/// </para>
/// <para>
/// In the bubble phase, events are propagated up from the target widget to the
/// toplevel, and gestures that are attached to containers above the widget get
/// a chance to interact with events that have not been handled yet.
/// </para>
/// <para>
/// ## States of a sequence # {#touch-sequence-states}
/// </para>
/// <para>
/// Whenever input interaction happens, a single event may trigger a cascade of
/// #GtkGestures, both across the parents of the widget receiving the event and
/// in parallel within an individual widget. It is a responsibility of the
/// widgets using those gestures to set the state of touch sequences accordingly
/// in order to enable cooperation of gestures around the #GdkEventSequences
/// triggering those.
/// </para>
/// <para>
/// Within a widget, gestures can be grouped through gtk_gesture_group(),
/// grouped gestures synchronize the state of sequences, so calling
/// gtk_gesture_set_sequence_state() on one will effectively propagate
/// the state throughout the group.
/// </para>
/// <para>
/// By default, all sequences start out in the #GTK_EVENT_SEQUENCE_NONE state,
/// sequences in this state trigger the gesture event handler, but event
/// propagation will continue unstopped by gestures.
/// </para>
/// <para>
/// If a sequence enters into the #GTK_EVENT_SEQUENCE_DENIED state, the gesture
/// group will effectively ignore the sequence, letting events go unstopped
/// through the gesture, but the &quot;slot&quot; will still remain occupied while
/// the touch is active.
/// </para>
/// <para>
/// If a sequence enters in the #GTK_EVENT_SEQUENCE_CLAIMED state, the gesture
/// group will grab all interaction on the sequence, by:
/// - Setting the same sequence to #GTK_EVENT_SEQUENCE_DENIED on every other gesture
///   group within the widget, and every gesture on parent widgets in the propagation
///   chain.
/// - calling #GtkGesture::cancel on every gesture in widgets underneath in the
///   propagation chain.
/// - Stopping event propagation after the gesture group handles the event.
/// </para>
/// <para>
/// Note: if a sequence is set early to #GTK_EVENT_SEQUENCE_CLAIMED on
/// #GDK_TOUCH_BEGIN/#GDK_BUTTON_PRESS (so those events are captured before
/// reaching the event widget, this implies #GTK_PHASE_CAPTURE), one similar
/// event will emulated if the sequence changes to #GTK_EVENT_SEQUENCE_DENIED.
/// This way event coherence is preserved before event propagation is unstopped
/// again.
/// </para>
/// <para>
/// Sequence states can&apos;t be changed freely, see gtk_gesture_set_sequence_state()
/// to know about the possible lifetimes of a #GdkEventSequence.
/// </para>
/// <para>
/// ## Touchpad gestures
/// </para>
/// <para>
/// On the platforms that support it, #GtkGesture will handle transparently
/// touchpad gesture events. The only precautions users of #GtkGesture should do
/// to enable this support are:
/// - Enabling %GDK_TOUCHPAD_GESTURE_MASK on their #GdkWindows
/// - If the gesture has %GTK_PHASE_NONE, ensuring events of type
///   %GDK_TOUCHPAD_SWIPE and %GDK_TOUCHPAD_PINCH are handled by the #GtkGesture
/// </para>
/// </summary>

public class GtkGestureHandle : GtkEventControllerHandle
{
}
public static class GtkGestureHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the gesture is recognized. This means the
/// number of touch sequences matches #GtkGesture:n-points, and the #GtkGesture::check
/// handler(s) returned #TRUE.
/// </para>
/// <para>
/// Note: These conditions may also happen when an extra touch (eg. a third touch
/// on a 2-touches gesture) is lifted, in that situation @sequence won&apos;t pertain
/// to the current set of active touches, so don&apos;t rely on this being true.
/// </para>
/// </summary>

	public static IObservable<GtkGestureHandleSignalStructs.BeginSignal> Signal_Begin(this GtkGestureHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureHandleSignalStructs.BeginSignal> obs) =>
		{
			GtkGestureHandleSignalDelegates.begin handler = ( MentorLake.Gtk.GtkGestureHandle self,  MentorLake.Gdk.GdkEventSequenceHandle sequence,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureHandleSignalStructs.BeginSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever a sequence is cancelled. This usually
/// happens on active touches when gtk_event_controller_reset() is called
/// on @gesture (manually, due to grabs...), or the individual @sequence
/// was claimed by parent widgets&apos; controllers (see gtk_gesture_set_sequence_state()).
/// </para>
/// <para>
/// @gesture must forget everything about @sequence as a reaction to this signal.
/// </para>
/// </summary>

	public static IObservable<GtkGestureHandleSignalStructs.CancelSignal> Signal_Cancel(this GtkGestureHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureHandleSignalStructs.CancelSignal> obs) =>
		{
			GtkGestureHandleSignalDelegates.cancel handler = ( MentorLake.Gtk.GtkGestureHandle self,  MentorLake.Gdk.GdkEventSequenceHandle sequence,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureHandleSignalStructs.CancelSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when @gesture either stopped recognizing the event
/// sequences as something to be handled (the #GtkGesture::check handler returned
/// %FALSE), or the number of touch sequences became higher or lower than
/// #GtkGesture:n-points.
/// </para>
/// <para>
/// Note: @sequence might not pertain to the group of sequences that were
/// previously triggering recognition on @gesture (ie. a just pressed touch
/// sequence that exceeds #GtkGesture:n-points). This situation may be detected
/// by checking through gtk_gesture_handles_sequence().
/// </para>
/// </summary>

	public static IObservable<GtkGestureHandleSignalStructs.EndSignal> Signal_End(this GtkGestureHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureHandleSignalStructs.EndSignal> obs) =>
		{
			GtkGestureHandleSignalDelegates.end handler = ( MentorLake.Gtk.GtkGestureHandle self,  MentorLake.Gdk.GdkEventSequenceHandle sequence,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureHandleSignalStructs.EndSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever a sequence state changes. See
/// gtk_gesture_set_sequence_state() to know more about the expectable
/// sequence lifetimes.
/// </para>
/// </summary>

	public static IObservable<GtkGestureHandleSignalStructs.SequenceStateChangedSignal> Signal_SequenceStateChanged(this GtkGestureHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureHandleSignalStructs.SequenceStateChangedSignal> obs) =>
		{
			GtkGestureHandleSignalDelegates.sequence_state_changed handler = ( MentorLake.Gtk.GtkGestureHandle self,  MentorLake.Gdk.GdkEventSequenceHandle sequence,  MentorLake.Gtk.GtkEventSequenceState state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureHandleSignalStructs.SequenceStateChangedSignal()
				{
					Self = self, Sequence = sequence, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "sequence-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever an event is handled while the gesture is
/// recognized. @sequence is guaranteed to pertain to the set of active touches.
/// </para>
/// </summary>

	public static IObservable<GtkGestureHandleSignalStructs.UpdateSignal> Signal_Update(this GtkGestureHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkGestureHandleSignalStructs.UpdateSignal> obs) =>
		{
			GtkGestureHandleSignalDelegates.update handler = ( MentorLake.Gtk.GtkGestureHandle self,  MentorLake.Gdk.GdkEventSequenceHandle sequence,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGestureHandleSignalStructs.UpdateSignal()
				{
					Self = self, Sequence = sequence, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkGestureHandleSignalStructs
{

public class BeginSignal
{

	public MentorLake.Gtk.GtkGestureHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSequence that made the gesture to be recognized
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;

	public IntPtr UserData;
}

public class CancelSignal
{

	public MentorLake.Gtk.GtkGestureHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSequence that was cancelled
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;

	public IntPtr UserData;
}

public class EndSignal
{

	public MentorLake.Gtk.GtkGestureHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSequence that made gesture recognition to finish
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;

	public IntPtr UserData;
}

public class SequenceStateChangedSignal
{

	public MentorLake.Gtk.GtkGestureHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSequence that was cancelled
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
/// <summary>
/// <para>
/// the new sequence state
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkEventSequenceState State;

	public IntPtr UserData;
}

public class UpdateSignal
{

	public MentorLake.Gtk.GtkGestureHandle Self;
/// <summary>
/// <para>
/// the #GdkEventSequence that was updated
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;

	public IntPtr UserData;
}
}

public static class GtkGestureHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the gesture is recognized. This means the
/// number of touch sequences matches #GtkGesture:n-points, and the #GtkGesture::check
/// handler(s) returned #TRUE.
/// </para>
/// <para>
/// Note: These conditions may also happen when an extra touch (eg. a third touch
/// on a 2-touches gesture) is lifted, in that situation @sequence won&apos;t pertain
/// to the current set of active touches, so don&apos;t rely on this being true.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sequence">
/// the #GdkEventSequence that made the gesture to be recognized
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a sequence is cancelled. This usually
/// happens on active touches when gtk_event_controller_reset() is called
/// on @gesture (manually, due to grabs...), or the individual @sequence
/// was claimed by parent widgets&apos; controllers (see gtk_gesture_set_sequence_state()).
/// </para>
/// <para>
/// @gesture must forget everything about @sequence as a reaction to this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sequence">
/// the #GdkEventSequence that was cancelled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when @gesture either stopped recognizing the event
/// sequences as something to be handled (the #GtkGesture::check handler returned
/// %FALSE), or the number of touch sequences became higher or lower than
/// #GtkGesture:n-points.
/// </para>
/// <para>
/// Note: @sequence might not pertain to the group of sequences that were
/// previously triggering recognition on @gesture (ie. a just pressed touch
/// sequence that exceeds #GtkGesture:n-points). This situation may be detected
/// by checking through gtk_gesture_handles_sequence().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sequence">
/// the #GdkEventSequence that made gesture recognition to finish
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a sequence state changes. See
/// gtk_gesture_set_sequence_state() to know more about the expectable
/// sequence lifetimes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sequence">
/// the #GdkEventSequence that was cancelled
/// </param>
/// <param name="state">
/// the new sequence state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sequence_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, MentorLake.Gtk.GtkEventSequenceState state, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever an event is handled while the gesture is
/// recognized. @sequence is guaranteed to pertain to the set of active touches.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="sequence">
/// the #GdkEventSequence that was updated
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);

}


public static class GtkGestureHandleExtensions
{
/// <summary>
/// <para>
/// If there are touch sequences being currently handled by @gesture,
/// this function returns %TRUE and fills in @rect with the bounding
/// box containing all active touches. Otherwise, %FALSE will be
/// returned.
/// </para>
/// <para>
/// Note: This function will yield unexpected results on touchpad
/// gestures. Since there is no correlation between physical and
/// pixel distances, these will look as if constrained in an
/// infinitely small area, @rect width and height will thus be 0
/// regardless of the number of touchpoints.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="rect">
/// bounding box containing all active touches.
/// </param>
/// <return>
/// %TRUE if there are active touches, %FALSE otherwise
/// </return>

	public static bool GetBoundingBox(this MentorLake.Gtk.GtkGestureHandle gesture, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_bounding_box(gesture, out rect);
	}

/// <summary>
/// <para>
/// If there are touch sequences being currently handled by @gesture,
/// this function returns %TRUE and fills in @x and @y with the center
/// of the bounding box containing all active touches. Otherwise, %FALSE
/// will be returned.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="x">
/// X coordinate for the bounding box center
/// </param>
/// <param name="y">
/// Y coordinate for the bounding box center
/// </param>
/// <return>
/// %FALSE if no active touches are present, %TRUE otherwise
/// </return>

	public static bool GetBoundingBoxCenter(this MentorLake.Gtk.GtkGestureHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_bounding_box_center(gesture, out x, out y);
	}

/// <summary>
/// <para>
/// Returns the master #GdkDevice that is currently operating
/// on @gesture, or %NULL if the gesture is not being interacted.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// a #GdkDevice, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_device(gesture);
	}

/// <summary>
/// <para>
/// Returns all gestures in the group of @gesture
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// The list
///   of #GtkGestures, free with g_list_free()
/// </return>

	public static MentorLake.GLib.GListHandle GetGroup(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_group(gesture);
	}

/// <summary>
/// <para>
/// Returns the last event that was processed for @sequence.
/// </para>
/// <para>
/// Note that the returned pointer is only valid as long as the @sequence
/// is still interpreted by the @gesture. If in doubt, you should make
/// a copy of the event.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="sequence">
/// a #GdkEventSequence
/// </param>
/// <return>
/// The last event from @sequence
/// </return>

	public static MentorLake.Gdk.GdkEventHandle GetLastEvent(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_last_event(gesture, sequence);
	}

/// <summary>
/// <para>
/// Returns the #GdkEventSequence that was last updated on @gesture.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// The last updated sequence
/// </return>

	public static MentorLake.Gdk.GdkEventSequenceHandle GetLastUpdatedSequence(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_last_updated_sequence(gesture);
	}

/// <summary>
/// <para>
/// If @sequence is currently being interpreted by @gesture, this
/// function returns %TRUE and fills in @x and @y with the last coordinates
/// stored for that event sequence. The coordinates are always relative to the
/// widget allocation.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="sequence">
/// a #GdkEventSequence, or %NULL for pointer events
/// </param>
/// <param name="x">
/// return location for X axis of the sequence coordinates
/// </param>
/// <param name="y">
/// return location for Y axis of the sequence coordinates
/// </param>
/// <return>
/// %TRUE if @sequence is currently interpreted
/// </return>

	public static bool GetPoint(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence, out double x, out double y)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_point(gesture, sequence, out x, out y);
	}

/// <summary>
/// <para>
/// Returns the @sequence state, as seen by @gesture.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="sequence">
/// a #GdkEventSequence
/// </param>
/// <return>
/// The sequence state in @gesture
/// </return>

	public static MentorLake.Gtk.GtkEventSequenceState GetSequenceState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_sequence_state(gesture, sequence);
	}

/// <summary>
/// <para>
/// Returns the list of #GdkEventSequences currently being interpreted
/// by @gesture.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// A list
///          of #GdkEventSequences, the list elements are owned by GTK+
///          and must not be freed or modified, the list itself must be deleted
///          through g_list_free()
/// </return>

	public static MentorLake.GLib.GListHandle GetSequences(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_sequences(gesture);
	}

/// <summary>
/// <para>
/// Returns the user-defined window that receives the events
/// handled by @gesture. See gtk_gesture_set_window() for more
/// information.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// the user defined window, or %NULL if none
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_window(gesture);
	}

/// <summary>
/// <para>
/// Adds @gesture to the same group than @group_gesture. Gestures
/// are by default isolated in their own groups.
/// </para>
/// <para>
/// When gestures are grouped, the state of #GdkEventSequences
/// is kept in sync for all of those, so calling gtk_gesture_set_sequence_state(),
/// on one will transfer the same value to the others.
/// </para>
/// <para>
/// Groups also perform an &quot;implicit grabbing&quot; of sequences, if a
/// #GdkEventSequence state is set to #GTK_EVENT_SEQUENCE_CLAIMED on one group,
/// every other gesture group attached to the same #GtkWidget will switch the
/// state for that sequence to #GTK_EVENT_SEQUENCE_DENIED.
/// </para>
/// </summary>

/// <param name="group_gesture">
/// #GtkGesture to group @gesture with
/// </param>
/// <param name="gesture">
/// a #GtkGesture
/// </param>

	public static T Group<T>(this T group_gesture, MentorLake.Gtk.GtkGestureHandle gesture) where T : GtkGestureHandle
	{
		if (group_gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		GtkGestureHandleExterns.gtk_gesture_group(group_gesture, gesture);
		return group_gesture;
	}

/// <summary>
/// <para>
/// Returns %TRUE if @gesture is currently handling events corresponding to
/// @sequence.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="sequence">
/// a #GdkEventSequence or %NULL
/// </param>
/// <return>
/// %TRUE if @gesture is handling @sequence, %FALSE otherwise
/// </return>

	public static bool HandlesSequence(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_handles_sequence(gesture, sequence);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the gesture is currently active.
/// A gesture is active meanwhile there are touch sequences
/// interacting with it.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// %TRUE if gesture is active
/// </return>

	public static bool IsActive(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_active(gesture);
	}

/// <summary>
/// <para>
/// Returns %TRUE if both gestures pertain to the same group.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="other">
/// another #GtkGesture
/// </param>
/// <return>
/// whether the gestures are grouped
/// </return>

	public static bool IsGroupedWith(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gtk.GtkGestureHandle other)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_grouped_with(gesture, other);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the gesture is currently recognized.
/// A gesture is recognized if there are as many interacting
/// touch sequences as required by @gesture, and #GtkGesture::check
/// returned %TRUE for the sequences being currently interpreted.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <return>
/// %TRUE if gesture is recognized
/// </return>

	public static bool IsRecognized(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_recognized(gesture);
	}

/// <summary>
/// <para>
/// Sets the state of @sequence in @gesture. Sequences start
/// in state #GTK_EVENT_SEQUENCE_NONE, and whenever they change
/// state, they can never go back to that state. Likewise,
/// sequences in state #GTK_EVENT_SEQUENCE_DENIED cannot turn
/// back to a not denied state. With these rules, the lifetime
/// of an event sequence is constrained to the next four:
/// </para>
/// <para>
/// * None
/// * None → Denied
/// * None → Claimed
/// * None → Claimed → Denied
/// </para>
/// <para>
/// Note: Due to event handling ordering, it may be unsafe to
/// set the state on another gesture within a #GtkGesture::begin
/// signal handler, as the callback might be executed before
/// the other gesture knows about the sequence. A safe way to
/// perform this could be:
/// </para>
/// <code>
/// static void
/// static void
/// first_gesture_begin_cb (GtkGesture       *first_gesture,
///                         GdkEventSequence *sequence,
///                         gpointer          user_data)
/// {
///   gtk_gesture_set_sequence_state (first_gesture, sequence, GTK_EVENT_SEQUENCE_CLAIMED);
///   gtk_gesture_set_sequence_state (second_gesture, sequence, GTK_EVENT_SEQUENCE_DENIED);
/// }
/// 
/// static void
/// second_gesture_begin_cb (GtkGesture       *second_gesture,
///                          GdkEventSequence *sequence,
///                          gpointer          user_data)
/// {
///   if (gtk_gesture_get_sequence_state (first_gesture, sequence) == GTK_EVENT_SEQUENCE_CLAIMED)
///     gtk_gesture_set_sequence_state (second_gesture, sequence, GTK_EVENT_SEQUENCE_DENIED);
/// }
/// </code>
/// <para>
/// If both gestures are in the same group, just set the state on
/// the gesture emitting the event, the sequence will be already
/// be initialized to the group&apos;s global state when the second
/// gesture processes the event.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="sequence">
/// a #GdkEventSequence
/// </param>
/// <param name="state">
/// the sequence state
/// </param>
/// <return>
/// %TRUE if @sequence is handled by @gesture,
///          and the state is changed successfully
/// </return>

	public static bool SetSequenceState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence, MentorLake.Gtk.GtkEventSequenceState state)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_set_sequence_state(gesture, sequence, state);
	}

/// <summary>
/// <para>
/// Sets the state of all sequences that @gesture is currently
/// interacting with. See gtk_gesture_set_sequence_state()
/// for more details on sequence states.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="state">
/// the sequence state
/// </param>
/// <return>
/// %TRUE if the state of at least one sequence
///     was changed successfully
/// </return>

	public static bool SetState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gtk.GtkEventSequenceState state)
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_set_state(gesture, state);
	}

/// <summary>
/// <para>
/// Sets a specific window to receive events about, so @gesture
/// will effectively handle only events targeting @window, or
/// a child of it. @window must pertain to gtk_event_controller_get_widget().
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>
/// <param name="window">
/// a #GdkWindow, or %NULL
/// </param>

	public static T SetWindow<T>(this T gesture, MentorLake.Gdk.GdkWindowHandle window) where T : GtkGestureHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		GtkGestureHandleExterns.gtk_gesture_set_window(gesture, window);
		return gesture;
	}

/// <summary>
/// <para>
/// Separates @gesture into an isolated group.
/// </para>
/// </summary>

/// <param name="gesture">
/// a #GtkGesture
/// </param>

	public static T Ungroup<T>(this T gesture) where T : GtkGestureHandle
	{
		if (gesture.IsInvalid) throw new Exception("Invalid handle (GtkGestureHandle)");
		GtkGestureHandleExterns.gtk_gesture_ungroup(gesture);
		return gesture;
	}

}

internal class GtkGestureHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_get_bounding_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_get_bounding_box_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, out double x, out double y);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gtk_gesture_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_gesture_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gtk_gesture_get_last_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))]
	internal static extern MentorLake.Gdk.GdkEventSequenceHandle gtk_gesture_get_last_updated_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_get_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, out double x, out double y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEventSequenceState gtk_gesture_get_sequence_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_gesture_get_sequences([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_gesture_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle group_gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_handles_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_is_grouped_with([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_is_recognized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_set_sequence_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, MentorLake.Gtk.GtkEventSequenceState state);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gtk.GtkEventSequenceState state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_set_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gesture_ungroup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

}
