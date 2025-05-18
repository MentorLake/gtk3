namespace MentorLake.Gdk;

public class GdkFrameClockHandle : GObjectHandle
{
}
public static class GdkFrameClockHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void after_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void before_paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void flush_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resume_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle self, IntPtr user_data);

}


public static class GdkFrameClockHandleExtensions
{
	public static T BeginUpdating<T>(this T frame_clock) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_begin_updating(frame_clock);
		return frame_clock;
	}

	public static T EndUpdating<T>(this T frame_clock) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_end_updating(frame_clock);
		return frame_clock;
	}

	public static MentorLake.Gdk.GdkFrameTimingsHandle GetCurrentTimings(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_current_timings(frame_clock);
	}

	public static long GetFrameCounter(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_frame_counter(frame_clock);
	}

	public static long GetFrameTime(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_frame_time(frame_clock);
	}

	public static long GetHistoryStart(this MentorLake.Gdk.GdkFrameClockHandle frame_clock)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_history_start(frame_clock);
	}

	public static T GetRefreshInfo<T>(this T frame_clock, long base_time, out long refresh_interval_return, out long presentation_time_return) where T : GdkFrameClockHandle
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		GdkFrameClockHandleExterns.gdk_frame_clock_get_refresh_info(frame_clock, base_time, out refresh_interval_return, out presentation_time_return);
		return frame_clock;
	}

	public static MentorLake.Gdk.GdkFrameTimingsHandle GetTimings(this MentorLake.Gdk.GdkFrameClockHandle frame_clock, long frame_counter)
	{
		if (frame_clock.IsInvalid) throw new Exception("Invalid handle (GdkFrameClockHandle)");
		return GdkFrameClockHandleExterns.gdk_frame_clock_get_timings(frame_clock, frame_counter);
	}

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
