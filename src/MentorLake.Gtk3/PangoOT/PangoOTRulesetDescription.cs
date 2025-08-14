namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The `PangoOTRuleset` structure holds all the information needed
/// to build a complete `PangoOTRuleset` from an OpenType font.
/// The main use of this struct is to act as the key for a per-font
/// hash of rulesets.  The user populates a ruleset description and
/// gets the ruleset using pango_ot_ruleset_get_for_description()
/// or create a new one using pango_ot_ruleset_new_from_description().
/// </para>
/// </summary>

public class PangoOTRulesetDescriptionHandle : BaseSafeHandle
{
}


public static class PangoOTRulesetDescriptionExtensions
{
/// <summary>
/// <para>
/// Creates a copy of @desc, which should be freed with
/// [method@PangoOT.RulesetDescription.free].
/// </para>
/// <para>
/// Primarily used internally by [func@PangoOT.Ruleset.get_for_description]
/// to cache rulesets for ruleset descriptions.
/// </para>
/// </summary>

/// <param name="desc">
/// ruleset description to copy
/// </param>
/// <return>
/// the newly allocated `PangoOTRulesetDescription`
/// </return>

	public static MentorLake.PangoOT.PangoOTRulesetDescriptionHandle Copy(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_copy(desc);
	}

/// <summary>
/// <para>
/// Compares two ruleset descriptions for equality.
/// </para>
/// <para>
/// Two ruleset descriptions are considered equal if the rulesets
/// they describe are provably identical. This means that their
/// script, language, and all feature sets should be equal.
/// </para>
/// <para>
/// For static feature sets, the array addresses are compared directly,
/// while for other features, the list of features is compared one by
/// one.(Two ruleset descriptions may result in identical rulesets
/// being created, but still compare %FALSE.)
/// </para>
/// </summary>

/// <param name="desc1">
/// a ruleset description
/// </param>
/// <param name="desc2">
/// a ruleset description
/// </param>
/// <return>
/// %TRUE if two ruleset descriptions are identical,
///   %FALSE otherwise
/// </return>

	public static bool Equal(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc1, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc2)
	{
		if (desc1.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_equal(desc1, desc2);
	}

/// <summary>
/// <para>
/// Frees a ruleset description allocated by
/// pango_ot_ruleset_description_copy().
/// </para>
/// </summary>

/// <param name="desc">
/// an allocated `PangoOTRulesetDescription`
/// </param>

	public static void Free(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetDescription)");
		PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_free(desc);
	}

/// <summary>
/// <para>
/// Computes a hash of a `PangoOTRulesetDescription` structure suitable
/// to be used, for example, as an argument to g_hash_table_new().
/// </para>
/// </summary>

/// <param name="desc">
/// a ruleset description
/// </param>
/// <return>
/// the hash value
/// </return>

	public static uint Hash(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid) throw new Exception("Invalid handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_hash(desc);
	}


	public static PangoOTRulesetDescription Dereference(this PangoOTRulesetDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTRulesetDescription>(x.DangerousGetHandle());
}
internal class PangoOTRulesetDescriptionExterns
{
	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTRulesetDescriptionHandle pango_ot_ruleset_description_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_ruleset_description_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc2);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_ruleset_description_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern uint pango_ot_ruleset_description_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

}

/// <summary>
/// <para>
/// The `PangoOTRuleset` structure holds all the information needed
/// to build a complete `PangoOTRuleset` from an OpenType font.
/// The main use of this struct is to act as the key for a per-font
/// hash of rulesets.  The user populates a ruleset description and
/// gets the ruleset using pango_ot_ruleset_get_for_description()
/// or create a new one using pango_ot_ruleset_new_from_description().
/// </para>
/// </summary>

public struct PangoOTRulesetDescription
{
	/// <summary>
/// <para>
/// a `PangoScript`
/// </para>
/// </summary>

public PangoScript script;
	/// <summary>
/// <para>
/// a `PangoLanguage`
/// </para>
/// </summary>

public IntPtr language;
	/// <summary>
/// <para>
/// static map of GSUB features
/// </para>
/// </summary>

public IntPtr static_gsub_features;
	/// <summary>
/// <para>
/// length of @static_gsub_features, or 0.
/// </para>
/// </summary>

public uint n_static_gsub_features;
	/// <summary>
/// <para>
/// static map of GPOS features
/// </para>
/// </summary>

public IntPtr static_gpos_features;
	/// <summary>
/// <para>
/// length of @static_gpos_features, or 0.
/// </para>
/// </summary>

public uint n_static_gpos_features;
	/// <summary>
/// <para>
/// map of extra features to add to both
///   GSUB and GPOS. Unlike the static maps, this pointer need not
///   live beyond the life of function calls taking this struct.
/// </para>
/// </summary>

public IntPtr other_features;
	/// <summary>
/// <para>
/// length of @other_features, or 0.
/// </para>
/// </summary>

public uint n_other_features;
}
