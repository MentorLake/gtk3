namespace MentorLake.Gio;

public interface GMemoryMonitorHandle
{
}

internal class GMemoryMonitorHandleImpl : BaseSafeHandle, GMemoryMonitorHandle
{
}

public static class GMemoryMonitorHandleExtensions
{
	public static MentorLake.Gio.GMemoryMonitorHandle DupDefault()
	{
		return GMemoryMonitorHandleExterns.g_memory_monitor_dup_default();
	}

}

internal class GMemoryMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMemoryMonitorHandle g_memory_monitor_dup_default();

}
