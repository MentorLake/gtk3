namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This class contains a set of options for launching child processes,
/// such as where its standard input and output will be directed, the
/// argument list, the environment, and more.
/// </para>
/// <para>
/// While the [class@Gio.Subprocess] class has high level functions covering
/// popular cases, use of this class allows access to more advanced
/// options.  It can also be used to launch multiple subprocesses with
/// a similar configuration.
/// </para>
/// </summary>

public class GSubprocessLauncherHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GSubprocessLauncher.
/// </para>
/// <para>
/// The launcher is created with the default options.  A copy of the
/// environment of the calling process is made at the time of this call
/// and will be used as the environment that the process is launched in.
/// </para>
/// </summary>

/// <param name="flags">
/// #GSubprocessFlags
/// </param>

	public static MentorLake.Gio.GSubprocessLauncherHandle New(MentorLake.Gio.GSubprocessFlags flags)
	{
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_new(flags);
	}

}

public static class GSubprocessLauncherHandleExtensions
{
/// <summary>
/// <para>
/// Closes all the file descriptors previously passed to the object with
/// g_subprocess_launcher_take_fd(), g_subprocess_launcher_take_stderr_fd(), etc.
/// </para>
/// <para>
/// After calling this method, any subsequent calls to g_subprocess_launcher_spawn() or g_subprocess_launcher_spawnv() will
/// return %G_IO_ERROR_CLOSED. This method is idempotent if
/// called more than once.
/// </para>
/// <para>
/// This function is called automatically when the #GSubprocessLauncher
/// is disposed, but is provided separately so that garbage collected
/// language bindings can call it earlier to guarantee when FDs are closed.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>

	public static T Close<T>(this T self) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_close(self);
		return self;
	}

/// <summary>
/// <para>
/// Returns the value of the environment variable @variable in the
/// environment of processes launched from this launcher.
/// </para>
/// <para>
/// On UNIX, the returned string can be an arbitrary byte string.
/// On Windows, it will be UTF-8.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="variable">
/// the environment variable to get
/// </param>
/// <return>
/// the value of the environment variable,
///     %NULL if unset
/// </return>

	public static string Getenv(this MentorLake.Gio.GSubprocessLauncherHandle self, string variable)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_getenv(self, variable);
	}

/// <summary>
/// <para>
/// Sets up a child setup function.
/// </para>
/// <para>
/// The child setup function will be called after fork() but before
/// exec() on the child's side.
/// </para>
/// <para>
/// @destroy_notify will not be automatically called on the child's side
/// of the fork().  It will only be called when the last reference on the
/// #GSubprocessLauncher is dropped or when a new child setup function is
/// given.
/// </para>
/// <para>
/// %NULL can be given as @child_setup to disable the functionality.
/// </para>
/// <para>
/// Child setup functions are only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="child_setup">
/// a #GSpawnChildSetupFunc to use as the child setup function
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="destroy_notify">
/// a #GDestroyNotify for @user_data
/// </param>

	public static T SetChildSetup<T>(this T self, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_child_setup(self, child_setup, user_data, destroy_notify);
		return self;
	}

/// <summary>
/// <para>
/// Sets the current working directory that processes will be launched
/// with.
/// </para>
/// <para>
/// By default processes are launched with the current working directory
/// of the launching process at the time of launch.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="cwd">
/// the cwd for launched processes
/// </param>

	public static T SetCwd<T>(this T self, string cwd) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_cwd(self, cwd);
		return self;
	}

/// <summary>
/// <para>
/// Replace the entire environment of processes launched from this
/// launcher with the given 'environ' variable.
/// </para>
/// <para>
/// Typically you will build this variable by using g_listenv() to copy
/// the process 'environ' and using the functions g_environ_setenv(),
/// g_environ_unsetenv(), etc.
/// </para>
/// <para>
/// As an alternative, you can use g_subprocess_launcher_setenv(),
/// g_subprocess_launcher_unsetenv(), etc.
/// </para>
/// <para>
/// Pass an empty array to set an empty environment. Pass %NULL to inherit the
/// parent process’ environment. As of GLib 2.54, the parent process’ environment
/// will be copied when g_subprocess_launcher_set_environ() is called.
/// Previously, it was copied when the subprocess was executed. This means the
/// copied environment may now be modified (using g_subprocess_launcher_setenv(),
/// etc.) before launching the subprocess.
/// </para>
/// <para>
/// On UNIX, all strings in this array can be arbitrary byte strings.
/// On Windows, they should be in UTF-8.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="env">
/// 
///     the replacement environment
/// </param>

	public static T SetEnviron<T>(this T self, string[] env) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_environ(self, env);
		return self;
	}

