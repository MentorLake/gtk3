namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The GDEF classes defined for glyphs.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_layout_glyph_class_t
{
/// <summary>
/// <para>
/// Glyphs not matching the other classifications
/// </para>
/// </summary>

	HB_OT_LAYOUT_GLYPH_CLASS_UNCLASSIFIED = 0,
/// <summary>
/// <para>
/// Spacing, single characters, capable of accepting marks
/// </para>
/// </summary>

	HB_OT_LAYOUT_GLYPH_CLASS_BASE_GLYPH = 1,
/// <summary>
/// <para>
/// Glyphs that represent ligation of multiple characters
/// </para>
/// </summary>

	HB_OT_LAYOUT_GLYPH_CLASS_LIGATURE = 2,
/// <summary>
/// <para>
/// Non-spacing, combining glyphs that represent marks
/// </para>
/// </summary>

	HB_OT_LAYOUT_GLYPH_CLASS_MARK = 3,
/// <summary>
/// <para>
/// Spacing glyphs that represent part of a single character
/// </para>
/// </summary>

	HB_OT_LAYOUT_GLYPH_CLASS_COMPONENT = 4
}
