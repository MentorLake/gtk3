namespace MentorLake.Gtk3.Gio;

public class GSubprocessLauncherHandle : GObjectHandle
{
	public static GSubprocessLauncherHandle New(GSubprocessFlags flags)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_new(flags);
	}

}

public static class GSubprocessLauncherHandleExtensions
{
	public static T Close<T>(this T self) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_close(self);
		return self;
	}

	public static string Getenv(this GSubprocessLauncherHandle self, string variable)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_getenv(self, variable);
	}

	public static T SetChildSetup<T>(this T self, GSpawnChildSetupFunc child_setup, IntPtr user_data, GDestroyNotify destroy_notify) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_child_setup(self, child_setup, user_data, destroy_notify);
		return self;
	}

	public static T SetCwd<T>(this T self, string cwd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_cwd(self, cwd);
		return self;
	}

	public static T SetEnviron<T>(this T self, string[] env) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_environ(self, env);
		return self;
	}

	public static T SetFlags<T>(this T self, GSubprocessFlags flags) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_flags(self, flags);
		return self;
	}

	public static T SetStderrFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stderr_file_path(self, path);
		return self;
	}

	public static T SetStdinFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stdin_file_path(self, path);
		return self;
	}

	public static T SetStdoutFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stdout_file_path(self, path);
		return self;
	}

	public static T Setenv<T>(this T self, string variable, string value, bool overwrite) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_setenv(self, variable, value, overwrite);
		return self;
	}

	public static GSubprocessHandle Spawn(this GSubprocessLauncherHandle self, out GErrorHandle error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_spawn(self, out error, argv0, @__arglist);
	}

	public static GSubprocessHandle Spawnv(this GSubprocessLauncherHandle self, string argv, out GErrorHandle error)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_spawnv(self, argv, out error);
	}

	public static T TakeFd<T>(this T self, int source_fd, int target_fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_fd(self, source_fd, target_fd);
		return self;
	}

	public static T TakeStderrFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stderr_fd(self, fd);
		return self;
	}

	public static T TakeStdinFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stdin_fd(self, fd);
		return self;
	}

	public static T TakeStdoutFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stdout_fd(self, fd);
		return self;
	}

	public static T Unsetenv<T>(this T self, string variable) where T : GSubprocessLauncherHandle
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_unsetenv(self, variable);
		return self;
	}

}

internal class GSubprocessLauncherExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessLauncherHandle g_subprocess_launcher_new(GSubprocessFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_close(GSubprocessLauncherHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern string g_subprocess_launcher_getenv(GSubprocessLauncherHandle self, string variable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_child_setup(GSubprocessLauncherHandle self, GSpawnChildSetupFunc child_setup, IntPtr user_data, GDestroyNotify destroy_notify);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_cwd(GSubprocessLauncherHandle self, string cwd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_environ(GSubprocessLauncherHandle self, string[] env);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_flags(GSubprocessLauncherHandle self, GSubprocessFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stderr_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stdin_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stdout_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_setenv(GSubprocessLauncherHandle self, string variable, string value, bool overwrite);

	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_launcher_spawn(GSubprocessLauncherHandle self, out GErrorHandle error, string argv0, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_launcher_spawnv(GSubprocessLauncherHandle self, string argv, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_fd(GSubprocessLauncherHandle self, int source_fd, int target_fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stderr_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stdin_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stdout_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_unsetenv(GSubprocessLauncherHandle self, string variable);

}
