namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GFileIOStream` provides I/O streams that both read and write to the same
/// file handle.
/// </para>
/// <para>
/// `GFileIOStream` implements [iface@Gio.Seekable], which allows the I/O
/// stream to jump to arbitrary positions in the file and to truncate
/// the file, provided the filesystem of the file supports these
/// operations.
/// </para>
/// <para>
/// To find the position of a file I/O stream, use [method@Gio.Seekable.tell].
/// </para>
/// <para>
/// To find out if a file I/O stream supports seeking, use
/// [method@Gio.Seekable.can_seek]. To position a file I/O stream, use
/// [method@Gio.Seekable.seek]. To find out if a file I/O stream supports
/// truncating, use [method@Gio.Seekable.can_truncate]. To truncate a file I/O
/// stream, use [method@Gio.Seekable.truncate].
/// </para>
/// <para>
/// The default implementation of all the `GFileIOStream` operations
/// and the implementation of [iface@Gio.Seekable] just call into the same
/// operations on the output stream.
/// </para>
/// </summary>

public class GFileIOStreamHandle : GIOStreamHandle, GSeekableHandle
{
}

public static class GFileIOStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets the entity tag for the file when it has been written.
/// This must be called after the stream has been written
/// and closed, as the etag can change while writing.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileIOStream.
/// </param>
/// <return>
/// the entity tag for the stream.
/// </return>

	public static string GetEtag(this MentorLake.Gio.GFileIOStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileIOStreamHandle)");
		return GFileIOStreamHandleExterns.g_file_io_stream_get_etag(stream);
	}

/// <summary>
/// <para>
/// Queries a file io stream for the given @attributes.
/// This function blocks while querying the stream. For the asynchronous
/// version of this function, see g_file_io_stream_query_info_async().
/// While the stream is blocked, the stream will set the pending flag
/// internally, and any other operations on the stream will fail with
/// %G_IO_ERROR_PENDING.
/// </para>
/// <para>
/// Can fail if the stream was already closed (with @error being set to
/// %G_IO_ERROR_CLOSED), the stream has pending operations (with @error being
/// set to %G_IO_ERROR_PENDING), or if querying info is not supported for
/// the stream&apos;s interface (with @error being set to %G_IO_ERROR_NOT_SUPPORTED). I
/// all cases of failure, %NULL will be returned.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be set, and %NULL will
/// be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileIOStream.
/// </param>
/// <param name="attributes">
/// a file attribute query string.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GFileInfo for the @stream, or %NULL on error.
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryInfo(this MentorLake.Gio.GFileIOStreamHandle stream, string attributes, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileIOStreamHandle)");
		var externCallResult = GFileIOStreamHandleExterns.g_file_io_stream_query_info(stream, attributes, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously queries the @stream for a #GFileInfo. When completed,
/// @callback will be called with a #GAsyncResult which can be used to
/// finish the operation with g_file_io_stream_query_info_finish().
/// </para>
/// <para>
/// For the synchronous version of this function, see
/// g_file_io_stream_query_info().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileIOStream.
/// </param>
/// <param name="attributes">
/// a file attribute query string.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the
///   request
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

	public static T QueryInfoAsync<T>(this T stream, string attributes, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GFileIOStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileIOStreamHandle)");
		GFileIOStreamHandleExterns.g_file_io_stream_query_info_async(stream, attributes, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finalizes the asynchronous query started
/// by g_file_io_stream_query_info_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a #GFileIOStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// A #GFileInfo for the finished query.
/// </return>

	public static MentorLake.Gio.GFileInfoHandle QueryInfoFinish(this MentorLake.Gio.GFileIOStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GFileIOStreamHandle)");
		var externCallResult = GFileIOStreamHandleExterns.g_file_io_stream_query_info_finish(stream, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GFileIOStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_io_stream_get_etag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_io_stream_query_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, string attributes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_io_stream_query_info_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, string attributes, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GFileInfoHandle>))]
	internal static extern MentorLake.Gio.GFileInfoHandle g_file_io_stream_query_info_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileIOStreamHandle>))] MentorLake.Gio.GFileIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
