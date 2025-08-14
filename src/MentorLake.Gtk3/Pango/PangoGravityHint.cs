namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoGravityHint` defines how horizontal scripts should behave in a
/// vertical context.
/// </para>
/// <para>
/// That is, English excerpts in a vertical paragraph for example.
/// </para>
/// <para>
/// See also [enum@Pango.Gravity]
/// </para>
/// </summary>

[Flags]
public enum PangoGravityHint
{
/// <summary>
/// <para>
/// scripts will take their natural gravity based
///   on the base gravity and the script.  This is the default.
/// </para>
/// </summary>

	PANGO_GRAVITY_HINT_NATURAL = 0,
/// <summary>
/// <para>
/// always use the base gravity set, regardless of
///   the script.
/// </para>
/// </summary>

	PANGO_GRAVITY_HINT_STRONG = 1,
/// <summary>
/// <para>
/// for scripts not in their natural direction (eg.
///   Latin in East gravity), choose per-script gravity such that every script
///   respects the line progression. This means, Latin and Arabic will take
///   opposite gravities and both flow top-to-bottom for example.
/// </para>
/// </summary>

	PANGO_GRAVITY_HINT_LINE = 2
}
