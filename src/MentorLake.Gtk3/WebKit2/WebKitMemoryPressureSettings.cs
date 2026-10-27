namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A boxed type representing the settings for the memory pressure handler
/// </para>
/// <para>
/// #WebKitMemoryPressureSettings is a boxed type that can be used to provide some custom settings
/// to control how the memory pressure situations are handled by the different processes.
/// </para>
/// <para>
/// The memory pressure system implemented inside the different process will try to keep the memory usage
/// under the defined memory limit. In order to do that, it will check the used memory with a user defined
/// frequency and decide whether it should try to release memory. The thresholds passed will define how urgent
/// is to release that memory.
/// </para>
/// <para>
/// Take into account that badly defined parameters can greatly reduce the performance of the engine. For
/// example, setting memory limit too low with a fast poll interval can cause the process to constantly
/// be trying to release memory.
/// </para>
/// <para>
/// A #WebKitMemoryPressureSettings can be passed to a #WebKitWebContext constructor, and the settings will
/// be applied to all the web processes created by that context.
/// </para>
/// <para>
/// A #WebKitMemoryPressureSettings can be passed to webkit_website_data_manager_set_memory_pressure_settings(),
/// and the settings will be applied to all the network processes created after that call by any instance of
/// #WebKitWebsiteDataManager.
/// </para>
/// </summary>

public class WebKitMemoryPressureSettingsHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitMemoryPressureSettings with the default values.
/// </para>
/// </summary>

/// <return>
/// A new #WebKitMemoryPressureSettings instance filled with the default values.
/// </return>

	public static MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle New()
	{
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_new();
	}

}


public static class WebKitMemoryPressureSettingsExtensions
{
/// <summary>
/// <para>
/// Make a copy of @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// A copy of of the passed #WebKitMemoryPressureSettings.
/// </return>

	public static MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle Copy(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_copy(settings);
	}

/// <summary>
/// <para>
/// Free the #WebKitMemoryPressureSettings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_free(settings);
	}

/// <summary>
/// <para>
/// Gets the conservative memory usage threshold.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// value in the `(0, 1)` range.
/// </return>

	public static double GetConservativeThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_get_conservative_threshold(settings);
	}

/// <summary>
/// <para>
/// Gets the kill memory usage threshold.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// positive value, can be zero.
/// </return>

	public static double GetKillThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_get_kill_threshold(settings);
	}

/// <summary>
/// <para>
/// Gets the memory usage limit.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// current value, in megabytes.
/// </return>

	public static uint GetMemoryLimit(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_get_memory_limit(settings);
	}

/// <summary>
/// <para>
/// Gets the interval at which memory usage is checked.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// current interval value, in seconds.
/// </return>

	public static double GetPollInterval(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_get_poll_interval(settings);
	}

/// <summary>
/// <para>
/// Gets the strict memory usage threshold.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <return>
/// value in the `(0, 1)` range.
/// </return>

	public static double GetStrictThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		return WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_get_strict_threshold(settings);
	}

/// <summary>
/// <para>
/// Sets the memory limit for the conservative policy to start working.
/// </para>
/// <para>
/// Sets @value as the fraction of the defined memory limit where the conservative
/// policy starts working. This policy will try to reduce the memory footprint by
/// releasing non critical memory.
/// </para>
/// <para>
/// The threshold must be bigger than 0 and smaller than 1, and it must be smaller
/// than the strict threshold defined in @settings. The default value is 0.33.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <param name="value">
/// fraction of the memory limit where the conservative policy starts working.
/// </param>

	public static void SetConservativeThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_set_conservative_threshold(settings, value);
	}

/// <summary>
/// <para>
/// Sets @value as the fraction of the defined memory limit where the process will be
/// killed.
/// </para>
/// <para>
/// The threshold must be a value bigger or equal to 0. A value of 0 means that the process
/// is never killed. If the threshold is not 0, then it must be bigger than the strict threshold
/// defined in @settings. The threshold can also have values bigger than 1. The default value is 0.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <param name="value">
/// fraction of the memory limit where the process will be killed because
///   of excessive memory usage.
/// </param>

	public static void SetKillThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_set_kill_threshold(settings, value);
	}

