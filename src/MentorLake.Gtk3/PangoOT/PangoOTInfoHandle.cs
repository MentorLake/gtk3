namespace MentorLake.PangoOT;


public class PangoOTInfoHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Returns the `PangoOTInfo` structure for the given FreeType font face.
/// </para>
/// </summary>

/// <param name="face">
/// a `FT_Face`
/// </param>
/// <return>
/// the `PangoOTInfo` for @face.
///   This object will have the same lifetime as @face.
/// </return>

	public static MentorLake.PangoOT.PangoOTInfoHandle Get(MentorLake.freetype2.FT_Face face)
	{
		return PangoOTInfoHandleExterns.pango_ot_info_get(face);
	}

}

public static class PangoOTInfoHandleExtensions
{
/// <summary>
/// <para>
/// Finds the index of a feature.
/// </para>
/// <para>
/// If the feature is not found, sets @feature_index to PANGO_OT_NO_FEATURE,
/// which is safe to pass to [method@PangoOT.Ruleset.add_feature] and similar
/// functions.
/// </para>
/// <para>
/// In the future, this may set @feature_index to an special value that if
/// used in [method@PangoOT.Ruleset.add_feature] will ask Pango to synthesize
/// the requested feature based on Unicode properties and data. However, this
/// function will still return %FALSE in those cases. So, users may want to
/// ignore the return value of this function in certain cases.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <param name="feature_tag">
/// the tag of the feature to find
/// </param>
/// <param name="script_index">
/// the index of the script
/// </param>
/// <param name="language_index">
/// the index of the language whose features are searched,
///   or %PANGO_OT_DEFAULT_LANGUAGE to use the default language of the script
/// </param>
/// <param name="feature_index">
/// location to store the index of
///   the feature
/// </param>
/// <return>
/// %TRUE if the feature was found
/// </return>

	public static bool FindFeature(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, uint script_index, uint language_index, out uint feature_index)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_feature(info, table_type, feature_tag, script_index, language_index, out feature_index);
	}

/// <summary>
/// <para>
/// Finds the index of a language and its required feature index.
/// </para>
/// <para>
/// If the language is not found, sets @language_index to %PANGO_OT_DEFAULT_LANGUAGE
/// and the required feature of the default language system is returned in
/// required_feature_index. For best compatibility with some fonts, also
/// searches the language system tag 'dflt' before falling back to the default
/// language system, but that is transparent to the user. The user can simply
/// ignore the return value of this function to automatically fall back to the
/// default language system.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <param name="script_index">
/// the index of the script whose languages are searched
/// </param>
/// <param name="language_tag">
/// the tag of the language to find
/// </param>
/// <param name="language_index">
/// location to store the index of the language
/// </param>
/// <param name="required_feature_index">
/// location to store the
///   required feature index of the language
/// </param>
/// <return>
/// %TRUE if the language was found
/// </return>

	public static bool FindLanguage(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag, out uint language_index, out uint required_feature_index)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_language(info, table_type, script_index, language_tag, out language_index, out required_feature_index);
	}

/// <summary>
/// <para>
/// Finds the index of a script.
/// </para>
/// <para>
/// If not found, tries to find the 'DFLT' and then 'dflt' scripts and
/// return the index of that in @script_index. If none of those is found
/// either, %PANGO_OT_NO_SCRIPT is placed in @script_index.
/// </para>
/// <para>
/// All other functions taking an input script_index parameter know
/// how to handle %PANGO_OT_NO_SCRIPT, so one can ignore the return
/// value of this function completely and proceed, to enjoy the automatic
/// fallback to the 'DFLT'/'dflt' script.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <param name="script_tag">
/// the tag of the script to find
/// </param>
/// <param name="script_index">
/// location to store the index of the script
/// </param>
/// <return>
/// %TRUE if the script was found
/// </return>

	public static bool FindScript(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag script_tag, out uint script_index)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_script(info, table_type, script_tag, out script_index);
	}

/// <summary>
/// <para>
/// Obtains the list of features for the given language of the given script.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <param name="tag">
/// unused parameter
/// </param>
/// <param name="script_index">
/// the index of the script to obtain information about
/// </param>
/// <param name="language_index">
/// the index of the language to list features for, or
///   %PANGO_OT_DEFAULT_LANGUAGE, to list features for the default
///   language of the script
/// </param>
/// <return>
/// a newly-allocated zero-terminated
///   array containing the tags of the available features
/// </return>

	public static MentorLake.PangoOT.PangoOTTagHandle ListFeatures(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag tag, uint script_index, uint language_index)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_list_features(info, table_type, tag, script_index, language_index);
	}

/// <summary>
/// <para>
/// Obtains the list of available languages for a given script.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <param name="script_index">
/// the index of the script to list languages for
/// </param>
/// <param name="language_tag">
/// unused parameter
/// </param>
/// <return>
/// a newly-allocated zero-terminated
///   array containing the tags of the available languages
/// </return>

	public static MentorLake.PangoOT.PangoOTTagHandle ListLanguages(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_list_languages(info, table_type, script_index, language_tag);
	}

/// <summary>
/// <para>
/// Obtains the list of available scripts.
/// </para>
/// </summary>

/// <param name="info">
/// a `PangoOTInfo`
/// </param>
/// <param name="table_type">
/// the table type to obtain information about
/// </param>
/// <return>
/// a newly-allocated zero-terminated
///   array containing the tags of the available scripts
/// </return>

	public static MentorLake.PangoOT.PangoOTTagHandle ListScripts(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_list_scripts(info, table_type);
	}

}

internal class PangoOTInfoHandleExterns
{
	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_info_find_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, uint script_index, uint language_index, out uint feature_index);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_info_find_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag, out uint language_index, out uint required_feature_index);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_info_find_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag script_tag, out uint script_index);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTTagHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag tag, uint script_index, uint language_index);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTTagHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTTagHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_scripts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTInfoHandle pango_ot_info_get(MentorLake.freetype2.FT_Face face);

}
