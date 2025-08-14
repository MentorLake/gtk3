namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkFrameClock tells the application when to update and repaint a
/// window. This may be synced to the vertical refresh rate of the
/// monitor, for example. Even when the frame clock uses a simple timer
/// rather than a hardware-based vertical sync, the frame clock helps
/// because it ensures everything paints at the same time (reducing the
/// total number of frames). The frame clock can also automatically
/// stop painting when it knows the frames will not be visible, or
/// scale back animation framerates.
/// </para>
/// <para>
/// #GdkFrameClock is designed to be compatible with an OpenGL-based
/// implementation or with mozRequestAnimationFrame in Firefox,
/// for example.
/// </para>
/// <para>
/// A frame clock is idle until someone requests a frame with
/// gdk_frame_clock_request_phase(). At some later point that makes
/// sense for the synchronization being implemented, the clock will
/// process a frame and emit signals for each phase that has been
/// requested. (See the signals of the #GdkFrameClock class for
/// documentation of the phases. %GDK_FRAME_CLOCK_PHASE_UPDATE and the
/// #GdkFrameClock::update signal are most interesting for application
/// writers, and are used to update the animations, using the frame time
/// given by gdk_frame_clock_get_frame_time().
/// </para>
/// <para>
/// The frame time is reported in microseconds and generally in the same
/// timescale as g_get_monotonic_time(), however, it is not the same
/// as g_get_monotonic_time(). The frame time does not advance during
/// the time a frame is being painted, and outside of a frame, an attempt
/// is made so that all calls to gdk_frame_clock_get_frame_time() that
/// are called at a “similar” time get the same value. This means that
/// if different animations are timed by looking at the difference in
/// time between an initial value from gdk_frame_clock_get_frame_time()
/// and the value inside the #GdkFrameClock::update signal of the clock,
/// they will stay exactly synchronized.
/// </para>
/// </summary>

public class GdkFrameClockHandle : GObjectHandle
{
}
public static class GdkFrameClockHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal ends processing of the frame. Applications
/// should generally not handle this signal.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.AfterPaintSignal> Signal_AfterPaint(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.AfterPaintSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.after_paint handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.AfterPaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "after-paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal begins processing of the frame. Applications
/// should generally not handle this signal.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.BeforePaintSignal> Signal_BeforePaint(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.BeforePaintSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.before_paint handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.BeforePaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "before-paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is used to flush pending motion events that
/// are being batched up and compressed together. Applications
/// should not handle this signal.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.FlushEventsSignal> Signal_FlushEvents(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.FlushEventsSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.flush_events handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.FlushEventsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "flush-events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted as the second step of toolkit and
/// application processing of the frame. Any work to update
/// sizes and positions of application elements should be
/// performed. GTK+ normally handles this internally.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.LayoutSignal> Signal_Layout(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.LayoutSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.layout handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.LayoutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "layout", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted as the third step of toolkit and
/// application processing of the frame. The frame is
/// repainted. GDK normally handles this internally and
/// produces expose events, which are turned into GTK+
/// #GtkWidget::draw signals.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.PaintSignal> Signal_Paint(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.PaintSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.paint handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.PaintSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "paint", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted after processing of the frame is
/// finished, and is handled internally by GTK+ to resume normal
/// event processing. Applications should not handle this signal.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.ResumeEventsSignal> Signal_ResumeEvents(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.ResumeEventsSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.resume_events handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.ResumeEventsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "resume-events", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted as the first step of toolkit and
/// application processing of the frame. Animations should
/// be updated using gdk_frame_clock_get_frame_time().
/// Applications can connect directly to this signal, or
/// use gtk_widget_add_tick_callback() as a more convenient
/// interface.
/// </para>
/// </summary>

	public static IObservable<GdkFrameClockHandleSignalStructs.UpdateSignal> Signal_Update(this GdkFrameClockHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkFrameClockHandleSignalStructs.UpdateSignal> obs) =>
		{
			GdkFrameClockHandleSignalDelegates.update handler = ( MentorLake.Gdk.GdkFrameClockHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkFrameClockHandleSignalStructs.UpdateSignal()
				{
					Self = self, UserData = user_data
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

public static class GdkFrameClockHandleSignalStructs
{

public class AfterPaintSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class BeforePaintSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class FlushEventsSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class LayoutSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class PaintSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class ResumeEventsSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}

public class UpdateSignal
{

	public MentorLake.Gdk.GdkFrameClockHandle Self;

	public IntPtr UserData;
}
}

public static class GdkFrameClockHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal ends processing of the frame. Applications
/// should generally not handle this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void after_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal begins processing of the frame. Applications
/// should generally not handle this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void before_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is used to flush pending motion events that
/// are being batched up and compressed together. Applications
/// should not handle this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void flush_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted as the second step of toolkit and
/// application processing of the frame. Any work to update
/// sizes and positions of application elements should be
/// performed. GTK+ normally handles this internally.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted as the third step of toolkit and
/// application processing of the frame. The frame is
/// repainted. GDK normally handles this internally and
/// produces expose events, which are turned into GTK+
/// #GtkWidget::draw signals.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after processing of the frame is
/// finished, and is handled internally by GTK+ to resume normal
/// event processing. Applications should not handle this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resume_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted as the first step of toolkit and
/// application processing of the frame. Animations should
/// be updated using gdk_frame_clock_get_frame_time().
/// Applications can connect directly to this signal, or
/// use gtk_widget_add_tick_callback() as a more convenient
/// interface.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);

}


public static class GdkFrameClockHandleExtensions
{
/// <summary>
/// <para>
/// Starts updates for an animation. Until a matching call to
/// gdk_frame_clock_end_updating() is made, the frame clock will continually
/// request a new frame with the %GDK_FRAME_CLOCK_PHASE_UPDATE phase.
/// This function may be called multiple times and frames will be
/// requested until gdk_frame_clock_end_updating() is called the same
/// number of times.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>

	public static T BeginUpdating<T>(this T frame_clock) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_begin_updating(frame_clock);
		return frame_clock;
	}

/// <summary>
/// <para>
/// Stops updates for an animation. See the documentation for
/// gdk_frame_clock_begin_updating().
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>

	public static T EndUpdating<T>(this T frame_clock) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_end_updating(frame_clock);
		return frame_clock;
	}

