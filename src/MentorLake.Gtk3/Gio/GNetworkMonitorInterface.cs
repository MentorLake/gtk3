namespace MentorLake.Gio;

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

public struct GNetworkMonitorInterface
{
	public GTypeInterface g_iface;
	public IntPtr network_changed;
	public IntPtr can_reach;
	public IntPtr can_reach_async;
	public IntPtr can_reach_finish;
}
