namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The `PangoOTRuleset` structure holds a set of features selected
/// from the tables in an OpenType font.
/// </para>
/// <para>
/// A feature is an operation such as adjusting glyph positioning
/// that should be applied to a text feature such as a certain
/// type of accent.
/// </para>
/// <para>
/// A `PangoOTRuleset` is created with [ctor@PangoOT.Ruleset.new],
/// features are added to it with [method@PangoOT.Ruleset.add_feature],
/// then it is applied to a `PangoGlyphString` with
/// [method@PangoOT.Ruleset.position].
/// </para>
/// </summary>

public class PangoOTRulesetHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new `PangoOTRuleset` for the given OpenType info.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <return>
/// the newly allocated `PangoOTRuleset`
/// </return>

	public static MentorLake.PangoOT.PangoOTRulesetHandle New(MentorLake.PangoOT.PangoOTInfoHandle info)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new(info);
	}

/// <summary>
/// <para>
/// Creates a new `PangoOTRuleset` for the given OpenType info, script, and
/// language.
/// </para>
/// <para>
/// This function is part of a convenience scheme that highly simplifies
/// using a `PangoOTRuleset` to represent features for a specific pair of script
/// and language.  So one can use this function passing in the script and
/// language of interest, and later try to add features to the ruleset by just
/// specifying the feature name or tag, without having to deal with finding
/// script, language, or feature indices manually.
/// </para>
/// <para>
/// In addition to what [ctor@PangoOT.Ruleset.new] does, this function will:
/// </para>
/// <para>
/// * Find the `PangoOTTag` script and language tags associated with
///   @script and @language using [func@PangoOT.tag_from_script] and
///   [func@PangoOT.tag_from_language],
/// </para>
/// <para>
/// * For each of table types %PANGO_OT_TABLE_GSUB and %PANGO_OT_TABLE_GPOS,
///   find the script index of the script tag found and the language
///   system index of the language tag found in that script system, using
///   [method@PangoOT.Info.find_script] and [method@PangoOT.Info.find_language],
/// </para>
/// <para>
/// * For found language-systems, if they have required feature index,
///   add that feature to the ruleset using [method@PangoOT.Ruleset.add_feature],
/// </para>
/// <para>
/// * Remember found script and language indices for both table types,
///   and use them in future [method@PangoOT.Ruleset.maybe_add_feature] and
///   [method@PangoOT.Ruleset.maybe_add_features].
/// </para>
/// <para>
/// Because of the way return values of [method@PangoOT.Info.find_script] and
/// [method@PangoOT.Info.find_language] are ignored, this function automatically
/// finds and uses the 'DFLT' script and the default language-system.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="script">
/// a `PangoScript`
/// </param>
/// <param name="language">
/// a `PangoLanguage`
/// </param>
/// <return>
/// the newly allocated `PangoOTRuleset`
/// </return>

	public static MentorLake.PangoOT.PangoOTRulesetHandle NewFor(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new_for(info, script, language);
	}

/// <summary>
/// <para>
/// Creates a new `PangoOTRuleset` for the given OpenType info and
/// matching the given ruleset description.
/// </para>
/// <para>
/// This is a convenience function that calls [ctor@PangoOT.Ruleset.new_for]
/// and adds the static GSUB/GPOS features to the resulting ruleset,
/// followed by adding other features to both GSUB and GPOS.
/// </para>
/// <para>
/// The static feature map members of @desc should be alive as
/// long as @info is.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="desc">
/// a `PangoOTRulesetDescription`
/// </param>
/// <return>
/// the newly allocated `PangoOTRuleset`
/// </return>

	public static MentorLake.PangoOT.PangoOTRulesetHandle NewFromDescription(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new_from_description(info, desc);
	}

/// <summary>
/// <para>
/// Returns a ruleset for the given OpenType info and ruleset
/// description.
/// </para>
/// <para>
/// Rulesets are created on demand using
/// [ctor@PangoOT.Ruleset.new_from_description].
/// The returned ruleset should not be modified or destroyed.
/// </para>
/// <para>
/// The static feature map members of @desc should be alive as
/// long as @info is.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="desc">
/// a `PangoOTRulesetDescription`
/// </param>
/// <return>
/// the `PangoOTRuleset` for @desc. This object will have
///   the same lifetime as @info.
/// </return>

	public static MentorLake.PangoOT.PangoOTRulesetHandle GetForDescription(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_get_for_description(info, desc);
	}

}

