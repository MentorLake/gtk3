namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontDescription` describes a font in an implementation-independent
/// manner.
/// </para>
/// <para>
/// `PangoFontDescription` structures are used both to list what fonts are
/// available on the system and also for specifying the characteristics of
/// a font to load.
/// </para>
/// </summary>

public class PangoFontDescriptionHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new font description structure with all fields unset.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoFontDescription`,
///   which should be freed using [method@Pango.FontDescription.free].
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle New()
	{
		return PangoFontDescriptionExterns.pango_font_description_new();
	}

}


public static class PangoFontDescriptionExtensions
{
/// <summary>
/// <para>
/// Determines if the style attributes of @new_match are a closer match
/// for @desc than those of @old_match are, or if @old_match is %NULL,
/// determines if @new_match is a match at all.
/// </para>
/// <para>
/// Approximate matching is done for weight and style; other style attributes
/// must match exactly. Style attributes are all attributes other than family
/// and size-related attributes. Approximate matching for style considers
/// %PANGO_STYLE_OBLIQUE and %PANGO_STYLE_ITALIC as matches, but not as good
/// a match as when the styles are equal.
/// </para>
/// <para>
/// Note that @old_match must match @desc.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="old_match">
/// a `PangoFontDescription`, or %NULL
/// </param>
/// <param name="new_match">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// %TRUE if @new_match is a better match
/// </return>

	public static bool BetterMatch(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle old_match, MentorLake.Pango.PangoFontDescriptionHandle new_match)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_better_match(desc, old_match, new_match);
	}

/// <summary>
/// <para>
/// Make a copy of a `PangoFontDescription`.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`, may be %NULL
/// </param>
/// <return>
/// the newly allocated `PangoFontDescription`,
///   which should be freed with [method@Pango.FontDescription.free],
///   or %NULL if @desc was %NULL.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle Copy(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_copy(desc);
	}

/// <summary>
/// <para>
/// Make a copy of a `PangoFontDescription`, but don't duplicate
/// allocated fields.
/// </para>
/// <para>
/// This is like [method@Pango.FontDescription.copy], but only a shallow
/// copy is made of the family name and other allocated fields. The result
/// can only be used until @desc is modified or freed. This is meant
/// to be used when the copy is only needed temporarily.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`, may be %NULL
/// </param>
/// <return>
/// the newly allocated `PangoFontDescription`,
///   which should be freed with [method@Pango.FontDescription.free],
///   or %NULL if @desc was %NULL.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle CopyStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_copy_static(desc);
	}

/// <summary>
/// <para>
/// Compares two font descriptions for equality.
/// </para>
/// <para>
/// Two font descriptions are considered equal if the fonts they describe
/// are provably identical. This means that their masks do not have to match,
/// as long as other fields are all the same. (Two font descriptions may
/// result in identical fonts being loaded, but still compare %FALSE.)
/// </para>
/// </summary>

