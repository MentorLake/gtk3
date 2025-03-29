namespace MentorLake.Gio;

public class GFileMonitorHandle : GObjectHandle
{
}
public static class GFileMonitorHandleSignalExtensions
{

	public static IObservable<GFileMonitorHandleSignalStructs.ChangedSignal> Signal_Changed(this GFileMonitorHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GFileMonitorHandleSignalStructs.ChangedSignal> obs) =>
		{
			GFileMonitorHandleSignalDelegates.changed handler = ( MentorLake.Gio.GFileMonitorHandle self,  MentorLake.Gio.GFileHandle file,  MentorLake.Gio.GFileHandle other_file,  MentorLake.Gio.GFileMonitorEvent event_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GFileMonitorHandleSignalStructs.ChangedSignal()
				{
					Self = self, File = file, OtherFile = other_file, EventType = event_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GFileMonitorHandleSignalStructs
{

public struct ChangedSignal
{
	public MentorLake.Gio.GFileMonitorHandle Self;
	public MentorLake.Gio.GFileHandle File;
	public MentorLake.Gio.GFileHandle OtherFile;
	public MentorLake.Gio.GFileMonitorEvent EventType;
	public IntPtr UserData;
}
}

public static class GFileMonitorHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type, IntPtr user_data);

}


public static class GFileMonitorHandleExtensions
{
	public static bool Cancel(this MentorLake.Gio.GFileMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GFileMonitorHandle)");
		return GFileMonitorHandleExterns.g_file_monitor_cancel(monitor);
	}

	public static T EmitEvent<T>(this T monitor, MentorLake.Gio.GFileHandle child, MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type) where T : GFileMonitorHandle
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GFileMonitorHandle)");
		GFileMonitorHandleExterns.g_file_monitor_emit_event(monitor, child, other_file, event_type);
		return monitor;
	}

	public static bool IsCancelled(this MentorLake.Gio.GFileMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GFileMonitorHandle)");
		return GFileMonitorHandleExterns.g_file_monitor_is_cancelled(monitor);
	}

	public static T SetRateLimit<T>(this T monitor, int limit_msecs) where T : GFileMonitorHandle
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GFileMonitorHandle)");
		GFileMonitorHandleExterns.g_file_monitor_set_rate_limit(monitor, limit_msecs);
		return monitor;
	}

}

internal class GFileMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_monitor_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_monitor_emit_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle other_file, MentorLake.Gio.GFileMonitorEvent event_type);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_monitor_is_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_monitor_set_rate_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileMonitorHandle>))] MentorLake.Gio.GFileMonitorHandle monitor, int limit_msecs);

}
