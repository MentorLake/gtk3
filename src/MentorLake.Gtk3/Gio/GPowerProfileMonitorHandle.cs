namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GPowerProfileMonitor` makes it possible for applications as well as OS
/// components to monitor system power profiles and act upon them. It currently
/// only exports whether the system is in “Power Saver” mode (known as
/// “Low Power” mode on some systems).
/// </para>
/// <para>
/// When in “Low Power” mode, it is recommended that applications:
/// - disable automatic downloads;
/// - reduce the rate of refresh from online sources such as calendar or
///   email synchronisation;
/// - reduce the use of expensive visual effects.
/// </para>
/// <para>
/// It is also likely that OS components providing services to applications will
/// lower their own background activity, for the sake of the system.
/// </para>
/// <para>
/// There are a variety of tools that exist for power consumption analysis, but those
/// usually depend on the OS and hardware used. On Linux, one could use `upower` to
/// monitor the battery discharge rate, `powertop` to check on the background activity
/// or activity at all), `sysprof` to inspect CPU usage, and `intel_gpu_time` to
/// profile GPU usage.
/// </para>
/// <para>
/// Don’t forget to disconnect the [signal@GObject.Object::notify] signal for
/// [property@Gio.PowerProfileMonitor:power-saver-enabled], and unref the
/// `GPowerProfileMonitor` itself when exiting.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets whether the system is in “Power Saver” mode.
/// </para>
/// <para>
/// You are expected to listen to the
/// #GPowerProfileMonitor::notify::power-saver-enabled signal to know when the profile has
/// changed.
/// </para>
/// </summary>

/// <param name="monitor">
/// a #GPowerProfileMonitor
/// </param>
/// <return>
/// Whether the system is in “Power Saver” mode.
/// </return>

	public static bool GetPowerSaverEnabled(this MentorLake.Gio.GPowerProfileMonitorHandle monitor)
	{
		if (monitor.IsInvalid) throw new Exception("Invalid handle (GPowerProfileMonitorHandle)");
		return GPowerProfileMonitorHandleExterns.g_power_profile_monitor_get_power_saver_enabled(monitor);
	}

/// <summary>
/// <para>
/// Gets a reference to the default #GPowerProfileMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a new reference to the default #GPowerProfileMonitor
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPowerProfileMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GPowerProfileMonitorHandle g_power_profile_monitor_dup_default();

}
