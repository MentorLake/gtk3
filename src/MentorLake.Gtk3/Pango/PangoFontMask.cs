namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The bits in a `PangoFontMask` correspond to the set fields in a
/// `PangoFontDescription`.
/// </para>
/// </summary>

[Flags]
public enum PangoFontMask : uint
{
/// <summary>
/// <para>
/// the font family is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_FAMILY = 1,
/// <summary>
/// <para>
/// the font style is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_STYLE = 2,
/// <summary>
/// <para>
/// the font variant is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_VARIANT = 4,
/// <summary>
/// <para>
/// the font weight is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_WEIGHT = 8,
/// <summary>
/// <para>
/// the font stretch is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_STRETCH = 16,
/// <summary>
/// <para>
/// the font size is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_SIZE = 32,
/// <summary>
/// <para>
/// The font gravity is specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_GRAVITY = 64,
/// <summary>
/// <para>
/// OpenType font variations are specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_VARIATIONS = 128,
/// <summary>
/// <para>
/// OpenType font features are specified.
/// </para>
/// </summary>

	PANGO_FONT_MASK_FEATURES = 256
}
