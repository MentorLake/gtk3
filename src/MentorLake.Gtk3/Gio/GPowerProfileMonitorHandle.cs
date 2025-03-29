namespace MentorLake.Gio;

public interface GPowerProfileMonitorHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GPowerProfileMonitorHandleImpl : BaseSafeHandle, GPowerProfileMonitorHandle
{
}

public static class GPowerProfileMonitorHandleExtensions
{
	public static bool GetPowerSaverEnabled(this MentorLake.Gio.GPowerProfileMonitorHandle monitor)
	{
		if (monitor.IsInvalid || monitor.IsClosed) throw new Exception("Invalid or closed handle (GPowerProfileMonitorHandle)");
		return GPowerProfileMonitorHandleExterns.g_power_profile_monitor_get_power_saver_enabled(monitor);
	}

	public static MentorLake.Gio.GPowerProfileMonitorHandle DupDefault()
	{
		return GPowerProfileMonitorHandleExterns.g_power_profile_monitor_dup_default();
	}

}

internal class GPowerProfileMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_power_profile_monitor_get_power_saver_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPowerProfileMonitorHandleImpl>))] MentorLake.Gio.GPowerProfileMonitorHandle monitor);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPowerProfileMonitorHandle g_power_profile_monitor_dup_default();

}
