namespace MentorLake.PangoOT;

public class PangoOTGlobalFunctions
{
	public static MentorLake.PangoOT.PangoOTTag TagFromLanguage(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_from_language(language);
	}

	public static MentorLake.PangoOT.PangoOTTag TagFromScript(MentorLake.Pango.PangoScript script)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_from_script(script);
	}

	public static MentorLake.Pango.PangoLanguageHandle TagToLanguage(MentorLake.PangoOT.PangoOTTag language_tag)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_to_language(language_tag);
	}

	public static MentorLake.Pango.PangoScript TagToScript(MentorLake.PangoOT.PangoOTTag script_tag)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_to_script(script_tag);
	}

}

internal class PangoOTGlobalFunctionsExterns
{
	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTTag pango_ot_tag_from_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTTag pango_ot_tag_from_script(MentorLake.Pango.PangoScript script);

	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_ot_tag_to_language(MentorLake.PangoOT.PangoOTTag language_tag);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.Pango.PangoScript pango_ot_tag_to_script(MentorLake.PangoOT.PangoOTTag script_tag);

}
