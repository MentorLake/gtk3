namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration that affects font sizes for superscript
/// and subscript positioning and for (emulated) Small Caps.
/// </para>
/// </summary>

[Flags]
public enum PangoFontScale
{
/// <summary>
/// <para>
/// Leave the font size unchanged
/// </para>
/// </summary>

	PANGO_FONT_SCALE_NONE = 0,
/// <summary>
/// <para>
/// Change the font to a size suitable for superscripts
/// </para>
/// </summary>

	PANGO_FONT_SCALE_SUPERSCRIPT = 1,
/// <summary>
/// <para>
/// Change the font to a size suitable for subscripts
/// </para>
/// </summary>

	PANGO_FONT_SCALE_SUBSCRIPT = 2,
/// <summary>
/// <para>
/// Change the font to a size suitable for Small Caps
/// </para>
/// </summary>

	PANGO_FONT_SCALE_SMALL_CAPS = 3
}
