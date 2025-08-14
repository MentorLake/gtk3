namespace MentorLake.Pango;

public class PangoGlobalFunctions
{
/// <summary>
/// <para>
/// Create a new allow-breaks attribute.
/// </para>
/// <para>
/// If breaks are disabled, the range will be kept in a
/// single run, as far as possible.
/// </para>
/// </summary>

/// <param name="allow_breaks">
/// %TRUE if we line breaks are allowed
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrAllowBreaksNew(bool allow_breaks)
	{
		return PangoGlobalFunctionsExterns.pango_attr_allow_breaks_new(allow_breaks);
	}

/// <summary>
/// <para>
/// Create a new background alpha attribute.
/// </para>
/// </summary>

/// <param name="alpha">
/// the alpha value, between 1 and 65536
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrBackgroundAlphaNew(ushort alpha)
	{
		return PangoGlobalFunctionsExterns.pango_attr_background_alpha_new(alpha);
	}

/// <summary>
/// <para>
/// Create a new background color attribute.
/// </para>
/// </summary>

/// <param name="red">
/// the red value (ranging from 0 to 65535)
/// </param>
/// <param name="green">
/// the green value
/// </param>
/// <param name="blue">
/// the blue value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrBackgroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_background_new(red, green, blue);
	}

/// <summary>
/// <para>
/// Create a new baseline displacement attribute.
/// </para>
/// <para>
/// The effect of this attribute is to shift the baseline of a run,
/// relative to the run of preceding run.
/// </para>
/// <para>
/// <picture>
///   <source srcset="baseline-shift-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Baseline Shift" src="baseline-shift-light.png">
/// </picture>
/// </para>
/// </summary>

/// <param name="shift">
/// either a `PangoBaselineShift` enumeration value or an absolute value (> 1024)
///   in Pango units, relative to the baseline of the previous run.
///   Positive values displace the text upwards.
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrBaselineShiftNew(int shift)
	{
		return PangoGlobalFunctionsExterns.pango_attr_baseline_shift_new(shift);
	}

/// <summary>
/// <para>
/// Apply customization from attributes to the breaks in @attrs.
/// </para>
/// <para>
/// The line breaks are assumed to have been produced
/// by [func@Pango.default_break] and [func@Pango.tailor_break].
/// </para>
/// </summary>

/// <param name="text">
/// text to break. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length of text in bytes (may be -1 if @text is nul-terminated)
/// </param>
/// <param name="attr_list">
/// `PangoAttrList` to apply
/// </param>
/// <param name="offset">
/// Byte offset of @text from the beginning of the paragraph
/// </param>
/// <param name="attrs">
/// array with one `PangoLogAttr`
///   per character in @text, plus one extra, to be filled in
/// </param>
/// <param name="attrs_len">
/// length of @attrs array
/// </param>

	public static void AttrBreak(string text, int length, MentorLake.Pango.PangoAttrListHandle attr_list, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_attr_break(text, length, attr_list, offset, attrs, attrs_len);
	}

/// <summary>
/// <para>
/// Create a new font fallback attribute.
/// </para>
/// <para>
/// If fallback is disabled, characters will only be
/// used from the closest matching font on the system.
/// No fallback will be done to other fonts on the system
/// that might contain the characters in the text.
/// </para>
/// </summary>

/// <param name="enable_fallback">
/// %TRUE if we should fall back on other fonts
///   for characters the active font is missing
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrFallbackNew(bool enable_fallback)
	{
		return PangoGlobalFunctionsExterns.pango_attr_fallback_new(enable_fallback);
	}

/// <summary>
/// <para>
/// Create a new font family attribute.
/// </para>
/// </summary>

/// <param name="family">
/// the family or comma-separated list of families
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrFamilyNew(string family)
	{
		return PangoGlobalFunctionsExterns.pango_attr_family_new(family);
	}

/// <summary>
/// <para>
/// Create a new font description attribute.
/// </para>
/// <para>
/// This attribute allows setting family, style, weight, variant,
/// stretch, and size simultaneously.
/// </para>
/// </summary>

/// <param name="desc">
/// the font description
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrFontDescNew(MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_desc_new(desc);
	}

/// <summary>
/// <para>
/// Create a new font features tag attribute.
/// </para>
/// <para>
/// You can use this attribute to select OpenType font features like small-caps,
/// alternative glyphs, ligatures, etc. for fonts that support them.
/// </para>
/// </summary>

/// <param name="features">
/// a string with OpenType font features, with the syntax of the [CSS
/// font-feature-settings property](https://www.w3.org/TR/css-fonts-4/#font-rend-desc)
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrFontFeaturesNew(string features)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_features_new(features);
	}

/// <summary>
/// <para>
/// Create a new font scale attribute.
/// </para>
/// <para>
/// The effect of this attribute is to change the font size of a run,
/// relative to the size of preceding run.
/// </para>
/// </summary>

/// <param name="scale">
/// a `PangoFontScale` value, which indicates font size change relative
///   to the size of the previous run.
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrFontScaleNew(MentorLake.Pango.PangoFontScale scale)
	{
		return PangoGlobalFunctionsExterns.pango_attr_font_scale_new(scale);
	}

/// <summary>
/// <para>
/// Create a new foreground alpha attribute.
/// </para>
/// </summary>

/// <param name="alpha">
/// the alpha value, between 1 and 65536
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrForegroundAlphaNew(ushort alpha)
	{
		return PangoGlobalFunctionsExterns.pango_attr_foreground_alpha_new(alpha);
	}

/// <summary>
/// <para>
/// Create a new foreground color attribute.
/// </para>
/// </summary>

/// <param name="red">
/// the red value (ranging from 0 to 65535)
/// </param>
/// <param name="green">
/// the green value
/// </param>
/// <param name="blue">
/// the blue value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrForegroundNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_foreground_new(red, green, blue);
	}

/// <summary>
/// <para>
/// Create a new gravity hint attribute.
/// </para>
/// </summary>

/// <param name="hint">
/// the gravity hint value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrGravityHintNew(MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_attr_gravity_hint_new(hint);
	}

/// <summary>
/// <para>
/// Create a new gravity attribute.
/// </para>
/// </summary>

/// <param name="gravity">
/// the gravity value; should not be %PANGO_GRAVITY_AUTO
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrGravityNew(MentorLake.Pango.PangoGravity gravity)
	{
		return PangoGlobalFunctionsExterns.pango_attr_gravity_new(gravity);
	}

/// <summary>
/// <para>
/// Create a new insert-hyphens attribute.
/// </para>
/// <para>
/// Pango will insert hyphens when breaking lines in
/// the middle of a word. This attribute can be used
/// to suppress the hyphen.
/// </para>
/// </summary>

/// <param name="insert_hyphens">
/// %TRUE if hyphens should be inserted
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrInsertHyphensNew(bool insert_hyphens)
	{
		return PangoGlobalFunctionsExterns.pango_attr_insert_hyphens_new(insert_hyphens);
	}

/// <summary>
/// <para>
/// Create a new language tag attribute.
/// </para>
/// </summary>

/// <param name="language">
/// language tag
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrLanguageNew(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoGlobalFunctionsExterns.pango_attr_language_new(language);
	}

/// <summary>
/// <para>
/// Create a new letter-spacing attribute.
/// </para>
/// </summary>

/// <param name="letter_spacing">
/// amount of extra space to add between
///   graphemes of the text, in Pango units
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrLetterSpacingNew(int letter_spacing)
	{
		return PangoGlobalFunctionsExterns.pango_attr_letter_spacing_new(letter_spacing);
	}

/// <summary>
/// <para>
/// Modify the height of logical line extents by a factor.
/// </para>
/// <para>
/// This affects the values returned by
/// [method@Pango.LayoutLine.get_extents],
/// [method@Pango.LayoutLine.get_pixel_extents] and
/// [method@Pango.LayoutIter.get_line_extents].
/// </para>
/// </summary>

/// <param name="factor">
/// the scaling factor to apply to the logical height
/// </param>

	public static MentorLake.Pango.PangoAttributeHandle AttrLineHeightNew(double factor)
	{
		return PangoGlobalFunctionsExterns.pango_attr_line_height_new(factor);
	}

/// <summary>
/// <para>
/// Override the height of logical line extents to be @height.
/// </para>
/// <para>
/// This affects the values returned by
/// [method@Pango.LayoutLine.get_extents],
/// [method@Pango.LayoutLine.get_pixel_extents] and
/// [method@Pango.LayoutIter.get_line_extents].
/// </para>
/// </summary>

/// <param name="height">
/// the line height, in %PANGO_SCALE-ths of a point
/// </param>

	public static MentorLake.Pango.PangoAttributeHandle AttrLineHeightNewAbsolute(int height)
	{
		return PangoGlobalFunctionsExterns.pango_attr_line_height_new_absolute(height);
	}

/// <summary>
/// <para>
/// Deserializes a `PangoAttrList` from a string.
/// </para>
/// <para>
/// This is the counterpart to [method@Pango.AttrList.to_string].
/// See that functions for details about the format.
/// </para>
/// </summary>

/// <param name="text">
/// a string
/// </param>
/// <return>
/// a new `PangoAttrList`
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle AttrListFromString(string text)
	{
		return PangoGlobalFunctionsExterns.pango_attr_list_from_string(text);
	}

