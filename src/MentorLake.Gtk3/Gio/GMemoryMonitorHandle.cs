namespace MentorLake.Gio;

public interface GMemoryMonitorHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GMemoryMonitorHandle g_memory_monitor_dup_default();

}
