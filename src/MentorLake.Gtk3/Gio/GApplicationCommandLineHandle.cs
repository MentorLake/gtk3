namespace MentorLake.Gio;

public class GApplicationCommandLineHandle : GObjectHandle
{
}

public static class GApplicationCommandLineHandleExtensions
{
	public static MentorLake.Gio.GFileHandle CreateFileForArg(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, string arg)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_create_file_for_arg(cmdline, arg);
	}

	public static T Done<T>(this T cmdline) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_done(cmdline);
		return cmdline;
	}

	public static string[] GetArguments(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, out int argc)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_arguments(cmdline, out argc);
	}

	public static string GetCwd(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_cwd(cmdline);
	}

	public static string[] GetEnviron(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_environ(cmdline);
	}

	public static int GetExitStatus(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_exit_status(cmdline);
	}

	public static bool GetIsRemote(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_is_remote(cmdline);
	}

	public static MentorLake.GLib.GVariantDictHandle GetOptionsDict(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_options_dict(cmdline);
	}

	public static MentorLake.GLib.GVariantHandle GetPlatformData(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_platform_data(cmdline);
	}

	public static MentorLake.Gio.GInputStreamHandle GetStdin(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_stdin(cmdline);
	}

	public static string Getenv(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, string name)
	{
		return GApplicationCommandLineHandleExterns.g_application_command_line_getenv(cmdline, name);
	}

	public static T Print<T>(this T cmdline, string format, IntPtr @__arglist) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_print(cmdline, format, @__arglist);
		return cmdline;
	}

	public static T PrintLiteral<T>(this T cmdline, string message) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_print_literal(cmdline, message);
		return cmdline;
	}

	public static T Printerr<T>(this T cmdline, string format, IntPtr @__arglist) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_printerr(cmdline, format, @__arglist);
		return cmdline;
	}

	public static T PrinterrLiteral<T>(this T cmdline, string message) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_printerr_literal(cmdline, message);
		return cmdline;
	}

	public static T SetExitStatus<T>(this T cmdline, int exit_status) where T : GApplicationCommandLineHandle
	{
		GApplicationCommandLineHandleExterns.g_application_command_line_set_exit_status(cmdline, exit_status);
		return cmdline;
	}

}

internal class GApplicationCommandLineHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle g_application_command_line_create_file_for_arg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string arg);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_application_command_line_get_arguments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, out int argc);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_command_line_get_cwd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_application_command_line_get_environ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_application_command_line_get_exit_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_command_line_get_is_remote([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantDictHandle g_application_command_line_get_options_dict([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_application_command_line_get_platform_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_application_command_line_get_stdin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_command_line_getenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_print_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_printerr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_printerr_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_set_exit_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, int exit_status);

}