/// <summary>
/// <para>
/// Create a new overline color attribute.
/// </para>
/// <para>
/// This attribute modifies the color of overlines.
/// If not set, overlines will use the foreground color.
/// </para>
/// </summary>

/// <param name="red">
/// the red value (ranging from 0 to 65535)
/// </param>
/// <param name="green">
/// the green value
/// </param>
/// <param name="blue">
/// the blue value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrOverlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_overline_color_new(red, green, blue);
	}

/// <summary>
/// <para>
/// Create a new overline-style attribute.
/// </para>
/// </summary>

/// <param name="overline">
/// the overline style
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrOverlineNew(MentorLake.Pango.PangoOverline overline)
	{
		return PangoGlobalFunctionsExterns.pango_attr_overline_new(overline);
	}

/// <summary>
/// <para>
/// Create a new baseline displacement attribute.
/// </para>
/// </summary>

/// <param name="rise">
/// the amount that the text should be displaced vertically,
///   in Pango units. Positive values displace the text upwards.
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrRiseNew(int rise)
	{
		return PangoGlobalFunctionsExterns.pango_attr_rise_new(rise);
	}

/// <summary>
/// <para>
/// Create a new font size scale attribute.
/// </para>
/// <para>
/// The base font for the affected text will have
/// its size multiplied by @scale_factor.
/// </para>
/// </summary>

/// <param name="scale_factor">
/// factor to scale the font
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrScaleNew(double scale_factor)
	{
		return PangoGlobalFunctionsExterns.pango_attr_scale_new(scale_factor);
	}

/// <summary>
/// <para>
/// Marks the range of the attribute as a single sentence.
/// </para>
/// <para>
/// Note that this may require adjustments to word and
/// sentence classification around the range.
/// </para>
/// </summary>

/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrSentenceNew()
	{
		return PangoGlobalFunctionsExterns.pango_attr_sentence_new();
	}

/// <summary>
/// <para>
/// Create a new shape attribute.
/// </para>
/// <para>
/// A shape is used to impose a particular ink and logical
/// rectangle on the result of shaping a particular glyph.
/// This might be used, for instance, for embedding a picture
/// or a widget inside a `PangoLayout`.
/// </para>
/// </summary>

/// <param name="ink_rect">
/// ink rectangle to assign to each character
/// </param>
/// <param name="logical_rect">
/// logical rectangle to assign to each character
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrShapeNew(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect)
	{
		return PangoGlobalFunctionsExterns.pango_attr_shape_new(ink_rect, logical_rect);
	}

/// <summary>
/// <para>
/// Creates a new shape attribute.
/// </para>
/// <para>
/// Like [func@Pango.AttrShape.new], but a user data pointer
/// is also provided; this pointer can be accessed when later
/// rendering the glyph.
/// </para>
/// </summary>

/// <param name="ink_rect">
/// ink rectangle to assign to each character
/// </param>
/// <param name="logical_rect">
/// logical rectangle to assign to each character
/// </param>
/// <param name="data">
/// user data pointer
/// </param>
/// <param name="copy_func">
/// function to copy @data when the
///   attribute is copied. If %NULL, @data is simply copied
///   as a pointer
/// </param>
/// <param name="destroy_func">
/// function to free @data when the
///   attribute is freed
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrShapeNewWithData(MentorLake.Pango.PangoRectangleHandle ink_rect, MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		return PangoGlobalFunctionsExterns.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}

/// <summary>
/// <para>
/// Create a new attribute that influences how invisible
/// characters are rendered.
/// </para>
/// </summary>

/// <param name="flags">
/// `PangoShowFlags` to apply
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrShowNew(MentorLake.Pango.PangoShowFlags flags)
	{
		return PangoGlobalFunctionsExterns.pango_attr_show_new(flags);
	}

/// <summary>
/// <para>
/// Create a new font-size attribute in fractional points.
/// </para>
/// </summary>

/// <param name="size">
/// the font size, in %PANGO_SCALE-ths of a point
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrSizeNew(int size)
	{
		return PangoGlobalFunctionsExterns.pango_attr_size_new(size);
	}

/// <summary>
/// <para>
/// Create a new font-size attribute in device units.
/// </para>
/// </summary>

/// <param name="size">
/// the font size, in %PANGO_SCALE-ths of a device unit
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrSizeNewAbsolute(int size)
	{
		return PangoGlobalFunctionsExterns.pango_attr_size_new_absolute(size);
	}

/// <summary>
/// <para>
/// Create a new font stretch attribute.
/// </para>
/// </summary>

/// <param name="stretch">
/// the stretch
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrStretchNew(MentorLake.Pango.PangoStretch stretch)
	{
		return PangoGlobalFunctionsExterns.pango_attr_stretch_new(stretch);
	}

/// <summary>
/// <para>
/// Create a new strikethrough color attribute.
/// </para>
/// <para>
/// This attribute modifies the color of strikethrough lines.
/// If not set, strikethrough lines will use the foreground color.
/// </para>
/// </summary>

/// <param name="red">
/// the red value (ranging from 0 to 65535)
/// </param>
/// <param name="green">
/// the green value
/// </param>
/// <param name="blue">
/// the blue value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrStrikethroughColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_strikethrough_color_new(red, green, blue);
	}

/// <summary>
/// <para>
/// Create a new strike-through attribute.
/// </para>
/// </summary>

/// <param name="strikethrough">
/// %TRUE if the text should be struck-through
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrStrikethroughNew(bool strikethrough)
	{
		return PangoGlobalFunctionsExterns.pango_attr_strikethrough_new(strikethrough);
	}

/// <summary>
/// <para>
/// Create a new font slant style attribute.
/// </para>
/// </summary>

/// <param name="style">
/// the slant style
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrStyleNew(MentorLake.Pango.PangoStyle style)
	{
		return PangoGlobalFunctionsExterns.pango_attr_style_new(style);
	}

/// <summary>
/// <para>
/// Create a new attribute that influences how characters
/// are transformed during shaping.
/// </para>
/// </summary>

/// <param name="transform">
/// `PangoTextTransform` to apply
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrTextTransformNew(MentorLake.Pango.PangoTextTransform transform)
	{
		return PangoGlobalFunctionsExterns.pango_attr_text_transform_new(transform);
	}

/// <summary>
/// <para>
/// Fetches the attribute type name.
/// </para>
/// <para>
/// The attribute type name is the string passed in
/// when registering the type using
/// [func@Pango.AttrType.register].
/// </para>
/// <para>
/// The returned value is an interned string (see
/// g_intern_string() for what that means) that should
/// not be modified or freed.
/// </para>
/// </summary>

/// <param name="type">
/// an attribute type ID to fetch the name for
/// </param>
/// <return>
/// the type ID name (which
///   may be %NULL), or %NULL if @type is a built-in Pango
///   attribute type or invalid.
/// </return>

	public static string AttrTypeGetName(MentorLake.Pango.PangoAttrType type)
	{
		return PangoGlobalFunctionsExterns.pango_attr_type_get_name(type);
	}

/// <summary>
/// <para>
/// Allocate a new attribute type ID.
/// </para>
/// <para>
/// The attribute type name can be accessed later
/// by using [func@Pango.AttrType.get_name].
/// </para>
/// </summary>

/// <param name="name">
/// an identifier for the type
/// </param>
/// <return>
/// the new type ID.
/// </return>

	public static MentorLake.Pango.PangoAttrType AttrTypeRegister(string name)
	{
		return PangoGlobalFunctionsExterns.pango_attr_type_register(name);
	}

/// <summary>
/// <para>
/// Create a new underline color attribute.
/// </para>
/// <para>
/// This attribute modifies the color of underlines.
/// If not set, underlines will use the foreground color.
/// </para>
/// </summary>

/// <param name="red">
/// the red value (ranging from 0 to 65535)
/// </param>
/// <param name="green">
/// the green value
/// </param>
/// <param name="blue">
/// the blue value
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrUnderlineColorNew(ushort red, ushort green, ushort blue)
	{
		return PangoGlobalFunctionsExterns.pango_attr_underline_color_new(red, green, blue);
	}

/// <summary>
/// <para>
/// Create a new underline-style attribute.
/// </para>
/// </summary>

/// <param name="underline">
/// the underline style
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrUnderlineNew(MentorLake.Pango.PangoUnderline underline)
	{
		return PangoGlobalFunctionsExterns.pango_attr_underline_new(underline);
	}

/// <summary>
/// <para>
/// Create a new font variant attribute (normal or small caps).
/// </para>
/// </summary>

/// <param name="variant">
/// the variant
/// </param>
/// <return>
/// the newly allocated `PangoAttribute`,
///   which should be freed with [method@Pango.Attribute.destroy].
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrVariantNew(MentorLake.Pango.PangoVariant variant)
	{
		return PangoGlobalFunctionsExterns.pango_attr_variant_new(variant);
	}

/// <summary>
/// <para>
/// Create a new font weight attribute.
/// </para>
/// </summary>

/// <param name="weight">
/// the weight
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrWeightNew(MentorLake.Pango.PangoWeight weight)
	{
		return PangoGlobalFunctionsExterns.pango_attr_weight_new(weight);
	}

/// <summary>
/// <para>
/// Marks the range of the attribute as a single word.
/// </para>
/// <para>
/// Note that this may require adjustments to word and
/// sentence classification around the range.
/// </para>
/// </summary>

