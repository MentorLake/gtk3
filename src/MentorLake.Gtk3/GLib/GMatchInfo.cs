namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A GMatchInfo is an opaque struct used to return information about
/// matches.
/// </para>
/// </summary>

public class GMatchInfoHandle : BaseSafeHandle
{
}


public static class GMatchInfoExtensions
{
/// <summary>
/// <para>
/// Returns a new string containing the text in @string_to_expand with
/// references and escape sequences expanded. References refer to the last
/// match done with @string against @regex and have the same syntax used by
/// g_regex_replace().
/// </para>
/// <para>
/// The @string_to_expand must be UTF-8 encoded even if %G_REGEX_RAW was
/// passed to g_regex_new().
/// </para>
/// <para>
/// The backreferences are extracted from the string passed to the match
/// function, so you cannot call this function after freeing the string.
/// </para>
/// <para>
/// @match_info may be %NULL in which case @string_to_expand must not
/// contain references. For instance "foo\n" does not refer to an actual
/// pattern and '\n' merely will be replaced with \n character,
/// while to expand "\0" (whole match) one needs the result of a match.
/// Use g_regex_check_replacement() to find out whether @string_to_expand
/// contains references.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo or %NULL
/// </param>
/// <param name="string_to_expand">
/// the string to expand
/// </param>
/// <return>
/// the expanded string, or %NULL if an error occurred
/// </return>

	public static string ExpandReferences(this MentorLake.GLib.GMatchInfoHandle match_info, string string_to_expand)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		var externCallResult = GMatchInfoExterns.g_match_info_expand_references(match_info, string_to_expand, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves the text matching the @match_num'th capturing
/// parentheses. 0 is the full text of the match, 1 is the first paren
/// set, 2 the second, and so on.
/// </para>
/// <para>
/// If @match_num is a valid sub pattern but it didn't match anything
/// (e.g. sub pattern 1, matching "b" against "(a)?b") then an empty
/// string is returned.
/// </para>
/// <para>
/// If the match was obtained using the DFA algorithm, that is using
/// g_regex_match_all() or g_regex_match_all_full(), the retrieved
/// string is not that of a set of parentheses but that of a matched
/// substring. Substrings are matched in reverse order of length, so
/// 0 is the longest match.
/// </para>
/// <para>
/// The string is fetched from the string passed to the match function,
/// so you cannot call this function after freeing the string.
/// </para>
/// </summary>

/// <param name="match_info">
/// #GMatchInfo structure
/// </param>
/// <param name="match_num">
/// number of the sub expression
/// </param>
/// <return>
/// The matched substring, or %NULL if an error
///     occurred. You have to free the string yourself
/// </return>

	public static string Fetch(this MentorLake.GLib.GMatchInfoHandle match_info, int match_num)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_fetch(match_info, match_num);
	}

/// <summary>
/// <para>
/// Bundles up pointers to each of the matching substrings from a match
/// and stores them in an array of gchar pointers. The first element in
/// the returned array is the match number 0, i.e. the entire matched
/// text.
/// </para>
/// <para>
/// If a sub pattern didn't match anything (e.g. sub pattern 1, matching
/// "b" against "(a)?b") then an empty string is inserted.
/// </para>
/// <para>
/// If the last match was obtained using the DFA algorithm, that is using
/// g_regex_match_all() or g_regex_match_all_full(), the retrieved
/// strings are not that matched by sets of parentheses but that of the
/// matched substring. Substrings are matched in reverse order of length,
/// so the first one is the longest match.
/// </para>
/// <para>
/// The strings are fetched from the string passed to the match function,
/// so you cannot call this function after freeing the string.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo structure
/// </param>
/// <return>
/// a %NULL-terminated array of gchar *
///     pointers.  It must be freed using g_strfreev(). If the previous
///     match failed %NULL is returned
/// </return>

	public static string[] FetchAll(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_fetch_all(match_info);
	}

/// <summary>
/// <para>
/// Retrieves the text matching the capturing parentheses named @name.
/// </para>
/// <para>
/// If @name is a valid sub pattern name but it didn't match anything
/// (e.g. sub pattern `"X"`, matching `"b"` against `"(?P<X>a)?b"`)
/// then an empty string is returned.
/// </para>
/// <para>
/// The string is fetched from the string passed to the match function,
/// so you cannot call this function after freeing the string.
/// </para>
/// </summary>

/// <param name="match_info">
/// #GMatchInfo structure
/// </param>
/// <param name="name">
/// name of the subexpression
/// </param>
/// <return>
/// The matched substring, or %NULL if an error
///     occurred. You have to free the string yourself
/// </return>

