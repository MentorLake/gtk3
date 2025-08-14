namespace MentorLake.GLib;

/// <summary>
/// <para>
/// #GIOError is only used by the deprecated functions
/// g_io_channel_read(), g_io_channel_write(), and g_io_channel_seek().
/// </para>
/// </summary>

[Flags]
public enum GIOError
{
/// <summary>
/// <para>
/// no error
/// </para>
/// </summary>

	G_IO_ERROR_NONE = 0,
/// <summary>
/// <para>
/// an EAGAIN error occurred
/// </para>
/// </summary>

	G_IO_ERROR_AGAIN = 1,
/// <summary>
/// <para>
/// an EINVAL error occurred
/// </para>
/// </summary>

	G_IO_ERROR_INVAL = 2,
/// <summary>
/// <para>
/// another error occurred
/// </para>
/// </summary>

	G_IO_ERROR_UNKNOWN = 3
}