/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy]
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle AttrWordNew()
	{
		return PangoGlobalFunctionsExterns.pango_attr_word_new();
	}

/// <summary>
/// <para>
/// Determines the bidirectional type of a character.
/// </para>
/// <para>
/// The bidirectional type is specified in the Unicode Character Database.
/// </para>
/// <para>
/// A simplified version of this function is available as [func@unichar_direction].
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// the bidirectional character type, as used in the
/// Unicode bidirectional algorithm.
/// </return>

	public static MentorLake.Pango.PangoBidiType BidiTypeForUnichar(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_bidi_type_for_unichar(ch);
	}

/// <summary>
/// <para>
/// Determines possible line, word, and character breaks
/// for a string of Unicode text with a single analysis.
/// </para>
/// <para>
/// For most purposes you may want to use [func@Pango.get_log_attrs].
/// </para>
/// </summary>

/// <param name="text">
/// the text to process. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length of @text in bytes (may be -1 if @text is nul-terminated)
/// </param>
/// <param name="analysis">
/// `PangoAnalysis` structure for @text
/// </param>
/// <param name="attrs">
/// an array to store character information in
/// </param>
/// <param name="attrs_len">
/// size of the array passed as @attrs
/// </param>

	public static void Break(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_break(text, length, analysis, attrs, attrs_len);
	}

/// <summary>
/// <para>
/// This is the default break algorithm.
/// </para>
/// <para>
/// It applies rules from the [Unicode Line Breaking Algorithm](http://www.unicode.org/unicode/reports/tr14/)
/// without language-specific tailoring, therefore the @analyis argument is unused
/// and can be %NULL.
/// </para>
/// <para>
/// See [func@Pango.tailor_break] for language-specific breaks.
/// </para>
/// <para>
/// See [func@Pango.attr_break] for attribute-based customization.
/// </para>
/// </summary>

/// <param name="text">
/// text to break. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length of text in bytes (may be -1 if @text is nul-terminated)
/// </param>
/// <param name="analysis">
/// a `PangoAnalysis` structure for the @text
/// </param>
/// <param name="attrs">
/// logical attributes to fill in
/// </param>
/// <param name="attrs_len">
/// size of the array passed as @attrs
/// </param>

	public static void DefaultBreak(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttrHandle attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_default_break(text, length, analysis, attrs, attrs_len);
	}

/// <summary>
/// <para>
/// Converts extents from Pango units to device units.
/// </para>
/// <para>
/// The conversion is done by dividing by the %PANGO_SCALE factor and
/// performing rounding.
/// </para>
/// <para>
/// The @inclusive rectangle is converted by flooring the x/y coordinates
/// and extending width/height, such that the final rectangle completely
/// includes the original rectangle.
/// </para>
/// <para>
/// The @nearest rectangle is converted by rounding the coordinates
/// of the rectangle to the nearest device unit (pixel).
/// </para>
/// <para>
/// The rule to which argument to use is: if you want the resulting device-space
/// rectangle to completely contain the original rectangle, pass it in as
/// @inclusive. If you want two touching-but-not-overlapping rectangles stay
/// touching-but-not-overlapping after rounding to device units, pass them in
/// as @nearest.
/// </para>
/// </summary>

/// <param name="inclusive">
/// rectangle to round to pixels inclusively
/// </param>
/// <param name="nearest">
/// rectangle to round to nearest pixels
/// </param>

	public static void ExtentsToPixels(MentorLake.Pango.PangoRectangleHandle inclusive, MentorLake.Pango.PangoRectangleHandle nearest)
	{
		PangoGlobalFunctionsExterns.pango_extents_to_pixels(inclusive, nearest);
	}

/// <summary>
/// <para>
/// Searches a string the first character that has a strong
/// direction, according to the Unicode bidirectional algorithm.
/// </para>
/// </summary>

/// <param name="text">
/// the text to process. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length of @text in bytes (may be -1 if @text is nul-terminated)
/// </param>
/// <return>
/// The direction corresponding to the first strong character.
///   If no such character is found, then %PANGO_DIRECTION_NEUTRAL is returned.
/// </return>

	public static MentorLake.Pango.PangoDirection FindBaseDir(string text, int length)
	{
		return PangoGlobalFunctionsExterns.pango_find_base_dir(text, length);
	}

/// <summary>
/// <para>
/// Locates a paragraph boundary in @text.
/// </para>
/// <para>
/// A boundary is caused by delimiter characters, such as
/// a newline, carriage return, carriage return-newline pair,
/// or Unicode paragraph separator character.
/// </para>
/// <para>
/// The index of the run of delimiters is returned in
/// @paragraph_delimiter_index. The index of the start of the
/// next paragraph (index after all delimiters) is stored n
/// @next_paragraph_start.
/// </para>
/// <para>
/// If no delimiters are found, both @paragraph_delimiter_index
/// and @next_paragraph_start are filled with the length of @text
/// (an index one off the end).
/// </para>
/// </summary>

/// <param name="text">
/// UTF-8 text
/// </param>
/// <param name="length">
/// length of @text in bytes, or -1 if nul-terminated
/// </param>
/// <param name="paragraph_delimiter_index">
/// return location for index of
///   delimiter
/// </param>
/// <param name="next_paragraph_start">
/// return location for start of next
///   paragraph
/// </param>

	public static void FindParagraphBoundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start)
	{
		PangoGlobalFunctionsExterns.pango_find_paragraph_boundary(text, length, out paragraph_delimiter_index, out next_paragraph_start);
	}

/// <summary>
/// <para>
/// Creates a new font description from a string representation.
/// </para>
/// <para>
/// The string must have the form
/// </para>
/// <para>
///     [FAMILY-LIST] [STYLE-OPTIONS] [SIZE] [VARIATIONS] [FEATURES]
/// </para>
/// <para>
/// where FAMILY-LIST is a comma-separated list of families optionally
/// terminated by a comma, STYLE_OPTIONS is a whitespace-separated list
/// of words where each word describes one of style, variant, weight,
/// stretch, or gravity, and SIZE is a decimal number (size in points)
/// or optionally followed by the unit modifier "px" for absolute size.
/// </para>
/// <para>
/// The following words are understood as styles:
/// "Normal", "Roman", "Oblique", "Italic".
/// </para>
/// <para>
/// The following words are understood as variants:
/// "Small-Caps", "All-Small-Caps", "Petite-Caps", "All-Petite-Caps",
/// "Unicase", "Title-Caps".
/// </para>
/// <para>
/// The following words are understood as weights:
/// "Thin", "Ultra-Light", "Extra-Light", "Light", "Semi-Light",
/// "Demi-Light", "Book", "Regular", "Medium", "Semi-Bold", "Demi-Bold",
/// "Bold", "Ultra-Bold", "Extra-Bold", "Heavy", "Black", "Ultra-Black",
/// "Extra-Black".
/// </para>
/// <para>
/// The following words are understood as stretch values:
/// "Ultra-Condensed", "Extra-Condensed", "Condensed", "Semi-Condensed",
/// "Semi-Expanded", "Expanded", "Extra-Expanded", "Ultra-Expanded".
/// </para>
/// <para>
/// The following words are understood as gravity values:
/// "Not-Rotated", "South", "Upside-Down", "North", "Rotated-Left",
/// "East", "Rotated-Right", "West".
/// </para>
/// <para>
/// VARIATIONS is a comma-separated list of font variations
/// of the form @‍axis1=value,axis2=value,...
/// </para>
/// <para>
/// FEATURES is a comma-separated list of font features of the form
/// \#‍feature1=value,feature2=value,...
/// </para>
/// <para>
/// Any one of the options may be absent. If FAMILY-LIST is absent, then
/// the family_name field of the resulting font description will be
/// initialized to %NULL. If STYLE-OPTIONS is missing, then all style
/// options will be set to the default values. If SIZE is missing, the
/// size in the resulting font description will be set to 0.
/// </para>
/// <para>
/// A typical example:
/// </para>
/// <para>
///     Cantarell Italic Light 15 @‍wght=200 #‍tnum=1
/// </para>
/// </summary>

/// <param name="str">
/// string representation of a font description.
/// </param>
/// <return>
/// a new `PangoFontDescription`.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle FontDescriptionFromString(string str)
	{
		return PangoGlobalFunctionsExterns.pango_font_description_from_string(str);
	}

/// <summary>
/// <para>
/// Computes a `PangoLogAttr` for each character in @text.
/// </para>
/// <para>
/// The @attrs array must have one `PangoLogAttr` for
/// each position in @text; if @text contains N characters,
/// it has N+1 positions, including the last position at the
/// end of the text. @text should be an entire paragraph;
/// logical attributes can't be computed without context
/// (for example you need to see spaces on either side of
/// a word to know the word is a word).
/// </para>
/// </summary>

/// <param name="text">
/// text to process. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length in bytes of @text
/// </param>
/// <param name="level">
/// embedding level, or -1 if unknown
/// </param>
/// <param name="language">
/// language tag
/// </param>
/// <param name="attrs">
/// array with one `PangoLogAttr`
///   per character in @text, plus one extra, to be filled in
/// </param>
/// <param name="attrs_len">
/// length of @attrs array
/// </param>

	public static void GetLogAttrs(string text, int length, int level, MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_get_log_attrs(text, length, level, language, attrs, attrs_len);
	}

