namespace MentorLake.Pango;

public class PangoLanguageHandle : BaseSafeHandle
{
}


public static class PangoLanguageExtensions
{
	public static string GetSampleString(this MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoLanguageExterns.pango_language_get_sample_string(language);
	}

	public static MentorLake.Pango.PangoScript[] GetScripts(this MentorLake.Pango.PangoLanguageHandle language, out int num_scripts)
	{
		return PangoLanguageExterns.pango_language_get_scripts(language, out num_scripts);
	}

	public static bool IncludesScript(this MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoScript script)
	{
		return PangoLanguageExterns.pango_language_includes_script(language, script);
	}

	public static bool Matches(this MentorLake.Pango.PangoLanguageHandle language, string range_list)
	{
		return PangoLanguageExterns.pango_language_matches(language, range_list);
	}

	public static string ToString(this MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoLanguageExterns.pango_language_to_string(language);
	}


	public static PangoLanguage Dereference(this PangoLanguageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLanguage>(x.DangerousGetHandle());
}
internal class PangoLanguageExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_language_get_sample_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoScript[] pango_language_get_scripts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language, out int num_scripts);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_language_includes_script([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoScript script);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_language_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language, string range_list);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_language_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_from_string(string language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_get_default();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_language_get_preferred();

}

public struct PangoLanguage
{
	public static MentorLake.Pango.PangoLanguageHandle FromString(string language)
	{
		return PangoLanguageExterns.pango_language_from_string(language);
	}

	public static MentorLake.Pango.PangoLanguageHandle GetDefault()
	{
		return PangoLanguageExterns.pango_language_get_default();
	}

	public static MentorLake.Pango.PangoLanguageHandle[] GetPreferred()
	{
		return PangoLanguageExterns.pango_language_get_preferred();
	}

}
