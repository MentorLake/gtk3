namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The interface for pollable output streams.
/// </para>
/// <para>
/// The default implementation of @can_poll always returns %TRUE.
/// </para>
/// <para>
/// The default implementation of @write_nonblocking calls
/// g_pollable_output_stream_is_writable(), and then calls
/// g_output_stream_write() if it returns %TRUE. This means you only
/// need to override it if it is possible that your @is_writable
/// implementation may return %TRUE when the stream is not actually
/// writable.
/// </para>
/// <para>
/// The default implementation of @writev_nonblocking calls
/// g_pollable_output_stream_write_nonblocking() for each vector, and converts
/// its return value and error (if set) to a #GPollableReturn. You should
/// override this where possible to avoid having to allocate a #GError to return
/// %G_IO_ERROR_WOULD_BLOCK.
/// </para>
/// </summary>

public class GPollableOutputStreamInterfaceHandle : BaseSafeHandle
{
}


public static class GPollableOutputStreamInterfaceExtensions
{

	public static GPollableOutputStreamInterface Dereference(this GPollableOutputStreamInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollableOutputStreamInterface>(x.DangerousGetHandle());
}
internal class GPollableOutputStreamInterfaceExterns
{
}

/// <summary>
/// <para>
/// The interface for pollable output streams.
/// </para>
/// <para>
/// The default implementation of @can_poll always returns %TRUE.
/// </para>
/// <para>
/// The default implementation of @write_nonblocking calls
/// g_pollable_output_stream_is_writable(), and then calls
/// g_output_stream_write() if it returns %TRUE. This means you only
/// need to override it if it is possible that your @is_writable
/// implementation may return %TRUE when the stream is not actually
/// writable.
/// </para>
/// <para>
/// The default implementation of @writev_nonblocking calls
/// g_pollable_output_stream_write_nonblocking() for each vector, and converts
/// its return value and error (if set) to a #GPollableReturn. You should
/// override this where possible to avoid having to allocate a #GError to return
/// %G_IO_ERROR_WOULD_BLOCK.
/// </para>
/// </summary>

public struct GPollableOutputStreamInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Checks if the #GPollableOutputStream instance is actually pollable
/// </para>
/// </summary>

public IntPtr can_poll;
	/// <summary>
/// <para>
/// Checks if the stream is writable
/// </para>
/// </summary>

public IntPtr is_writable;
	/// <summary>
/// <para>
/// Creates a #GSource to poll the stream
/// </para>
/// </summary>

public IntPtr create_source;
	/// <summary>
/// <para>
/// Does a non-blocking write or returns
///   %G_IO_ERROR_WOULD_BLOCK
/// </para>
/// </summary>

public IntPtr write_nonblocking;
	/// <summary>
/// <para>
/// Does a vectored non-blocking write, or returns
///   %G_POLLABLE_RETURN_WOULD_BLOCK
/// </para>
/// </summary>

public IntPtr writev_nonblocking;
}