/// <summary>
/// <para>
/// Returns the mirrored character of a Unicode character.
/// </para>
/// <para>
/// Mirror characters are determined by the Unicode mirrored property.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <param name="mirrored_ch">
/// location to store the mirrored character
/// </param>
/// <return>
/// %TRUE if @ch has a mirrored character and @mirrored_ch is
/// filled in, %FALSE otherwise
/// </return>

	public static bool GetMirrorChar(char ch, char mirrored_ch)
	{
		return PangoGlobalFunctionsExterns.pango_get_mirror_char(ch, mirrored_ch);
	}

/// <summary>
/// <para>
/// Finds the gravity that best matches the rotation component
/// in a `PangoMatrix`.
/// </para>
/// </summary>

/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <return>
/// the gravity of @matrix, which will never be
/// %PANGO_GRAVITY_AUTO, or %PANGO_GRAVITY_SOUTH if @matrix is %NULL
/// </return>

	public static MentorLake.Pango.PangoGravity GravityGetForMatrix(MentorLake.Pango.PangoMatrixHandle matrix)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_matrix(matrix);
	}

/// <summary>
/// <para>
/// Returns the gravity to use in laying out a `PangoItem`.
/// </para>
/// <para>
/// The gravity is determined based on the script, base gravity, and hint.
/// </para>
/// <para>
/// If @base_gravity is %PANGO_GRAVITY_AUTO, it is first replaced with the
/// preferred gravity of @script.  To get the preferred gravity of a script,
/// pass %PANGO_GRAVITY_AUTO and %PANGO_GRAVITY_HINT_STRONG in.
/// </para>
/// </summary>

/// <param name="script">
/// `PangoScript` to query
/// </param>
/// <param name="base_gravity">
/// base gravity of the paragraph
/// </param>
/// <param name="hint">
/// orientation hint
/// </param>
/// <return>
/// resolved gravity suitable to use for a run of text
/// with @script
/// </return>

	public static MentorLake.Pango.PangoGravity GravityGetForScript(MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_script(script, base_gravity, hint);
	}

/// <summary>
/// <para>
/// Returns the gravity to use in laying out a single character
/// or `PangoItem`.
/// </para>
/// <para>
/// The gravity is determined based on the script, East Asian width,
/// base gravity, and hint,
/// </para>
/// <para>
/// This function is similar to [func@Pango.Gravity.get_for_script] except
/// that this function makes a distinction between narrow/half-width and
/// wide/full-width characters also. Wide/full-width characters always
/// stand *upright*, that is, they always take the base gravity,
/// whereas narrow/full-width characters are always rotated in vertical
/// context.
/// </para>
/// <para>
/// If @base_gravity is %PANGO_GRAVITY_AUTO, it is first replaced with the
/// preferred gravity of @script.
/// </para>
/// </summary>

/// <param name="script">
/// `PangoScript` to query
/// </param>
/// <param name="wide">
/// %TRUE for wide characters as returned by g_unichar_iswide()
/// </param>
/// <param name="base_gravity">
/// base gravity of the paragraph
/// </param>
/// <param name="hint">
/// orientation hint
/// </param>
/// <return>
/// resolved gravity suitable to use for a run of text
/// with @script and @wide.
/// </return>

	public static MentorLake.Pango.PangoGravity GravityGetForScriptAndWidth(MentorLake.Pango.PangoScript script, bool wide, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_get_for_script_and_width(script, wide, base_gravity, hint);
	}

/// <summary>
/// <para>
/// Converts a `PangoGravity` value to its natural rotation in radians.
/// </para>
/// <para>
/// Note that [method@Pango.Matrix.rotate] takes angle in degrees, not radians.
/// So, to call [method@Pango.Matrix,rotate] with the output of this function
/// you should multiply it by (180. / G_PI).
/// </para>
/// </summary>

/// <param name="gravity">
/// gravity to query, should not be %PANGO_GRAVITY_AUTO
/// </param>
/// <return>
/// the rotation value corresponding to @gravity.
/// </return>

	public static double GravityToRotation(MentorLake.Pango.PangoGravity gravity)
	{
		return PangoGlobalFunctionsExterns.pango_gravity_to_rotation(gravity);
	}

/// <summary>
/// <para>
/// Checks if a character that should not be normally rendered.
/// </para>
/// <para>
/// This includes all Unicode characters with "ZERO WIDTH" in their name,
/// as well as *bidi* formatting characters, and a few other ones.
/// </para>
/// <para>
/// This is totally different from [func@GLib.unichar_iszerowidth] and is at best misnamed.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @ch is a zero-width character, %FALSE otherwise
/// </return>

	public static bool IsZeroWidth(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_is_zero_width(ch);
	}

/// <summary>
/// <para>
/// Breaks a piece of text into segments with consistent directional
/// level and font.
/// </para>
/// <para>
/// Each byte of @text will be contained in exactly one of the items in the
/// returned list; the generated list of items will be in logical order (the
/// start offsets of the items are ascending).
/// </para>
/// <para>
/// @cached_iter should be an iterator over @attrs currently positioned
/// at a range before or containing @start_index; @cached_iter will be
/// advanced to the range covering the position just after
/// @start_index + @length. (i.e. if itemizing in a loop, just keep passing
/// in the same @cached_iter).
/// </para>
/// </summary>

/// <param name="context">
/// a structure holding information that affects
///   the itemization process.
/// </param>
/// <param name="text">
/// the text to itemize. Must be valid UTF-8
/// </param>
/// <param name="start_index">
/// first byte in @text to process
/// </param>
/// <param name="length">
/// the number of bytes (not characters) to process
///   after @start_index. This must be >= 0.
/// </param>
/// <param name="attrs">
/// the set of attributes that apply to @text.
/// </param>
/// <param name="cached_iter">
/// Cached attribute iterator
/// </param>
/// <return>
/// a `GList` of
///   [struct@Pango.Item] structures. The items should be freed using
///   [method@Pango.Item.free] in combination with [func@GLib.List.free_full].
/// </return>

	public static MentorLake.GLib.GListHandle Itemize(MentorLake.Pango.PangoContextHandle context, string text, int start_index, int length, MentorLake.Pango.PangoAttrListHandle attrs, MentorLake.Pango.PangoAttrIteratorHandle cached_iter)
	{
		return PangoGlobalFunctionsExterns.pango_itemize(context, text, start_index, length, attrs, cached_iter);
	}

/// <summary>
/// <para>
/// Like `pango_itemize()`, but with an explicitly specified base direction.
/// </para>
/// <para>
/// The base direction is used when computing bidirectional levels.
/// [func@itemize] gets the base direction from the `PangoContext`
/// (see [method@Pango.Context.set_base_dir]).
/// </para>
/// </summary>

/// <param name="context">
/// a structure holding information that affects
///   the itemization process.
/// </param>
/// <param name="base_dir">
/// base direction to use for bidirectional processing
/// </param>
/// <param name="text">
/// the text to itemize.
/// </param>
/// <param name="start_index">
/// first byte in @text to process
/// </param>
/// <param name="length">
/// the number of bytes (not characters) to process
///   after @start_index. This must be >= 0.
/// </param>
/// <param name="attrs">
/// the set of attributes that apply to @text.
/// </param>
/// <param name="cached_iter">
/// Cached attribute iterator
/// </param>
/// <return>
/// a `GList` of
///   [struct@Pango.Item] structures. The items should be freed using
///   [method@Pango.Item.free] probably in combination with [func@GLib.List.free_full].
/// </return>

	public static MentorLake.GLib.GListHandle ItemizeWithBaseDir(MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoDirection base_dir, string text, int start_index, int length, MentorLake.Pango.PangoAttrListHandle attrs, MentorLake.Pango.PangoAttrIteratorHandle cached_iter)
	{
		return PangoGlobalFunctionsExterns.pango_itemize_with_base_dir(context, base_dir, text, start_index, length, attrs, cached_iter);
	}

/// <summary>
/// <para>
/// Convert a language tag to a `PangoLanguage`.
/// </para>
/// <para>
/// The language tag must be in a RFC-3066 format. `PangoLanguage` pointers
/// can be efficiently copied (copy the pointer) and compared with other
/// language tags (compare the pointer.)
/// </para>
/// <para>
/// This function first canonicalizes the string by converting it to
/// lowercase, mapping '_' to '-', and stripping all characters other
/// than letters and '-'.
/// </para>
/// <para>
/// Use [func@Pango.Language.get_default] if you want to get the
/// `PangoLanguage` for the current locale of the process.
/// </para>
/// </summary>

/// <param name="language">
/// a string representing a language tag
/// </param>
/// <return>
/// a `PangoLanguage`
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle LanguageFromString(string language)
	{
		return PangoGlobalFunctionsExterns.pango_language_from_string(language);
	}