	public static string FetchNamed(this MentorLake.GLib.GMatchInfoHandle match_info, string name)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_fetch_named(match_info, name);
	}

/// <summary>
/// <para>
/// Retrieves the position in bytes of the capturing parentheses named @name.
/// </para>
/// <para>
/// If @name is a valid sub pattern name but it didn't match anything
/// (e.g. sub pattern `"X"`, matching `"b"` against `"(?P<X>a)?b"`)
/// then @start_pos and @end_pos are set to -1 and %TRUE is returned.
/// </para>
/// </summary>

/// <param name="match_info">
/// #GMatchInfo structure
/// </param>
/// <param name="name">
/// name of the subexpression
/// </param>
/// <param name="start_pos">
/// pointer to location where to store
///     the start position, or %NULL
/// </param>
/// <param name="end_pos">
/// pointer to location where to store
///     the end position, or %NULL
/// </param>
/// <return>
/// %TRUE if the position was fetched, %FALSE otherwise.
///     If the position cannot be fetched, @start_pos and @end_pos
///     are left unchanged.
/// </return>

	public static bool FetchNamedPos(this MentorLake.GLib.GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_fetch_named_pos(match_info, name, out start_pos, out end_pos);
	}

/// <summary>
/// <para>
/// Retrieves the position in bytes of the @match_num'th capturing
/// parentheses. 0 is the full text of the match, 1 is the first
/// paren set, 2 the second, and so on.
/// </para>
/// <para>
/// If @match_num is a valid sub pattern but it didn't match anything
/// (e.g. sub pattern 1, matching "b" against "(a)?b") then @start_pos
/// and @end_pos are set to -1 and %TRUE is returned.
/// </para>
/// <para>
/// If the match was obtained using the DFA algorithm, that is using
/// g_regex_match_all() or g_regex_match_all_full(), the retrieved
/// position is not that of a set of parentheses but that of a matched
/// substring. Substrings are matched in reverse order of length, so
/// 0 is the longest match.
/// </para>
/// </summary>

/// <param name="match_info">
/// #GMatchInfo structure
/// </param>
/// <param name="match_num">
/// number of the sub expression
/// </param>
/// <param name="start_pos">
/// pointer to location where to store
///     the start position, or %NULL
/// </param>
/// <param name="end_pos">
/// pointer to location where to store
///     the end position, or %NULL
/// </param>
/// <return>
/// %TRUE if the position was fetched, %FALSE otherwise. If
///   the position cannot be fetched, @start_pos and @end_pos are left
///   unchanged
/// </return>

	public static bool FetchPos(this MentorLake.GLib.GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_fetch_pos(match_info, match_num, out start_pos, out end_pos);
	}

/// <summary>
/// <para>
/// If @match_info is not %NULL, calls g_match_info_unref(); otherwise does
/// nothing.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo, or %NULL
/// </param>

	public static void Free(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		GMatchInfoExterns.g_match_info_free(match_info);
	}

/// <summary>
/// <para>
/// Retrieves the number of matched substrings (including substring 0,
/// that is the whole matched text), so 1 is returned if the pattern
/// has no substrings in it and 0 is returned if the match failed.
/// </para>
/// <para>
/// If the last match was obtained using the DFA algorithm, that is
/// using g_regex_match_all() or g_regex_match_all_full(), the retrieved
/// count is not that of the number of capturing parentheses but that of
/// the number of matched substrings.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo structure
/// </param>
/// <return>
/// Number of matched substrings, or -1 if an error occurred
/// </return>

	public static int GetMatchCount(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_get_match_count(match_info);
	}

/// <summary>
/// <para>
/// Returns #GRegex object used in @match_info. It belongs to Glib
/// and must not be freed. Use g_regex_ref() if you need to keep it
/// after you free @match_info object.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo
/// </param>
/// <return>
/// #GRegex object used in @match_info
/// </return>

	public static MentorLake.GLib.GRegexHandle GetRegex(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_get_regex(match_info);
	}

/// <summary>
/// <para>
/// Returns the string searched with @match_info. This is the
/// string passed to g_regex_match() or g_regex_replace() so
/// you may not free it before calling this function.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo
/// </param>
/// <return>
/// the string searched with @match_info
/// </return>

	public static string GetString(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_get_string(match_info);
	}

