namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Defined by [OpenType Design-Variation Axis Tag Registry](https://docs.microsoft.com/en-us/typography/opentype/spec/dvaraxisreg).
/// </para>
/// </summary>

[Flags]
public enum hb_style_tag_t
{
/// <summary>
/// <para>
/// Used to vary between non-italic and italic.
/// A value of 0 can be interpreted as &quot;Roman&quot; (non-italic); a value of 1 can
/// be interpreted as (fully) italic.
/// </para>
/// </summary>

	HB_STYLE_TAG_ITALIC = 1769234796,
/// <summary>
/// <para>
/// Used to vary design to suit different text sizes.
/// Non-zero. Values can be interpreted as text size, in points.
/// </para>
/// </summary>

	HB_STYLE_TAG_OPTICAL_SIZE = 1869640570,
/// <summary>
/// <para>
/// Used to vary between upright and slanted text. Values
/// must be greater than -90 and less than +90. Values can be interpreted as
/// the angle, in counter-clockwise degrees, of oblique slant from whatever the
/// designer considers to be upright for that font design. Typical right-leaning
/// Italic fonts have a negative slant angle (typically around -12)
/// </para>
/// </summary>

	HB_STYLE_TAG_SLANT_ANGLE = 1936486004,
/// <summary>
/// <para>
/// same as @HB_STYLE_TAG_SLANT_ANGLE expression as ratio.
/// Typical right-leaning Italic fonts have a positive slant ratio (typically around 0.2)
/// </para>
/// </summary>

	HB_STYLE_TAG_SLANT_RATIO = 1399615092,
/// <summary>
/// <para>
/// Used to vary width of text from narrower to wider.
/// Non-zero. Values can be interpreted as a percentage of whatever the font
/// designer considers “normal width” for that font design.
/// </para>
/// </summary>

	HB_STYLE_TAG_WIDTH = 2003072104,
/// <summary>
/// <para>
/// Used to vary stroke thicknesses or other design details
/// to give variation from lighter to blacker. Values can be interpreted in direct
/// comparison to values for usWeightClass in the OS/2 table,
/// or the CSS font-weight property.
/// </para>
/// </summary>

	HB_STYLE_TAG_WEIGHT = 2003265652
}
