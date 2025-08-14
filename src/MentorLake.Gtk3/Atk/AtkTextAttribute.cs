namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Describes the text attributes supported
/// </para>
/// </summary>

[Flags]
public enum AtkTextAttribute
{
/// <summary>
/// <para>
/// Invalid attribute, like bad spelling or grammar.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_INVALID = 0,
/// <summary>
/// <para>
/// The pixel width of the left margin
/// </para>
/// </summary>

	ATK_TEXT_ATTR_LEFT_MARGIN = 1,
/// <summary>
/// <para>
/// The pixel width of the right margin
/// </para>
/// </summary>

	ATK_TEXT_ATTR_RIGHT_MARGIN = 2,
/// <summary>
/// <para>
/// The number of pixels that the text is indented
/// </para>
/// </summary>

	ATK_TEXT_ATTR_INDENT = 3,
/// <summary>
/// <para>
/// Either "true" or "false" indicating whether text is visible or not
/// </para>
/// </summary>

	ATK_TEXT_ATTR_INVISIBLE = 4,
/// <summary>
/// <para>
/// Either "true" or "false" indicating whether text is editable or not
/// </para>
/// </summary>

	ATK_TEXT_ATTR_EDITABLE = 5,
/// <summary>
/// <para>
/// Pixels of blank space to leave above each newline-terminated line.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_PIXELS_ABOVE_LINES = 6,
/// <summary>
/// <para>
/// Pixels of blank space to leave below each newline-terminated line.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_PIXELS_BELOW_LINES = 7,
/// <summary>
/// <para>
/// Pixels of blank space to leave between wrapped lines inside the same newline-terminated line (paragraph).
/// </para>
/// </summary>

	ATK_TEXT_ATTR_PIXELS_INSIDE_WRAP = 8,
/// <summary>
/// <para>
/// "true" or "false" whether to make the background color for each character the height of the highest font used on the current line, or the height of the font used for the current character.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_BG_FULL_HEIGHT = 9,
/// <summary>
/// <para>
/// Number of pixels that the characters are risen above the baseline. See also ATK_TEXT_ATTR_TEXT_POSITION.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_RISE = 10,
/// <summary>
/// <para>
/// "none", "single", "double", "low", or "error"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_UNDERLINE = 11,
/// <summary>
/// <para>
/// "true" or "false" whether the text is strikethrough
/// </para>
/// </summary>

	ATK_TEXT_ATTR_STRIKETHROUGH = 12,
/// <summary>
/// <para>
/// The size of the characters in points. eg: 10
/// </para>
/// </summary>

	ATK_TEXT_ATTR_SIZE = 13,
/// <summary>
/// <para>
/// The scale of the characters. The value is a string representation of a double
/// </para>
/// </summary>

	ATK_TEXT_ATTR_SCALE = 14,
/// <summary>
/// <para>
/// The weight of the characters.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_WEIGHT = 15,
/// <summary>
/// <para>
/// The language used
/// </para>
/// </summary>

	ATK_TEXT_ATTR_LANGUAGE = 16,
/// <summary>
/// <para>
/// The font family name
/// </para>
/// </summary>

	ATK_TEXT_ATTR_FAMILY_NAME = 17,
/// <summary>
/// <para>
/// The background color. The value is an RGB value of the format "%u,%u,%u"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_BG_COLOR = 18,
/// <summary>
/// <para>
/// The foreground color. The value is an RGB value of the format "%u,%u,%u"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_FG_COLOR = 19,
/// <summary>
/// <para>
/// "true" if a #GdkBitmap is set for stippling the background color.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_BG_STIPPLE = 20,
/// <summary>
/// <para>
/// "true" if a #GdkBitmap is set for stippling the foreground color.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_FG_STIPPLE = 21,
/// <summary>
/// <para>
/// The wrap mode of the text, if any. Values are "none", "char", "word", or "word_char".
/// </para>
/// </summary>

	ATK_TEXT_ATTR_WRAP_MODE = 22,
/// <summary>
/// <para>
/// The direction of the text, if set. Values are "none", "ltr" or "rtl"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_DIRECTION = 23,
/// <summary>
/// <para>
/// The justification of the text, if set. Values are "left", "right", "center" or "fill"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_JUSTIFICATION = 24,
/// <summary>
/// <para>
/// The stretch of the text, if set. Values are "ultra_condensed", "extra_condensed", "condensed", "semi_condensed", "normal", "semi_expanded", "expanded", "extra_expanded" or "ultra_expanded"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_STRETCH = 25,
/// <summary>
/// <para>
/// The capitalization variant of the text, if set. Values are "normal" or "small_caps"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_VARIANT = 26,
/// <summary>
/// <para>
/// The slant style of the text, if set. Values are "normal", "oblique" or "italic"
/// </para>
/// </summary>

	ATK_TEXT_ATTR_STYLE = 27,
/// <summary>
/// <para>
/// The vertical position with respect to the baseline. Values are "baseline", "super", or "sub". Note that a super or sub text attribute refers to position with respect to the baseline of the prior character.
/// </para>
/// </summary>

	ATK_TEXT_ATTR_TEXT_POSITION = 28,
/// <summary>
/// <para>
/// not a valid text attribute, used for finding end of enumeration
/// </para>
/// </summary>

	ATK_TEXT_ATTR_LAST_DEFINED = 29
}