/// <summary>
/// <para>
/// Usually if the string passed to g_regex_match*() matches as far as
/// it goes, but is too short to match the entire pattern, %FALSE is
/// returned. There are circumstances where it might be helpful to
/// distinguish this case from other cases in which there is no match.
/// </para>
/// <para>
/// Consider, for example, an application where a human is required to
/// type in data for a field with specific formatting requirements. An
/// example might be a date in the form ddmmmyy, defined by the pattern
/// "^\d?\d(jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)\d\d$".
/// If the application sees the user’s keystrokes one by one, and can
/// check that what has been typed so far is potentially valid, it is
/// able to raise an error as soon as a mistake is made.
/// </para>
/// <para>
/// GRegex supports the concept of partial matching by means of the
/// %G_REGEX_MATCH_PARTIAL_SOFT and %G_REGEX_MATCH_PARTIAL_HARD flags.
/// When they are used, the return code for
/// g_regex_match() or g_regex_match_full() is, as usual, %TRUE
/// for a complete match, %FALSE otherwise. But, when these functions
/// return %FALSE, you can check if the match was partial calling
/// g_match_info_is_partial_match().
/// </para>
/// <para>
/// The difference between %G_REGEX_MATCH_PARTIAL_SOFT and
/// %G_REGEX_MATCH_PARTIAL_HARD is that when a partial match is encountered
/// with %G_REGEX_MATCH_PARTIAL_SOFT, matching continues to search for a
/// possible complete match, while with %G_REGEX_MATCH_PARTIAL_HARD matching
/// stops at the partial match.
/// When both %G_REGEX_MATCH_PARTIAL_SOFT and %G_REGEX_MATCH_PARTIAL_HARD
/// are set, the latter takes precedence.
/// </para>
/// <para>
/// There were formerly some restrictions on the pattern for partial matching.
/// The restrictions no longer apply.
/// </para>
/// <para>
/// See pcrepartial(3) for more information on partial matching.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo structure
/// </param>
/// <return>
/// %TRUE if the match was partial, %FALSE otherwise
/// </return>

	public static bool IsPartialMatch(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_is_partial_match(match_info);
	}

/// <summary>
/// <para>
/// Returns whether the previous match operation succeeded.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo structure
/// </param>
/// <return>
/// %TRUE if the previous match operation succeeded,
///   %FALSE otherwise
/// </return>

	public static bool Matches(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_matches(match_info);
	}

/// <summary>
/// <para>
/// Scans for the next match using the same parameters of the previous
/// call to g_regex_match_full() or g_regex_match() that returned
/// @match_info.
/// </para>
/// <para>
/// The match is done on the string passed to the match function, so you
/// cannot free it before calling this function.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo structure
/// </param>
/// <return>
/// %TRUE is the string matched, %FALSE otherwise
/// </return>

	public static bool Next(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		var externCallResult = GMatchInfoExterns.g_match_info_next(match_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increases reference count of @match_info by 1.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo
/// </param>
/// <return>
/// @match_info
/// </return>

	public static MentorLake.GLib.GMatchInfoHandle Ref(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		return GMatchInfoExterns.g_match_info_ref(match_info);
	}

/// <summary>
/// <para>
/// Decreases reference count of @match_info by 1. When reference count drops
/// to zero, it frees all the memory associated with the match_info structure.
/// </para>
/// </summary>

/// <param name="match_info">
/// a #GMatchInfo
/// </param>

	public static void Unref(this MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (match_info.IsInvalid) throw new Exception("Invalid handle (GMatchInfo)");
		GMatchInfoExterns.g_match_info_unref(match_info);
	}


	public static GMatchInfo Dereference(this GMatchInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMatchInfo>(x.DangerousGetHandle());
}
internal class GMatchInfoExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_expand_references([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string string_to_expand, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_fetch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, int match_num);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_match_info_fetch_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_fetch_named([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_fetch_named_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, string name, out int start_pos, out int end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_fetch_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, int match_num, out int start_pos, out int end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_match_info_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_match_info_get_match_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))]
	internal static extern MentorLake.GLib.GRegexHandle g_match_info_get_regex([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_match_info_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_is_partial_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_match_info_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))]
	internal static extern MentorLake.GLib.GMatchInfoHandle g_match_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_match_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] MentorLake.GLib.GMatchInfoHandle match_info);

}

/// <summary>
/// <para>
/// A GMatchInfo is an opaque struct used to return information about
/// matches.
/// </para>
/// </summary>

public struct GMatchInfo
{
}
