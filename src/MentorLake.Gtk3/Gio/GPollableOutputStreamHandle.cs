namespace MentorLake.Gio;

public interface GPollableOutputStreamHandle
{
}

internal class GPollableOutputStreamHandleImpl : BaseSafeHandle, GPollableOutputStreamHandle
{
}

public static class GPollableOutputStreamHandleExtensions
{
	public static bool CanPoll(this MentorLake.Gio.GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_can_poll(stream);
	}

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_create_source(stream, cancellable);
	}

	public static bool IsWritable(this MentorLake.Gio.GPollableOutputStreamHandle stream)
	{
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_is_writable(stream);
	}

	public static UIntPtr WriteNonblocking(this MentorLake.Gio.GPollableOutputStreamHandle stream, byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_write_nonblocking(stream, buffer, count, cancellable);
	}

	public static MentorLake.Gio.GPollableReturn WritevNonblocking(this MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GPollableOutputStreamHandleExterns.g_pollable_output_stream_writev_nonblocking(stream, vectors, n_vectors, out bytes_written, cancellable);
	}

}

internal class GPollableOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_output_stream_can_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_output_stream_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_output_stream_is_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_output_stream_write_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GPollableReturn g_pollable_output_stream_writev_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableOutputStreamHandleImpl>))] MentorLake.Gio.GPollableOutputStreamHandle stream, MentorLake.Gio.GOutputVector[] vectors, UIntPtr n_vectors, out UIntPtr bytes_written, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

}
