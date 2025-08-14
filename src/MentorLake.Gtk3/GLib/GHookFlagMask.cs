namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags used internally in the #GHook implementation.
/// </para>
/// </summary>

[Flags]
public enum GHookFlagMask : uint
{
/// <summary>
/// <para>
/// set if the hook has not been destroyed
/// </para>
/// </summary>

	G_HOOK_FLAG_ACTIVE = 1,
/// <summary>
/// <para>
/// set if the hook is currently being run
/// </para>
/// </summary>

	G_HOOK_FLAG_IN_CALL = 2,
/// <summary>
/// <para>
/// A mask covering all bits reserved for
///   hook flags; see %G_HOOK_FLAG_USER_SHIFT
/// </para>
/// </summary>

	G_HOOK_FLAG_MASK = 15
}