/// <param name="desc1">
/// a `PangoFontDescription`
/// </param>
/// <param name="desc2">
/// another `PangoFontDescription`
/// </param>
/// <return>
/// %TRUE if the two font descriptions are identical,
///   %FALSE otherwise.
/// </return>

	public static bool Equal(this MentorLake.Pango.PangoFontDescriptionHandle desc1, MentorLake.Pango.PangoFontDescriptionHandle desc2)
	{
		if (desc1.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_equal(desc1, desc2);
	}

/// <summary>
/// <para>
/// Frees a font description.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`, may be %NULL
/// </param>

	public static void Free(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_free(desc);
	}

/// <summary>
/// <para>
/// Gets the family name field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_family].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <return>
/// the family name field for the
///   font description, or %NULL if not previously set. This has the same
///   life-time as the font description itself and should not be freed.
/// </return>

	public static string GetFamily(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_family(desc);
	}

/// <summary>
/// <para>
/// Gets the features field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_features].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the features field for the font
///   description, or %NULL if not previously set. This has the same
///   life-time as the font description itself and should not be freed.
/// </return>

	public static string GetFeatures(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_features(desc);
	}

/// <summary>
/// <para>
/// Gets the gravity field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_gravity].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the gravity field for the font description.
///   Use [method@Pango.FontDescription.get_set_fields] to find out
///   if the field was explicitly set or not.
/// </return>

	public static MentorLake.Pango.PangoGravity GetGravity(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_gravity(desc);
	}

/// <summary>
/// <para>
/// Determines which fields in a font description have been set.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// a bitmask with bits set corresponding to the
///   fields in @desc that have been set.
/// </return>

	public static MentorLake.Pango.PangoFontMask GetSetFields(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_set_fields(desc);
	}

/// <summary>
/// <para>
/// Gets the size field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_size].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the size field for the font description in points
///   or device units. You must call
///   [method@Pango.FontDescription.get_size_is_absolute] to find out
///   which is the case. Returns 0 if the size field has not previously
///   been set or it has been set to 0 explicitly.
///   Use [method@Pango.FontDescription.get_set_fields] to find out
///   if the field was explicitly set or not.
/// </return>

	public static int GetSize(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_size(desc);
	}

/// <summary>
/// <para>
/// Determines whether the size of the font is in points (not absolute)
/// or device units (absolute).
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_size]
/// and [method@Pango.FontDescription.set_absolute_size].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// whether the size for the font description is in
///   points or device units. Use [method@Pango.FontDescription.get_set_fields]
///   to find out if the size field of the font description was explicitly
///   set or not.
/// </return>

	public static bool GetSizeIsAbsolute(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_size_is_absolute(desc);
	}

/// <summary>
/// <para>
/// Gets the stretch field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_stretch].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <return>
/// the stretch field for the font description.
///   Use [method@Pango.FontDescription.get_set_fields] to find
///   out if the field was explicitly set or not.
/// </return>

	public static MentorLake.Pango.PangoStretch GetStretch(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_stretch(desc);
	}

/// <summary>
/// <para>
/// Gets the style field of a `PangoFontDescription`.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_style].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the style field for the font description.
///   Use [method@Pango.FontDescription.get_set_fields] to
///   find out if the field was explicitly set or not.
/// </return>

	public static MentorLake.Pango.PangoStyle GetStyle(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_style(desc);
	}

/// <summary>
/// <para>
/// Gets the variant field of a `PangoFontDescription`.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_variant].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <return>
/// the variant field for the font description.
///   Use [method@Pango.FontDescription.get_set_fields] to find
///   out if the field was explicitly set or not.
/// </return>

	public static MentorLake.Pango.PangoVariant GetVariant(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_variant(desc);
	}

/// <summary>
/// <para>
/// Gets the variations field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_variations].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the variations field for the font
///   description, or %NULL if not previously set. This has the same
///   life-time as the font description itself and should not be freed.
/// </return>

	public static string GetVariations(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_variations(desc);
	}

/// <summary>
/// <para>
/// Gets the weight field of a font description.
/// </para>
/// <para>
/// See [method@Pango.FontDescription.set_weight].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the weight field for the font description.
///   Use [method@Pango.FontDescription.get_set_fields] to find
///   out if the field was explicitly set or not.
/// </return>

	public static MentorLake.Pango.PangoWeight GetWeight(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_get_weight(desc);
	}

/// <summary>
/// <para>
/// Computes a hash of a `PangoFontDescription` structure.
/// </para>
/// <para>
/// This is suitable to be used, for example, as an argument
/// to g_hash_table_new(). The hash value is independent of @desc->mask.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// the hash value.
/// </return>

	public static uint Hash(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_hash(desc);
	}

/// <summary>
/// <para>
/// Merges the fields that are set in @desc_to_merge into the fields in
/// @desc.
/// </para>
/// <para>
/// If @replace_existing is %FALSE, only fields in @desc that
/// are not already set are affected. If %TRUE, then fields that are
/// already set will be replaced as well.
/// </para>
/// <para>
/// If @desc_to_merge is %NULL, this function performs nothing.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="desc_to_merge">
/// the `PangoFontDescription` to merge from,
///   or %NULL
/// </param>
/// <param name="replace_existing">
/// if %TRUE, replace fields in @desc with the
///   corresponding values from @desc_to_merge, even if they
///   are already exist.
/// </param>

	public static void Merge(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_merge(desc, desc_to_merge, replace_existing);
	}