/// <summary>
/// <para>
/// Gets the frame timings for the current frame.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <return>
/// the #GdkFrameTimings for the
///  frame currently being processed, or even no frame is being
///  processed, for the previous frame. Before any frames have been
///  processed, returns %NULL.
/// </return>

	public static MentorLake.Gdk.GdkFrameTimingsHandle GetCurrentTimings(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_current_timings(frame_clock);
	}

/// <summary>
/// <para>
/// A #GdkFrameClock maintains a 64-bit counter that increments for
/// each frame drawn.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <return>
/// inside frame processing, the value of the frame counter
///  for the current frame. Outside of frame processing, the frame
///   counter for the last frame.
/// </return>

	public static long GetFrameCounter(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_frame_counter(frame_clock);
	}

/// <summary>
/// <para>
/// Gets the time that should currently be used for animations.  Inside
/// the processing of a frame, it’s the time used to compute the
/// animation position of everything in a frame. Outside of a frame, it's
/// the time of the conceptual “previous frame,” which may be either
/// the actual previous frame time, or if that’s too old, an updated
/// time.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <return>
/// a timestamp in microseconds, in the timescale of
///  of g_get_monotonic_time().
/// </return>

	public static long GetFrameTime(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_frame_time(frame_clock);
	}

/// <summary>
/// <para>
/// #GdkFrameClock internally keeps a history of #GdkFrameTimings
/// objects for recent frames that can be retrieved with
/// gdk_frame_clock_get_timings(). The set of stored frames
/// is the set from the counter values given by
/// gdk_frame_clock_get_history_start() and
/// gdk_frame_clock_get_frame_counter(), inclusive.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <return>
/// the frame counter value for the oldest frame
///  that is available in the internal frame history of the
///  #GdkFrameClock.
/// </return>

	public static long GetHistoryStart(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_history_start(frame_clock);
	}

/// <summary>
/// <para>
/// Using the frame history stored in the frame clock, finds the last
/// known presentation time and refresh interval, and assuming that
/// presentation times are separated by the refresh interval,
/// predicts a presentation time that is a multiple of the refresh
/// interval after the last presentation time, and later than @base_time.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <param name="base_time">
/// base time for determining a presentaton time
/// </param>
/// <param name="refresh_interval_return">
/// a location to store the
/// determined refresh interval, or %NULL. A default refresh interval of
/// 1/60th of a second will be stored if no history is present.
/// </param>
/// <param name="presentation_time_return">
/// a location to store the next
///  candidate presentation time after the given base time.
///  0 will be will be stored if no history is present.
/// </param>

	public static T GetRefreshInfo<T>(this T frame_clock, long base_time, out long refresh_interval_return, out long presentation_time_return) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_get_refresh_info(frame_clock, base_time, out refresh_interval_return, out presentation_time_return);
		return frame_clock;
	}

/// <summary>
/// <para>
/// Retrieves a #GdkFrameTimings object holding timing information
/// for the current frame or a recent frame. The #GdkFrameTimings
/// object may not yet be complete: see gdk_frame_timings_get_complete().
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <param name="frame_counter">
/// the frame counter value identifying the frame to
///  be received.
/// </param>
/// <return>
/// the #GdkFrameTimings object for
///  the specified frame, or %NULL if it is not available. See
///  gdk_frame_clock_get_history_start().
/// </return>

	public static MentorLake.Gdk.GdkFrameTimingsHandle GetTimings(this MentorLake.Gdk.GdkFrameClockHandle frame_clock, long frame_counter)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_timings(frame_clock, frame_counter);
	}

/// <summary>
/// <para>
/// Asks the frame clock to run a particular phase. The signal
/// corresponding the requested phase will be emitted the next
/// time the frame clock processes. Multiple calls to
/// gdk_frame_clock_request_phase() will be combined together
/// and only one frame processed. If you are displaying animated
/// content and want to continually request the
/// %GDK_FRAME_CLOCK_PHASE_UPDATE phase for a period of time,
/// you should use gdk_frame_clock_begin_updating() instead, since
/// this allows GTK+ to adjust system parameters to get maximally
/// smooth animations.
/// </para>
/// </summary>

/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>
/// <param name="phase">
/// the phase that is requested
/// </param>

	public static T RequestPhase<T>(this T frame_clock, MentorLake.Gdk.GdkFrameClockPhase phase) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_request_phase(frame_clock, phase);
		return frame_clock;
	}

}

internal class GdkFrameClockHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_frame_clock_begin_updating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_frame_clock_end_updating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameTimingsHandle gdk_frame_clock_get_current_timings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_clock_get_frame_counter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_clock_get_frame_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	internal static extern long gdk_frame_clock_get_history_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_frame_clock_get_refresh_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock, long base_time, out long refresh_interval_return, out long presentation_time_return);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameTimingsHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameTimingsHandle gdk_frame_clock_get_timings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock, long frame_counter);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_frame_clock_request_phase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock, MentorLake.Gdk.GdkFrameClockPhase phase);

}
