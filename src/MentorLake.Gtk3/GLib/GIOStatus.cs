namespace MentorLake.GLib;

[Flags]
public enum GIOStatus
{
	G_IO_STATUS_ERROR = 0,
	G_IO_STATUS_NORMAL = 1,
	G_IO_STATUS_EOF = 2,
	G_IO_STATUS_AGAIN = 3
}
