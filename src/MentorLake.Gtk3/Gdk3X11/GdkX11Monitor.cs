namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11MonitorHandle : GdkMonitorHandle
{
	public static ulong GetOutput(GdkMonitorHandle monitor)
	{
		return GdkX11MonitorExterns.gdk_x11_monitor_get_output(monitor);
	}

}

public static class GdkX11MonitorHandleExtensions
{
}

internal class GdkX11MonitorExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern ulong gdk_x11_monitor_get_output(GdkMonitorHandle monitor);

}
