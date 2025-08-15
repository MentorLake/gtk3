namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags to pass to [ctor@GLib.MainContext.new_with_flags] which affect the
/// behaviour of a [struct@GLib.MainContext].
/// </para>
/// </summary>

[Flags]
public enum GMainContextFlags : uint
{
/// <summary>
/// <para>
/// Default behaviour.
/// </para>
/// </summary>

	G_MAIN_CONTEXT_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Assume that polling for events will
/// free the thread to process other jobs. That&apos;s useful if you&apos;re using
/// `g_main_context_{prepare,query,check,dispatch}` to integrate GMainContext in
/// other event loops.
/// </para>
/// </summary>

	G_MAIN_CONTEXT_FLAGS_OWNERLESS_POLLING = 1
}
