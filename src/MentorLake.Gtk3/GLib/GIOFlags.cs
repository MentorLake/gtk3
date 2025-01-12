namespace MentorLake.Gtk3.GLib;

[Flags]
public enum GIOFlags
{
	G_IO_FLAG_NONE = 0,
	G_IO_FLAG_APPEND = 1,
	G_IO_FLAG_NONBLOCK = 2,
	G_IO_FLAG_IS_READABLE = 4,
	G_IO_FLAG_IS_WRITABLE = 8,
	G_IO_FLAG_IS_WRITEABLE = 16,
	G_IO_FLAG_IS_SEEKABLE = 32,
	G_IO_FLAG_MASK = 64,
	G_IO_FLAG_GET_MASK = 128,
	G_IO_FLAG_SET_MASK = 256
}
