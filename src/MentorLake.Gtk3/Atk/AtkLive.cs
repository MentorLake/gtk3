namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Enumeration used to indicate a type of live region and how assertive it
/// should be in terms of speaking notifications. Currently, this is only used
/// for "notification" events, but it may be used for additional purposes
/// in the future.
/// </para>
/// </summary>

[Flags]
public enum AtkLive
{
/// <summary>
/// <para>
/// No live region.
/// </para>
/// </summary>

	ATK_LIVE_NONE = 0,
/// <summary>
/// <para>
/// This live region should be considered polite.
/// </para>
/// </summary>

	ATK_LIVE_POLITE = 1,
/// <summary>
/// <para>
/// This live region should be considered assertive.
/// </para>
/// </summary>

	ATK_LIVE_ASSERTIVE = 2
}