/// <summary>
/// <para>
/// Merges the fields that are set in @desc_to_merge into the fields in
/// @desc, without copying allocated fields.
/// </para>
/// <para>
/// This is like [method@Pango.FontDescription.merge], but only a shallow copy
/// is made of the family name and other allocated fields. @desc can only
/// be used until @desc_to_merge is modified or freed. This is meant to
/// be used when the merged font description is only needed temporarily.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="desc_to_merge">
/// the `PangoFontDescription` to merge from
/// </param>
/// <param name="replace_existing">
/// if %TRUE, replace fields in @desc with the
///   corresponding values from @desc_to_merge, even if they
///   are already exist.
/// </param>

	public static void MergeStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_merge_static(desc, desc_to_merge, replace_existing);
	}

/// <summary>
/// <para>
/// Sets the size field of a font description, in device units.
/// </para>
/// <para>
/// This is mutually exclusive with [method@Pango.FontDescription.set_size]
/// which sets the font size in points.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="size">
/// the new size, in Pango units. There are %PANGO_SCALE Pango units
///   in one device unit. For an output backend where a device unit is a pixel,
///   a @size value of 10 * PANGO_SCALE gives a 10 pixel font.
/// </param>

	public static void SetAbsoluteSize(this MentorLake.Pango.PangoFontDescriptionHandle desc, double size)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_absolute_size(desc, size);
	}

/// <summary>
/// <para>
/// Sets the family name field of a font description.
/// </para>
/// <para>
/// The family
/// name represents a family of related font styles, and will
/// resolve to a particular `PangoFontFamily`. In some uses of
/// `PangoFontDescription`, it is also possible to use a comma
/// separated list of family names for this field.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <param name="family">
/// a string representing the family name.
/// </param>

	public static void SetFamily(this MentorLake.Pango.PangoFontDescriptionHandle desc, string family)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_family(desc, family);
	}

/// <summary>
/// <para>
/// Sets the family name field of a font description, without copying the string.
/// </para>
/// <para>
/// This is like [method@Pango.FontDescription.set_family], except that no
/// copy of @family is made. The caller must make sure that the
/// string passed in stays around until @desc has been freed or the
/// name is set again. This function can be used if @family is a static
/// string such as a C string literal, or if @desc is only needed temporarily.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="family">
/// a string representing the family name
/// </param>

	public static void SetFamilyStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string family)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_family_static(desc, family);
	}

/// <summary>
/// <para>
/// Sets the features field of a font description.
/// </para>
/// <para>
/// OpenType font features allow to enable or disable certain optional
/// features of a font, such as tabular numbers.
/// </para>
/// <para>
/// The format of the features string is comma-separated list of
/// feature assignments, with each assignment being one of these forms:
/// </para>
/// <para>
///     FEATURE=n
/// </para>
/// <para>
/// where FEATURE must be a 4 character tag that identifies and OpenType
/// feature, and n an integer (depending on the feature, the allowed
/// values may be 0, 1 or bigger numbers). Unknown features are ignored.
/// </para>
/// <para>
/// Note that font features set in this way are enabled for the entire text
/// that is using the font, which is not appropriate for all OpenType features.
/// The intended use case is to select character variations (features cv01 - c99),
/// style sets (ss01 - ss20) and the like.
/// </para>
/// <para>
/// Pango does not currently have a way to find supported OpenType features
/// of a font. Both harfbuzz and freetype have API for this. See for example
/// [hb_ot_layout_table_get_feature_tags](https://harfbuzz.github.io/harfbuzz-hb-ot-layout.html#hb-ot-layout-table-get-feature-tags).
/// </para>
/// <para>
/// Features that are not supported by the font are silently ignored.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <param name="features">
/// a string representing the features
/// </param>

	public static void SetFeatures(this MentorLake.Pango.PangoFontDescriptionHandle desc, string features)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_features(desc, features);
	}

