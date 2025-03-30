namespace MentorLake.GLib;

[Flags]
public enum GHookFlagMask : uint
{
	G_HOOK_FLAG_ACTIVE = 1,
	G_HOOK_FLAG_IN_CALL = 2,
	G_HOOK_FLAG_MASK = 15
}
