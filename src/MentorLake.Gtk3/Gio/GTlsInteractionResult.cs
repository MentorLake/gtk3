namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GTlsInteractionResult is returned by various functions in #GTlsInteraction
/// when finishing an interaction request.
/// </para>
/// </summary>

[Flags]
public enum GTlsInteractionResult
{
/// <summary>
/// <para>
/// The interaction was unhandled (i.e. not
///     implemented).
/// </para>
/// </summary>

	G_TLS_INTERACTION_UNHANDLED = 0,
/// <summary>
/// <para>
/// The interaction completed, and resulting data
///     is available.
/// </para>
/// </summary>

	G_TLS_INTERACTION_HANDLED = 1,
/// <summary>
/// <para>
/// The interaction has failed, or was cancelled.
///     and the operation should be aborted.
/// </para>
/// </summary>

	G_TLS_INTERACTION_FAILED = 2
}
