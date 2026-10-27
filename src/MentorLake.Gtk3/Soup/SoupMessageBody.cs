namespace MentorLake.Soup;

/// <summary>
/// <para>
/// [struct@MessageBody] represents the request or response body of a
/// [class@Message].
/// </para>
/// <para>
/// Note that while @length always reflects the full length of the
/// message body, @data is normally %NULL, and will only be filled in
/// after [method@MessageBody.flatten] is called. For client-side
/// messages, this automatically happens for the response body after it
/// has been fully read. Likewise, for server-side
/// messages, the request body is automatically filled in after being
/// read.
/// </para>
/// <para>
/// As an added bonus, when @data is filled in, it is always terminated
/// with a `\0` byte (which is not reflected in @length).
/// </para>
/// </summary>

public class SoupMessageBodyHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [struct@MessageBody]
/// </para>
/// <para>
/// [class@Message] uses this internally; you
/// will not normally need to call it yourself.
/// </para>
/// </summary>

/// <return>
/// a new #SoupMessageBody.
/// </return>

	public static MentorLake.Soup.SoupMessageBodyHandle New()
	{
		return SoupMessageBodyExterns.soup_message_body_new();
	}

}


public static class SoupMessageBodyExtensions
{
/// <summary>
/// <para>
/// Appends @length bytes from @data to @body according to @use.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="use">
/// how to use @data
/// </param>
/// <param name="data">
/// data to append
/// </param>
/// <param name="length">
/// length of @data
/// </param>

	public static void Append(this MentorLake.Soup.SoupMessageBodyHandle body, MentorLake.Soup.SoupMemoryUse use, byte[] data, UIntPtr length)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_append(body, use, data, length);
	}

/// <summary>
/// <para>
/// Appends the data from @buffer to @body.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="buffer">
/// a #GBytes
/// </param>

	public static void AppendBytes(this MentorLake.Soup.SoupMessageBodyHandle body, MentorLake.GLib.GBytesHandle buffer)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_append_bytes(body, buffer);
	}

/// <summary>
/// <para>
/// Appends @length bytes from @data to @body.
/// </para>
/// <para>
/// This function is exactly equivalent to [method@MessageBody.append]
/// with %SOUP_MEMORY_TAKE as second argument; it exists mainly for
/// convenience and simplifying language bindings.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="data">
/// data to append
/// </param>
/// <param name="length">
/// length of @data
/// </param>

	public static void AppendTake(this MentorLake.Soup.SoupMessageBodyHandle body, byte[] data, UIntPtr length)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_append_take(body, data, length);
	}

/// <summary>
/// <para>
/// Tags @body as being complete.
/// </para>
/// <para>
/// Call this when using chunked encoding after you have appended the last chunk.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>

	public static void Complete(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_complete(body);
	}

/// <summary>
/// <para>
/// Fills in @body&apos;s data field with a buffer containing all of the
/// data in @body.
/// </para>
/// <para>
/// Adds an additional `\0` byte not counted by @body&apos;s
/// length field.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <return>
/// a #GBytes containing the same data as @body.
///   (You must [method@GLib.Bytes.unref] this if you do not want it.)
/// </return>

	public static MentorLake.GLib.GBytesHandle Flatten(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		return SoupMessageBodyExterns.soup_message_body_flatten(body);
	}

/// <summary>
/// <para>
/// Gets the accumulate flag on @body.
/// </para>
/// <para>
/// See [method@MessageBody.set_accumulate. for details.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <return>
/// the accumulate flag for @body.
/// </return>

	public static bool GetAccumulate(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		return SoupMessageBodyExterns.soup_message_body_get_accumulate(body);
	}

/// <summary>
/// <para>
/// Gets a [struct@GLib.Bytes] containing data from @body starting at @offset.
/// </para>
/// <para>
/// The size of the returned chunk is unspecified. You can iterate
/// through the entire body by first calling
/// [method@MessageBody.get_chunk] with an offset of 0, and then on each
/// successive call, increment the offset by the length of the
/// previously-returned chunk.
/// </para>
/// <para>
/// If @offset is greater than or equal to the total length of @body,
/// then the return value depends on whether or not
/// [method@MessageBody.complete] has been called or not; if it has,
/// then [method@MessageBody.get_chunk] will return a 0-length chunk
/// (indicating the end of @body). If it has not, then
/// [method@MessageBody.get_chunk] will return %NULL (indicating that
/// @body may still potentially have more data, but that data is not
/// currently available).
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="offset">
/// an offset
/// </param>
/// <return>
/// a #GBytes
/// </return>

	public static MentorLake.GLib.GBytesHandle GetChunk(this MentorLake.Soup.SoupMessageBodyHandle body, int offset)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		return SoupMessageBodyExterns.soup_message_body_get_chunk(body, offset);
	}