/// <summary>
/// <para>
/// Sets the flags on the launcher.
/// </para>
/// <para>
/// The default flags are %G_SUBPROCESS_FLAGS_NONE.
/// </para>
/// <para>
/// You may not set flags that specify conflicting options for how to
/// handle a particular stdio stream (eg: specifying both
/// %G_SUBPROCESS_FLAGS_STDIN_PIPE and
/// %G_SUBPROCESS_FLAGS_STDIN_INHERIT).
/// </para>
/// <para>
/// You may also not set a flag that conflicts with a previous call to a
/// function like g_subprocess_launcher_set_stdin_file_path() or
/// g_subprocess_launcher_take_stdout_fd().
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="flags">
/// #GSubprocessFlags
/// </param>

	public static T SetFlags<T>(this T self, MentorLake.Gio.GSubprocessFlags flags) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_flags(self, flags);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file path to use as the stderr for spawned processes.
/// </para>
/// <para>
/// If @path is %NULL then any previously given path is unset.
/// </para>
/// <para>
/// The file will be created or truncated when the process is spawned, as
/// would be the case if using '2>' at the shell.
/// </para>
/// <para>
/// If you want to send both stdout and stderr to the same file then use
/// %G_SUBPROCESS_FLAGS_STDERR_MERGE.
/// </para>
/// <para>
/// You may not set a stderr file path if a stderr fd is already set or
/// if the launcher flags contain any flags directing stderr elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="path">
/// a filename or %NULL
/// </param>

	public static T SetStderrFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stderr_file_path(self, path);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file path to use as the stdin for spawned processes.
/// </para>
/// <para>
/// If @path is %NULL then any previously given path is unset.
/// </para>
/// <para>
/// The file must exist or spawning the process will fail.
/// </para>
/// <para>
/// You may not set a stdin file path if a stdin fd is already set or if
/// the launcher flags contain any flags directing stdin elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="path">
/// a filename or %NULL
/// </param>

	public static T SetStdinFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stdin_file_path(self, path);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file path to use as the stdout for spawned processes.
/// </para>
/// <para>
/// If @path is %NULL then any previously given path is unset.
/// </para>
/// <para>
/// The file will be created or truncated when the process is spawned, as
/// would be the case if using '>' at the shell.
/// </para>
/// <para>
/// You may not set a stdout file path if a stdout fd is already set or
/// if the launcher flags contain any flags directing stdout elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="path">
/// a filename or %NULL
/// </param>

	public static T SetStdoutFilePath<T>(this T self, string path) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_set_stdout_file_path(self, path);
		return self;
	}

/// <summary>
/// <para>
/// Sets the environment variable @variable in the environment of
/// processes launched from this launcher.
/// </para>
/// <para>
/// On UNIX, both the variable's name and value can be arbitrary byte
/// strings, except that the variable's name cannot contain '='.
/// On Windows, they should be in UTF-8.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="variable">
/// the environment variable to set,
///     must not contain '='
/// </param>
/// <param name="value">
/// the new value for the variable
/// </param>
/// <param name="overwrite">
/// whether to change the variable if it already exists
/// </param>

	public static T Setenv<T>(this T self, string variable, string value, bool overwrite) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_setenv(self, variable, value, overwrite);
		return self;
	}

