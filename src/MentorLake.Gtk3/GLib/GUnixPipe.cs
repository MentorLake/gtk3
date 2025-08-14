namespace MentorLake.GLib;

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
}
