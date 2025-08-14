namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The match types specify what g_signal_handlers_block_matched(),
/// g_signal_handlers_unblock_matched() and g_signal_handlers_disconnect_matched()
/// match signals by.
/// </para>
/// </summary>

[Flags]
public enum GSignalMatchType : uint
{
/// <summary>
/// <para>
/// The signal id must be equal.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_ID = 1,
/// <summary>
/// <para>
/// The signal detail must be equal.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_DETAIL = 2,
/// <summary>
/// <para>
/// The closure must be the same.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_CLOSURE = 4,
/// <summary>
/// <para>
/// The C closure callback must be the same.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_FUNC = 8,
/// <summary>
/// <para>
/// The closure data must be the same.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_DATA = 16,
/// <summary>
/// <para>
/// Only unblocked signals may be matched.
/// </para>
/// </summary>

	G_SIGNAL_MATCH_UNBLOCKED = 32
}
