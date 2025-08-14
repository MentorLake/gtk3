namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies variants of a font face based on their slant.
/// </para>
/// </summary>

[Flags]
public enum cairo_font_slant_t
{
/// <summary>
/// <para>
/// Upright font style, since 1.0
/// </para>
/// </summary>

	CAIRO_FONT_SLANT_NORMAL = 0,
/// <summary>
/// <para>
/// Italic font style, since 1.0
/// </para>
/// </summary>

	CAIRO_FONT_SLANT_ITALIC = 1,
/// <summary>
/// <para>
/// Oblique font style, since 1.0
/// </para>
/// </summary>

	CAIRO_FONT_SLANT_OBLIQUE = 2
}
