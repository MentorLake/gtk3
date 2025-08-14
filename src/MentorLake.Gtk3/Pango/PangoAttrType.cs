namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttrType` distinguishes between different types of attributes.
/// </para>
/// <para>
/// Along with the predefined values, it is possible to allocate additional
/// values for custom attributes using [func@AttrType.register]. The predefined
/// values are given below. The type of structure used to store the attribute is
/// listed in parentheses after the description.
/// </para>
/// </summary>

[Flags]
public enum PangoAttrType
{
/// <summary>
/// <para>
/// does not happen
/// </para>
/// </summary>

	PANGO_ATTR_INVALID = 0,
/// <summary>
/// <para>
/// language ([struct@Pango.AttrLanguage])
/// </para>
/// </summary>

	PANGO_ATTR_LANGUAGE = 1,
/// <summary>
/// <para>
/// font family name list ([struct@Pango.AttrString])
/// </para>
/// </summary>

	PANGO_ATTR_FAMILY = 2,
/// <summary>
/// <para>
/// font slant style ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_STYLE = 3,
/// <summary>
/// <para>
/// font weight ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_WEIGHT = 4,
/// <summary>
/// <para>
/// font variant (normal or small caps) ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_VARIANT = 5,
/// <summary>
/// <para>
/// font stretch ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_STRETCH = 6,
/// <summary>
/// <para>
/// font size in points scaled by %PANGO_SCALE ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_SIZE = 7,
/// <summary>
/// <para>
/// font description ([struct@Pango.AttrFontDesc])
/// </para>
/// </summary>

	PANGO_ATTR_FONT_DESC = 8,
/// <summary>
/// <para>
/// foreground color ([struct@Pango.AttrColor])
/// </para>
/// </summary>

	PANGO_ATTR_FOREGROUND = 9,
/// <summary>
/// <para>
/// background color ([struct@Pango.AttrColor])
/// </para>
/// </summary>

	PANGO_ATTR_BACKGROUND = 10,
/// <summary>
/// <para>
/// whether the text has an underline ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_UNDERLINE = 11,
/// <summary>
/// <para>
/// whether the text is struck-through ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_STRIKETHROUGH = 12,
/// <summary>
/// <para>
/// baseline displacement ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_RISE = 13,
/// <summary>
/// <para>
/// shape ([struct@Pango.AttrShape])
/// </para>
/// </summary>

	PANGO_ATTR_SHAPE = 14,
/// <summary>
/// <para>
/// font size scale factor ([struct@Pango.AttrFloat])
/// </para>
/// </summary>

	PANGO_ATTR_SCALE = 15,
/// <summary>
/// <para>
/// whether fallback is enabled ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_FALLBACK = 16,
/// <summary>
/// <para>
/// letter spacing ([struct@PangoAttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_LETTER_SPACING = 17,
/// <summary>
/// <para>
/// underline color ([struct@Pango.AttrColor])
/// </para>
/// </summary>

	PANGO_ATTR_UNDERLINE_COLOR = 18,
/// <summary>
/// <para>
/// strikethrough color ([struct@Pango.AttrColor])
/// </para>
/// </summary>

	PANGO_ATTR_STRIKETHROUGH_COLOR = 19,
/// <summary>
/// <para>
/// font size in pixels scaled by %PANGO_SCALE ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_ABSOLUTE_SIZE = 20,
/// <summary>
/// <para>
/// base text gravity ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_GRAVITY = 21,
/// <summary>
/// <para>
/// gravity hint ([struct@Pango.AttrInt])
/// </para>
/// </summary>

	PANGO_ATTR_GRAVITY_HINT = 22,
/// <summary>
/// <para>
/// OpenType font features ([struct@Pango.AttrFontFeatures]). Since 1.38
/// </para>
/// </summary>

	PANGO_ATTR_FONT_FEATURES = 23,
/// <summary>
/// <para>
/// foreground alpha ([struct@Pango.AttrInt]). Since 1.38
/// </para>
/// </summary>

	PANGO_ATTR_FOREGROUND_ALPHA = 24,
/// <summary>
/// <para>
/// background alpha ([struct@Pango.AttrInt]). Since 1.38
/// </para>
/// </summary>

	PANGO_ATTR_BACKGROUND_ALPHA = 25,
/// <summary>
/// <para>
/// whether breaks are allowed ([struct@Pango.AttrInt]). Since 1.44
/// </para>
/// </summary>

	PANGO_ATTR_ALLOW_BREAKS = 26,
/// <summary>
/// <para>
/// how to render invisible characters ([struct@Pango.AttrInt]). Since 1.44
/// </para>
/// </summary>

	PANGO_ATTR_SHOW = 27,
/// <summary>
/// <para>
/// whether to insert hyphens at intra-word line breaks ([struct@Pango.AttrInt]). Since 1.44
/// </para>
/// </summary>

	PANGO_ATTR_INSERT_HYPHENS = 28,
/// <summary>
/// <para>
/// whether the text has an overline ([struct@Pango.AttrInt]). Since 1.46
/// </para>
/// </summary>

	PANGO_ATTR_OVERLINE = 29,
/// <summary>
/// <para>
/// overline color ([struct@Pango.AttrColor]). Since 1.46
/// </para>
/// </summary>

	PANGO_ATTR_OVERLINE_COLOR = 30,
/// <summary>
/// <para>
/// line height factor ([struct@Pango.AttrFloat]). Since: 1.50
/// </para>
/// </summary>

	PANGO_ATTR_LINE_HEIGHT = 31,
/// <summary>
/// <para>
/// line height ([struct@Pango.AttrInt]). Since: 1.50
/// </para>
/// </summary>

	PANGO_ATTR_ABSOLUTE_LINE_HEIGHT = 32,

	PANGO_ATTR_TEXT_TRANSFORM = 33,
/// <summary>
/// <para>
/// override segmentation to classify the range of the attribute as a single word ([struct@Pango.AttrInt]). Since 1.50
/// </para>
/// </summary>

	PANGO_ATTR_WORD = 34,
/// <summary>
/// <para>
/// override segmentation to classify the range of the attribute as a single sentence ([struct@Pango.AttrInt]). Since 1.50
/// </para>
/// </summary>

	PANGO_ATTR_SENTENCE = 35,
/// <summary>
/// <para>
/// baseline displacement ([struct@Pango.AttrInt]). Since 1.50
/// </para>
/// </summary>

	PANGO_ATTR_BASELINE_SHIFT = 36,
/// <summary>
/// <para>
/// font-relative size change ([struct@Pango.AttrInt]). Since 1.50
/// </para>
/// </summary>

	PANGO_ATTR_FONT_SCALE = 37
}
