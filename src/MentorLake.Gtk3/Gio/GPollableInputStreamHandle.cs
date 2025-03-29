namespace MentorLake.Gio;

public interface GPollableInputStreamHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GPollableInputStreamHandleImpl : BaseSafeHandle, GPollableInputStreamHandle
{
}

public static class GPollableInputStreamHandleExtensions
{
	public static bool CanPoll(this MentorLake.Gio.GPollableInputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_can_poll(stream);
	}

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GPollableInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_create_source(stream, cancellable);
	}

	public static bool IsReadable(this MentorLake.Gio.GPollableInputStreamHandle stream)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GPollableInputStreamHandle)");
		return GPollableInputStreamHandleExterns.g_pollable_input_stream_is_readable(stream);
	}

	public static UIntPtr ReadNonblocking(this MentorLake.Gio.GPollableInputStreamHandle stream, out byte[] buffer, UIntPtr count, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid || stream.IsClosed) throw new Exception("Invalid or closed handle (GPollableInputStreamHandle)");
		var externCallResult = GPollableInputStreamHandleExterns.g_pollable_input_stream_read_nonblocking(stream, out buffer, count, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GPollableInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_input_stream_can_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_pollable_input_stream_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_pollable_input_stream_is_readable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_pollable_input_stream_read_nonblocking([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPollableInputStreamHandleImpl>))] MentorLake.Gio.GPollableInputStreamHandle stream, out byte[] buffer, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