/// <summary>
/// <para>
/// Handles the [struct@MessageBody] part of receiving a chunk of data from
/// the network.
/// </para>
/// <para>
/// Normally this means appending @chunk to @body, exactly as with
/// [method@MessageBody.append_bytes], but if you have set @body&apos;s accumulate
/// flag to %FALSE, then that will not happen.
/// </para>
/// <para>
/// This is a low-level method which you should not normally need to
/// use.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="chunk">
/// a #GBytes received from the network
/// </param>

	public static void GotChunk(this MentorLake.Soup.SoupMessageBodyHandle body, MentorLake.GLib.GBytesHandle chunk)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_got_chunk(body, chunk);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @body by one.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <return>
/// the passed in #SoupMessageBody
/// </return>

	public static MentorLake.Soup.SoupMessageBodyHandle Ref(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		return SoupMessageBodyExterns.soup_message_body_ref(body);
	}

/// <summary>
/// <para>
/// Sets or clears the accumulate flag on @body.
/// </para>
/// <para>
/// (The default value is %TRUE.) If set to %FALSE, @body&apos;s data field will not
/// be filled in after the body is fully sent/received, and the chunks that make
/// up @body may be discarded when they are no longer needed.
/// </para>
/// <para>
/// If you set the flag to %FALSE on the [class@Message] request_body of a
/// client-side message, it will block the accumulation of chunks into
/// @body&apos;s data field, but it will not normally cause the chunks to
/// be discarded after being written like in the server-side
/// [class@Message] response_body case, because the request body needs to
/// be kept around in case the request needs to be sent a second time
/// due to redirection or authentication.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="accumulate">
/// whether or not to accumulate body chunks in @body
/// </param>

	public static void SetAccumulate(this MentorLake.Soup.SoupMessageBodyHandle body, bool accumulate)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_set_accumulate(body, accumulate);
	}

/// <summary>
/// <para>
/// Deletes all of the data in @body.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>

	public static void Truncate(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_truncate(body);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @body by one.
/// </para>
/// <para>
/// When the reference count reaches zero, the resources allocated by
/// @body are freed
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>

	public static void Unref(this MentorLake.Soup.SoupMessageBodyHandle body)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_unref(body);
	}

/// <summary>
/// <para>
/// Handles the [struct@MessageBody] part of writing a chunk of data to the
/// network.
/// </para>
/// <para>
/// Normally this is a no-op, but if you have set @body&apos;s accumulate flag to
/// %FALSE, then this will cause @chunk to be discarded to free up memory.
/// </para>
/// <para>
/// This is a low-level method which you should not need to use, and
/// there are further restrictions on its proper use which are not
/// documented here.
/// </para>
/// </summary>

/// <param name="body">
/// a #SoupMessageBody
/// </param>
/// <param name="chunk">
/// a #GBytes returned from [method@MessageBody.get_chunk]
/// </param>

	public static void WroteChunk(this MentorLake.Soup.SoupMessageBodyHandle body, MentorLake.GLib.GBytesHandle chunk)
	{
		if (body.IsInvalid) throw new Exception("Invalid handle (SoupMessageBody)");
		SoupMessageBodyExterns.soup_message_body_wrote_chunk(body, chunk);
	}


	public static SoupMessageBody Dereference(this SoupMessageBodyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMessageBody>(x.DangerousGetHandle());
}
internal class SoupMessageBodyExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))]
	internal static extern MentorLake.Soup.SoupMessageBodyHandle soup_message_body_new();

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, MentorLake.Soup.SoupMemoryUse use, byte[] data, UIntPtr length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_append_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle buffer);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_append_take([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, byte[] data, UIntPtr length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_message_body_flatten([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_body_get_accumulate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_message_body_get_chunk([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, int offset);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_got_chunk([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle chunk);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))]
	internal static extern MentorLake.Soup.SoupMessageBodyHandle soup_message_body_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_set_accumulate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, bool accumulate);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_body_wrote_chunk([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))] MentorLake.Soup.SoupMessageBodyHandle body, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle chunk);

}

/// <summary>
/// <para>
/// [struct@MessageBody] represents the request or response body of a
/// [class@Message].
/// </para>
/// <para>
/// Note that while @length always reflects the full length of the
/// message body, @data is normally %NULL, and will only be filled in
/// after [method@MessageBody.flatten] is called. For client-side
/// messages, this automatically happens for the response body after it
/// has been fully read. Likewise, for server-side
/// messages, the request body is automatically filled in after being
/// read.
/// </para>
/// <para>
/// As an added bonus, when @data is filled in, it is always terminated
/// with a `\0` byte (which is not reflected in @length).
/// </para>
/// </summary>

public struct SoupMessageBody
{
	/// <summary>
/// <para>
/// the data
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public byte[] data;
	/// <summary>
/// <para>
/// length of @data
/// </para>
/// </summary>

public int length;
}
