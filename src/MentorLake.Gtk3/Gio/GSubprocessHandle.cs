namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSubprocess` allows the creation of and interaction with child
/// processes.
/// </para>
/// <para>
/// Processes can be communicated with using standard GIO-style APIs (ie:
/// [class@Gio.InputStream], [class@Gio.OutputStream]). There are GIO-style APIs
/// to wait for process termination (ie: cancellable and with an asynchronous
/// variant).
/// </para>
/// <para>
/// There is an API to force a process to terminate, as well as a
/// race-free API for sending UNIX signals to a subprocess.
/// </para>
/// <para>
/// One major advantage that GIO brings over the core GLib library is
/// comprehensive API for asynchronous I/O, such
/// [method@Gio.OutputStream.splice_async].  This makes `GSubprocess`
/// significantly more powerful and flexible than equivalent APIs in
/// some other languages such as the `subprocess.py`
/// included with Python.  For example, using `GSubprocess` one could
/// create two child processes, reading standard output from the first,
/// processing it, and writing to the input stream of the second, all
/// without blocking the main loop.
/// </para>
/// <para>
/// A powerful [method@Gio.Subprocess.communicate] API is provided similar to the
/// `communicate()` method of `subprocess.py`. This enables very easy
/// interaction with a subprocess that has been opened with pipes.
/// </para>
/// <para>
/// `GSubprocess` defaults to tight control over the file descriptors open
/// in the child process, avoiding dangling-FD issues that are caused by
/// a simple `fork()`/`exec()`.  The only open file descriptors in the
/// spawned process are ones that were explicitly specified by the
/// `GSubprocess` API (unless `G_SUBPROCESS_FLAGS_INHERIT_FDS` was
/// specified).
/// </para>
/// <para>
/// `GSubprocess` will quickly reap all child processes as they exit,
/// avoiding ‘zombie processes’ remaining around for long periods of
/// time.  [method@Gio.Subprocess.wait] can be used to wait for this to happen,
/// but it will happen even without the call being explicitly made.
/// </para>
/// <para>
/// As a matter of principle, `GSubprocess` has no API that accepts
/// shell-style space-separated strings.  It will, however, match the
/// typical shell behaviour of searching the `PATH` for executables that do
/// not contain a directory separator in their name. By default, the `PATH`
/// of the current process is used.  You can specify
/// `G_SUBPROCESS_FLAGS_SEARCH_PATH_FROM_ENVP` to use the `PATH` of the
/// launcher environment instead.
/// </para>
/// <para>
/// `GSubprocess` attempts to have a very simple API for most uses (ie:
/// spawning a subprocess with arguments and support for most typical
/// kinds of input and output redirection).  See [ctor@Gio.Subprocess.new]. The
/// [class@Gio.SubprocessLauncher] API is provided for more complicated cases
/// (advanced types of redirection, environment variable manipulation,
/// change of working directory, child setup functions, etc).
/// </para>
/// <para>
/// A typical use of `GSubprocess` will involve calling
/// [ctor@Gio.Subprocess.new], followed by [method@Gio.Subprocess.wait_async] or
/// [method@Gio.Subprocess.wait].  After the process exits, the status can be
/// checked using functions such as [method@Gio.Subprocess.get_if_exited] (which
/// are similar to the familiar `WIFEXITED`-style POSIX macros).
/// </para>
/// <para>
/// Note that as of GLib 2.82, creating a `GSubprocess` causes the signal
/// `SIGPIPE` to be ignored for the remainder of the program. If you are writing
/// a command-line utility that uses `GSubprocess`, you may need to take into
/// account the fact that your program will not automatically be killed
/// if it tries to write to `stdout` after it has been closed.
/// </para>
/// </summary>

public class GSubprocessHandle : GObjectHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Create a new process with the given flags and varargs argument
/// list.  By default, matching the g_spawn_async() defaults, the
/// child's stdin will be set to the system null device, and
/// stdout/stderr will be inherited from the parent.  You can use
/// @flags to control this behavior.
/// </para>
/// <para>
/// The argument list must be terminated with %NULL.
/// </para>
/// </summary>

/// <param name="flags">
/// flags that define the behaviour of the subprocess
/// </param>
/// <param name="error">
/// return location for an error, or %NULL
/// </param>
/// <param name="argv0">
/// first commandline argument to pass to the subprocess
/// </param>
/// <param name="@__arglist">
/// more commandline arguments, followed by %NULL
/// </param>
/// <return>
/// A newly created #GSubprocess, or %NULL on error (and @error
///   will be set)
/// </return>

	public static MentorLake.Gio.GSubprocessHandle New(MentorLake.Gio.GSubprocessFlags flags, IntPtr error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessHandleExterns.g_subprocess_new(flags, error, argv0, @__arglist);
	}

/// <summary>
/// <para>
/// Create a new process with the given flags and argument list.
/// </para>
/// <para>
/// The argument list is expected to be %NULL-terminated.
/// </para>
/// </summary>

/// <param name="argv">
/// commandline arguments for the subprocess
/// </param>
/// <param name="flags">
/// flags that define the behaviour of the subprocess
/// </param>
/// <return>
/// A newly created #GSubprocess, or %NULL on error (and @error
///   will be set)
/// </return>

	public static MentorLake.Gio.GSubprocessHandle Newv(string[] argv, MentorLake.Gio.GSubprocessFlags flags)
	{
		var externCallResult = GSubprocessHandleExterns.g_subprocess_newv(argv, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GSubprocessHandleExtensions
{
/// <summary>
/// <para>
/// Communicate with the subprocess until it terminates, and all input
/// and output has been completed.
/// </para>
/// <para>
/// If @stdin_buf is given, the subprocess must have been created with
/// %G_SUBPROCESS_FLAGS_STDIN_PIPE.  The given data is fed to the
/// stdin of the subprocess and the pipe is closed (ie: EOF).
/// </para>
/// <para>
/// At the same time (as not to cause blocking when dealing with large
/// amounts of data), if %G_SUBPROCESS_FLAGS_STDOUT_PIPE or
/// %G_SUBPROCESS_FLAGS_STDERR_PIPE were used, reads from those
/// streams.  The data that was read is returned in @stdout and/or
/// the @stderr.
/// </para>
/// <para>
/// If the subprocess was created with %G_SUBPROCESS_FLAGS_STDOUT_PIPE,
/// @stdout_buf will contain the data read from stdout.  Otherwise, for
/// subprocesses not created with %G_SUBPROCESS_FLAGS_STDOUT_PIPE,
/// @stdout_buf will be set to %NULL.  Similar provisions apply to
/// @stderr_buf and %G_SUBPROCESS_FLAGS_STDERR_PIPE.
/// </para>
/// <para>
/// As usual, any output variable may be given as %NULL to ignore it.
/// </para>
/// <para>
/// If you desire the stdout and stderr data to be interleaved, create
/// the subprocess with %G_SUBPROCESS_FLAGS_STDOUT_PIPE and
/// %G_SUBPROCESS_FLAGS_STDERR_MERGE.  The merged result will be returned
/// in @stdout_buf and @stderr_buf will be set to %NULL.
/// </para>
/// <para>
/// In case of any error (including cancellation), %FALSE will be
/// returned with @error set.  Some or all of the stdin data may have
/// been written.  Any stdout or stderr data that has been read will be
/// discarded. None of the out variables (aside from @error) will have
/// been set to anything in particular and should not be inspected.
/// </para>
/// <para>
/// In the case that %TRUE is returned, the subprocess has exited and the
/// exit status inspection APIs (eg: g_subprocess_get_if_exited(),
/// g_subprocess_get_exit_status()) may be used.
/// </para>
/// <para>
/// You should not attempt to use any of the subprocess pipes after
/// starting this function, since they may be left in strange states,
/// even if the operation was cancelled.  You should especially not
/// attempt to interact with the pipes while the operation is in progress
/// (either from another thread or if using the asynchronous version).
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="stdin_buf">
/// data to send to the stdin of the subprocess, or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="stdout_buf">
/// data read from the subprocess stdout
/// </param>
/// <param name="stderr_buf">
/// data read from the subprocess stderr
/// </param>
/// <return>
/// %TRUE if successful
/// </return>

	public static bool Communicate(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.GLib.GBytesHandle stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GBytesHandle stdout_buf, out MentorLake.GLib.GBytesHandle stderr_buf)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_communicate(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronous version of g_subprocess_communicate().  Complete
/// invocation with g_subprocess_communicate_finish().
/// </para>
/// </summary>

/// <param name="subprocess">
/// Self
/// </param>
/// <param name="stdin_buf">
/// Input data, or %NULL
/// </param>
/// <param name="cancellable">
/// Cancellable
/// </param>
/// <param name="callback">
/// Callback
/// </param>
/// <param name="user_data">
/// User data
/// </param>

	public static T CommunicateAsync<T>(this T subprocess, MentorLake.GLib.GBytesHandle stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_communicate_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

/// <summary>
/// <para>
/// Complete an invocation of g_subprocess_communicate_async().
/// </para>
/// </summary>

/// <param name="subprocess">
/// Self
/// </param>
/// <param name="result">
/// Result
/// </param>
/// <param name="stdout_buf">
/// Return location for stdout data
/// </param>
/// <param name="stderr_buf">
/// Return location for stderr data
/// </param>

	public static bool CommunicateFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GBytesHandle stdout_buf, out MentorLake.GLib.GBytesHandle stderr_buf)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_communicate_finish(subprocess, result, out stdout_buf, out stderr_buf, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_subprocess_communicate(), but validates the output of the
/// process as UTF-8, and returns it as a regular NUL terminated string.
/// </para>
/// <para>
/// On error, @stdout_buf and @stderr_buf will be set to undefined values and
/// should not be used.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="stdin_buf">
/// data to send to the stdin of the subprocess, or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="stdout_buf">
/// data read from the subprocess stdout
/// </param>
/// <param name="stderr_buf">
/// data read from the subprocess stderr
/// </param>

	public static bool CommunicateUtf8(this MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_communicate_utf8(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronous version of g_subprocess_communicate_utf8().  Complete
/// invocation with g_subprocess_communicate_utf8_finish().
/// </para>
/// </summary>

/// <param name="subprocess">
/// Self
/// </param>
/// <param name="stdin_buf">
/// Input data, or %NULL
/// </param>
/// <param name="cancellable">
/// Cancellable
/// </param>
/// <param name="callback">
/// Callback
/// </param>
/// <param name="user_data">
/// User data
/// </param>

	public static T CommunicateUtf8Async<T>(this T subprocess, string stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_communicate_utf8_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

/// <summary>
/// <para>
/// Complete an invocation of g_subprocess_communicate_utf8_async().
/// </para>
/// </summary>

/// <param name="subprocess">
/// Self
/// </param>
/// <param name="result">
/// Result
/// </param>
/// <param name="stdout_buf">
/// Return location for stdout data
/// </param>
/// <param name="stderr_buf">
/// Return location for stderr data
/// </param>

	public static bool CommunicateUtf8Finish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, out string stdout_buf, out string stderr_buf)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_communicate_utf8_finish(subprocess, result, out stdout_buf, out stderr_buf, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Use an operating-system specific method to attempt an immediate,
/// forceful termination of the process.  There is no mechanism to
/// determine whether or not the request itself was successful;
/// however, you can use g_subprocess_wait() to monitor the status of
/// the process after calling this function.
/// </para>
/// <para>
/// On Unix, this function sends %SIGKILL.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>

	public static T ForceExit<T>(this T subprocess) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_force_exit(subprocess);
		return subprocess;
	}

/// <summary>
/// <para>
/// Check the exit status of the subprocess, given that it exited
/// normally.  This is the value passed to the exit() system call or the
/// return value from main.
/// </para>
/// <para>
/// This is equivalent to the system WEXITSTATUS macro.
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() and
/// unless g_subprocess_get_if_exited() returned %TRUE.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the exit status
/// </return>

	public static int GetExitStatus(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_exit_status(subprocess);
	}

/// <summary>
/// <para>
/// On UNIX, returns the process ID as a decimal string.
/// On Windows, returns the result of GetProcessId() also as a string.
/// If the subprocess has terminated, this will return %NULL.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the subprocess identifier, or %NULL if the subprocess
///    has terminated
/// </return>

	public static string GetIdentifier(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_identifier(subprocess);
	}

/// <summary>
/// <para>
/// Check if the given subprocess exited normally (ie: by way of exit()
/// or return from main()).
/// </para>
/// <para>
/// This is equivalent to the system WIFEXITED macro.
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() has
/// returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// %TRUE if the case of a normal exit
/// </return>

	public static bool GetIfExited(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_if_exited(subprocess);
	}

/// <summary>
/// <para>
/// Check if the given subprocess terminated in response to a signal.
/// </para>
/// <para>
/// This is equivalent to the system WIFSIGNALED macro.
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() has
/// returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// %TRUE if the case of termination due to a signal
/// </return>

	public static bool GetIfSignaled(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_if_signaled(subprocess);
	}

/// <summary>
/// <para>
/// Gets the raw status code of the process, as from waitpid().
/// </para>
/// <para>
/// This value has no particular meaning, but it can be used with the
/// macros defined by the system headers such as WIFEXITED.  It can also
/// be used with g_spawn_check_wait_status().
/// </para>
/// <para>
/// It is more likely that you want to use g_subprocess_get_if_exited()
/// followed by g_subprocess_get_exit_status().
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() has
/// returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the (meaningless) waitpid() exit status from the kernel
/// </return>

	public static int GetStatus(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_status(subprocess);
	}

/// <summary>
/// <para>
/// Gets the #GInputStream from which to read the stderr output of
/// @subprocess.
/// </para>
/// <para>
/// The process must have been created with %G_SUBPROCESS_FLAGS_STDERR_PIPE,
/// otherwise %NULL will be returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the stderr pipe
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetStderrPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_stderr_pipe(subprocess);
	}

/// <summary>
/// <para>
/// Gets the #GOutputStream that you can write to in order to give data
/// to the stdin of @subprocess.
/// </para>
/// <para>
/// The process must have been created with %G_SUBPROCESS_FLAGS_STDIN_PIPE and
/// not %G_SUBPROCESS_FLAGS_STDIN_INHERIT, otherwise %NULL will be returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the stdout pipe
/// </return>

	public static MentorLake.Gio.GOutputStreamHandle GetStdinPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_stdin_pipe(subprocess);
	}

/// <summary>
/// <para>
/// Gets the #GInputStream from which to read the stdout output of
/// @subprocess.
/// </para>
/// <para>
/// The process must have been created with %G_SUBPROCESS_FLAGS_STDOUT_PIPE,
/// otherwise %NULL will be returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the stdout pipe
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetStdoutPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_stdout_pipe(subprocess);
	}

/// <summary>
/// <para>
/// Checks if the process was "successful".  A process is considered
/// successful if it exited cleanly with an exit status of 0, either by
/// way of the exit() system call or return from main().
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() has
/// returned.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// %TRUE if the process exited cleanly with a exit status of 0
/// </return>

	public static bool GetSuccessful(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_successful(subprocess);
	}

/// <summary>
/// <para>
/// Get the signal number that caused the subprocess to terminate, given
/// that it terminated due to a signal.
/// </para>
/// <para>
/// This is equivalent to the system WTERMSIG macro.
/// </para>
/// <para>
/// It is an error to call this function before g_subprocess_wait() and
/// unless g_subprocess_get_if_signaled() returned %TRUE.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <return>
/// the signal causing termination
/// </return>

	public static int GetTermSig(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		return GSubprocessHandleExterns.g_subprocess_get_term_sig(subprocess);
	}

/// <summary>
/// <para>
/// Sends the UNIX signal @signal_num to the subprocess, if it is still
/// running.
/// </para>
/// <para>
/// This API is race-free.  If the subprocess has terminated, it will not
/// be signalled.
/// </para>
/// <para>
/// This API is not available on Windows.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="signal_num">
/// the signal number to send
/// </param>

	public static T SendSignal<T>(this T subprocess, int signal_num) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_send_signal(subprocess, signal_num);
		return subprocess;
	}

/// <summary>
/// <para>
/// Synchronously wait for the subprocess to terminate.
/// </para>
/// <para>
/// After the process terminates you can query its exit status with
/// functions such as g_subprocess_get_if_exited() and
/// g_subprocess_get_exit_status().
/// </para>
/// <para>
/// This function does not fail in the case of the subprocess having
/// abnormal termination.  See g_subprocess_wait_check() for that.
/// </para>
/// <para>
/// Cancelling @cancellable doesn't kill the subprocess.  Call
/// g_subprocess_force_exit() if it is desirable.
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @cancellable was cancelled
/// </return>

	public static bool Wait(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_wait(subprocess, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Wait for the subprocess to terminate.
/// </para>
/// <para>
/// This is the asynchronous version of g_subprocess_wait().
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the operation is complete
/// </param>
/// <param name="user_data">
/// user_data for @callback
/// </param>

	public static T WaitAsync<T>(this T subprocess, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_wait_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

/// <summary>
/// <para>
/// Combines g_subprocess_wait() with g_spawn_check_wait_status().
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// %TRUE on success, %FALSE if process exited abnormally, or
/// @cancellable was cancelled
/// </return>

	public static bool WaitCheck(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_wait_check(subprocess, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Combines g_subprocess_wait_async() with g_spawn_check_wait_status().
/// </para>
/// <para>
/// This is the asynchronous version of g_subprocess_wait_check().
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the operation is complete
/// </param>
/// <param name="user_data">
/// user_data for @callback
/// </param>

	public static T WaitCheckAsync<T>(this T subprocess, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		GSubprocessHandleExterns.g_subprocess_wait_check_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

/// <summary>
/// <para>
/// Collects the result of a previous call to
/// g_subprocess_wait_check_async().
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// %TRUE if successful, or %FALSE with @error set
/// </return>

	public static bool WaitCheckFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_wait_check_finish(subprocess, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Collects the result of a previous call to
/// g_subprocess_wait_async().
/// </para>
/// </summary>

/// <param name="subprocess">
/// a #GSubprocess
/// </param>
/// <param name="result">
/// the #GAsyncResult passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// %TRUE if successful, or %FALSE with @error set
/// </return>

	public static bool WaitFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (subprocess.IsInvalid) throw new Exception("Invalid handle (GSubprocessHandle)");
		var externCallResult = GSubprocessHandleExterns.g_subprocess_wait_finish(subprocess, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GSubprocessHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_new(MentorLake.Gio.GSubprocessFlags flags, IntPtr error, string argv0, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_newv(string[] argv, MentorLake.Gio.GSubprocessFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stdout_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stderr_buf, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_communicate_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stdout_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stderr_buf, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_communicate_utf8_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_utf8_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out string stdout_buf, out string stderr_buf, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_force_exit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_subprocess_get_exit_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_subprocess_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_get_if_exited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_get_if_signaled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_subprocess_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_subprocess_get_stderr_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GOutputStreamHandle>))]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_subprocess_get_stdin_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_subprocess_get_stdout_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_get_successful([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_subprocess_get_term_sig([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_send_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, int signal_num);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_wait_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_wait_check_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_check_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
