namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GFileInputStream` provides input streams that take their
/// content from a file.
/// </para>
/// <para>
/// `GFileInputStream` implements [iface@Gio.Seekable], which allows the input
/// stream to jump to arbitrary positions in the file, provided the
/// filesystem of the file allows it. To find the position of a file
/// input stream, use [method@Gio.Seekable.tell]. To find out if a file input
/// stream supports seeking, use [vfunc@Gio.Seekable.can_seek].
/// To position a file input stream, use [vfunc@Gio.Seekable.seek].
/// </para>
/// </summary>

public class GFileInputStreamHandle : GInputStreamHandle, GSeekableHandle
{
}

public static class GFileInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Queries a file input stream the given @attributes. This function blocks
/// while querying the stream. For the asynchronous (non-blocking) version
/// of this function, see g_file_input_stream_query_info_async(). While the
/// stream is blocked, the stream will set the pending flag internally, and
/// any other operations on the stream will fail with %G_IO_ERROR_PENDING.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileInputStream.
/// </param>
/// <param name="attributes">
/// a file attribute query string.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GFileInfo, or %NULL on error.
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileInputStreamHandle stream, string attributes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileInputStreamHandle)");
		var externCallResult = GFileInputStreamHandleExterns.g_file_input_stream_query_info(stream, attributes, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Queries the stream information asynchronously.
/// When the operation is finished @callback will be called.
/// You can then call g_file_input_stream_query_info_finish()
/// to get the result of the operation.
/// </para>
/// <para>
/// For the synchronous version of this function,
/// see g_file_input_stream_query_info().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be set
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileInputStream.
/// </param>
/// <param name="attributes">
/// a file attribute query string.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T QueryInfoAsync<T>(this T stream, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileInputStreamHandle)");
		GFileInputStreamHandleExterns.g_file_input_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous info query operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// #GFileInfo.
/// </return>

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
