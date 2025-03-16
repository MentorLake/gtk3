namespace MentorLake.GLib;

[Flags]
public enum GIOChannelError
{
	G_IO_CHANNEL_ERROR_FBIG = 0,
	G_IO_CHANNEL_ERROR_INVAL = 1,
	G_IO_CHANNEL_ERROR_IO = 2,
	G_IO_CHANNEL_ERROR_ISDIR = 3,
	G_IO_CHANNEL_ERROR_NOSPC = 4,
	G_IO_CHANNEL_ERROR_NXIO = 5,
	G_IO_CHANNEL_ERROR_OVERFLOW = 6,
	G_IO_CHANNEL_ERROR_PIPE = 7,
	G_IO_CHANNEL_ERROR_FAILED = 8
}
