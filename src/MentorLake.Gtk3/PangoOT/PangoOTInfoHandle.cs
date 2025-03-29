namespace MentorLake.PangoOT;

public class PangoOTInfoHandle : GObjectHandle
{
	public static MentorLake.PangoOT.PangoOTInfoHandle Get(MentorLake.freetype2.FT_Face face)
	{
		return PangoOTInfoHandleExterns.pango_ot_info_get(face);
	}

}

public static class PangoOTInfoHandleExtensions
{
	public static bool FindFeature(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag feature_tag, uint script_index, uint language_index, out uint feature_index)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_feature(info, table_type, feature_tag, script_index, language_index, out feature_index);
	}

	public static bool FindLanguage(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag, out uint language_index, out uint required_feature_index)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_language(info, table_type, script_index, language_tag, out language_index, out required_feature_index);
	}

	public static bool FindScript(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag script_tag, out uint script_index)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_find_script(info, table_type, script_tag, out script_index);
	}

	public static MentorLake.PangoOT.PangoOTTagHandle ListFeatures(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag tag, uint script_index, uint language_index)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_list_features(info, table_type, tag, script_index, language_index);
	}

	public static MentorLake.PangoOT.PangoOTTagHandle ListLanguages(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
		return PangoOTInfoHandleExterns.pango_ot_info_list_languages(info, table_type, script_index, language_tag);
	}

	public static MentorLake.PangoOT.PangoOTTagHandle ListScripts(this MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (PangoOTInfoHandle)");
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
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, MentorLake.PangoOT.PangoOTTag tag, uint script_index, uint language_index);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_languages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type, uint script_index, MentorLake.PangoOT.PangoOTTag language_tag);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTTagHandle pango_ot_info_list_scripts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTInfoHandle>))] MentorLake.PangoOT.PangoOTInfoHandle info, MentorLake.PangoOT.PangoOTTableType table_type);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTInfoHandle pango_ot_info_get(MentorLake.freetype2.FT_Face face);

}
