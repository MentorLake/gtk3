namespace MentorLake.PangoOT;

public class PangoOTGlobalFunctions
{
/// <summary>
/// <para>
/// Finds the OpenType language-system tag best describing @language.
/// </para>
/// </summary>

/// <param name="language">
/// A `PangoLanguage`
/// </param>
/// <return>
/// `PangoOTTag` best matching @language or
/// %PANGO_OT_TAG_DEFAULT_LANGUAGE if none found or if @language
/// is %NULL.
/// </return>

	public static MentorLake.PangoOT.PangoOTTag TagFromLanguage(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_from_language(language);
	}

/// <summary>
/// <para>
/// Finds the OpenType script tag corresponding to @script.
/// </para>
/// <para>
/// The %PANGO_SCRIPT_COMMON, %PANGO_SCRIPT_INHERITED, and
/// %PANGO_SCRIPT_UNKNOWN scripts are mapped to the OpenType
/// 'DFLT' script tag that is also defined as
/// %PANGO_OT_TAG_DEFAULT_SCRIPT.
/// </para>
/// <para>
/// Note that multiple `PangoScript` values may map to the same
/// OpenType script tag.  In particular, %PANGO_SCRIPT_HIRAGANA
/// and %PANGO_SCRIPT_KATAKANA both map to the OT tag 'kana'.
/// </para>
/// </summary>

/// <param name="script">
/// A `PangoScript`
/// </param>
/// <return>
/// `PangoOTTag` corresponding to @script or
/// %PANGO_OT_TAG_DEFAULT_SCRIPT if none found.
/// </return>

	public static MentorLake.PangoOT.PangoOTTag TagFromScript(MentorLake.Pango.PangoScript script)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_from_script(script);
	}

/// <summary>
/// <para>
/// Finds a `PangoLanguage` corresponding to @language_tag.
/// </para>
/// </summary>

/// <param name="language_tag">
/// A `PangoOTTag` OpenType language-system tag
/// </param>
/// <return>
/// `PangoLanguage` best matching @language_tag or
/// `PangoLanguage` corresponding to the string "xx" if none found.
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle TagToLanguage(MentorLake.PangoOT.PangoOTTag language_tag)
	{
		return PangoOTGlobalFunctionsExterns.pango_ot_tag_to_language(language_tag);
	}

/// <summary>
/// <para>
/// Finds the `PangoScript` corresponding to @script_tag.
/// </para>
/// <para>
/// The 'DFLT' script tag is mapped to %PANGO_SCRIPT_COMMON.
/// </para>
/// <para>
/// Note that an OpenType script tag may correspond to multiple
/// `PangoScript` values.  In such cases, the `PangoScript` value
/// with the smallest value is returned.
/// In particular, %PANGO_SCRIPT_HIRAGANA
/// and %PANGO_SCRIPT_KATAKANA both map to the OT tag 'kana'.
/// This function will return %PANGO_SCRIPT_HIRAGANA for
/// 'kana'.
/// </para>
/// </summary>

/// <param name="script_tag">
/// A `PangoOTTag` OpenType script tag
/// </param>
/// <return>
/// `PangoScript` corresponding to @script_tag or
/// %PANGO_SCRIPT_UNKNOWN if none found.
/// </return>

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
