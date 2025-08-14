namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoDirection` represents a direction in the Unicode bidirectional
/// algorithm.
/// </para>
/// <para>
/// Not every value in this enumeration makes sense for every usage of
/// `PangoDirection`; for example, the return value of [func@unichar_direction]
/// and [func@find_base_dir] cannot be `PANGO_DIRECTION_WEAK_LTR` or
/// `PANGO_DIRECTION_WEAK_RTL`, since every character is either neutral
/// or has a strong direction; on the other hand `PANGO_DIRECTION_NEUTRAL`
/// doesn't make sense to pass to [func@itemize_with_base_dir].
/// </para>
/// <para>
/// The `PANGO_DIRECTION_TTB_LTR`, `PANGO_DIRECTION_TTB_RTL` values come from
/// an earlier interpretation of this enumeration as the writing direction
/// of a block of text and are no longer used. See `PangoGravity` for how
/// vertical text is handled in Pango.
/// </para>
/// <para>
/// If you are interested in text direction, you should really use fribidi
/// directly. `PangoDirection` is only retained because it is used in some
/// public apis.
/// </para>
/// </summary>

[Flags]
public enum PangoDirection
{
/// <summary>
/// <para>
/// A strong left-to-right direction
/// </para>
/// </summary>

	PANGO_DIRECTION_LTR = 0,
/// <summary>
/// <para>
/// A strong right-to-left direction
/// </para>
/// </summary>

	PANGO_DIRECTION_RTL = 1,
/// <summary>
/// <para>
/// Deprecated value; treated the
///   same as `PANGO_DIRECTION_RTL`.
/// </para>
/// </summary>

	PANGO_DIRECTION_TTB_LTR = 2,
/// <summary>
/// <para>
/// Deprecated value; treated the
///   same as `PANGO_DIRECTION_LTR`
/// </para>
/// </summary>

	PANGO_DIRECTION_TTB_RTL = 3,
/// <summary>
/// <para>
/// A weak left-to-right direction
/// </para>
/// </summary>

	PANGO_DIRECTION_WEAK_LTR = 4,
/// <summary>
/// <para>
/// A weak right-to-left direction
/// </para>
/// </summary>

	PANGO_DIRECTION_WEAK_RTL = 5,
/// <summary>
/// <para>
/// No direction specified
/// </para>
/// </summary>

	PANGO_DIRECTION_NEUTRAL = 6
}
