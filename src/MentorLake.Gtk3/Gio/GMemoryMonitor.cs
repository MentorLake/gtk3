namespace MentorLake.Gtk3.Gio;

public interface GMemoryMonitorHandle
{
}

internal class GMemoryMonitorHandleImpl : BaseSafeHandle, GMemoryMonitorHandle
{
}

public static class GMemoryMonitorHandleExtensions
{
	public static GMemoryMonitorHandle DupDefault()
	{
		return GMemoryMonitorExterns.g_memory_monitor_dup_default();
	}

}

internal class GMemoryMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GMemoryMonitorHandle g_memory_monitor_dup_default();

}
