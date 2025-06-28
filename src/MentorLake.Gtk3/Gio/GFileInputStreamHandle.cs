namespace MentorLake.Gio;

public class GFileInputStreamHandle : GInputStreamHandle, GSeekableHandle
{
}

public static class GFileInputStreamHandleExtensions
{
	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileInputStreamHandle stream, string attributes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileInputStreamHandle)");
		var externCallResult = GFileInputStreamHandleExterns.g_file_input_stream_query_info(stream, attributes, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T QueryInfoAsync<T>(this T stream, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileInputStreamHandle)");
		GFileInputStreamHandleExterns.g_file_input_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileInputStreamHandle)");
		var externCallResult = GFileInputStreamHandleExterns.g_file_input_stream_query_info_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GFileInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_input_stream_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInputStreamHandle>))] MentorLake.Gio.GFileInputStreamHandle stream, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_input_stream_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInputStreamHandle>))] MentorLake.Gio.GFileInputStreamHandle stream, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_input_stream_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileInputStreamHandle>))] MentorLake.Gio.GFileInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
