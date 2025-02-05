namespace MentorLake.Gtk3.Gio;

public interface GPollableOutputStreamHandle
{
}

internal class GPollableOutputStreamHandleImpl : BaseSafeHandle, GPollableOutputStreamHandle
{
}

public static class GPollableOutputStreamHandleExtensions
{
	public static bool CanPoll(this GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_can_poll(stream);
	}

	public static GSourceHandle CreateSource(this GPollableOutputStreamHandle stream, GCancellableHandle cancellable)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_create_source(stream, cancellable);
	}

	public static bool IsWritable(this GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_is_writable(stream);
	}

	public static UIntPtr WriteNonblocking(this GPollableOutputStreamHandle stream, IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_write_nonblocking(stream, buffer, count, cancellable, out error);
	}

	public static GPollableReturn WritevNonblocking(this GPollableOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPollableOutputStreamExterns.g_pollable_output_stream_writev_nonblocking(stream, vectors, n_vectors, out bytes_written, cancellable, out error);
	}

}

internal class GPollableOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_output_stream_can_poll(GPollableOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_pollable_output_stream_create_source(GPollableOutputStreamHandle stream, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_pollable_output_stream_is_writable(GPollableOutputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_pollable_output_stream_write_nonblocking(GPollableOutputStreamHandle stream, IntPtr buffer, UIntPtr count, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GPollableReturn g_pollable_output_stream_writev_nonblocking(GPollableOutputStreamHandle stream, GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, GCancellableHandle cancellable, out GErrorHandle error);

}