/// <summary>
/// <para>
/// Returns the `PangoLanguage` for the current locale of the process.
/// </para>
/// <para>
/// On Unix systems, this is the return value is derived from
/// `setlocale (LC_CTYPE, NULL)`, and the user can
/// affect this through the environment variables LC_ALL, LC_CTYPE or
/// LANG (checked in that order). The locale string typically is in
/// the form lang_COUNTRY, where lang is an ISO-639 language code, and
/// COUNTRY is an ISO-3166 country code. For instance, sv_FI for
/// Swedish as written in Finland or pt_BR for Portuguese as written in
/// Brazil.
/// </para>
/// <para>
/// On Windows, the C library does not use any such environment
/// variables, and setting them won't affect the behavior of functions
/// like ctime(). The user sets the locale through the Regional Options
/// in the Control Panel. The C library (in the setlocale() function)
/// does not use country and language codes, but country and language
/// names spelled out in English.
/// However, this function does check the above environment
/// variables, and does return a Unix-style locale string based on
/// either said environment variables or the thread's current locale.
/// </para>
/// <para>
/// Your application should call `setlocale(LC_ALL, "")` for the user
/// settings to take effect. GTK does this in its initialization
/// functions automatically (by calling gtk_set_locale()).
/// See the setlocale() manpage for more details.
/// </para>
/// <para>
/// Note that the default language can change over the life of an application.
/// </para>
/// <para>
/// Also note that this function will not do the right thing if you
/// use per-thread locales with uselocale(). In that case, you should
/// just call pango_language_from_string() yourself.
/// </para>
/// </summary>

/// <return>
/// the default language as a `PangoLanguage`
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle LanguageGetDefault()
	{
		return PangoGlobalFunctionsExterns.pango_language_get_default();
	}

/// <summary>
/// <para>
/// Returns the list of languages that the user prefers.
/// </para>
/// <para>
/// The list is specified by the `PANGO_LANGUAGE` or `LANGUAGE`
/// environment variables, in order of preference. Note that this
/// list does not necessarily include the language returned by
/// [func@Pango.Language.get_default].
/// </para>
/// <para>
/// When choosing language-specific resources, such as the sample
/// text returned by [method@Pango.Language.get_sample_string],
/// you should first try the default language, followed by the
/// languages returned by this function.
/// </para>
/// </summary>

/// <return>
/// a %NULL-terminated array
///   of `PangoLanguage`*
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle[] LanguageGetPreferred()
	{
		return PangoGlobalFunctionsExterns.pango_language_get_preferred();
	}



	public static MentorLake.GLib.GQuark LayoutDeserializeErrorQuark()
	{
		return PangoGlobalFunctionsExterns.pango_layout_deserialize_error_quark();
	}

/// <summary>
/// <para>
/// Return the bidirectional embedding levels of the input paragraph.
/// </para>
/// <para>
/// The bidirectional embedding levels are defined by the [Unicode Bidirectional
/// Algorithm](http://www.unicode.org/reports/tr9/).
/// </para>
/// <para>
/// If the input base direction is a weak direction, the direction of the
/// characters in the text will determine the final resolved direction.
/// </para>
/// </summary>

/// <param name="text">
/// the text to itemize.
/// </param>
/// <param name="length">
/// the number of bytes (not characters) to process, or -1
///   if @text is nul-terminated and the length should be calculated.
/// </param>
/// <param name="pbase_dir">
/// input base direction, and output resolved direction.
/// </param>
/// <return>
/// a newly allocated array of embedding levels, one item per
///   character (not byte), that should be freed using [func@GLib.free].
/// </return>

	public static byte Log2VisGetEmbeddingLevels(string text, int length, ref MentorLake.Pango.PangoDirection pbase_dir)
	{
		return PangoGlobalFunctionsExterns.pango_log2vis_get_embedding_levels(text, length, ref pbase_dir);
	}

/// <summary>
/// <para>
/// Finishes parsing markup.
/// </para>
/// <para>
/// After feeding a Pango markup parser some data with [method@GLib.MarkupParseContext.parse],
/// use this function to get the list of attributes and text out of the
/// markup. This function will not free @context, use [method@GLib.MarkupParseContext.free]
/// to do so.
/// </para>
/// </summary>

