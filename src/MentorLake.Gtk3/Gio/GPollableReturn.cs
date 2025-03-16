namespace MentorLake.Gio;

[Flags]
public enum GPollableReturn
{
	G_POLLABLE_RETURN_FAILED = 0,
	G_POLLABLE_RETURN_OK = 1,
	G_POLLABLE_RETURN_WOULD_BLOCK = -27
}
