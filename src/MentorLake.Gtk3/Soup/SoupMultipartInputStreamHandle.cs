namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Handles streams of multipart messages.
/// </para>
/// <para>
/// This adds support for the multipart responses. For handling the
/// multiple parts the user needs to wrap the [class@Gio.InputStream] obtained by
/// sending the request with a [class@MultipartInputStream] and use
/// [method@MultipartInputStream.next_part] before reading. Responses
/// which are not wrapped will be treated like non-multipart responses.
/// </para>
/// <para>
/// Note that although [class@MultipartInputStream] is a [class@Gio.InputStream],
/// you should not read directly from it, and the results are undefined
/// if you do.
/// </para>
/// </summary>

public class SoupMultipartInputStreamHandle : GFilterInputStreamHandle, GPollableInputStreamHandle
{
/// <summary>
/// <para>
/// Creates a new [class@MultipartInputStream] that wraps the
/// [class@Gio.InputStream] obtained by sending the [class@Message].
/// </para>
/// <para>
/// Reads should not be done directly through this object, use the input streams
/// returned by [method@MultipartInputStream.next_part] or its async
/// counterpart instead.
/// </para>
/// </summary>

/// <param name="msg">
/// the #SoupMessage the response is related to.
/// </param>
/// <param name="base_stream">
/// the #GInputStream returned by sending the request.
/// </param>
/// <return>
/// a new #SoupMultipartInputStream
/// </return>

	public static MentorLake.Soup.SoupMultipartInputStreamHandle New(MentorLake.Soup.SoupMessageHandle msg, MentorLake.Gio.GInputStreamHandle base_stream)
	{
		return SoupMultipartInputStreamHandleExterns.soup_multipart_input_stream_new(msg, base_stream);
	}

}

public static class SoupMultipartInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Obtains the headers for the part currently being processed.
/// </para>
/// <para>
/// Note that the [struct@MessageHeaders] that are returned are owned by the
/// [class@MultipartInputStream] and will be replaced when a call is made to
/// [method@MultipartInputStream.next_part] or its async counterpart, so if
/// keeping the headers is required, a copy must be made.
/// </para>
/// <para>
/// Note that if a part had no headers at all an empty [struct@MessageHeaders]
/// will be returned.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipartInputStream.
/// </param>
/// <return>
/// a #SoupMessageHeaders
///   containing the headers for the part currently being processed or
///   %NULL if the headers failed to parse.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetHeaders(this MentorLake.Soup.SoupMultipartInputStreamHandle multipart)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipartInputStreamHandle)");
		return SoupMultipartInputStreamHandleExterns.soup_multipart_input_stream_get_headers(multipart);
	}

/// <summary>
/// <para>
/// Obtains an input stream for the next part.
/// </para>
/// <para>
/// When dealing with a multipart response the input stream needs to be wrapped
/// in a [class@MultipartInputStream] and this function or its async counterpart
/// need to be called to obtain the first part for reading.
/// </para>
/// <para>
/// After calling this function,
/// [method@MultipartInputStream.get_headers] can be used to obtain the
/// headers for the first part. A read of 0 bytes indicates the end of
/// the part; a new call to this function should be done at that point,
/// to obtain the next part.
/// </para>
/// <para>
/// @error will only be set if an error happens during a read, %NULL
/// is a valid return value otherwise.
/// </para>
/// </summary>

/// <param name="multipart">
/// the #SoupMultipartInputStream
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// a new #GInputStream, or
///   %NULL if there are no more parts
/// </return>

	public static MentorLake.Gio.GInputStreamHandle NextPart(this MentorLake.Soup.SoupMultipartInputStreamHandle multipart, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipartInputStreamHandle)");
		var externCallResult = SoupMultipartInputStreamHandleExterns.soup_multipart_input_stream_next_part(multipart, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Obtains a [class@Gio.InputStream] for the next request.
/// </para>
/// <para>
/// See [method@MultipartInputStream.next_part] for details on the workflow.
/// </para>
/// </summary>

/// <param name="multipart">
/// the #SoupMultipartInputStream.
/// </param>
/// <param name="io_priority">
/// the I/O priority for the request.
/// </param>
/// <param name="cancellable">
/// a #GCancellable.
/// </param>
/// <param name="callback">
/// callback to call when request is satisfied.
/// </param>
/// <param name="data">
/// data for @callback
/// </param>

	public static T NextPartAsync<T>(this T multipart, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr data) where T : SoupMultipartInputStreamHandle
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipartInputStreamHandle)");
		SoupMultipartInputStreamHandleExterns.soup_multipart_input_stream_next_part_async(multipart, io_priority, cancellable, callback, data);
		return multipart;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous request for the next part.
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipartInputStream.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a newly created
///   [class@Gio.InputStream] for reading the next part or %NULL if there are no
///   more parts.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle NextPartFinish(this MentorLake.Soup.SoupMultipartInputStreamHandle multipart, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (multipart.IsInvalid) throw new Exception("Invalid handle (SoupMultipartInputStreamHandle)");
		var externCallResult = SoupMultipartInputStreamHandleExterns.soup_multipart_input_stream_next_part_finish(multipart, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class SoupMultipartInputStreamHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMultipartInputStreamHandle>))]
	internal static extern MentorLake.Soup.SoupMultipartInputStreamHandle soup_multipart_input_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_multipart_input_stream_get_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartInputStreamHandle>))] MentorLake.Soup.SoupMultipartInputStreamHandle multipart);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle soup_multipart_input_stream_next_part([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartInputStreamHandle>))] MentorLake.Soup.SoupMultipartInputStreamHandle multipart, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_multipart_input_stream_next_part_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartInputStreamHandle>))] MentorLake.Soup.SoupMultipartInputStreamHandle multipart, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr data);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle soup_multipart_input_stream_next_part_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartInputStreamHandle>))] MentorLake.Soup.SoupMultipartInputStreamHandle multipart, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
