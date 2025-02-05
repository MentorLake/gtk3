namespace MentorLake.Gtk3.Gio;

public interface GNetworkMonitorHandle
{
}

internal class GNetworkMonitorHandleImpl : BaseSafeHandle, GNetworkMonitorHandle
{
}

public static class GNetworkMonitorHandleExtensions
{
	public static bool CanReach(this GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GNetworkMonitorExterns.g_network_monitor_can_reach(monitor, connectable, cancellable, out error);
	}

	public static T CanReachAsync<T>(this T monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GNetworkMonitorHandle
	{
		GNetworkMonitorExterns.g_network_monitor_can_reach_async(monitor, connectable, cancellable, callback, user_data);
		return monitor;
	}

	public static bool CanReachFinish(this GNetworkMonitorHandle monitor, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GNetworkMonitorExterns.g_network_monitor_can_reach_finish(monitor, result, out error);
	}

	public static GNetworkConnectivity GetConnectivity(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_connectivity(monitor);
	}

	public static bool GetNetworkAvailable(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_network_available(monitor);
	}

	public static bool GetNetworkMetered(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_network_metered(monitor);
	}

	public static GNetworkMonitorHandle GetDefault()
	{
		return GNetworkMonitorExterns.g_network_monitor_get_default();
	}

}

internal class GNetworkMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_can_reach(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_network_monitor_can_reach_async(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_can_reach_finish(GNetworkMonitorHandle monitor, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GNetworkConnectivity g_network_monitor_get_connectivity(GNetworkMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_get_network_available(GNetworkMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_get_network_metered(GNetworkMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern GNetworkMonitorHandle g_network_monitor_get_default();

}
