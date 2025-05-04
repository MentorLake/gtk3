namespace MentorLake.Gtk;

public class GtkGestureHandle : GtkEventControllerHandle
{
}
public static class GtkGestureHandleSignalExtensions
{

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
	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public class CancelSignal
{
	public MentorLake.Gtk.GtkGestureHandle Self;
	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public class EndSignal
{
	public MentorLake.Gtk.GtkGestureHandle Self;
	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}

public class SequenceStateChangedSignal
{
	public MentorLake.Gtk.GtkGestureHandle Self;
	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
	public MentorLake.Gtk.GtkEventSequenceState State;
	public IntPtr UserData;
}

public class UpdateSignal
{
	public MentorLake.Gtk.GtkGestureHandle Self;
	public MentorLake.Gdk.GdkEventSequenceHandle Sequence;
	public IntPtr UserData;
}
}

public static class GtkGestureHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void sequence_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, MentorLake.Gtk.GtkEventSequenceState state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, IntPtr user_data);

}


public static class GtkGestureHandleExtensions
{
	public static bool GetBoundingBox(this MentorLake.Gtk.GtkGestureHandle gesture, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_bounding_box(gesture, out rect);
	}

	public static bool GetBoundingBoxCenter(this MentorLake.Gtk.GtkGestureHandle gesture, out double x, out double y)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_bounding_box_center(gesture, out x, out y);
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetDevice(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_device(gesture);
	}

	public static MentorLake.GLib.GListHandle GetGroup(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_group(gesture);
	}

	public static MentorLake.Gdk.GdkEventHandle GetLastEvent(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_last_event(gesture, sequence);
	}

	public static MentorLake.Gdk.GdkEventSequenceHandle GetLastUpdatedSequence(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_last_updated_sequence(gesture);
	}

	public static bool GetPoint(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence, out double x, out double y)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_point(gesture, sequence, out x, out y);
	}

	public static MentorLake.Gtk.GtkEventSequenceState GetSequenceState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_sequence_state(gesture, sequence);
	}

	public static MentorLake.GLib.GListHandle GetSequences(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_sequences(gesture);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_get_window(gesture);
	}

	public static T Group<T>(this T group_gesture, MentorLake.Gtk.GtkGestureHandle gesture) where T : GtkGestureHandle
	{
		if (group_gesture.IsInvalid || group_gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		GtkGestureHandleExterns.gtk_gesture_group(group_gesture, gesture);
		return group_gesture;
	}

	public static bool HandlesSequence(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_handles_sequence(gesture, sequence);
	}

	public static bool IsActive(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_active(gesture);
	}

	public static bool IsGroupedWith(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gtk.GtkGestureHandle other)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_grouped_with(gesture, other);
	}

	public static bool IsRecognized(this MentorLake.Gtk.GtkGestureHandle gesture)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_is_recognized(gesture);
	}

	public static bool SetSequenceState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gdk.GdkEventSequenceHandle sequence, MentorLake.Gtk.GtkEventSequenceState state)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_set_sequence_state(gesture, sequence, state);
	}

	public static bool SetState(this MentorLake.Gtk.GtkGestureHandle gesture, MentorLake.Gtk.GtkEventSequenceState state)
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		return GtkGestureHandleExterns.gtk_gesture_set_state(gesture, state);
	}

	public static T SetWindow<T>(this T gesture, MentorLake.Gdk.GdkWindowHandle window) where T : GtkGestureHandle
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
		GtkGestureHandleExterns.gtk_gesture_set_window(gesture, window);
		return gesture;
	}

	public static T Ungroup<T>(this T gesture) where T : GtkGestureHandle
	{
		if (gesture.IsInvalid || gesture.IsClosed) throw new Exception("Invalid or closed handle (GtkGestureHandle)");
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
	internal static extern MentorLake.Gdk.GdkDeviceHandle gtk_gesture_get_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_gesture_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventHandle gtk_gesture_get_last_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventSequenceHandle gtk_gesture_get_last_updated_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gesture_get_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence, out double x, out double y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkEventSequenceState gtk_gesture_get_sequence_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSequenceHandle>))] MentorLake.Gdk.GdkEventSequenceHandle sequence);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_gesture_get_sequences([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGestureHandle>))] MentorLake.Gtk.GtkGestureHandle gesture);

	[DllImport(GtkLibrary.Name)]
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
