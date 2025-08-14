namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoLanguage` structure is used to
/// represent a language.
/// </para>
/// <para>
/// `PangoLanguage` pointers can be efficiently
/// copied and compared with each other.
/// </para>
/// </summary>

public class PangoLanguageHandle : BaseSafeHandle
{
}


public static class PangoLanguageExtensions
{
/// <summary>
/// <para>
/// Get a string that is representative of the characters needed to
/// render a particular language.
/// </para>
/// <para>
/// The sample text may be a pangram, but is not necessarily. It is chosen
/// to be demonstrative of normal text in the language, as well as exposing
/// font feature requirements unique to the language. It is suitable for use
/// as sample text in a font selection dialog.
/// </para>
/// <para>
/// If @language is %NULL, the default language as found by
/// [func@Pango.Language.get_default] is used.
/// </para>
/// <para>
/// If Pango does not have a sample string for @language, the classic
/// "The quick brown fox..." is returned.  This can be detected by
/// comparing the returned pointer value to that returned for (non-existent)
/// language code "xx".  That is, compare to:
/// </para>
/// <para>
/// ```
/// pango_language_get_sample_string (pango_language_from_string ("xx"))
/// ```
/// </para>
/// </summary>

/// <param name="language">
/// a `PangoLanguage`
/// </param>
/// <return>
/// the sample string
/// </return>

	public static string GetSampleString(this MentorLake.Pango.PangoLanguageHandle language)
	{
		if (language.IsInvalid) throw new Exception("Invalid handle (PangoLanguage)");
		return PangoLanguageExterns.pango_language_get_sample_string(language);
	}

/// <summary>
/// <para>
/// Determines the scripts used to to write @language.
/// </para>
/// <para>
/// If nothing is known about the language tag @language,
/// or if @language is %NULL, then %NULL is returned.
/// The list of scripts returned starts with the script that the
/// language uses most and continues to the one it uses least.
/// </para>
/// <para>
/// The value @num_script points at will be set to the number
/// of scripts in the returned array (or zero if %NULL is returned).
/// </para>
/// <para>
/// Most languages use only one script for writing, but there are
/// some that use two (Latin and Cyrillic for example), and a few
/// use three (Japanese for example). Applications should not make
/// any assumptions on the maximum number of scripts returned
/// though, except that it is positive if the return value is not
/// %NULL, and it is a small number.
/// </para>
/// <para>
/// The [method@Pango.Language.includes_script] function uses this
/// function internally.
/// </para>
/// <para>
/// Note: while the return value is declared as `PangoScript`, the
/// returned values are from the `GUnicodeScript` enumeration, which
/// may have more values. Callers need to handle unknown values.
/// </para>
/// </summary>

/// <param name="language">
/// a `PangoLanguage`
/// </param>
/// <param name="num_scripts">
/// location to return number of scripts
/// </param>
/// <return>
/// 
///   An array of `PangoScript` values, with the number of entries in
///   the array stored in @num_scripts, or %NULL if Pango does not have
///   any information about this particular language tag (also the case
///   if @language is %NULL).
/// </return>

	public static MentorLake.Pango.PangoScript[] GetScripts(this MentorLake.Pango.PangoLanguageHandle language, out int num_scripts)
	{
		if (language.IsInvalid) throw new Exception("Invalid handle (PangoLanguage)");
		return PangoLanguageExterns.pango_language_get_scripts(language, out num_scripts);
	}

/// <summary>
/// <para>
/// Determines if @script is one of the scripts used to
/// write @language.
/// </para>
/// <para>
/// The returned value is conservative; if nothing is known about
/// the language tag @language, %TRUE will be returned, since, as
/// far as Pango knows, @script might be used to write @language.
/// </para>
/// <para>
/// This routine is used in Pango's itemization process when
/// determining if a supplied language tag is relevant to
/// a particular section of text. It probably is not useful
/// for applications in most circumstances.
/// </para>
/// <para>
/// This function uses [method@Pango.Language.get_scripts] internally.
/// </para>
/// </summary>

/// <param name="language">
/// a `PangoLanguage`
/// </param>
/// <param name="script">
/// a `PangoScript`
/// </param>
/// <return>
/// %TRUE if @script is one of the scripts used
///   to write @language or if nothing is known about @language
///   (including the case that @language is %NULL), %FALSE otherwise.
/// </return>

	public static bool IncludesScript(this MentorLake.Pango.PangoLanguageHandle language, MentorLake.Pango.PangoScript script)
	{
		if (language.IsInvalid) throw new Exception("Invalid handle (PangoLanguage)");
		return PangoLanguageExterns.pango_language_includes_script(language, script);
	}

/// <summary>
/// <para>
/// Checks if a language tag matches one of the elements in a list of
/// language ranges.
/// </para>
/// <para>
/// A language tag is considered to match a range in the list if the
/// range is '*', the range is exactly the tag, or the range is a prefix
/// of the tag, and the character after it in the tag is '-'.
/// </para>
/// </summary>

/// <param name="language">
/// a language tag (see [func@Pango.Language.from_string]),
///   %NULL is allowed and matches nothing but '*'
/// </param>
/// <param name="range_list">
/// a list of language ranges, separated by ';', ':',
///   ',', or space characters.
///   Each element must either be '*', or a RFC 3066 language range
///   canonicalized as by [func@Pango.Language.from_string]
/// </param>
/// <return>
/// %TRUE if a match was found
/// </return>

	public static bool Matches(this MentorLake.Pango.PangoLanguageHandle language, string range_list)
	{
		if (language.IsInvalid) throw new Exception("Invalid handle (PangoLanguage)");
		return PangoLanguageExterns.pango_language_matches(language, range_list);
	}

/// <summary>
/// <para>
/// Gets the RFC-3066 format string representing the given language tag.
/// </para>
/// <para>
/// Returns (transfer none): a string representing the language tag
/// </para>
/// </summary>

/// <param name="language">
/// a language tag.
/// </param>

	public static string ToString(this MentorLake.Pango.PangoLanguageHandle language)
	{
		if (language.IsInvalid) throw new Exception("Invalid handle (PangoLanguage)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_from_string(string language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle pango_language_get_default();

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLanguageHandle[] pango_language_get_preferred();

}

/// <summary>
/// <para>
/// The `PangoLanguage` structure is used to
/// represent a language.
/// </para>
/// <para>
/// `PangoLanguage` pointers can be efficiently
/// copied and compared with each other.
/// </para>
/// </summary>

public struct PangoLanguage
{
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

	public static MentorLake.Pango.PangoLanguageHandle FromString(string language)
	{
		return PangoLanguageExterns.pango_language_from_string(language);
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

	public static MentorLake.Pango.PangoLanguageHandle GetDefault()
	{
		return PangoLanguageExterns.pango_language_get_default();
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

	public static MentorLake.Pango.PangoLanguageHandle[] GetPreferred()
	{
		return PangoLanguageExterns.pango_language_get_preferred();
	}

}
