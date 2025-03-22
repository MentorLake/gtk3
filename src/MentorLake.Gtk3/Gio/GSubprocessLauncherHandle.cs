namespace MentorLake.Gio;

public class GSubprocessLauncherHandle : GObjectHandle
{
	public static MentorLake.Gio.GSubprocessLauncherHandle New(MentorLake.Gio.GSubprocessFlags flags)
	{
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_new(flags);
	}

}

public static class GSubprocessLauncherHandleExtensions
{
	public static T Close<T>(this T self) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_close(self);
		return self;
	}

	public static string Getenv(this MentorLake.Gio.GSubprocessLauncherHandle self, string variable)
	{
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_getenv(self, variable);
	}

	public static T SetChildSetup<T>(this T self, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_child_setup(self, child_setup, user_data, destroy_notify);
		return self;
	}

	public static T SetCwd<T>(this T self, string cwd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_cwd(self, cwd);
		return self;
	}

	public static T SetEnviron<T>(this T self, string[] env) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_environ(self, env);
		return self;
	}

	public static T SetFlags<T>(this T self, MentorLake.Gio.GSubprocessFlags flags) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_flags(self, flags);
		return self;
	}

	public static T SetStderrFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stderr_file_path(self, path);
		return self;
	}

	public static T SetStdinFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stdin_file_path(self, path);
		return self;
	}

	public static T SetStdoutFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stdout_file_path(self, path);
		return self;
	}

	public static T Setenv<T>(this T self, string variable, string value, bool overwrite) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_setenv(self, variable, value, overwrite);
		return self;
	}

	public static MentorLake.Gio.GSubprocessHandle Spawn(this MentorLake.Gio.GSubprocessLauncherHandle self, IntPtr error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_spawn(self, error, argv0, @__arglist);
	}

	public static MentorLake.Gio.GSubprocessHandle Spawnv(this MentorLake.Gio.GSubprocessLauncherHandle self, string[] argv)
	{
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_spawnv(self, argv);
	}

	public static T TakeFd<T>(this T self, int source_fd, int target_fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_fd(self, source_fd, target_fd);
		return self;
	}

	public static T TakeStderrFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stderr_fd(self, fd);
		return self;
	}

	public static T TakeStdinFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stdin_fd(self, fd);
		return self;
	}

	public static T TakeStdoutFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stdout_fd(self, fd);
		return self;
	}

	public static T Unsetenv<T>(this T self, string variable) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_unsetenv(self, variable);
		return self;
	}

}

internal class GSubprocessLauncherHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSubprocessLauncherHandle g_subprocess_launcher_new(MentorLake.Gio.GSubprocessFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_subprocess_launcher_getenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string variable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_child_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_cwd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string cwd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_environ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string[] env);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, MentorLake.Gio.GSubprocessFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_stderr_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_stdin_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_set_stdout_file_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_setenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string variable, string value, bool overwrite);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_launcher_spawn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, IntPtr error, string argv0, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_launcher_spawnv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string[] argv);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_take_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, int source_fd, int target_fd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_take_stderr_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, int fd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_take_stdin_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, int fd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_take_stdout_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, int fd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_launcher_unsetenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string variable);

}
