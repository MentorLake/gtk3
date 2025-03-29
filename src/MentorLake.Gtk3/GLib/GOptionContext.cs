namespace MentorLake.GLib;

public class GOptionContextHandle : BaseSafeHandle
{
}


public static class GOptionContextExtensions
{
	public static void AddGroup(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionGroupHandle group)
	{
		GOptionContextExterns.g_option_context_add_group(context, group);
	}

	public static void AddMainEntries(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionEntry[] entries, string translation_domain)
	{
		GOptionContextExterns.g_option_context_add_main_entries(context, entries, translation_domain);
	}

	public static void Free(this MentorLake.GLib.GOptionContextHandle context)
	{
		GOptionContextExterns.g_option_context_free(context);
	}

	public static string GetDescription(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_description(context);
	}

	public static string GetHelp(this MentorLake.GLib.GOptionContextHandle context, bool main_help, MentorLake.GLib.GOptionGroupHandle group)
	{
		return GOptionContextExterns.g_option_context_get_help(context, main_help, group);
	}

	public static bool GetHelpEnabled(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_help_enabled(context);
	}

	public static bool GetIgnoreUnknownOptions(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_ignore_unknown_options(context);
	}

	public static MentorLake.GLib.GOptionGroupHandle GetMainGroup(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_main_group(context);
	}

	public static bool GetStrictPosix(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_strict_posix(context);
	}

	public static string GetSummary(this MentorLake.GLib.GOptionContextHandle context)
	{
		return GOptionContextExterns.g_option_context_get_summary(context);
	}

	public static bool Parse(this MentorLake.GLib.GOptionContextHandle context, ref int argc, ref string[] argv)
	{
		var externCallResult = GOptionContextExterns.g_option_context_parse(context, ref argc, ref argv, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ParseStrv(this MentorLake.GLib.GOptionContextHandle context, ref string[] arguments)
	{
		var externCallResult = GOptionContextExterns.g_option_context_parse_strv(context, ref arguments, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void SetDescription(this MentorLake.GLib.GOptionContextHandle context, string description)
	{
		GOptionContextExterns.g_option_context_set_description(context, description);
	}

	public static void SetHelpEnabled(this MentorLake.GLib.GOptionContextHandle context, bool help_enabled)
	{
		GOptionContextExterns.g_option_context_set_help_enabled(context, help_enabled);
	}

	public static void SetIgnoreUnknownOptions(this MentorLake.GLib.GOptionContextHandle context, bool ignore_unknown)
	{
		GOptionContextExterns.g_option_context_set_ignore_unknown_options(context, ignore_unknown);
	}

	public static void SetMainGroup(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionGroupHandle group)
	{
		GOptionContextExterns.g_option_context_set_main_group(context, group);
	}

	public static void SetStrictPosix(this MentorLake.GLib.GOptionContextHandle context, bool strict_posix)
	{
		GOptionContextExterns.g_option_context_set_strict_posix(context, strict_posix);
	}

	public static void SetSummary(this MentorLake.GLib.GOptionContextHandle context, string summary)
	{
		GOptionContextExterns.g_option_context_set_summary(context, summary);
	}

	public static void SetTranslateFunc(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify)
	{
		GOptionContextExterns.g_option_context_set_translate_func(context, func, data, destroy_notify);
	}

	public static void SetTranslationDomain(this MentorLake.GLib.GOptionContextHandle context, string domain)
	{
		GOptionContextExterns.g_option_context_set_translation_domain(context, domain);
	}


	public static GOptionContext Dereference(this GOptionContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionContext>(x.DangerousGetHandle());
}
internal class GOptionContextExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_add_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_add_main_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionEntry[] entries, string translation_domain);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_help([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool main_help, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_help_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_ignore_unknown_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_context_get_main_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_strict_posix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, ref int argc, ref string[] argv, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_parse_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, ref string[] arguments, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string description);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_help_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool help_enabled);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_ignore_unknown_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool ignore_unknown);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_main_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_strict_posix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool strict_posix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string summary);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string domain);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GOptionContextHandle g_option_context_new(string parameter_string);

}

public struct GOptionContext
{
	public static MentorLake.GLib.GOptionContextHandle New(string parameter_string)
	{
		return GOptionContextExterns.g_option_context_new(parameter_string);
	}

}