public static class PangoOTRulesetHandleExtensions
{
/// <summary>
/// <para>
/// Adds a feature to the ruleset.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="table_type">
/// the table type to add a feature to
/// </param>
/// <param name="feature_index">
/// the index of the feature to add
/// </param>
/// <param name="property_bit">
/// the property bit to use for this feature. Used to
///   identify the glyphs that this feature should be applied to, or
///   %PANGO_OT_ALL_GLYPHS if it should be applied to all glyphs.
/// </param>

	public static T AddFeature<T>(this T ruleset, MentorLake.PangoOT.PangoOTTableType table_type, uint feature_index, ulong property_bit) where T : PangoOTRulesetHandle
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		PangoOTRulesetHandleExterns.pango_ot_ruleset_add_feature(ruleset, table_type, feature_index, property_bit);
		return ruleset;
	}

/// <summary>
/// <para>
/// Gets the number of GSUB and GPOS features in the ruleset.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="n_gsub_features">
/// location to store number of GSUB features
/// </param>
/// <param name="n_gpos_features">
/// location to store number of GPOS features
/// </param>
/// <return>
/// Total number of features in the @ruleset
/// </return>

	public static uint GetFeatureCount(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, out uint n_gsub_features, out uint n_gpos_features)
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_get_feature_count(ruleset, out n_gsub_features, out n_gpos_features);
	}

/// <summary>
/// <para>
/// This is a convenience function that first tries to find the feature
/// using [method@PangoOT.Info.find_feature] and the ruleset script and
/// language passed to [ctor@PangoOT.Ruleset.new_for] and if the feature
/// is found, adds it to the ruleset.
/// </para>
/// <para>
/// If @ruleset was not created using [ctor@PangoOT.Ruleset.new_for],
/// this function does nothing.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="table_type">
/// the table type to add a feature to
/// </param>
/// <param name="feature_tag">
/// the tag of the feature to add
/// </param>
/// <param name="property_bit">
/// the property bit to use for this feature. Used to
///   identify the glyphs that this feature should be applied to, or
///   %PANGO_OT_ALL_GLYPHS if it should be applied to all glyphs.
/// </param>
/// <return>
/// %TRUE if the feature was found and added to ruleset,
///   %FALSE otherwise
/// </return>

	public static bool MaybeAddFeature(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, ulong property_bit)
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_maybe_add_feature(ruleset, table_type, feature_tag, property_bit);
	}

/// <summary>
/// <para>
/// This is a convenience function that for each feature in the feature map
/// array @features converts the feature name to a `PangoOTTag` feature tag
/// using PANGO_OT_TAG_MAKE() and calls [method@PangoOT.Ruleset.maybe_add_feature]
/// on it.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="table_type">
/// the table type to add features to
/// </param>
/// <param name="features">
/// array of feature name and property bits to add
/// </param>
/// <param name="n_features">
/// number of feature records in @features array
/// </param>
/// <return>
/// The number of features in @features that were found
///   and added to @ruleset
/// </return>

	public static uint MaybeAddFeatures(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTFeatureMapHandle features, uint n_features)
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_maybe_add_features(ruleset, table_type, features, n_features);
	}

/// <summary>
/// <para>
/// Performs the OpenType GPOS positioning on @buffer using
/// the features in @ruleset.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>

	public static T Position<T>(this T ruleset, MentorLake.PangoOT.PangoOTBufferHandle buffer) where T : PangoOTRulesetHandle
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		PangoOTRulesetHandleExterns.pango_ot_ruleset_position(ruleset, buffer);
		return ruleset;
	}

/// <summary>
/// <para>
/// Performs the OpenType GSUB substitution on @buffer using
/// the features in @ruleset.
/// </para>
/// </summary>

/// <param name="ruleset">
/// a `PangoOTRuleset`
/// </param>
/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>

	public static T Substitute<T>(this T ruleset, MentorLake.PangoOT.PangoOTBufferHandle buffer) where T : PangoOTRulesetHandle
	{
		if (ruleset.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetHandle)");
		PangoOTRulesetHandleExterns.pango_ot_ruleset_substitute(ruleset, buffer);
		return ruleset;
	}

}

internal class PangoOTRulesetHandleExterns
{
	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_new_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.Pango.PangoScript script, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_new_from_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_ruleset_add_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, uint feature_index, ulong property_bit);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern uint pango_ot_ruleset_get_feature_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, out uint n_gsub_features, out uint n_gpos_features);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_ruleset_maybe_add_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, ulong property_bit);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern uint pango_ot_ruleset_maybe_add_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTFeatureMapHandle>))] MentorLake.PangoOT.PangoOTFeatureMapHandle features, uint n_features);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_ruleset_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_ruleset_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))] MentorLake.PangoOT.PangoOTRulesetHandle ruleset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_get_for_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

}
