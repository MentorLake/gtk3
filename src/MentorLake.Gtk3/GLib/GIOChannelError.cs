namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by #GIOChannel operations.
/// </para>
/// </summary>

[Flags]
public enum GIOChannelError
{
/// <summary>
/// <para>
/// File too large.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_FBIG = 0,
/// <summary>
/// <para>
/// Invalid argument.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_INVAL = 1,
/// <summary>
/// <para>
/// IO error.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_IO = 2,
/// <summary>
/// <para>
/// File is a directory.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_ISDIR = 3,
/// <summary>
/// <para>
/// No space left on device.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_NOSPC = 4,
/// <summary>
/// <para>
/// No such device or address.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_NXIO = 5,
/// <summary>
/// <para>
/// Value too large for defined datatype.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_OVERFLOW = 6,
/// <summary>
/// <para>
/// Broken pipe.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_PIPE = 7,
/// <summary>
/// <para>
/// Some other error.
/// </para>
/// </summary>

	G_IO_CHANNEL_ERROR_FAILED = 8
}
