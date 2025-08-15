namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Data input stream implements [class@Gio.InputStream] and includes functions
/// for reading structured data directly from a binary input stream.
/// </para>
/// </summary>

public class GDataInputStreamHandle : GBufferedInputStreamHandle, GSeekableHandle
{
/// <summary>
/// <para>
/// Creates a new data input stream for the @base_stream.
/// </para>
/// </summary>

/// <param name="base_stream">
/// a #GInputStream.
/// </param>
/// <return>
/// a new #GDataInputStream.
/// </return>

	public static MentorLake.Gio.GDataInputStreamHandle New(MentorLake.Gio.GInputStreamHandle base_stream)
	{
		return GDataInputStreamHandleExterns.g_data_input_stream_new(base_stream);
	}

}

public static class GDataInputStreamHandleExtensions
{
/// <summary>
/// <para>
/// Gets the byte order for the data input stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <return>
/// the @stream&apos;s current #GDataStreamByteOrder.
/// </return>

	public static MentorLake.Gio.GDataStreamByteOrder GetByteOrder(this MentorLake.Gio.GDataInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		return GDataInputStreamHandleExterns.g_data_input_stream_get_byte_order(stream);
	}

/// <summary>
/// <para>
/// Gets the current newline type for the @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <return>
/// #GDataStreamNewlineType for the given @stream.
/// </return>

	public static MentorLake.Gio.GDataStreamNewlineType GetNewlineType(this MentorLake.Gio.GDataInputStreamHandle stream)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		return GDataInputStreamHandleExterns.g_data_input_stream_get_newline_type(stream);
	}

