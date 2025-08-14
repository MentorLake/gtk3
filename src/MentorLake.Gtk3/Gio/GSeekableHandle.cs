namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSeekable` is implemented by streams (implementations of
/// [class@Gio.InputStream] or [class@Gio.OutputStream]) that support seeking.
/// </para>
/// <para>
/// Seekable streams largely fall into two categories: resizable and
/// fixed-size.
/// </para>
/// <para>
/// `GSeekable` on fixed-sized streams is approximately the same as POSIX
/// <see href="man:lseek(2">lseek()</see>) on a block device (for example: attempting to seek
/// past the end of the device is an error).  Fixed streams typically cannot be
/// truncated.
/// </para>
/// <para>
/// `GSeekable` on resizable streams is approximately the same as POSIX
/// <see href="man:lseek(2">lseek()</see>) on a normal file.  Seeking past the end and writing
/// data will usually cause the stream to resize by introducing zero bytes.
/// </para>
/// </summary>

public interface GSeekableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GSeekableHandleImpl : BaseSafeHandle, GSeekableHandle
{
}

public static class GSeekableHandleExtensions
{
/// <summary>
/// <para>
/// Tests if the stream supports the #GSeekableIface.
/// </para>
/// </summary>

/// <param name="seekable">
/// a #GSeekable.
/// </param>
/// <return>
/// %TRUE if @seekable can be seeked. %FALSE otherwise.
/// </return>

	public static bool CanSeek(this MentorLake.Gio.GSeekableHandle seekable)
	{
		if (seekable.IsInvalid) throw new Exception("Invalid handle (GSeekableHandle)");
		return GSeekableHandleExterns.g_seekable_can_seek(seekable);
	}

/// <summary>
/// <para>
/// Tests if the length of the stream can be adjusted with
/// g_seekable_truncate().
/// </para>
/// </summary>

/// <param name="seekable">
/// a #GSeekable.
/// </param>
/// <return>
/// %TRUE if the stream can be truncated, %FALSE otherwise.
/// </return>

	public static bool CanTruncate(this MentorLake.Gio.GSeekableHandle seekable)
	{
		if (seekable.IsInvalid) throw new Exception("Invalid handle (GSeekableHandle)");
		return GSeekableHandleExterns.g_seekable_can_truncate(seekable);
	}

/// <summary>
/// <para>
/// Seeks in the stream by the given @offset, modified by @type.
/// </para>
/// <para>
/// Attempting to seek past the end of the stream will have different
/// results depending on if the stream is fixed-sized or resizable.  If
/// the stream is resizable then seeking past the end and then writing
/// will result in zeros filling the empty space.  Seeking past the end
/// of a resizable stream and reading will result in EOF.  Seeking past
/// the end of a fixed-sized stream will fail.
/// </para>
/// <para>
/// Any operation that would result in a negative offset will fail.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="seekable">
/// a #GSeekable.
/// </param>
/// <param name="offset">
/// a #goffset.
/// </param>
/// <param name="type">
/// a #GSeekType.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE if successful. If an error
///     has occurred, this function will return %FALSE and set @error
///     appropriately if present.
/// </return>

	public static bool Seek(this MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.GLib.GSeekType type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (seekable.IsInvalid) throw new Exception("Invalid handle (GSeekableHandle)");
		var externCallResult = GSeekableHandleExterns.g_seekable_seek(seekable, offset, type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Tells the current position within the stream.
/// </para>
/// </summary>

/// <param name="seekable">
/// a #GSeekable.
/// </param>
/// <return>
/// the (positive or zero) offset from the beginning of the
/// buffer, zero if the target is not seekable.
/// </return>

	public static int Tell(this MentorLake.Gio.GSeekableHandle seekable)
	{
		if (seekable.IsInvalid) throw new Exception("Invalid handle (GSeekableHandle)");
		return GSeekableHandleExterns.g_seekable_tell(seekable);
	}

/// <summary>
/// <para>
/// Sets the length of the stream to @offset. If the stream was previously
/// larger than @offset, the extra data is discarded. If the stream was
/// previously shorter than @offset, it is extended with NUL ('\0') bytes.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned. If an
/// operation was partially finished when the operation was cancelled the
/// partial result will be returned, without an error.
/// </para>
/// </summary>

/// <param name="seekable">
/// a #GSeekable.
/// </param>
/// <param name="offset">
/// new length for @seekable, in bytes.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE if successful. If an error
///     has occurred, this function will return %FALSE and set @error
///     appropriately if present.
/// </return>

	public static bool Truncate(this MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (seekable.IsInvalid) throw new Exception("Invalid handle (GSeekableHandle)");
		var externCallResult = GSeekableHandleExterns.g_seekable_truncate(seekable, offset, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GSeekableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_can_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_can_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_seek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable, int offset, MentorLake.GLib.GSeekType type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_seekable_tell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_seekable_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSeekableHandleImpl>))] MentorLake.Gio.GSeekableHandle seekable, int offset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
