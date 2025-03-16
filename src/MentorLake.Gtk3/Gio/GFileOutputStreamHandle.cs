namespace MentorLake.Gio;

public class GFileOutputStreamHandle : GOutputStreamHandle, GSeekableHandle
{
}

public static class GFileOutputStreamHandleExtensions
{
	public static string GetEtag(this MentorLake.Gio.GFileOutputStreamHandle stream)
	{
		return GFileOutputStreamHandleExterns.g_file_output_stream_get_etag(stream);
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileOutputStreamHandle stream, string attributes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GFileOutputStreamHandleExterns.g_file_output_stream_query_info(stream, attributes, cancellable);
	}

	public static T QueryInfoAsync<T>(this T stream, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileOutputStreamHandle
	{
		GFileOutputStreamHandleExterns.g_file_output_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileOutputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		return GFileOutputStreamHandleExterns.g_file_output_stream_query_info_finish(stream, result);
	}

}

internal class GFileOutputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_output_stream_get_etag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))] MentorLake.Gio.GFileOutputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_output_stream_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))] MentorLake.Gio.GFileOutputStreamHandle stream, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_output_stream_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))] MentorLake.Gio.GFileOutputStreamHandle stream, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_output_stream_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileOutputStreamHandle>))] MentorLake.Gio.GFileOutputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result);

}