/// <summary>
/// <para>
/// Reads an unsigned 8-bit/1-byte value from @stream.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// an unsigned 8-bit/1-byte value read from the @stream or `0`
/// if an error occurred.
/// </return>

	public static byte ReadByte(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_byte(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a 16-bit/2-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order() and g_data_input_stream_set_byte_order().
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a signed 16-bit/2-byte value read from @stream or `0` if
/// an error occurred.
/// </return>

	public static short ReadInt16(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int16(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a signed 32-bit/4-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order() and g_data_input_stream_set_byte_order().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a signed 32-bit/4-byte value read from the @stream or `0` if
/// an error occurred.
/// </return>

	public static int ReadInt32(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int32(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a 64-bit/8-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order() and g_data_input_stream_set_byte_order().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a signed 64-bit/8-byte value read from @stream or `0` if
/// an error occurred.
/// </return>

	public static long ReadInt64(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_int64(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a line from the data input stream.  Note that no encoding
/// checks or conversion is performed; the input is not guaranteed to
/// be UTF-8, and may in fact have embedded NUL characters.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// 
///  a NUL terminated byte array with the line that was read in
///  (without the newlines).  Set @length to a #gsize to get the length
///  of the read line.  On an error, it will return %NULL and @error
///  will be set. If there&apos;s no content to read, it will still return
///  %NULL, but @error won&apos;t be set.
/// </return>

	public static byte[] ReadLine(this MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line(stream, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// The asynchronous version of g_data_input_stream_read_line().  It is
/// an error to have two outstanding calls to this function.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You
/// can then call g_data_input_stream_read_line_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// callback to call when the request is satisfied.
/// </param>
/// <param name="user_data">
/// the data to pass to callback function.
/// </param>

	public static T ReadLineAsync<T>(this T stream, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		GDataInputStreamHandleExterns.g_data_input_stream_read_line_async(stream, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finish an asynchronous call started by
/// g_data_input_stream_read_line_async().  Note the warning about
/// string encoding in g_data_input_stream_read_line() applies here as
/// well.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="result">
/// the #GAsyncResult that was provided to the callback.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <return>
/// 
///  a NUL-terminated byte array with the line that was read in
///  (without the newlines).  Set @length to a #gsize to get the length
///  of the read line.  On an error, it will return %NULL and @error
///  will be set. If there&apos;s no content to read, it will still return
///  %NULL, but @error won&apos;t be set.
/// </return>

	public static byte[] ReadLineFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finish an asynchronous call started by
/// g_data_input_stream_read_line_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="result">
/// the #GAsyncResult that was provided to the callback.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <return>
/// a string with the line that
///  was read in (without the newlines).  Set @length to a #gsize to
///  get the length of the read line.  On an error, it will return
///  %NULL and @error will be set. For UTF-8 conversion errors, the set
///  error domain is %G_CONVERT_ERROR.  If there&apos;s no content to read,
///  it will still return %NULL, but @error won&apos;t be set.
/// </return>

	public static string ReadLineFinishUtf8(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_finish_utf8(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a UTF-8 encoded line from the data input stream.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a NUL terminated UTF-8 string
///  with the line that was read in (without the newlines).  Set
///  @length to a #gsize to get the length of the read line.  On an
///  error, it will return %NULL and @error will be set.  For UTF-8
///  conversion errors, the set error domain is %G_CONVERT_ERROR.  If
///  there&apos;s no content to read, it will still return %NULL, but @error
///  won&apos;t be set.
/// </return>

	public static string ReadLineUtf8(this MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_line_utf8(stream, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads an unsigned 16-bit/2-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order() and g_data_input_stream_set_byte_order().
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// an unsigned 16-bit/2-byte value read from the @stream or `0` if
/// an error occurred.
/// </return>

	public static ushort ReadUint16(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint16(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads an unsigned 32-bit/4-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order() and g_data_input_stream_set_byte_order().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// an unsigned 32-bit/4-byte value read from the @stream or `0` if
/// an error occurred.
/// </return>

	public static uint ReadUint32(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint32(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads an unsigned 64-bit/8-byte value from @stream.
/// </para>
/// <para>
/// In order to get the correct byte order for this read operation,
/// see g_data_input_stream_get_byte_order().
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// an unsigned 64-bit/8-byte read from @stream or `0` if
/// an error occurred.
/// </return>

	public static ulong ReadUint64(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_uint64(stream, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a string from the data input stream, up to the first
/// occurrence of any of the stop characters.
/// </para>
/// <para>
/// Note that, in contrast to g_data_input_stream_read_until_async(),
/// this function consumes the stop character that it finds.
/// </para>
/// <para>
/// Don&apos;t use this function in new code.  Its functionality is
/// inconsistent with g_data_input_stream_read_until_async().  Both
/// functions will be marked as deprecated in a future release.  Use
/// g_data_input_stream_read_upto() instead, but note that that function
/// does not consume the stop character.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="stop_chars">
/// characters to terminate the read.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a string with the data that was read
///     before encountering any of the stop characters. Set @length to
///     a #gsize to get the length of the string. This function will
///     return %NULL on an error.
/// </return>

	public static string ReadUntil(this MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_until(stream, stop_chars, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// The asynchronous version of g_data_input_stream_read_until().
/// It is an error to have two outstanding calls to this function.
/// </para>
/// <para>
/// Note that, in contrast to g_data_input_stream_read_until(),
/// this function does not consume the stop character that it finds.  You
/// must read it for yourself.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You
/// can then call g_data_input_stream_read_until_finish() to get
/// the result of the operation.
/// </para>
/// <para>
/// Don&apos;t use this function in new code.  Its functionality is
/// inconsistent with g_data_input_stream_read_until().  Both functions
/// will be marked as deprecated in a future release.  Use
/// g_data_input_stream_read_upto_async() instead.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="stop_chars">
/// characters to terminate the read.
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// callback to call when the request is satisfied.
/// </param>
/// <param name="user_data">
/// the data to pass to callback function.
/// </param>

	public static T ReadUntilAsync<T>(this T stream, string stop_chars, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		GDataInputStreamHandleExterns.g_data_input_stream_read_until_async(stream, stop_chars, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finish an asynchronous call started by
/// g_data_input_stream_read_until_async().
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="result">
/// the #GAsyncResult that was provided to the callback.
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in.
/// </param>
/// <return>
/// a string with the data that was read
///     before encountering any of the stop characters. Set @length to
///     a #gsize to get the length of the string. This function will
///     return %NULL on an error.
/// </return>

	public static string ReadUntilFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_until_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a string from the data input stream, up to the first
/// occurrence of any of the stop characters.
/// </para>
/// <para>
/// In contrast to g_data_input_stream_read_until(), this function
/// does not consume the stop character. You have to use
/// g_data_input_stream_read_byte() to get it before calling
/// g_data_input_stream_read_upto() again.
/// </para>
/// <para>
/// Note that @stop_chars may contain &apos;\0&apos; if @stop_chars_len is
/// specified.
/// </para>
/// <para>
/// The returned string will always be nul-terminated on success.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GDataInputStream
/// </param>
/// <param name="stop_chars">
/// characters to terminate the read
/// </param>
/// <param name="stop_chars_len">
/// length of @stop_chars. May be -1 if @stop_chars is
///     nul-terminated
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <return>
/// a string with the data that was read
///     before encountering any of the stop characters. Set @length to
///     a #gsize to get the length of the string. This function will
///     return %NULL on an error
/// </return>

	public static string ReadUpto(this MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, out UIntPtr length, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_upto(stream, stop_chars, stop_chars_len, out length, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// The asynchronous version of g_data_input_stream_read_upto().
/// It is an error to have two outstanding calls to this function.
/// </para>
/// <para>
/// In contrast to g_data_input_stream_read_until(), this function
/// does not consume the stop character. You have to use
/// g_data_input_stream_read_byte() to get it before calling
/// g_data_input_stream_read_upto() again.
/// </para>
/// <para>
/// Note that @stop_chars may contain &apos;\0&apos; if @stop_chars_len is
/// specified.
/// </para>
/// <para>
/// When the operation is finished, @callback will be called. You
/// can then call g_data_input_stream_read_upto_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GDataInputStream
/// </param>
/// <param name="stop_chars">
/// characters to terminate the read
/// </param>
/// <param name="stop_chars_len">
/// length of @stop_chars. May be -1 if @stop_chars is
///     nul-terminated
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore
/// </param>
/// <param name="callback">
/// callback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T ReadUptoAsync<T>(this T stream, string stop_chars, UIntPtr stop_chars_len, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDataInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		GDataInputStreamHandleExterns.g_data_input_stream_read_upto_async(stream, stop_chars, stop_chars_len, io_priority, cancellable, callback, user_data);
		return stream;
	}

/// <summary>
/// <para>
/// Finish an asynchronous call started by
/// g_data_input_stream_read_upto_async().
/// </para>
/// <para>
/// Note that this function does not consume the stop character. You
/// have to use g_data_input_stream_read_byte() to get it before calling
/// g_data_input_stream_read_upto_async() again.
/// </para>
/// <para>
/// The returned string will always be nul-terminated on success.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GDataInputStream
/// </param>
/// <param name="result">
/// the #GAsyncResult that was provided to the callback
/// </param>
/// <param name="length">
/// a #gsize to get the length of the data read in
/// </param>
/// <return>
/// a string with the data that was read
///     before encountering any of the stop characters. Set @length to
///     a #gsize to get the length of the string. This function will
///     return %NULL on an error.
/// </return>

	public static string ReadUptoFinish(this MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length)
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		var externCallResult = GDataInputStreamHandleExterns.g_data_input_stream_read_upto_finish(stream, result, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function sets the byte order for the given @stream. All subsequent
/// reads from the @stream will be read in the given @order.
/// </para>
/// </summary>

/// <param name="stream">
/// a given #GDataInputStream.
/// </param>
/// <param name="order">
/// a #GDataStreamByteOrder to set.
/// </param>

	public static T SetByteOrder<T>(this T stream, MentorLake.Gio.GDataStreamByteOrder order) where T : GDataInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		GDataInputStreamHandleExterns.g_data_input_stream_set_byte_order(stream, order);
		return stream;
	}

/// <summary>
/// <para>
/// Sets the newline type for the @stream.
/// </para>
/// <para>
/// Note that using G_DATA_STREAM_NEWLINE_TYPE_ANY is slightly unsafe. If a read
/// chunk ends in &quot;CR&quot; we must read an additional byte to know if this is &quot;CR&quot; or
/// &quot;CR LF&quot;, and this might block if there is no more data available.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GDataInputStream.
/// </param>
/// <param name="type">
/// the type of new line return as #GDataStreamNewlineType.
/// </param>

	public static T SetNewlineType<T>(this T stream, MentorLake.Gio.GDataStreamNewlineType type) where T : GDataInputStreamHandle
	{
		if (stream.IsInvalid) throw new Exception("Invalid handle (GDataInputStreamHandle)");
		GDataInputStreamHandleExterns.g_data_input_stream_set_newline_type(stream, type);
		return stream;
	}

}

internal class GDataInputStreamHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))]
	internal static extern MentorLake.Gio.GDataInputStreamHandle g_data_input_stream_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle base_stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataStreamByteOrder g_data_input_stream_get_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDataStreamNewlineType g_data_input_stream_get_newline_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream);

	[DllImport(GioLibrary.Name)]
	internal static extern byte g_data_input_stream_read_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern short g_data_input_stream_read_int16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_data_input_stream_read_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_data_input_stream_read_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_data_input_stream_read_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_line_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern byte[] g_data_input_stream_read_line_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_line_finish_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_line_utf8([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_data_input_stream_read_uint16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_data_input_stream_read_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_data_input_stream_read_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_until([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_until_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_until_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_upto([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, out UIntPtr length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_read_upto_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, string stop_chars, UIntPtr stop_chars_len, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_data_input_stream_read_upto_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_set_byte_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GDataStreamByteOrder order);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_data_input_stream_set_newline_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDataInputStreamHandle>))] MentorLake.Gio.GDataInputStreamHandle stream, MentorLake.Gio.GDataStreamNewlineType type);

}