/// <summary>
/// <para>
/// Sets @memory_limit the memory limit value to @settings.
/// </para>
/// <para>
/// The default value is the system&apos;s RAM size with a maximum of 3GB.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <param name="memory_limit">
/// amount of memory (in MB) that the process is allowed to use.
/// </param>

	public static void SetMemoryLimit(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, uint memory_limit)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_set_memory_limit(settings, memory_limit);
	}

/// <summary>
/// <para>
/// Sets @value as the poll interval used by @settings.
/// </para>
/// <para>
/// The poll interval value must be bigger than 0. The default value is 30 seconds.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <param name="value">
/// period (in seconds) between memory usage measurements.
/// </param>

	public static void SetPollInterval(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_set_poll_interval(settings, value);
	}

/// <summary>
/// <para>
/// Sets the memory limit for the strict policy to start working.
/// </para>
/// <para>
/// Sets @value as the fraction of the defined memory limit where the strict
/// policy starts working. This policy will try to reduce the memory footprint by
/// releasing critical memory.
/// </para>
/// <para>
/// The threshold must be bigger than 0 and smaller than 1. Also, it must be bigger
/// than the conservative threshold defined in @settings, and smaller than the kill
/// threshold if the latter is not 0. The default value is 0.5.
/// </para>
/// </summary>

/// <param name="settings">
/// a #WebKitMemoryPressureSettings
/// </param>
/// <param name="value">
/// fraction of the memory limit where the strict policy starts working.
/// </param>

	public static void SetStrictThreshold(this MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (WebKitMemoryPressureSettings)");
		WebKitMemoryPressureSettingsExterns.webkit_memory_pressure_settings_set_strict_threshold(settings, value);
	}


	public static WebKitMemoryPressureSettings Dereference(this WebKitMemoryPressureSettingsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitMemoryPressureSettings>(x.DangerousGetHandle());
}
internal class WebKitMemoryPressureSettingsExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle webkit_memory_pressure_settings_new();

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle webkit_memory_pressure_settings_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_memory_pressure_settings_get_conservative_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_memory_pressure_settings_get_kill_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_memory_pressure_settings_get_memory_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_memory_pressure_settings_get_poll_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern double webkit_memory_pressure_settings_get_strict_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_set_conservative_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_set_kill_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_set_memory_limit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, uint memory_limit);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_set_poll_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_memory_pressure_settings_set_strict_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle>))] MentorLake.WebKit2.WebKitMemoryPressureSettingsHandle settings, double value);

}

/// <summary>
/// <para>
/// A boxed type representing the settings for the memory pressure handler
/// </para>
/// <para>
/// #WebKitMemoryPressureSettings is a boxed type that can be used to provide some custom settings
/// to control how the memory pressure situations are handled by the different processes.
/// </para>
/// <para>
/// The memory pressure system implemented inside the different process will try to keep the memory usage
/// under the defined memory limit. In order to do that, it will check the used memory with a user defined
/// frequency and decide whether it should try to release memory. The thresholds passed will define how urgent
/// is to release that memory.
/// </para>
/// <para>
/// Take into account that badly defined parameters can greatly reduce the performance of the engine. For
/// example, setting memory limit too low with a fast poll interval can cause the process to constantly
/// be trying to release memory.
/// </para>
/// <para>
/// A #WebKitMemoryPressureSettings can be passed to a #WebKitWebContext constructor, and the settings will
/// be applied to all the web processes created by that context.
/// </para>
/// <para>
/// A #WebKitMemoryPressureSettings can be passed to webkit_website_data_manager_set_memory_pressure_settings(),
/// and the settings will be applied to all the network processes created after that call by any instance of
/// #WebKitWebsiteDataManager.
/// </para>
/// </summary>

public struct WebKitMemoryPressureSettings
{
}
