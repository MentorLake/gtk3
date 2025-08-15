namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GNetworkMonitor` provides an easy-to-use cross-platform API
/// for monitoring network connectivity. On Linux, the available
/// implementations are based on the kernel&apos;s netlink interface and
/// on NetworkManager.
/// </para>
/// <para>
/// There is also an implementation for use inside Flatpak sandboxes.
/// </para>
/// </summary>

public interface GNetworkMonitorHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GNetworkMonitorHandleImpl : BaseSafeHandle, GNetworkMonitorHandle
{
}

public static class GNetworkMonitorHandleExtensions
{
/// <summary>
/// <para>
/// Attempts to determine whether or not the host pointed to by
/// @connectable can be reached, without actually trying to connect to
/// it.
/// </para>
/// <para>
/// This may return %TRUE even when #GNetworkMonitor:network-available
/// is %FALSE, if, for example, @monitor can determine that
/// @connectable refers to a host on a local network.
/// </para>
/// <para>
/// If @monitor believes that an attempt to connect to @connectable
/// will succeed, it will return %TRUE. Otherwise, it will return
/// %FALSE and set @error to an appropriate error (such as
/// %G_IO_ERROR_HOST_UNREACHABLE).
/// </para>
/// <para>
/// Note that although this does not attempt to connect to
/// @connectable, it may still block for a brief period of time (eg,
/// trying to do multicast DNS on the local network), so if you do not
/// want to block, you should use g_network_monitor_can_reach_async().
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GNetworkMonitor
/// </param>
/// <param name="connectable">
/// a #GSocketConnectable
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if @connectable is reachable, %FALSE if not.
/// </return>

	public static bool CanReach(this MentorLake.Gio.GNetworkMonitorHandle monitor, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		var externCallResult = GNetworkMonitorHandleExterns.g_network_monitor_can_reach(monitor, connectable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously attempts to determine whether or not the host
/// pointed to by @connectable can be reached, without actually
/// trying to connect to it.
/// </para>
/// <para>
/// For more details, see g_network_monitor_can_reach().
/// </para>
/// <para>
/// When the operation is finished, @callback will be called.
/// You can then call g_network_monitor_can_reach_finish()
/// to get the result of the operation.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GNetworkMonitor
/// </param>
/// <param name="connectable">
/// a #GSocketConnectable
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///     to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T CanReachAsync<T>(this T monitor, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GNetworkMonitorHandle
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		GNetworkMonitorHandleExterns.g_network_monitor_can_reach_async(monitor, connectable, cancellable, callback, user_data);
		return monitor;
	}

/// <summary>
/// <para>
/// Finishes an async network connectivity test.
/// See g_network_monitor_can_reach_async().
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GNetworkMonitor
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE if network is reachable, %FALSE if not.
/// </return>

	public static bool CanReachFinish(this MentorLake.Gio.GNetworkMonitorHandle monitor, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		var externCallResult = GNetworkMonitorHandleExterns.g_network_monitor_can_reach_finish(monitor, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets a more detailed networking state than
/// g_network_monitor_get_network_available().
/// </para>
/// <para>
/// If #GNetworkMonitor:network-available is %FALSE, then the
/// connectivity state will be %G_NETWORK_CONNECTIVITY_LOCAL.
/// </para>
/// <para>
/// If #GNetworkMonitor:network-available is %TRUE, then the
/// connectivity state will be %G_NETWORK_CONNECTIVITY_FULL (if there
/// is full Internet connectivity), %G_NETWORK_CONNECTIVITY_LIMITED (if
/// the host has a default route, but appears to be unable to actually
/// reach the full Internet), or %G_NETWORK_CONNECTIVITY_PORTAL (if the
/// host is trapped behind a &quot;captive portal&quot; that requires some sort
/// of login or acknowledgement before allowing full Internet access).
/// </para>
/// <para>
/// Note that in the case of %G_NETWORK_CONNECTIVITY_LIMITED and
/// %G_NETWORK_CONNECTIVITY_PORTAL, it is possible that some sites are
/// reachable but others are not. In this case, applications can
/// attempt to connect to remote servers, but should gracefully fall
/// back to their &quot;offline&quot; behavior if the connection attempt fails.
/// </para>
/// </summary>

/// <param name="monitor">
/// the #GNetworkMonitor
/// </param>
/// <return>
/// the network connectivity state
/// </return>

	public static MentorLake.Gio.GNetworkConnectivity GetConnectivity(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		return GNetworkMonitorHandleExterns.g_network_monitor_get_connectivity(monitor);
	}

/// <summary>
/// <para>
/// Checks if the network is available. &quot;Available&quot; here means that the
/// system has a default route available for at least one of IPv4 or
/// IPv6. It does not necessarily imply that the public Internet is
/// reachable. See #GNetworkMonitor:network-available for more details.
/// </para>
/// </summary>

/// <param name="monitor">
/// the #GNetworkMonitor
/// </param>
/// <return>
/// whether the network is available
/// </return>

	public static bool GetNetworkAvailable(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		return GNetworkMonitorHandleExterns.g_network_monitor_get_network_available(monitor);
	}

/// <summary>
/// <para>
/// Checks if the network is metered.
/// See #GNetworkMonitor:network-metered for more details.
/// </para>
/// </summary>

/// <param name="monitor">
/// the #GNetworkMonitor
/// </param>
/// <return>
/// whether the connection is metered
/// </return>

	public static bool GetNetworkMetered(this MentorLake.Gio.GNetworkMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GNetworkMonitorHandle)");
		return GNetworkMonitorHandleExterns.g_network_monitor_get_network_metered(monitor);
	}

/// <summary>
/// <para>
/// Gets the default #GNetworkMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a #GNetworkMonitor, which will be
///     a dummy object if no network monitor is available
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNetworkMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GNetworkMonitorHandle g_network_monitor_get_default();

}
