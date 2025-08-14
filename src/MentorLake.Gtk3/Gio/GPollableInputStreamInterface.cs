namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The interface for pollable input streams.
/// </para>
/// <para>
/// The default implementation of @can_poll always returns %TRUE.
/// </para>
/// <para>
/// The default implementation of @read_nonblocking calls
/// g_pollable_input_stream_is_readable(), and then calls
/// g_input_stream_read() if it returns %TRUE. This means you only need
/// to override it if it is possible that your @is_readable
/// implementation may return %TRUE when the stream is not actually
/// readable.
/// </para>
/// </summary>

public class GPollableInputStreamInterfaceHandle : BaseSafeHandle
{
}


public static class GPollableInputStreamInterfaceExtensions
{

	public static GPollableInputStreamInterface Dereference(this GPollableInputStreamInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollableInputStreamInterface>(x.DangerousGetHandle());
}
internal class GPollableInputStreamInterfaceExterns
{
}

/// <summary>
/// <para>
/// The interface for pollable input streams.
/// </para>
/// <para>
/// The default implementation of @can_poll always returns %TRUE.
/// </para>
/// <para>
/// The default implementation of @read_nonblocking calls
/// g_pollable_input_stream_is_readable(), and then calls
/// g_input_stream_read() if it returns %TRUE. This means you only need
/// to override it if it is possible that your @is_readable
/// implementation may return %TRUE when the stream is not actually
/// readable.
/// </para>
/// </summary>

public struct GPollableInputStreamInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Checks if the #GPollableInputStream instance is actually pollable
/// </para>
/// </summary>

public IntPtr can_poll;
	/// <summary>
/// <para>
/// Checks if the stream is readable
/// </para>
/// </summary>

public IntPtr is_readable;
	/// <summary>
/// <para>
/// Creates a #GSource to poll the stream
/// </para>
/// </summary>

public IntPtr create_source;
	/// <summary>
/// <para>
/// Does a non-blocking read or returns
///   %G_IO_ERROR_WOULD_BLOCK
/// </para>
/// </summary>

public IntPtr read_nonblocking;
}
