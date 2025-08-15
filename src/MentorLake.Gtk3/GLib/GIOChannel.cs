namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GIOChannel` data type aims to provide a portable method for
/// using file descriptors, pipes, and sockets, and integrating them
/// into the main event loop (see [struct@GLib.MainContext]). Currently,
/// full support is available on UNIX platforms; support for Windows
/// is only partially complete.
/// </para>
/// <para>
/// To create a new `GIOChannel` on UNIX systems use
/// [ctor@GLib.IOChannel.unix_new]. This works for plain file descriptors,
/// pipes and sockets. Alternatively, a channel can be created for a
/// file in a system independent manner using [ctor@GLib.IOChannel.new_file].
/// </para>
/// <para>
/// Once a `GIOChannel` has been created, it can be used in a generic
/// manner with the functions [method@GLib.IOChannel.read_chars],
/// [method@GLib.IOChannel.write_chars], [method@GLib.IOChannel.seek_position],
/// and [method@GLib.IOChannel.shutdown].
/// </para>
/// <para>
/// To add a `GIOChannel` to the main event loop, use [func@GLib.io_add_watch] or
/// [func@GLib.io_add_watch_full]. Here you specify which events you are
/// interested in on the `GIOChannel`, and provide a function to be called
/// whenever these events occur.
/// </para>
/// <para>
/// `GIOChannel` instances are created with an initial reference count of 1.
/// [method@GLib.IOChannel.ref] and [method@GLib.IOChannel.unref] can be used to
/// increment or decrement the reference count respectively. When the
/// reference count falls to 0, the `GIOChannel` is freed. (Though it
/// isn’t closed automatically, unless it was created using
/// [ctor@GLib.IOChannel.new_file].) Using [func@GLib.io_add_watch] or
/// [func@GLib.io_add_watch_full] increments a channel’s reference count.
/// </para>
/// <para>
/// The new functions [method@GLib.IOChannel.read_chars],
/// [method@GLib.IOChannel.read_line], [method@GLib.IOChannel.read_line_string],
/// [method@GLib.IOChannel.read_to_end], [method@GLib.IOChannel.write_chars],
/// [method@GLib.IOChannel.seek_position], and [method@GLib.IOChannel.flush]
/// should not be mixed with the deprecated functions
/// [method@GLib.IOChannel.read], [method@GLib.IOChannel.write], and
/// [method@GLib.IOChannel.seek] on the same channel.
/// </para>
/// </summary>

public class GIOChannelHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Open a file @filename as a #GIOChannel using mode @mode. This
/// channel will be closed when the last reference to it is dropped,
/// so there is no need to call g_io_channel_close() (though doing
/// so will not cause problems, as long as no attempt is made to
/// access the channel after it is closed).
/// </para>
/// </summary>

/// <param name="filename">
/// A string containing the name of a file
/// </param>
/// <param name="mode">
/// One of &quot;r&quot;, &quot;w&quot;, &quot;a&quot;, &quot;r+&quot;, &quot;w+&quot;, &quot;a+&quot;. These have
///        the same meaning as in fopen()
/// </param>
/// <return>
/// A #GIOChannel on success, %NULL on failure.
/// </return>

	public static MentorLake.GLib.GIOChannelHandle NewFile(string filename, string mode)
	{
		var externCallResult = GIOChannelExterns.g_io_channel_new_file(filename, mode, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GIOChannel given a file descriptor. On UNIX systems
/// this works for plain files, pipes, and sockets.
/// </para>
/// <para>
/// The returned #GIOChannel has a reference count of 1.
/// </para>
/// <para>
/// The default encoding for #GIOChannel is UTF-8. If your application
/// is reading output from a command using via pipe, you may need to set
/// the encoding to the encoding of the current locale (see
/// g_get_charset()) with the g_io_channel_set_encoding() function.
/// By default, the fd passed will not be closed when the final reference
/// to the #GIOChannel data structure is dropped.
/// </para>
/// <para>
/// If you want to read raw binary data without interpretation, then
/// call the g_io_channel_set_encoding() function with %NULL for the
/// encoding argument.
/// </para>
/// <para>
/// This function is available in GLib on Windows, too, but you should
/// avoid using it on Windows. The domain of file descriptors and
/// sockets overlap. There is no way for GLib to know which one you mean
/// in case the argument you pass to this function happens to be both a
/// valid file descriptor and socket. If that happens a warning is
/// issued, and GLib assumes that it is the file descriptor you mean.
/// </para>
/// </summary>

/// <param name="fd">
/// a file descriptor.
/// </param>
/// <return>
/// a new #GIOChannel.
/// </return>

	public static MentorLake.GLib.GIOChannelHandle UnixNew(int fd)
	{
		return GIOChannelExterns.g_io_channel_unix_new(fd);
	}

}


public static class GIOChannelExtensions
{
/// <summary>
/// <para>
/// Close an IO channel. Any pending data to be written will be
/// flushed, ignoring errors. The channel will not be freed until the
/// last reference is dropped using g_io_channel_unref().
/// </para>
/// </summary>

/// <param name="channel">
/// A #GIOChannel
/// </param>

	public static void Close(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_close(channel);
	}

/// <summary>
/// <para>
/// Flushes the write buffer for the GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// the status of the operation: One of
///   %G_IO_STATUS_NORMAL, %G_IO_STATUS_AGAIN, or
///   %G_IO_STATUS_ERROR.
/// </return>

	public static MentorLake.GLib.GIOStatus Flush(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_flush(channel, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function returns a #GIOCondition depending on whether there
/// is data to be read/space to write data in the internal buffers in
/// the #GIOChannel. Only the flags %G_IO_IN and %G_IO_OUT may be set.
/// </para>
/// </summary>

/// <param name="channel">
/// A #GIOChannel
/// </param>
/// <return>
/// A #GIOCondition
/// </return>

	public static MentorLake.GLib.GIOCondition GetBufferCondition(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffer_condition(channel);
	}

/// <summary>
/// <para>
/// Gets the buffer size.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// the size of the buffer.
/// </return>

	public static UIntPtr GetBufferSize(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffer_size(channel);
	}

/// <summary>
/// <para>
/// Returns whether @channel is buffered.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// %TRUE if the @channel is buffered.
/// </return>

	public static bool GetBuffered(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_buffered(channel);
	}

/// <summary>
/// <para>
/// Returns whether the file/socket/whatever associated with @channel
/// will be closed when @channel receives its final unref and is
/// destroyed. The default value of this is %TRUE for channels created
/// by g_io_channel_new_file (), and %FALSE for all other channels.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel.
/// </param>
/// <return>
/// %TRUE if the channel will be closed, %FALSE otherwise.
/// </return>

	public static bool GetCloseOnUnref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_close_on_unref(channel);
	}

/// <summary>
/// <para>
/// Gets the encoding for the input/output of the channel.
/// The internal encoding is always UTF-8. The encoding %NULL
/// makes the channel safe for binary data.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// A string containing the encoding, this string is
///   owned by GLib and must not be freed.
/// </return>

	public static string GetEncoding(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_encoding(channel);
	}

/// <summary>
/// <para>
/// Gets the current flags for a #GIOChannel, including read-only
/// flags such as %G_IO_FLAG_IS_READABLE.
/// </para>
/// <para>
/// The values of the flags %G_IO_FLAG_IS_READABLE and %G_IO_FLAG_IS_WRITABLE
/// are cached for internal use by the channel when it is created.
/// If they should change at some later point (e.g. partial shutdown
/// of a socket with the UNIX shutdown() function), the user
/// should immediately call g_io_channel_get_flags() to update
/// the internal values of these flags.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// the flags which are set on the channel
/// </return>

	public static MentorLake.GLib.GIOFlags GetFlags(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_flags(channel);
	}

/// <summary>
/// <para>
/// This returns the string that #GIOChannel uses to determine
/// where in the file a line break occurs. A value of %NULL
/// indicates autodetection. Since 2.84, the return value is always
/// nul-terminated.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="length">
/// a location to return the length of the line terminator
/// </param>
/// <return>
/// The line termination string. This value
///   is owned by GLib and must not be freed.
/// </return>

	public static string GetLineTerm(this MentorLake.GLib.GIOChannelHandle channel, out int length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_get_line_term(channel, out length);
	}

/// <summary>
/// <para>
/// Initializes a #GIOChannel struct.
/// </para>
/// <para>
/// This is called by each of the above functions when creating a
/// #GIOChannel, and so is not often needed by the application
/// programmer (unless you are creating a new type of #GIOChannel).
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>

	public static void Init(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_init(channel);
	}

/// <summary>
/// <para>
/// Reads data from a #GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buf">
/// a buffer to read the data into (which should be at least
///       count bytes long)
/// </param>
/// <param name="count">
/// the number of bytes to read from the #GIOChannel
/// </param>
/// <param name="bytes_read">
/// returns the number of bytes actually read
/// </param>
/// <return>
/// %G_IO_ERROR_NONE if the operation was successful.
/// </return>

	public static MentorLake.GLib.GIOError Read(this MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_read)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_read(channel, buf, count, bytes_read);
	}

/// <summary>
/// <para>
/// Replacement for g_io_channel_read() with the new API.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buf">
/// 
///     a buffer to read data into
/// </param>
/// <param name="count">
/// the size of the buffer. Note that the buffer may not be
///     completely filled even if there is data in the buffer if the
///     remaining data is not a complete character.
/// </param>
/// <param name="bytes_read">
/// The number of bytes read. This may be
///     zero even on success if count &amp;lt; 6 and the channel&apos;s encoding
///     is non-%NULL. This indicates that the next UTF-8 character is
///     too wide for the buffer.
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus ReadChars(this MentorLake.GLib.GIOChannelHandle channel, out byte[] buf, UIntPtr count, out UIntPtr bytes_read)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_chars(channel, out buf, count, out bytes_read, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a line, including the terminating character(s),
/// from a #GIOChannel into a newly-allocated string.
/// @str_return will contain allocated memory if the return
/// is %G_IO_STATUS_NORMAL.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="str_return">
/// The line read from the #GIOChannel, including the
///              line terminator. This data should be freed with g_free()
///              when no longer needed. This is a nul-terminated string.
///              If a @length of zero is returned, this will be %NULL instead.
/// </param>
/// <param name="length">
/// location to store length of the read data, or %NULL
/// </param>
/// <param name="terminator_pos">
/// location to store position of line terminator, or %NULL
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus ReadLine(this MentorLake.GLib.GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_line(channel, out str_return, out length, out terminator_pos, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a line from a #GIOChannel, using a #GString as a buffer.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buffer">
/// a #GString into which the line will be written.
///          If @buffer already contains data, the old data will
///          be overwritten.
/// </param>
/// <param name="terminator_pos">
/// location to store position of line terminator, or %NULL
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus ReadLineString(this MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GStringHandle buffer, UIntPtr terminator_pos)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_line_string(channel, buffer, terminator_pos, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads all the remaining data from the file.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="str_return">
/// Location to
///              store a pointer to a string holding the remaining data in the
///              #GIOChannel. This data should be freed with g_free() when no
///              longer needed. This data is terminated by an extra nul
///              character, but there may be other nuls in the intervening data.
/// </param>
/// <param name="length">
/// location to store length of the data
/// </param>
/// <return>
/// %G_IO_STATUS_NORMAL on success.
///     This function never returns %G_IO_STATUS_EOF.
/// </return>

	public static MentorLake.GLib.GIOStatus ReadToEnd(this MentorLake.GLib.GIOChannelHandle channel, out byte[] str_return, out UIntPtr length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_to_end(channel, out str_return, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads a Unicode character from @channel.
/// This function cannot be called on a channel with %NULL encoding.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="thechar">
/// a location to return a character
/// </param>
/// <return>
/// a #GIOStatus
/// </return>

	public static MentorLake.GLib.GIOStatus ReadUnichar(this MentorLake.GLib.GIOChannelHandle channel, out char thechar)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_read_unichar(channel, out thechar, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increments the reference count of a #GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <return>
/// the @channel that was passed in (since 2.6)
/// </return>

	public static MentorLake.GLib.GIOChannelHandle Ref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_ref(channel);
	}

/// <summary>
/// <para>
/// Sets the current position in the #GIOChannel, similar to the standard
/// library function fseek().
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="offset">
/// an offset, in bytes, which is added to the position specified
///          by @type
/// </param>
/// <param name="type">
/// the position in the file, which can be %G_SEEK_CUR (the current
///        position), %G_SEEK_SET (the start of the file), or %G_SEEK_END
///        (the end of the file)
/// </param>
/// <return>
/// %G_IO_ERROR_NONE if the operation was successful.
/// </return>

	public static MentorLake.GLib.GIOError Seek(this MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_seek(channel, offset, type);
	}

/// <summary>
/// <para>
/// Replacement for g_io_channel_seek() with the new API.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="offset">
/// The offset in bytes from the position specified by @type
/// </param>
/// <param name="type">
/// a #GSeekType. The type %G_SEEK_CUR is only allowed in those
///                      cases where a call to g_io_channel_set_encoding ()
///                      is allowed. See the documentation for
///                      g_io_channel_set_encoding () for details.
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus SeekPosition(this MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_seek_position(channel, offset, type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the buffer size.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="size">
/// the size of the buffer, or 0 to let GLib pick a good size
/// </param>

	public static void SetBufferSize(this MentorLake.GLib.GIOChannelHandle channel, UIntPtr size)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_buffer_size(channel, size);
	}

/// <summary>
/// <para>
/// The buffering state can only be set if the channel&apos;s encoding
/// is %NULL. For any other encoding, the channel must be buffered.
/// </para>
/// <para>
/// A buffered channel can only be set unbuffered if the channel&apos;s
/// internal buffers have been flushed. Newly created channels or
/// channels which have returned %G_IO_STATUS_EOF
/// not require such a flush. For write-only channels, a call to
/// g_io_channel_flush () is sufficient. For all other channels,
/// the buffers may be flushed by a call to g_io_channel_seek_position ().
/// This includes the possibility of seeking with seek type %G_SEEK_CUR
/// and an offset of zero. Note that this means that socket-based
/// channels cannot be set unbuffered once they have had data
/// read from them.
/// </para>
/// <para>
/// On unbuffered channels, it is safe to mix read and write
/// calls from the new and old APIs, if this is necessary for
/// maintaining old code.
/// </para>
/// <para>
/// The default state of the channel is buffered.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buffered">
/// whether to set the channel buffered or unbuffered
/// </param>

	public static void SetBuffered(this MentorLake.GLib.GIOChannelHandle channel, bool buffered)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_buffered(channel, buffered);
	}

/// <summary>
/// <para>
/// Whether to close the channel on the final unref of the #GIOChannel
/// data structure. The default value of this is %TRUE for channels
/// created by g_io_channel_new_file (), and %FALSE for all other channels.
/// </para>
/// <para>
/// Setting this flag to %TRUE for a channel you have already closed
/// can cause problems when the final reference to the #GIOChannel is dropped.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="do_close">
/// Whether to close the channel on the final unref of
///            the GIOChannel data structure.
/// </param>

	public static void SetCloseOnUnref(this MentorLake.GLib.GIOChannelHandle channel, bool do_close)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_close_on_unref(channel, do_close);
	}

/// <summary>
/// <para>
/// Sets the encoding for the input/output of the channel.
/// The internal encoding is always UTF-8. The default encoding
/// for the external file is UTF-8.
/// </para>
/// <para>
/// The encoding %NULL is safe to use with binary data.
/// </para>
/// <para>
/// The encoding can only be set if one of the following conditions
/// is true:
/// </para>
/// <para>
/// - The channel was just created, and has not been written to or read from yet.
/// </para>
/// <para>
/// - The channel is write-only.
/// </para>
/// <para>
/// - The channel is a file, and the file pointer was just repositioned
///   by a call to g_io_channel_seek_position(). (This flushes all the
///   internal buffers.)
/// </para>
/// <para>
/// - The current encoding is %NULL or UTF-8.
/// </para>
/// <para>
/// - One of the (new API) read functions has just returned %G_IO_STATUS_EOF
///   (or, in the case of g_io_channel_read_to_end(), %G_IO_STATUS_NORMAL).
/// </para>
/// <para>
/// -  One of the functions g_io_channel_read_chars() or
///    g_io_channel_read_unichar() has returned %G_IO_STATUS_AGAIN or
///    %G_IO_STATUS_ERROR. This may be useful in the case of
///    %G_CONVERT_ERROR_ILLEGAL_SEQUENCE.
///    Returning one of these statuses from g_io_channel_read_line(),
///    g_io_channel_read_line_string(), or g_io_channel_read_to_end()
///    does not guarantee that the encoding can be changed.
/// </para>
/// <para>
/// Channels which do not meet one of the above conditions cannot call
/// g_io_channel_seek_position() with an offset of %G_SEEK_CUR, and, if
/// they are &quot;seekable&quot;, cannot call g_io_channel_write_chars() after
/// calling one of the API &quot;read&quot; functions.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="encoding">
/// the encoding type
/// </param>
/// <return>
/// %G_IO_STATUS_NORMAL if the encoding was successfully set
/// </return>

	public static MentorLake.GLib.GIOStatus SetEncoding(this MentorLake.GLib.GIOChannelHandle channel, string encoding)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_set_encoding(channel, encoding, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the (writeable) flags in @channel to (@flags &amp; %G_IO_FLAG_SET_MASK).
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="flags">
/// the flags to set on the IO channel
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus SetFlags(this MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOFlags flags)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_set_flags(channel, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This sets the string that #GIOChannel uses to determine
/// where in the file a line break occurs.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="line_term">
/// The line termination string. Use %NULL for
///             autodetect.  Autodetection breaks on &quot;\n&quot;, &quot;\r\n&quot;, &quot;\r&quot;, &quot;\0&quot;,
///             and the Unicode paragraph separator. Autodetection should not be
///             used for anything other than file-based channels.
/// </param>
/// <param name="length">
/// The length of the termination string. If -1 is passed, the
///          string is assumed to be nul-terminated. This option allows
///          termination strings with embedded nuls.
/// </param>

	public static void SetLineTerm(this MentorLake.GLib.GIOChannelHandle channel, string line_term, int length)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_set_line_term(channel, line_term, length);
	}

/// <summary>
/// <para>
/// Close an IO channel. Any pending data to be written will be
/// flushed if @flush is %TRUE. The channel will not be freed until the
/// last reference is dropped using g_io_channel_unref().
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="flush">
/// if %TRUE, flush pending
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus Shutdown(this MentorLake.GLib.GIOChannelHandle channel, bool flush)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_shutdown(channel, flush, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the file descriptor of the #GIOChannel.
/// </para>
/// <para>
/// On Windows this function returns the file descriptor or socket of
/// the #GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel, created with g_io_channel_unix_new().
/// </param>
/// <return>
/// the file descriptor of the #GIOChannel.
/// </return>

	public static int UnixGetFd(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_unix_get_fd(channel);
	}

/// <summary>
/// <para>
/// Decrements the reference count of a #GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>

	public static void Unref(this MentorLake.GLib.GIOChannelHandle channel)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		GIOChannelExterns.g_io_channel_unref(channel);
	}

/// <summary>
/// <para>
/// Writes data to a #GIOChannel.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buf">
/// the buffer containing the data to write
/// </param>
/// <param name="count">
/// the number of bytes to write
/// </param>
/// <param name="bytes_written">
/// the number of bytes actually written
/// </param>
/// <return>
/// %G_IO_ERROR_NONE if the operation was successful.
/// </return>

	public static MentorLake.GLib.GIOError Write(this MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_written)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		return GIOChannelExterns.g_io_channel_write(channel, buf, count, bytes_written);
	}

/// <summary>
/// <para>
/// Replacement for g_io_channel_write() with the new API.
/// </para>
/// <para>
/// On seekable channels with encodings other than %NULL or UTF-8, generic
/// mixing of reading and writing is not allowed. A call to g_io_channel_write_chars ()
/// may only be made on a channel from which data has been read in the
/// cases described in the documentation for g_io_channel_set_encoding ().
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="buf">
/// a buffer to write data from
/// </param>
/// <param name="count">
/// the size of the buffer. If -1, the buffer
///         is taken to be a nul-terminated string.
/// </param>
/// <param name="bytes_written">
/// The number of bytes written. This can be nonzero
///                 even if the return value is not %G_IO_STATUS_NORMAL.
///                 If the return value is %G_IO_STATUS_NORMAL and the
///                 channel is blocking, this will always be equal
///                 to @count if @count &amp;gt;= 0.
/// </param>
/// <return>
/// the status of the operation.
/// </return>

	public static MentorLake.GLib.GIOStatus WriteChars(this MentorLake.GLib.GIOChannelHandle channel, byte[] buf, UIntPtr count, out UIntPtr bytes_written)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_write_chars(channel, buf, count, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Writes a Unicode character to @channel.
/// This function cannot be called on a channel with %NULL encoding.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="thechar">
/// a character
/// </param>
/// <return>
/// a #GIOStatus
/// </return>

	public static MentorLake.GLib.GIOStatus WriteUnichar(this MentorLake.GLib.GIOChannelHandle channel, char thechar)
	{
		if (channel.IsInvalid) throw new Exception("Invalid handle (GIOChannel)");
		var externCallResult = GIOChannelExterns.g_io_channel_write_unichar(channel, thechar, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


	public static GIOChannel Dereference(this GIOChannelHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOChannel>(x.DangerousGetHandle());
}
internal class GIOChannelExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_new_file(string filename, string mode, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_unix_new(int fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_io_channel_get_buffer_condition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_io_channel_get_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_io_channel_get_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_io_channel_get_close_on_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_io_channel_get_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOFlags g_io_channel_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_io_channel_get_line_term([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_read);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] buf, UIntPtr count, out UIntPtr bytes_read, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out string str_return, out UIntPtr length, out UIntPtr terminator_pos, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_line_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle buffer, UIntPtr terminator_pos, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_to_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] str_return, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_read_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, out char thechar, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))]
	internal static extern MentorLake.GLib.GIOChannelHandle g_io_channel_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_seek_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, long offset, MentorLake.GLib.GSeekType type, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_buffer_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool buffered);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_close_on_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool do_close);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_set_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string encoding, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_set_line_term([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string line_term, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, bool flush, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_io_channel_unix_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_io_channel_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOError g_io_channel_write([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, string buf, UIntPtr count, UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_write_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, byte[] buf, UIntPtr count, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOStatus g_io_channel_write_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, char thechar, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOChannelError g_io_channel_error_from_errno(int en);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_channel_error_quark();

}

/// <summary>
/// <para>
/// The `GIOChannel` data type aims to provide a portable method for
/// using file descriptors, pipes, and sockets, and integrating them
/// into the main event loop (see [struct@GLib.MainContext]). Currently,
/// full support is available on UNIX platforms; support for Windows
/// is only partially complete.
/// </para>
/// <para>
/// To create a new `GIOChannel` on UNIX systems use
/// [ctor@GLib.IOChannel.unix_new]. This works for plain file descriptors,
/// pipes and sockets. Alternatively, a channel can be created for a
/// file in a system independent manner using [ctor@GLib.IOChannel.new_file].
/// </para>
/// <para>
/// Once a `GIOChannel` has been created, it can be used in a generic
/// manner with the functions [method@GLib.IOChannel.read_chars],
/// [method@GLib.IOChannel.write_chars], [method@GLib.IOChannel.seek_position],
/// and [method@GLib.IOChannel.shutdown].
/// </para>
/// <para>
/// To add a `GIOChannel` to the main event loop, use [func@GLib.io_add_watch] or
/// [func@GLib.io_add_watch_full]. Here you specify which events you are
/// interested in on the `GIOChannel`, and provide a function to be called
/// whenever these events occur.
/// </para>
/// <para>
/// `GIOChannel` instances are created with an initial reference count of 1.
/// [method@GLib.IOChannel.ref] and [method@GLib.IOChannel.unref] can be used to
/// increment or decrement the reference count respectively. When the
/// reference count falls to 0, the `GIOChannel` is freed. (Though it
/// isn’t closed automatically, unless it was created using
/// [ctor@GLib.IOChannel.new_file].) Using [func@GLib.io_add_watch] or
/// [func@GLib.io_add_watch_full] increments a channel’s reference count.
/// </para>
/// <para>
/// The new functions [method@GLib.IOChannel.read_chars],
/// [method@GLib.IOChannel.read_line], [method@GLib.IOChannel.read_line_string],
/// [method@GLib.IOChannel.read_to_end], [method@GLib.IOChannel.write_chars],
/// [method@GLib.IOChannel.seek_position], and [method@GLib.IOChannel.flush]
/// should not be mixed with the deprecated functions
/// [method@GLib.IOChannel.read], [method@GLib.IOChannel.write], and
/// [method@GLib.IOChannel.seek] on the same channel.
/// </para>
/// </summary>

public struct GIOChannel
{
/// <summary>
/// <para>
/// Converts an `errno` error number to a #GIOChannelError.
/// </para>
/// </summary>

/// <param name="en">
/// an `errno` error number, e.g. `EINVAL`
/// </param>
/// <return>
/// a #GIOChannelError error number, e.g.
///      %G_IO_CHANNEL_ERROR_INVAL.
/// </return>

	public static MentorLake.GLib.GIOChannelError ErrorFromErrno(int en)
	{
		return GIOChannelExterns.g_io_channel_error_from_errno(en);
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GIOChannelExterns.g_io_channel_error_quark();
	}

}