/// <summary>
/// <para>
/// Sets the features field of a font description.
/// </para>
/// <para>
/// This is like [method@Pango.FontDescription.set_features], except
/// that no copy of @featuresis made. The caller must make sure that
/// the string passed in stays around until @desc has been freed
/// or the name is set again. This function can be used if
/// @features is a static string such as a C string literal,
/// or if @desc is only needed temporarily.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="features">
/// a string representing the features
/// </param>

	public static void SetFeaturesStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string features)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_features_static(desc, features);
	}

/// <summary>
/// <para>
/// Sets the gravity field of a font description.
/// </para>
/// <para>
/// The gravity field
/// specifies how the glyphs should be rotated. If @gravity is
/// %PANGO_GRAVITY_AUTO, this actually unsets the gravity mask on
/// the font description.
/// </para>
/// <para>
/// This function is seldom useful to the user. Gravity should normally
/// be set on a `PangoContext`.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="gravity">
/// the gravity for the font description.
/// </param>

	public static void SetGravity(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoGravity gravity)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_gravity(desc, gravity);
	}

/// <summary>
/// <para>
/// Sets the size field of a font description in fractional points.
/// </para>
/// <para>
/// This is mutually exclusive with
/// [method@Pango.FontDescription.set_absolute_size].
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="size">
/// the size of the font in points, scaled by %PANGO_SCALE.
///   (That is, a @size value of 10 * PANGO_SCALE is a 10 point font.
///   The conversion factor between points and device units depends on
///   system configuration and the output device. For screen display, a
///   logical DPI of 96 is common, in which case a 10 point font corresponds
///   to a 10 * (96 / 72) = 13.3 pixel font.
///   Use [method@Pango.FontDescription.set_absolute_size] if you need
///   a particular size in device units.
/// </param>

	public static void SetSize(this MentorLake.Pango.PangoFontDescriptionHandle desc, int size)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_size(desc, size);
	}

/// <summary>
/// <para>
/// Sets the stretch field of a font description.
/// </para>
/// <para>
/// The [enum@Pango.Stretch] field specifies how narrow or
/// wide the font should be.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="stretch">
/// the stretch for the font description
/// </param>

	public static void SetStretch(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStretch stretch)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_stretch(desc, stretch);
	}

/// <summary>
/// <para>
/// Sets the style field of a `PangoFontDescription`.
/// </para>
/// <para>
/// The [enum@Pango.Style] enumeration describes whether the font is
/// slanted and the manner in which it is slanted; it can be either
/// %PANGO_STYLE_NORMAL, %PANGO_STYLE_ITALIC, or %PANGO_STYLE_OBLIQUE.
/// </para>
/// <para>
/// Most fonts will either have a italic style or an oblique style,
/// but not both, and font matching in Pango will match italic
/// specifications with oblique fonts and vice-versa if an exact
/// match is not found.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="style">
/// the style for the font description
/// </param>

	public static void SetStyle(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStyle style)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_style(desc, style);
	}

/// <summary>
/// <para>
/// Sets the variant field of a font description.
/// </para>
/// <para>
/// The [enum@Pango.Variant] can either be %PANGO_VARIANT_NORMAL
/// or %PANGO_VARIANT_SMALL_CAPS.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="variant">
/// the variant type for the font description.
/// </param>

	public static void SetVariant(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoVariant variant)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_variant(desc, variant);
	}

