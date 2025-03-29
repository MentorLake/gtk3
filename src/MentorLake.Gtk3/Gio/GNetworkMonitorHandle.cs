namespace MentorLake.Gio;

public interface GNetworkMonitorHandle
{
}

internal class GNetworkMonitorHandleImpl : BaseSafeHandle, GNetworkMonitorHandle
{
}

public static class GNetworkMonitorHandleExtensions
{
	public static bool CanReach(this MentorLake.Gio.GNetworkMonitorHandle monitor, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GNetworkMonitorHandleExterns.g_network_monitor_can_reach(monitor, connectable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T CanReachAsync<T>(this T monitor, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GNetworkMonitorHandle
	{
		GNetworkMonitorHandleExterns.g_network_monitor_can_reach_async(monitor, connectable, cancellable, callback, user_data);
		return monitor;
	}

	public static bool CanReachFinish(this MentorLake.Gio.GNetworkMonitorHandle monitor, MentorLake.Gio.GAsyncResultHandle result)
	{
		var externCallResult = GNetworkMonitorHandleExterns.g_network_monitor_can_reach_finish(monitor, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GNetworkConnectivity GetConnectivity(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorHandleExterns.g_network_monitor_get_connectivity(monitor);
	}

	public static bool GetNetworkAvailable(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorHandleExterns.g_network_monitor_get_network_available(monitor);
	}

	public static bool GetNetworkMetered(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorHandleExterns.g_network_monitor_get_network_metered(monitor);
	}

	public static MentorLake.Gio.GNetworkMonitorHandle GetDefault()
	{
		return GNetworkMonitorHandleExterns.g_network_monitor_get_default();
	}

}

internal class GNetworkMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_network_monitor_can_reach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_network_monitor_can_reach_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_network_monitor_can_reach_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GNetworkConnectivity g_network_monitor_get_connectivity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_network_monitor_get_network_available([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_network_monitor_get_network_metered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))] MentorLake.Gio.GNetworkMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GNetworkMonitorHandle g_network_monitor_get_default();

}
