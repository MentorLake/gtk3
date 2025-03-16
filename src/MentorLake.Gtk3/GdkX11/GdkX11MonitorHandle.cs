namespace MentorLake.GdkX11;

public class GdkX11MonitorHandle : GdkMonitorHandle
{
	public static ulong GetOutput(MentorLake.Gdk.GdkMonitorHandle monitor)
	{
		return GdkX11MonitorHandleExterns.gdk_x11_monitor_get_output(monitor);
	}

}

public static class GdkX11MonitorHandleExtensions
{
}

internal class GdkX11MonitorHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern ulong gdk_x11_monitor_get_output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkMonitorHandle>))] MentorLake.Gdk.GdkMonitorHandle monitor);

}