/// <summary>
/// <para>
/// Sets the variations field of a font description.
/// </para>
/// <para>
/// OpenType font variations allow to select a font instance by
/// specifying values for a number of axes, such as width or weight.
/// </para>
/// <para>
/// The format of the variations string is
/// </para>
/// <para>
///     AXIS1=VALUE,AXIS2=VALUE...
/// </para>
/// <para>
/// with each AXIS a 4 character tag that identifies a font axis,
/// and each VALUE a floating point number. Unknown axes are ignored,
/// and values are clamped to their allowed range.
/// </para>
/// <para>
/// Pango does not currently have a way to find supported axes of
/// a font. Both harfbuzz and freetype have API for this. See
/// for example [hb_ot_var_get_axis_infos](https://harfbuzz.github.io/harfbuzz-hb-ot-var.html#hb-ot-var-get-axis-infos).
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`.
/// </param>
/// <param name="variations">
/// a string representing the variations
/// </param>

	public static void SetVariations(this MentorLake.Pango.PangoFontDescriptionHandle desc, string variations)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_variations(desc, variations);
	}

/// <summary>
/// <para>
/// Sets the variations field of a font description.
/// </para>
/// <para>
/// This is like [method@Pango.FontDescription.set_variations], except
/// that no copy of @variations is made. The caller must make sure that
/// the string passed in stays around until @desc has been freed
/// or the name is set again. This function can be used if
/// @variations is a static string such as a C string literal,
/// or if @desc is only needed temporarily.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="variations">
/// a string representing the variations
/// </param>

	public static void SetVariationsStatic(this MentorLake.Pango.PangoFontDescriptionHandle desc, string variations)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_variations_static(desc, variations);
	}

/// <summary>
/// <para>
/// Sets the weight field of a font description.
/// </para>
/// <para>
/// The weight field
/// specifies how bold or light the font should be. In addition
/// to the values of the [enum@Pango.Weight] enumeration, other
/// intermediate numeric values are possible.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="weight">
/// the weight for the font description.
/// </param>

	public static void SetWeight(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoWeight weight)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_set_weight(desc, weight);
	}

/// <summary>
/// <para>
/// Creates a filename representation of a font description.
/// </para>
/// <para>
/// The filename is identical to the result from calling
/// [method@Pango.FontDescription.to_string], but with underscores
/// instead of characters that are untypical in filenames, and in
/// lower case only.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// a new string that must be freed with g_free().
/// </return>

	public static string ToFilename(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_to_filename(desc);
	}

/// <summary>
/// <para>
/// Creates a string representation of a font description.
/// </para>
/// <para>
/// See [func@Pango.FontDescription.from_string] for a description
/// of the format of the string representation. The family list in
/// the string description will only have a terminating comma if
/// the last word of the list is a valid style option.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <return>
/// a new string that must be freed with g_free().
/// </return>

	public static string ToString(this MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		return PangoFontDescriptionExterns.pango_font_description_to_string(desc);
	}

/// <summary>
/// <para>
/// Unsets some of the fields in a `PangoFontDescription`.
/// </para>
/// <para>
/// The unset fields will get back to their default values.
/// </para>
/// </summary>

/// <param name="desc">
/// a `PangoFontDescription`
/// </param>
/// <param name="to_unset">
/// bitmask of fields in the @desc to unset.
/// </param>

	public static void UnsetFields(this MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontMask to_unset)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoFontDescription)");
		PangoFontDescriptionExterns.pango_font_description_unset_fields(desc, to_unset);
	}


	public static PangoFontDescription Dereference(this PangoFontDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontDescription>(x.DangerousGetHandle());
}
internal class PangoFontDescriptionExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_better_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle old_match, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle new_match);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_copy_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc2);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGravity pango_font_description_get_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMask pango_font_description_get_set_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_font_description_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_description_get_size_is_absolute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoStretch pango_font_description_get_stretch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoStyle pango_font_description_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoVariant pango_font_description_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_get_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWeight pango_font_description_get_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_font_description_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_merge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_merge_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc_to_merge, bool replace_existing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_absolute_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, double size);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_family_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string features);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_features_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string features);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoGravity gravity);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, int size);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_stretch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStretch stretch);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoStyle style);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoVariant variant);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string variations);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_variations_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, string variations);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_set_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoWeight weight);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_to_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_description_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_description_unset_fields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoFontMask to_unset);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_description_from_string(string str);

}

/// <summary>
/// <para>
/// A `PangoFontDescription` describes a font in an implementation-independent
/// manner.
/// </para>
/// <para>
/// `PangoFontDescription` structures are used both to list what fonts are
/// available on the system and also for specifying the characteristics of
/// a font to load.
/// </para>
/// </summary>

public struct PangoFontDescription
{
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

	public static MentorLake.Pango.PangoFontDescriptionHandle FromString(string str)
	{
		return PangoFontDescriptionExterns.pango_font_description_from_string(str);
	}

}
