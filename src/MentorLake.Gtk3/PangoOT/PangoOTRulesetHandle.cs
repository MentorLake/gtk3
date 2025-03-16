namespace MentorLake.PangoOT;

public class PangoOTRulesetHandle : GObjectHandle
{
	public static MentorLake.PangoOT.PangoOTRulesetHandle New(MentorLake.PangoOT.PangoOTInfoHandle info)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new(info);
	}

	public static MentorLake.PangoOT.PangoOTRulesetHandle NewFor(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.Pango.PangoScript script, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new_for(info, script, language);
	}

	public static MentorLake.PangoOT.PangoOTRulesetHandle NewFromDescription(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_new_from_description(info, desc);
	}

	public static MentorLake.PangoOT.PangoOTRulesetHandle GetForDescription(MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_get_for_description(info, desc);
	}

}

public static class PangoOTRulesetHandleExtensions
{
	public static T AddFeature<T>(this T ruleset, MentorLake.PangoOT.PangoOTTableType table_type, uint feature_index, ulong property_bit) where T : PangoOTRulesetHandle
	{
		PangoOTRulesetHandleExterns.pango_ot_ruleset_add_feature(ruleset, table_type, feature_index, property_bit);
		return ruleset;
	}

	public static uint GetFeatureCount(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, out uint n_gsub_features, out uint n_gpos_features)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_get_feature_count(ruleset, out n_gsub_features, out n_gpos_features);
	}

	public static bool MaybeAddFeature(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, ulong property_bit)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_maybe_add_feature(ruleset, table_type, feature_tag, property_bit);
	}

	public static uint MaybeAddFeatures(this MentorLake.PangoOT.PangoOTRulesetHandle ruleset, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTFeatureMapHandle features, uint n_features)
	{
		return PangoOTRulesetHandleExterns.pango_ot_ruleset_maybe_add_features(ruleset, table_type, features, n_features);
	}

	public static T Position<T>(this T ruleset, MentorLake.PangoOT.PangoOTBufferHandle buffer) where T : PangoOTRulesetHandle
	{
		PangoOTRulesetHandleExterns.pango_ot_ruleset_position(ruleset, buffer);
		return ruleset;
	}

	public static T Substitute<T>(this T ruleset, MentorLake.PangoOT.PangoOTBufferHandle buffer) where T : PangoOTRulesetHandle
	{
		PangoOTRulesetHandleExterns.pango_ot_ruleset_substitute(ruleset, buffer);
		return ruleset;
	}

}

internal class PangoOTRulesetHandleExterns
{
	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_new_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.Pango.PangoScript script, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoOTLibrary.Name)]
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
	internal static extern MentorLake.PangoOT.PangoOTRulesetHandle pango_ot_ruleset_get_for_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

}
