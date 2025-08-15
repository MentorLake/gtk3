namespace MentorLake.GLibUnix;

/// <summary>
/// <para>
/// A Unix pipe. The advantage of this type over `int[2]` is that it can
/// be closed automatically when it goes out of scope, using `g_auto(GUnixPipe)`,
/// on compilers that support that feature.
/// </para>
/// </summary>

public class GUnixPipeHandle : BaseSafeHandle
{
}


public static class GUnixPipeExtensions
{

	public static GUnixPipe Dereference(this GUnixPipeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixPipe>(x.DangerousGetHandle());
}
internal class GUnixPipeExterns
{
	[DllImport(GLibUnixLibrary.Name)]
	internal static extern void g_unix_pipe_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_pipe_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_unix_pipe_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_pipe_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, int flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_unix_pipe_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end);

}

/// <summary>
/// <para>
/// A Unix pipe. The advantage of this type over `int[2]` is that it can
/// be closed automatically when it goes out of scope, using `g_auto(GUnixPipe)`,
/// on compilers that support that feature.
/// </para>
/// </summary>

public struct GUnixPipe
{
	/// <summary>
/// <para>
/// A pair of file descriptors, each negative if closed or not yet opened.
///  The file descriptor with index %G_UNIX_PIPE_END_READ is readable.
///  The file descriptor with index %G_UNIX_PIPE_END_WRITE is writable.
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public int[] fds;
/// <summary>
/// <para>
/// Close both ends of the pipe, unless they have already been closed or
/// stolen. Any errors are ignored: use g_unix_pipe_close() or g_clear_fd()
/// if error-handling is required.
/// </para>
/// <para>
/// This function is async-signal safe if @error is %NULL and each member
/// of @fds are either negative or a valid open file descriptor.
/// As a result, it is safe to call this function or use `g_auto(GUnixPipe)`
/// (on compilers that support it) in a signal handler or a
/// #GSpawnChildSetupFunc, as long as those conditions are ensured to be true.
/// See &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;) for more details.
/// </para>
/// <para>
/// This function preserves the value of `errno`.
/// </para>
/// </summary>

/// <param name="self">
/// a #GUnixPipe
/// </param>

	public static void Clear(MentorLake.GLib.GUnixPipeHandle self)
	{
		GUnixPipeExterns.g_unix_pipe_clear(self);
	}

/// <summary>
/// <para>
/// Close one of the ends of the pipe and set the relevant member of @fds
/// to `-1` before returning, equivalent to g_clear_fd().
/// </para>
/// <para>
/// Like g_close(), if closing the file descriptor fails, the error is
/// stored in both %errno and @error. If this function succeeds,
/// %errno is undefined.
/// </para>
/// <para>
/// This function is async-signal safe if @error is %NULL and the relevant
/// member of @fds is either negative or a valid open file descriptor.
/// This makes it safe to call from a signal handler or a #GSpawnChildSetupFunc
/// under those conditions.
/// See &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;) for more details.
/// </para>
/// <para>
/// To close both file descriptors and ignore any errors, use
/// g_unix_pipe_clear() instead.
/// </para>
/// </summary>

/// <param name="self">
/// A pair of file descriptors
/// </param>
/// <param name="end">
/// One of the ends of the pipe
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool Close(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		var externCallResult = GUnixPipeExterns.g_unix_pipe_close(self, end, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Return one of the ends of the pipe. It remains owned by @self.
/// </para>
/// <para>
/// This function is async-signal safe (see &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;)), making it safe to call from a
/// signal handler or a #GSpawnChildSetupFunc.
/// </para>
/// <para>
/// This function preserves the value of `errno`.
/// </para>
/// </summary>

/// <param name="self">
/// A pair of file descriptors
/// </param>
/// <param name="end">
/// One of the ends of the pipe
/// </param>
/// <return>
/// a non-negative file descriptor owned by @self, which must not
///  be closed by the caller, or a negative number if the corresponding
///  end of the pipe was already closed or stolen
/// </return>

	public static int Get(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		return GUnixPipeExterns.g_unix_pipe_get(self, end);
	}

/// <summary>
/// <para>
/// Open a pipe. This is the same as g_unix_open_pipe(), but uses the
/// #GUnixPipe data structure.
/// </para>
/// </summary>

/// <param name="self">
/// A pair of file descriptors
/// </param>
/// <param name="flags">
/// Flags to pass to g_unix_open_pipe(), typically `O_CLOEXEC`
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool Open(MentorLake.GLib.GUnixPipeHandle self, int flags)
	{
		var externCallResult = GUnixPipeExterns.g_unix_pipe_open(self, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Return one of the ends of the pipe. It becomes owned by the caller,
/// and the file descriptor in the data structure is set to `-1`,
/// similar to g_steal_fd().
/// </para>
/// <para>
/// This function is async-signal safe (see &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;)), making it safe to call from a
/// signal handler or a #GSpawnChildSetupFunc.
/// </para>
/// <para>
/// This function preserves the value of `errno`.
/// </para>
/// </summary>

/// <param name="self">
/// A pair of file descriptors
/// </param>
/// <param name="end">
/// One of the ends of the pipe
/// </param>
/// <return>
/// a non-negative file descriptor, which becomes owned by the
///  caller and must be closed by the caller if required, or a negative
///  number if the corresponding end of the pipe was already closed or stolen
/// </return>

	public static int Steal(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		return GUnixPipeExterns.g_unix_pipe_steal(self, end);
	}

}
