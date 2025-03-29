namespace MentorLake.Gio;

public class GFileIOStreamHandle : GIOStreamHandle, GSeekableHandle
{
}

public static class GFileIOStreamHandleExtensions
{
	public static string GetEtag(this MentorLake.Gio.GFileIOStreamHandle stream)
	{
		return GFileIOStreamHandleExterns.g_file_io_stream_get_etag(stream);
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileIOStreamHandle stream, string attributes, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GFileIOStreamHandleExterns.g_file_io_stream_query_info(stream, attributes, cancellable, error);
	}

	public static T QueryInfoAsync<T>(this T stream, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileIOStreamHandle
	{
		GFileIOStreamHandleExterns.g_file_io_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileIOStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GFileIOStreamHandleExterns.g_file_io_stream_query_info_finish(stream, result, error);
	}

}

internal class GFileIOStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_io_stream_get_etag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_io_stream_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_io_stream_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_io_stream_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
