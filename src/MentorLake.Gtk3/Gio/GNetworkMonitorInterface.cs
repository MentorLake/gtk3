namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GNetworkMonitor.
/// </para>
/// </summary>

public class GNetworkMonitorInterfaceHandle : BaseSafeHandle
{
}


public static class GNetworkMonitorInterfaceExtensions
{

	public static GNetworkMonitorInterface Dereference(this GNetworkMonitorInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNetworkMonitorInterface>(x.DangerousGetHandle());
}
internal class GNetworkMonitorInterfaceExterns
{
}

/// <summary>
/// <para>
/// The virtual function table for #GNetworkMonitor.
/// </para>
/// </summary>

public struct GNetworkMonitorInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for the
///  GNetworkMonitor::network-changed signal.
/// </para>
/// </summary>

public IntPtr network_changed;
	/// <summary>
/// <para>
/// the virtual function pointer for g_network_monitor_can_reach()
/// </para>
/// </summary>

public IntPtr can_reach;
	/// <summary>
/// <para>
/// the virtual function pointer for
///  g_network_monitor_can_reach_async()
/// </para>
/// </summary>

public IntPtr can_reach_async;
	/// <summary>
/// <para>
/// the virtual function pointer for
///  g_network_monitor_can_reach_finish()
/// </para>
/// </summary>

public IntPtr can_reach_finish;
}
