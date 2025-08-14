namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies properties of a #GIOChannel. Some of the flags can only be
/// read with g_io_channel_get_flags(), but not changed with
/// g_io_channel_set_flags().
/// </para>
/// </summary>

[Flags]
public enum GIOFlags : uint
{
/// <summary>
/// <para>
/// no special flags set. Since: 2.74
/// </para>
/// </summary>

	G_IO_FLAG_NONE = 0,
/// <summary>
/// <para>
/// turns on append mode, corresponds to %O_APPEND
///     (see the documentation of the UNIX open() syscall)
/// </para>
/// </summary>

	G_IO_FLAG_APPEND = 1,
/// <summary>
/// <para>
/// turns on nonblocking mode, corresponds to
///     %O_NONBLOCK/%O_NDELAY (see the documentation of the UNIX open()
///     syscall)
/// </para>
/// </summary>

	G_IO_FLAG_NONBLOCK = 2,
/// <summary>
/// <para>
/// indicates that the io channel is readable.
///     This flag cannot be changed.
/// </para>
/// </summary>

	G_IO_FLAG_IS_READABLE = 4,
/// <summary>
/// <para>
/// indicates that the io channel is writable.
///     This flag cannot be changed.
/// </para>
/// </summary>

	G_IO_FLAG_IS_WRITABLE = 8,
/// <summary>
/// <para>
/// a misspelled version of @G_IO_FLAG_IS_WRITABLE
///     that existed before the spelling was fixed in GLib 2.30. It is kept
///     here for compatibility reasons. Deprecated since 2.30
/// </para>
/// </summary>

	G_IO_FLAG_IS_WRITEABLE = 8,
/// <summary>
/// <para>
/// indicates that the io channel is seekable,
///     i.e. that g_io_channel_seek_position() can be used on it.
///     This flag cannot be changed.
/// </para>
/// </summary>

	G_IO_FLAG_IS_SEEKABLE = 16,
/// <summary>
/// <para>
/// the mask that specifies all the valid flags.
/// </para>
/// </summary>

	G_IO_FLAG_MASK = 31,
/// <summary>
/// <para>
/// the mask of the flags that are returned from
///     g_io_channel_get_flags()
/// </para>
/// </summary>

	G_IO_FLAG_GET_MASK = 31,
/// <summary>
/// <para>
/// the mask of the flags that the user can modify
///     with g_io_channel_set_flags()
/// </para>
/// </summary>

	G_IO_FLAG_SET_MASK = 3
}
