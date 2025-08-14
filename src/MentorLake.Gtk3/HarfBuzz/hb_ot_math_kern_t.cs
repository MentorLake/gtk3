namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The math kerning-table types defined for the four corners
/// of a glyph.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_math_kern_t
{
/// <summary>
/// <para>
/// The top right corner of the glyph.
/// </para>
/// </summary>

	HB_OT_MATH_KERN_TOP_RIGHT = 0,
/// <summary>
/// <para>
/// The top left corner of the glyph.
/// </para>
/// </summary>

	HB_OT_MATH_KERN_TOP_LEFT = 1,
/// <summary>
/// <para>
/// The bottom right corner of the glyph.
/// </para>
/// </summary>

	HB_OT_MATH_KERN_BOTTOM_RIGHT = 2,
/// <summary>
/// <para>
/// The bottom left corner of the glyph.
/// </para>
/// </summary>

	HB_OT_MATH_KERN_BOTTOM_LEFT = 3
}
