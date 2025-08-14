namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for implementing seekable functionality on I/O Streams.
/// </para>
/// </summary>

public class GSeekableIfaceHandle : BaseSafeHandle
{
}


public static class GSeekableIfaceExtensions
{

	public static GSeekableIface Dereference(this GSeekableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSeekableIface>(x.DangerousGetHandle());
}
internal class GSeekableIfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for implementing seekable functionality on I/O Streams.
/// </para>
/// </summary>

public struct GSeekableIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Tells the current location within a stream.
/// </para>
/// </summary>

public IntPtr tell;
	/// <summary>
/// <para>
/// Checks if seeking is supported by the stream.
/// </para>
/// </summary>

public IntPtr can_seek;
	/// <summary>
/// <para>
/// Seeks to a location within a stream.
/// </para>
/// </summary>

public IntPtr seek;
	/// <summary>
/// <para>
/// Checks if truncation is supported by the stream.
/// </para>
/// </summary>

public IntPtr can_truncate;
	/// <summary>
/// <para>
/// Truncates a stream.
/// </para>
/// </summary>

public IntPtr truncate_fn;
}
