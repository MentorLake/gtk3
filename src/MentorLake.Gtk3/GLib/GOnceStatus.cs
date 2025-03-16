namespace MentorLake.GLib;

[Flags]
public enum GOnceStatus
{
	G_ONCE_STATUS_NOTCALLED = 0,
	G_ONCE_STATUS_PROGRESS = 1,
	G_ONCE_STATUS_READY = 2
}
