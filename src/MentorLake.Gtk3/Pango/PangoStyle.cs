namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration specifying the various slant styles possible for a font.
/// </para>
/// </summary>

[Flags]
public enum PangoStyle
{
/// <summary>
/// <para>
/// the font is upright.
/// </para>
/// </summary>

	PANGO_STYLE_NORMAL = 0,
/// <summary>
/// <para>
/// the font is slanted, but in a roman style.
/// </para>
/// </summary>

	PANGO_STYLE_OBLIQUE = 1,
/// <summary>
/// <para>
/// the font is slanted in an italic style.
/// </para>
/// </summary>

	PANGO_STYLE_ITALIC = 2
}
