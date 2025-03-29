namespace MentorLake.Gio;

public class GSubprocessHandle : GObjectHandle, GInitableHandle
{
	public static MentorLake.Gio.GSubprocessHandle New(MentorLake.Gio.GSubprocessFlags flags, IntPtr error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessHandleExterns.g_subprocess_new(flags, error, argv0, @__arglist);
	}

	public static MentorLake.Gio.GSubprocessHandle Newv(string[] argv, MentorLake.Gio.GSubprocessFlags flags)
	{
		return GSubprocessHandleExterns.g_subprocess_newv(argv, flags);
	}

}

public static class GSubprocessHandleExtensions
{
	public static bool Communicate(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.GLib.GBytesHandle stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GBytesHandle stdout_buf, out MentorLake.GLib.GBytesHandle stderr_buf, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_communicate(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, error);
	}

	public static T CommunicateAsync<T>(this T subprocess, MentorLake.GLib.GBytesHandle stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_communicate_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool CommunicateFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GBytesHandle stdout_buf, out MentorLake.GLib.GBytesHandle stderr_buf, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_communicate_finish(subprocess, result, out stdout_buf, out stderr_buf, error);
	}

	public static bool CommunicateUtf8(this MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_communicate_utf8(subprocess, stdin_buf, cancellable, out stdout_buf, out stderr_buf, error);
	}

	public static T CommunicateUtf8Async<T>(this T subprocess, string stdin_buf, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_communicate_utf8_async(subprocess, stdin_buf, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool CommunicateUtf8Finish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, out string stdout_buf, out string stderr_buf, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_communicate_utf8_finish(subprocess, result, out stdout_buf, out stderr_buf, error);
	}

	public static T ForceExit<T>(this T subprocess) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_force_exit(subprocess);
		return subprocess;
	}

	public static int GetExitStatus(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_exit_status(subprocess);
	}

	public static string GetIdentifier(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_identifier(subprocess);
	}

	public static bool GetIfExited(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_if_exited(subprocess);
	}

	public static bool GetIfSignaled(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_if_signaled(subprocess);
	}

	public static int GetStatus(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_status(subprocess);
	}

	public static MentorLake.Gio.GInputStreamHandle GetStderrPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_stderr_pipe(subprocess);
	}

	public static MentorLake.Gio.GOutputStreamHandle GetStdinPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_stdin_pipe(subprocess);
	}

	public static MentorLake.Gio.GInputStreamHandle GetStdoutPipe(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_stdout_pipe(subprocess);
	}

	public static bool GetSuccessful(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_successful(subprocess);
	}

	public static int GetTermSig(this MentorLake.Gio.GSubprocessHandle subprocess)
	{
		return GSubprocessHandleExterns.g_subprocess_get_term_sig(subprocess);
	}

	public static T SendSignal<T>(this T subprocess, int signal_num) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_send_signal(subprocess, signal_num);
		return subprocess;
	}

	public static bool Wait(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_wait(subprocess, cancellable, error);
	}

	public static T WaitAsync<T>(this T subprocess, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_wait_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool WaitCheck(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_wait_check(subprocess, cancellable, error);
	}

	public static T WaitCheckAsync<T>(this T subprocess, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSubprocessHandle
	{
		GSubprocessHandleExterns.g_subprocess_wait_check_async(subprocess, cancellable, callback, user_data);
		return subprocess;
	}

	public static bool WaitCheckFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_wait_check_finish(subprocess, result, error);
	}

	public static bool WaitFinish(this MentorLake.Gio.GSubprocessHandle subprocess, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GSubprocessHandleExterns.g_subprocess_wait_finish(subprocess, result, error);
	}

}

internal class GSubprocessHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_new(MentorLake.Gio.GSubprocessFlags flags, IntPtr error, string argv0, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSubprocessHandle g_subprocess_newv(string[] argv, MentorLake.Gio.GSubprocessFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stdout_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stderr_buf, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_communicate_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stdout_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle stderr_buf, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out string stdout_buf, out string stderr_buf, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_communicate_utf8_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, string stdin_buf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_communicate_utf8_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out string stdout_buf, out string stderr_buf, IntPtr error);

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
	internal static extern MentorLake.Gio.GInputStreamHandle g_subprocess_get_stderr_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GOutputStreamHandle g_subprocess_get_stdin_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_subprocess_get_stdout_pipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_get_successful([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_subprocess_get_term_sig([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_send_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, int signal_num);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_wait_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_subprocess_wait_check_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_check_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_subprocess_wait_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSubprocessHandle>))] MentorLake.Gio.GSubprocessHandle subprocess, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