/// <param name="context">
/// A valid parse context that was returned from [func@markup_parser_new]
/// </param>
/// <param name="attr_list">
/// address of return location for a `PangoAttrList`
/// </param>
/// <param name="text">
/// address of return location for text with tags stripped
/// </param>
/// <param name="accel_char">
/// address of return location for accelerator char
/// </param>
/// <return>
/// %FALSE if @error is set, otherwise %TRUE
/// </return>

	public static bool MarkupParserFinish(MentorLake.GLib.GMarkupParseContextHandle context, out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char)
	{
		var externCallResult = PangoGlobalFunctionsExterns.pango_markup_parser_finish(context, out attr_list, out text, out accel_char, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Incrementally parses marked-up text to create a plain-text string
/// and an attribute list.
/// </para>
/// <para>
/// See the [Pango Markup](pango_markup.html) docs for details about the
/// supported markup.
/// </para>
/// <para>
/// If @accel_marker is nonzero, the given character will mark the
/// character following it as an accelerator. For example, @accel_marker
/// might be an ampersand or underscore. All characters marked
/// as an accelerator will receive a %PANGO_UNDERLINE_LOW attribute,
/// and the first character so marked will be returned in @accel_char,
/// when calling [func@markup_parser_finish]. Two @accel_marker characters
/// following each other produce a single literal @accel_marker character.
/// </para>
/// <para>
/// To feed markup to the parser, use [method@GLib.MarkupParseContext.parse]
/// on the returned [struct@GLib.MarkupParseContext]. When done with feeding markup
/// to the parser, use [func@markup_parser_finish] to get the data out
/// of it, and then use [method@GLib.MarkupParseContext.free] to free it.
/// </para>
/// <para>
/// This function is designed for applications that read Pango markup
/// from streams. To simply parse a string containing Pango markup,
/// the [func@Pango.parse_markup] API is recommended instead.
/// </para>
/// </summary>

/// <param name="accel_marker">
/// character that precedes an accelerator, or 0 for none
/// </param>
/// <return>
/// a `GMarkupParseContext` that should be
/// destroyed with [method@GLib.MarkupParseContext.free].
/// </return>

	public static MentorLake.GLib.GMarkupParseContextHandle MarkupParserNew(char accel_marker)
	{
		return PangoGlobalFunctionsExterns.pango_markup_parser_new(accel_marker);
	}

/// <summary>
/// <para>
/// Parses an enum type and stores the result in @value.
/// </para>
/// <para>
/// If @str does not match the nick name of any of the possible values
/// for the enum and is not an integer, %FALSE is returned, a warning
/// is issued if @warn is %TRUE, and a string representing the list of
/// possible values is stored in @possible_values. The list is
/// slash-separated, eg. "none/start/middle/end".
/// </para>
/// <para>
/// If failed and @possible_values is not %NULL, returned string should
/// be freed using g_free().
/// </para>
/// </summary>

/// <param name="type">
/// enum type to parse, eg. %PANGO_TYPE_ELLIPSIZE_MODE
/// </param>
/// <param name="str">
/// string to parse
/// </param>
/// <param name="value">
/// integer to store the result in
/// </param>
/// <param name="warn">
/// if %TRUE, issue a g_warning() on bad input
/// </param>
/// <param name="possible_values">
/// place to store list of possible
///   values on failure
/// </param>
/// <return>
/// %TRUE if @str was successfully parsed
/// </return>

	public static bool ParseEnum(MentorLake.GObject.GType type, string str, out int value, bool warn, out string possible_values)
	{
		return PangoGlobalFunctionsExterns.pango_parse_enum(type, str, out value, warn, out possible_values);
	}

/// <summary>
/// <para>
/// Parses marked-up text to create a plain-text string and an attribute list.
/// </para>
/// <para>
/// See the [Pango Markup](pango_markup.html) docs for details about the
/// supported markup.
/// </para>
/// <para>
/// If @accel_marker is nonzero, the given character will mark the
/// character following it as an accelerator. For example, @accel_marker
/// might be an ampersand or underscore. All characters marked
/// as an accelerator will receive a %PANGO_UNDERLINE_LOW attribute,
/// and the first character so marked will be returned in @accel_char.
/// Two @accel_marker characters following each other produce a single
/// literal @accel_marker character.
/// </para>
/// <para>
/// To parse a stream of pango markup incrementally, use [func@markup_parser_new].
/// </para>
/// <para>
/// If any error happens, none of the output arguments are touched except
/// for @error.
/// </para>
/// </summary>

/// <param name="markup_text">
/// markup to parse (see the [Pango Markup](pango_markup.html) docs)
/// </param>
/// <param name="length">
/// length of @markup_text, or -1 if nul-terminated
/// </param>
/// <param name="accel_marker">
/// character that precedes an accelerator, or 0 for none
/// </param>
/// <param name="attr_list">
/// address of return location for a `PangoAttrList`
/// </param>
/// <param name="text">
/// address of return location for text with tags stripped
/// </param>
/// <param name="accel_char">
/// address of return location for accelerator char
/// </param>
/// <return>
/// %FALSE if @error is set, otherwise %TRUE
/// </return>

	public static bool ParseMarkup(string markup_text, int length, char accel_marker, out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char)
	{
		var externCallResult = PangoGlobalFunctionsExterns.pango_parse_markup(markup_text, length, accel_marker, out attr_list, out text, out accel_char, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a font stretch.
/// </para>
/// <para>
/// The allowed values are
/// "ultra_condensed", "extra_condensed", "condensed",
/// "semi_condensed", "normal", "semi_expanded", "expanded",
/// "extra_expanded" and "ultra_expanded". Case variations are
/// ignored and the '_' characters may be omitted.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse.
/// </param>
/// <param name="stretch">
/// a `PangoStretch` to store the result in.
/// </param>
/// <param name="warn">
/// if %TRUE, issue a g_warning() on bad input.
/// </param>
/// <return>
/// %TRUE if @str was successfully parsed.
/// </return>

	public static bool ParseStretch(string str, out MentorLake.Pango.PangoStretch stretch, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_stretch(str, out stretch, warn);
	}

/// <summary>
/// <para>
/// Parses a font style.
/// </para>
/// <para>
/// The allowed values are "normal", "italic" and "oblique", case
/// variations being
/// ignored.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse.
/// </param>
/// <param name="style">
/// a `PangoStyle` to store the result in.
/// </param>
/// <param name="warn">
/// if %TRUE, issue a g_warning() on bad input.
/// </param>
/// <return>
/// %TRUE if @str was successfully parsed.
/// </return>

	public static bool ParseStyle(string str, out MentorLake.Pango.PangoStyle style, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_style(str, out style, warn);
	}

/// <summary>
/// <para>
/// Parses a font variant.
/// </para>
/// <para>
/// The allowed values are "normal", "small-caps", "all-small-caps",
/// "petite-caps", "all-petite-caps", "unicase" and "title-caps",
/// case variations being ignored.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse.
/// </param>
/// <param name="variant">
/// a `PangoVariant` to store the result in.
/// </param>
/// <param name="warn">
/// if %TRUE, issue a g_warning() on bad input.
/// </param>
/// <return>
/// %TRUE if @str was successfully parsed.
/// </return>

	public static bool ParseVariant(string str, out MentorLake.Pango.PangoVariant variant, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_variant(str, out variant, warn);
	}

/// <summary>
/// <para>
/// Parses a font weight.
/// </para>
/// <para>
/// The allowed values are "heavy",
/// "ultrabold", "bold", "normal", "light", "ultraleight"
/// and integers. Case variations are ignored.
/// </para>
/// </summary>

/// <param name="str">
/// a string to parse.
/// </param>
/// <param name="weight">
/// a `PangoWeight` to store the result in.
/// </param>
/// <param name="warn">
/// if %TRUE, issue a g_warning() on bad input.
/// </param>
/// <return>
/// %TRUE if @str was successfully parsed.
/// </return>

	public static bool ParseWeight(string str, out MentorLake.Pango.PangoWeight weight, bool warn)
	{
		return PangoGlobalFunctionsExterns.pango_parse_weight(str, out weight, warn);
	}

/// <summary>
/// <para>
/// Quantizes the thickness and position of a line to whole device pixels.
/// </para>
/// <para>
/// This is typically used for underline or strikethrough. The purpose of
/// this function is to avoid such lines looking blurry.
/// </para>
/// <para>
/// Care is taken to make sure @thickness is at least one pixel when this
/// function returns, but returned @position may become zero as a result
/// of rounding.
/// </para>
/// </summary>

/// <param name="thickness">
/// pointer to the thickness of a line, in Pango units
/// </param>
/// <param name="position">
/// corresponding position
/// </param>

	public static void QuantizeLineGeometry(ref int thickness, ref int position)
	{
		PangoGlobalFunctionsExterns.pango_quantize_line_geometry(ref thickness, ref position);
	}

/// <summary>
/// <para>
/// Reads an entire line from a file into a buffer.
/// </para>
/// <para>
/// Lines may be delimited with '\n', '\r', '\n\r', or '\r\n'. The delimiter
/// is not written into the buffer. Text after a '#' character is treated as
/// a comment and skipped. '\' can be used to escape a # character.
/// '\' proceeding a line delimiter combines adjacent lines. A '\' proceeding
/// any other character is ignored and written into the output buffer
/// unmodified.
/// </para>
/// </summary>

/// <param name="stream">
/// a stdio stream
/// </param>
/// <param name="str">
/// `GString` buffer into which to write the result
/// </param>
/// <return>
/// 0 if the stream was already at an %EOF character,
///   otherwise the number of lines read (this is useful for maintaining
///   a line number counter which doesn't combine lines with '\')
/// </return>

	public static int ReadLine(IntPtr stream, MentorLake.GLib.GStringHandle str)
	{
		return PangoGlobalFunctionsExterns.pango_read_line(stream, str);
	}

/// <summary>
/// <para>
/// Reorder items from logical order to visual order.
/// </para>
/// <para>
/// The visual order is determined from the associated directional
/// levels of the items. The original list is unmodified.
/// </para>
/// <para>
/// (Please open a bug if you use this function.
///  It is not a particularly convenient interface, and the code
///  is duplicated elsewhere in Pango for that reason.)
/// </para>
/// </summary>

/// <param name="items">
/// a `GList` of `PangoItem`
///   in logical order.
/// </param>
/// <return>
/// a `GList`
///   of `PangoItem` structures in visual order.
/// </return>

	public static MentorLake.GLib.GListHandle ReorderItems(MentorLake.GLib.GListHandle items)
	{
		return PangoGlobalFunctionsExterns.pango_reorder_items(items);
	}

/// <summary>
/// <para>
/// Scans an integer.
/// </para>
/// <para>
/// Leading white space is skipped.
/// </para>
/// </summary>

/// <param name="pos">
/// in/out string position
/// </param>
/// <param name="@out">
/// an int into which to write the result
/// </param>
/// <return>
/// %FALSE if a parse error occurred
/// </return>

	public static bool ScanInt(ref string pos, out int @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_int(ref pos, out @out);
	}

/// <summary>
/// <para>
/// Scans a string into a `GString` buffer.
/// </para>
/// <para>
/// The string may either be a sequence of non-white-space characters,
/// or a quoted string with '"'. Instead a quoted string, '\"' represents
/// a literal quote. Leading white space outside of quotes is skipped.
/// </para>
/// </summary>

/// <param name="pos">
/// in/out string position
/// </param>
/// <param name="@out">
/// a `GString` into which to write the result
/// </param>
/// <return>
/// %FALSE if a parse error occurred
/// </return>

	public static bool ScanString(ref string pos, MentorLake.GLib.GStringHandle @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_string(ref pos, @out);
	}

/// <summary>
/// <para>
/// Scans a word into a `GString` buffer.
/// </para>
/// <para>
/// A word consists of [A-Za-z_] followed by zero or more
/// [A-Za-z_0-9]. Leading white space is skipped.
/// </para>
/// </summary>

/// <param name="pos">
/// in/out string position
/// </param>
/// <param name="@out">
/// a `GString` into which to write the result
/// </param>
/// <return>
/// %FALSE if a parse error occurred
/// </return>

	public static bool ScanWord(ref string pos, MentorLake.GLib.GStringHandle @out)
	{
		return PangoGlobalFunctionsExterns.pango_scan_word(ref pos, @out);
	}

/// <summary>
/// <para>
/// Looks up the script for a particular character.
/// </para>
/// <para>
/// The script of a character is defined by
/// [Unicode Standard Annex 24: Script names](http://www.unicode.org/reports/tr24/).
/// </para>
/// <para>
/// No check is made for @ch being a valid Unicode character; if you pass
/// in invalid character, the result is undefined.
/// </para>
/// <para>
/// Note that while the return type of this function is declared
/// as `PangoScript`, as of Pango 1.18, this function simply returns
/// the return value of [func@GLib.unichar_get_script]. Callers must be
/// prepared to handle unknown values.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// the `PangoScript` for the character.
/// </return>

	public static MentorLake.Pango.PangoScript ScriptForUnichar(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_script_for_unichar(ch);
	}

/// <summary>
/// <para>
/// Finds a language tag that is reasonably representative of @script.
/// </para>
/// <para>
/// The language will usually be the most widely spoken or used language
/// written in that script: for instance, the sample language for
/// %PANGO_SCRIPT_CYRILLIC is ru (Russian), the sample language for
/// %PANGO_SCRIPT_ARABIC is ar.
/// </para>
/// <para>
/// For some scripts, no sample language will be returned because
/// there is no language that is sufficiently representative. The
/// best example of this is %PANGO_SCRIPT_HAN, where various different
/// variants of written Chinese, Japanese, and Korean all use
/// significantly different sets of Han characters and forms
/// of shared characters. No sample language can be provided
/// for many historical scripts as well.
/// </para>
/// <para>
/// As of 1.18, this function checks the environment variables
/// `PANGO_LANGUAGE` and `LANGUAGE` (checked in that order) first.
/// If one of them is set, it is parsed as a list of language tags
/// separated by colons or other separators. This function
/// will return the first language in the parsed list that Pango
/// believes may use @script for writing. This last predicate
/// is tested using [method@Pango.Language.includes_script]. This can
/// be used to control Pango's font selection for non-primary
/// languages. For example, a `PANGO_LANGUAGE` enviroment variable
/// set to "en:fa" makes Pango choose fonts suitable for Persian (fa)
/// instead of Arabic (ar) when a segment of Arabic text is found
/// in an otherwise non-Arabic text. The same trick can be used to
/// choose a default language for %PANGO_SCRIPT_HAN when setting
/// context language is not feasible.
/// </para>
/// </summary>

/// <param name="script">
/// a `PangoScript`
/// </param>
/// <return>
/// a `PangoLanguage` that is representative
///   of the script
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle ScriptGetSampleLanguage(MentorLake.Pango.PangoScript script)
	{
		return PangoGlobalFunctionsExterns.pango_script_get_sample_language(script);
	}

/// <summary>
/// <para>
/// Convert the characters in @text into glyphs.
/// </para>
/// <para>
/// Given a segment of text and the corresponding `PangoAnalysis` structure
/// returned from [func@Pango.itemize], convert the characters into glyphs. You
/// may also pass in only a substring of the item from [func@Pango.itemize].
/// </para>
/// <para>
/// It is recommended that you use [func@Pango.shape_full] instead, since
/// that API allows for shaping interaction happening across text item
/// boundaries.
/// </para>
/// <para>
/// Some aspects of hyphen insertion and text transformation (in particular,
/// capitalization) require log attrs, and thus can only be handled by
/// [func@Pango.shape_item].
/// </para>
/// <para>
/// Note that the extra attributes in the @analyis that is returned from
/// [func@Pango.itemize] have indices that are relative to the entire paragraph,
/// so you need to subtract the item offset from their indices before
/// calling [func@Pango.shape].
/// </para>
/// </summary>

/// <param name="text">
/// the text to process
/// </param>
/// <param name="length">
/// the length (in bytes) of @text
/// </param>
/// <param name="analysis">
/// `PangoAnalysis` structure from [func@Pango.itemize]
/// </param>
/// <param name="glyphs">
/// glyph string in which to store results
/// </param>

	public static void Shape(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoGlobalFunctionsExterns.pango_shape(text, length, analysis, glyphs);
	}

/// <summary>
/// <para>
/// Convert the characters in @text into glyphs.
/// </para>
/// <para>
/// Given a segment of text and the corresponding `PangoAnalysis` structure
/// returned from [func@Pango.itemize], convert the characters into glyphs.
/// You may also pass in only a substring of the item from [func@Pango.itemize].
/// </para>
/// <para>
/// This is similar to [func@Pango.shape], except it also can optionally take
/// the full paragraph text as input, which will then be used to perform
/// certain cross-item shaping interactions. If you have access to the broader
/// text of which @item_text is part of, provide the broader text as
/// @paragraph_text. If @paragraph_text is %NULL, item text is used instead.
/// </para>
/// <para>
/// Some aspects of hyphen insertion and text transformation (in particular,
/// capitalization) require log attrs, and thus can only be handled by
/// [func@Pango.shape_item].
/// </para>
/// <para>
/// Note that the extra attributes in the @analyis that is returned from
/// [func@Pango.itemize] have indices that are relative to the entire paragraph,
/// so you do not pass the full paragraph text as @paragraph_text, you need
/// to subtract the item offset from their indices before calling
/// [func@Pango.shape_full].
/// </para>
/// </summary>

/// <param name="item_text">
/// valid UTF-8 text to shape.
/// </param>
/// <param name="item_length">
/// the length (in bytes) of @item_text. -1 means nul-terminated text.
/// </param>
/// <param name="paragraph_text">
/// text of the paragraph (see details).
/// </param>
/// <param name="paragraph_length">
/// the length (in bytes) of @paragraph_text. -1 means nul-terminated text.
/// </param>
/// <param name="analysis">
/// `PangoAnalysis` structure from [func@Pango.itemize].
/// </param>
/// <param name="glyphs">
/// glyph string in which to store results.
/// </param>

	public static void ShapeFull(string item_text, int item_length, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoGlobalFunctionsExterns.pango_shape_full(item_text, item_length, paragraph_text, paragraph_length, analysis, glyphs);
	}

/// <summary>
/// <para>
/// Convert the characters in @item into glyphs.
/// </para>
/// <para>
/// This is similar to [func@Pango.shape_with_flags], except it takes a
/// `PangoItem` instead of separate @item_text and @analysis arguments.
/// </para>
/// <para>
/// It also takes @log_attrs, which are needed for implementing some aspects
/// of hyphen insertion and text transforms (in particular, capitalization).
/// </para>
/// <para>
/// Note that the extra attributes in the @analyis that is returned from
/// [func@Pango.itemize] have indices that are relative to the entire paragraph,
/// so you do not pass the full paragraph text as @paragraph_text, you need
/// to subtract the item offset from their indices before calling
/// [func@Pango.shape_with_flags].
/// </para>
/// </summary>

/// <param name="item">
/// `PangoItem` to shape
/// </param>
/// <param name="paragraph_text">
/// text of the paragraph (see details).
/// </param>
/// <param name="paragraph_length">
/// the length (in bytes) of @paragraph_text.
///     -1 means nul-terminated text.
/// </param>
/// <param name="log_attrs">
/// array of `PangoLogAttr` for @item
/// </param>
/// <param name="glyphs">
/// glyph string in which to store results
/// </param>
/// <param name="flags">
/// flags influencing the shaping process
/// </param>

	public static void ShapeItem(MentorLake.Pango.PangoItemHandle item, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoLogAttrHandle log_attrs, MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags)
	{
		PangoGlobalFunctionsExterns.pango_shape_item(item, paragraph_text, paragraph_length, log_attrs, glyphs, flags);
	}

/// <summary>
/// <para>
/// Convert the characters in @text into glyphs.
/// </para>
/// <para>
/// Given a segment of text and the corresponding `PangoAnalysis` structure
/// returned from [func@Pango.itemize], convert the characters into glyphs.
/// You may also pass in only a substring of the item from [func@Pango.itemize].
/// </para>
/// <para>
/// This is similar to [func@Pango.shape_full], except it also takes flags
/// that can influence the shaping process.
/// </para>
/// <para>
/// Some aspects of hyphen insertion and text transformation (in particular,
/// capitalization) require log attrs, and thus can only be handled by
/// [func@Pango.shape_item].
/// </para>
/// <para>
/// Note that the extra attributes in the @analyis that is returned from
/// [func@Pango.itemize] have indices that are relative to the entire paragraph,
/// so you do not pass the full paragraph text as @paragraph_text, you need
/// to subtract the item offset from their indices before calling
/// [func@Pango.shape_with_flags].
/// </para>
/// </summary>

/// <param name="item_text">
/// valid UTF-8 text to shape
/// </param>
/// <param name="item_length">
/// the length (in bytes) of @item_text.
///     -1 means nul-terminated text.
/// </param>
/// <param name="paragraph_text">
/// text of the paragraph (see details).
/// </param>
/// <param name="paragraph_length">
/// the length (in bytes) of @paragraph_text.
///     -1 means nul-terminated text.
/// </param>
/// <param name="analysis">
/// `PangoAnalysis` structure from [func@Pango.itemize]
/// </param>
/// <param name="glyphs">
/// glyph string in which to store results
/// </param>
/// <param name="flags">
/// flags influencing the shaping process
/// </param>

	public static void ShapeWithFlags(string item_text, int item_length, string paragraph_text, int paragraph_length, MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags)
	{
		PangoGlobalFunctionsExterns.pango_shape_with_flags(item_text, item_length, paragraph_text, paragraph_length, analysis, glyphs, flags);
	}

/// <summary>
/// <para>
/// Skips 0 or more characters of white space.
/// </para>
/// </summary>

/// <param name="pos">
/// in/out string position
/// </param>
/// <return>
/// %FALSE if skipping the white space leaves
///   the position at a '\0' character.
/// </return>

	public static bool SkipSpace(ref string pos)
	{
		return PangoGlobalFunctionsExterns.pango_skip_space(ref pos);
	}

/// <summary>
/// <para>
/// Splits a %G_SEARCHPATH_SEPARATOR-separated list of files, stripping
/// white space and substituting ~/ with $HOME/.
/// </para>
/// </summary>

/// <param name="str">
/// a %G_SEARCHPATH_SEPARATOR separated list of filenames
/// </param>
/// <return>
/// a list of
///   strings to be freed with g_strfreev()
/// </return>

	public static string[] SplitFileList(string str)
	{
		return PangoGlobalFunctionsExterns.pango_split_file_list(str);
	}

/// <summary>
/// <para>
/// Deserializes a `PangoTabArray` from a string.
/// </para>
/// <para>
/// This is the counterpart to [method@Pango.TabArray.to_string].
/// See that functions for details about the format.
/// </para>
/// </summary>

/// <param name="text">
/// a string
/// </param>
/// <return>
/// a new `PangoTabArray`
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle TabArrayFromString(string text)
	{
		return PangoGlobalFunctionsExterns.pango_tab_array_from_string(text);
	}

/// <summary>
/// <para>
/// Apply language-specific tailoring to the breaks in @attrs.
/// </para>
/// <para>
/// The line breaks are assumed to have been produced by [func@Pango.default_break].
/// </para>
/// <para>
/// If @offset is not -1, it is used to apply attributes from @analysis that are
/// relevant to line breaking.
/// </para>
/// <para>
/// Note that it is better to pass -1 for @offset and use [func@Pango.attr_break]
/// to apply attributes to the whole paragraph.
/// </para>
/// </summary>

/// <param name="text">
/// text to process. Must be valid UTF-8
/// </param>
/// <param name="length">
/// length in bytes of @text
/// </param>
/// <param name="analysis">
/// `PangoAnalysis` for @text
/// </param>
/// <param name="offset">
/// Byte offset of @text from the beginning of the
///   paragraph, or -1 to ignore attributes from @analysis
/// </param>
/// <param name="attrs">
/// array with one `PangoLogAttr`
///   per character in @text, plus one extra, to be filled in
/// </param>
/// <param name="attrs_len">
/// length of @attrs array
/// </param>

	public static void TailorBreak(string text, int length, MentorLake.Pango.PangoAnalysisHandle analysis, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len)
	{
		PangoGlobalFunctionsExterns.pango_tailor_break(text, length, analysis, offset, attrs, attrs_len);
	}

/// <summary>
/// <para>
/// Trims leading and trailing whitespace from a string.
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <return>
/// A newly-allocated string that must be freed with g_free()
/// </return>

	public static string TrimString(string str)
	{
		return PangoGlobalFunctionsExterns.pango_trim_string(str);
	}

/// <summary>
/// <para>
/// Determines the inherent direction of a character.
/// </para>
/// <para>
/// The inherent direction is either `PANGO_DIRECTION_LTR`, `PANGO_DIRECTION_RTL`,
/// or `PANGO_DIRECTION_NEUTRAL`.
/// </para>
/// <para>
/// This function is useful to categorize characters into left-to-right
/// letters, right-to-left letters, and everything else. If full Unicode
/// bidirectional type of a character is needed, [func@Pango.BidiType.for_unichar]
/// can be used instead.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// the direction of the character.
/// </return>

	public static MentorLake.Pango.PangoDirection UnicharDirection(char ch)
	{
		return PangoGlobalFunctionsExterns.pango_unichar_direction(ch);
	}

/// <summary>
/// <para>
/// Converts a floating-point number to Pango units.
/// </para>
/// <para>
/// The conversion is done by multiplying @d by %PANGO_SCALE and
/// rounding the result to nearest integer.
/// </para>
/// </summary>

/// <param name="d">
/// double floating-point value
/// </param>
/// <return>
/// the value in Pango units.
/// </return>

	public static int UnitsFromDouble(double d)
	{
		return PangoGlobalFunctionsExterns.pango_units_from_double(d);
	}

/// <summary>
/// <para>
/// Converts a number in Pango units to floating-point.
/// </para>
/// <para>
/// The conversion is done by dividing @i by %PANGO_SCALE.
/// </para>
/// </summary>

/// <param name="i">
/// value in Pango units
/// </param>
/// <return>
/// the double value.
/// </return>

	public static double UnitsToDouble(int i)
	{
		return PangoGlobalFunctionsExterns.pango_units_to_double(i);
	}

/// <summary>
/// <para>
/// Returns the encoded version of Pango available at run-time.
/// </para>
/// <para>
/// This is similar to the macro %PANGO_VERSION except that the macro
/// returns the encoded version available at compile-time. A version
/// number can be encoded into an integer using PANGO_VERSION_ENCODE().
/// </para>
/// </summary>

/// <return>
/// The encoded version of Pango library available at run time.
/// </return>

	public static int Version()
	{
		return PangoGlobalFunctionsExterns.pango_version();
	}

/// <summary>
/// <para>
/// Checks that the Pango library in use is compatible with the
/// given version.
/// </para>
/// <para>
/// Generally you would pass in the constants %PANGO_VERSION_MAJOR,
/// %PANGO_VERSION_MINOR, %PANGO_VERSION_MICRO as the three arguments
/// to this function; that produces a check that the library in use at
/// run-time is compatible with the version of Pango the application or
/// module was compiled against.
/// </para>
/// <para>
/// Compatibility is defined by two things: first the version
/// of the running library is newer than the version
/// @required_major.required_minor.@required_micro. Second
/// the running library must be binary compatible with the
/// version @required_major.required_minor.@required_micro
/// (same major version.)
/// </para>
/// <para>
/// For compile-time version checking use PANGO_VERSION_CHECK().
/// </para>
/// </summary>

/// <param name="required_major">
/// the required major version
/// </param>
/// <param name="required_minor">
/// the required minor version
/// </param>
/// <param name="required_micro">
/// the required major version
/// </param>
/// <return>
/// %NULL if the Pango library is compatible
///   with the given version, or a string describing the version
///   mismatch.  The returned string is owned by Pango and should not
///   be modified or freed.
/// </return>

	public static string VersionCheck(int required_major, int required_minor, int required_micro)
	{
		return PangoGlobalFunctionsExterns.pango_version_check(required_major, required_minor, required_micro);
	}

/// <summary>
/// <para>
/// Returns the version of Pango available at run-time.
/// </para>
/// <para>
/// This is similar to the macro %PANGO_VERSION_STRING except that the
/// macro returns the version available at compile-time.
/// </para>
/// </summary>

/// <return>
/// A string containing the version of Pango library available
///   at run time. The returned string is owned by Pango and should not
///   be modified or freed.
/// </return>

	public static string VersionString()
	{
		return PangoGlobalFunctionsExterns.pango_version_string();
	}

}

internal class PangoGlobalFunctionsExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_allow_breaks_new(bool allow_breaks);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_background_alpha_new(ushort alpha);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_background_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_baseline_shift_new(int shift);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attr_list, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_fallback_new(bool enable_fallback);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_family_new(string family);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_desc_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_features_new(string features);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_font_scale_new(MentorLake.Pango.PangoFontScale scale);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_foreground_alpha_new(ushort alpha);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_foreground_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_gravity_hint_new(MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_gravity_new(MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_insert_hyphens_new(bool insert_hyphens);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_language_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_letter_spacing_new(int letter_spacing);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_line_height_new(double factor);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_line_height_new_absolute(int height);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_attr_list_from_string(string text);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_overline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_overline_new(MentorLake.Pango.PangoOverline overline);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_rise_new(int rise);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_scale_new(double scale_factor);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_sentence_new();

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_shape_new_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle ink_rect, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle logical_rect, IntPtr data, MentorLake.Pango.PangoAttrDataCopyFunc copy_func, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_show_new(MentorLake.Pango.PangoShowFlags flags);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new(int size);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_size_new_absolute(int size);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_stretch_new(MentorLake.Pango.PangoStretch stretch);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_strikethrough_new(bool strikethrough);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_style_new(MentorLake.Pango.PangoStyle style);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_text_transform_new(MentorLake.Pango.PangoTextTransform transform);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_attr_type_get_name(MentorLake.Pango.PangoAttrType type);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrType pango_attr_type_register(string name);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_underline_color_new(ushort red, ushort green, ushort blue);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_underline_new(MentorLake.Pango.PangoUnderline underline);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_variant_new(MentorLake.Pango.PangoVariant variant);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_weight_new(MentorLake.Pango.PangoWeight weight);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_word_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoBidiType pango_bidi_type_for_unichar(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_default_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLogAttrHandle>))] MentorLake.Pango.PangoLogAttrHandle attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_extents_to_pixels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle inclusive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRectangleHandle>))] MentorLake.Pango.PangoRectangleHandle nearest);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_find_base_dir(string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_find_paragraph_boundary(string text, int length, out int paragraph_delimiter_index, out int next_paragraph_start);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_from_string(string str);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_get_log_attrs(string text, int length, int level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_get_mirror_char(char ch, char mirrored_ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_script(MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_gravity_get_for_script_and_width(MentorLake.Pango.PangoScript script, bool wide, MentorLake.Pango.PangoGravity base_gravity, MentorLake.Pango.PangoGravityHint hint);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_gravity_to_rotation(MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_is_zero_width(char ch);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle pango_itemize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, string text, int start_index, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle cached_iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle pango_itemize_with_base_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoDirection base_dir, string text, int start_index, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle cached_iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_from_string(string language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_get_default();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_language_get_preferred();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark pango_layout_deserialize_error_quark();

	[DllImport(PangoLibrary.Name)]
	internal static extern byte pango_log2vis_get_embedding_levels(string text, int length, ref MentorLake.Pango.PangoDirection pbase_dir);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_markup_parser_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle pango_markup_parser_new(char accel_marker);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_enum(MentorLake.GObject.GType type, string str, out int value, bool warn, out string possible_values);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_markup(string markup_text, int length, char accel_marker, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] out MentorLake.Pango.PangoAttrListHandle attr_list, out string text, out char accel_char, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_stretch(string str, out MentorLake.Pango.PangoStretch stretch, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_style(string str, out MentorLake.Pango.PangoStyle style, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_variant(string str, out MentorLake.Pango.PangoVariant variant, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_parse_weight(string str, out MentorLake.Pango.PangoWeight weight, bool warn);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_quantize_line_geometry(ref int thickness, ref int position);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_read_line(IntPtr stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle str);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle pango_reorder_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle items);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_int(ref string pos, out int @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_string(ref string pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_scan_word(ref string pos, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @out);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoScript pango_script_for_unichar(char ch);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_script_get_sample_language(MentorLake.Pango.PangoScript script);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLogAttrHandle>))] MentorLake.Pango.PangoLogAttrHandle log_attrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_shape_with_flags(string item_text, int item_length, string paragraph_text, int paragraph_length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, MentorLake.Pango.PangoShapeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_skip_space(ref string pos);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] pango_split_file_list(string str);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_tab_array_from_string(string text);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_tailor_break(string text, int length, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAnalysisHandle>))] MentorLake.Pango.PangoAnalysisHandle analysis, int offset, MentorLake.Pango.PangoLogAttr[] attrs, int attrs_len);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_trim_string(string str);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_unichar_direction(char ch);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_units_from_double(double d);

	[DllImport(PangoLibrary.Name)]
	internal static extern double pango_units_to_double(int i);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_version();

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_check(int required_major, int required_minor, int required_micro);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_version_string();

}