/// <summary>
/// <para>
/// Creates a #GSubprocess given a provided varargs list of arguments.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="error">
/// Error
/// </param>
/// <param name="argv0">
/// Command line arguments
/// </param>
/// <param name="@__arglist">
/// Continued arguments, %NULL terminated
/// </param>
/// <return>
/// A new #GSubprocess, or %NULL on error (and @error will be set)
/// </return>

	public static MentorLake.Gio.GSubprocessHandle Spawn(this MentorLake.Gio.GSubprocessLauncherHandle self, IntPtr error, string argv0, IntPtr @__arglist)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		return GSubprocessLauncherHandleExterns.g_subprocess_launcher_spawn(self, error, argv0, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a #GSubprocess given a provided array of arguments.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="argv">
/// Command line arguments
/// </param>
/// <return>
/// A new #GSubprocess, or %NULL on error (and @error will be set)
/// </return>

	public static MentorLake.Gio.GSubprocessHandle Spawnv(this MentorLake.Gio.GSubprocessLauncherHandle self, string[] argv)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		var externCallResult = GSubprocessLauncherHandleExterns.g_subprocess_launcher_spawnv(self, argv, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Transfer an arbitrary file descriptor from parent process to the
/// child.  This function takes ownership of the @source_fd; it will be closed
/// in the parent when @self is freed.
/// </para>
/// <para>
/// By default, all file descriptors from the parent will be closed.
/// This function allows you to create (for example) a custom `pipe()` or
/// `socketpair()` before launching the process, and choose the target
/// descriptor in the child.
/// </para>
/// <para>
/// An example use case is GNUPG, which has a command line argument
/// `--passphrase-fd` providing a file descriptor number where it expects
/// the passphrase to be written.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="source_fd">
/// File descriptor in parent process
/// </param>
/// <param name="target_fd">
/// Target descriptor for child process
/// </param>

	public static T TakeFd<T>(this T self, int source_fd, int target_fd) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_fd(self, source_fd, target_fd);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file descriptor to use as the stderr for spawned processes.
/// </para>
/// <para>
/// If @fd is -1 then any previously given fd is unset.
/// </para>
/// <para>
/// Note that the default behaviour is to pass stderr through to the
/// stderr of the parent process.
/// </para>
/// <para>
/// The passed @fd belongs to the #GSubprocessLauncher.  It will be
/// automatically closed when the launcher is finalized.  The file
/// descriptor will also be closed on the child side when executing the
/// spawned process.
/// </para>
/// <para>
/// You may not set a stderr fd if a stderr file path is already set or
/// if the launcher flags contain any flags directing stderr elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="fd">
/// a file descriptor, or -1
/// </param>

	public static T TakeStderrFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stderr_fd(self, fd);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file descriptor to use as the stdin for spawned processes.
/// </para>
/// <para>
/// If @fd is -1 then any previously given fd is unset.
/// </para>
/// <para>
/// Note that if your intention is to have the stdin of the calling
/// process inherited by the child then %G_SUBPROCESS_FLAGS_STDIN_INHERIT
/// is a better way to go about doing that.
/// </para>
/// <para>
/// The passed @fd is noted but will not be touched in the current
/// process.  It is therefore necessary that it be kept open by the
/// caller until the subprocess is spawned.  The file descriptor will
/// also not be explicitly closed on the child side, so it must be marked
/// O_CLOEXEC if that's what you want.
/// </para>
/// <para>
/// You may not set a stdin fd if a stdin file path is already set or if
/// the launcher flags contain any flags directing stdin elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="fd">
/// a file descriptor, or -1
/// </param>

	public static T TakeStdinFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stdin_fd(self, fd);
		return self;
	}

/// <summary>
/// <para>
/// Sets the file descriptor to use as the stdout for spawned processes.
/// </para>
/// <para>
/// If @fd is -1 then any previously given fd is unset.
/// </para>
/// <para>
/// Note that the default behaviour is to pass stdout through to the
/// stdout of the parent process.
/// </para>
/// <para>
/// The passed @fd is noted but will not be touched in the current
/// process.  It is therefore necessary that it be kept open by the
/// caller until the subprocess is spawned.  The file descriptor will
/// also not be explicitly closed on the child side, so it must be marked
/// O_CLOEXEC if that's what you want.
/// </para>
/// <para>
/// You may not set a stdout fd if a stdout file path is already set or
/// if the launcher flags contain any flags directing stdout elsewhere.
/// </para>
/// <para>
/// This feature is only available on UNIX.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="fd">
/// a file descriptor, or -1
/// </param>

	public static T TakeStdoutFd<T>(this T self, int fd) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_take_stdout_fd(self, fd);
		return self;
	}

/// <summary>
/// <para>
/// Removes the environment variable @variable from the environment of
/// processes launched from this launcher.
/// </para>
/// <para>
/// On UNIX, the variable's name can be an arbitrary byte string not
/// containing '='. On Windows, it should be in UTF-8.
/// </para>
/// </summary>

/// <param name="self">
/// a #GSubprocessLauncher
/// </param>
/// <param name="variable">
/// the environment variable to unset,
///     must not contain '='
/// </param>

	public static T Unsetenv<T>(this T self, string variable) where T : GSubprocessLauncherHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GSubprocessLauncherHandle)");
		GSubprocessLauncherHandleExterns.g_subprocess_launcher_unsetenv(self, variable);
		return self;
	}

}

internal class GSubprocessLauncherHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_launcher_spawn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, IntPtr error, string argv0, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_launcher_spawnv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessLauncherHandle>))] MentorLake.Gio.GSubprocessLauncherHandle self, string[] argv, out MentorLake.GLib.GErrorHandle error);

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
