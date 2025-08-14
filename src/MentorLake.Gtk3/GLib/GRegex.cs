namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GRegex` is the "compiled" form of a regular expression pattern.
/// </para>
/// <para>
/// `GRegex` implements regular expression pattern matching using syntax and
/// semantics similar to Perl regular expression. See the
/// [PCRE documentation](man:pcrepattern(3)) for the syntax definition.
/// </para>
/// <para>
/// Some functions accept a @start_position argument, setting it differs
/// from just passing over a shortened string and setting %G_REGEX_MATCH_NOTBOL
/// in the case of a pattern that begins with any kind of lookbehind assertion.
/// For example, consider the pattern "\Biss\B" which finds occurrences of "iss"
/// in the middle of words. ("\B" matches only if the current position in the
/// subject is not a word boundary.) When applied to the string "Mississipi"
/// from the fourth byte, namely "issipi", it does not match, because "\B" is
/// always false at the start of the subject, which is deemed to be a word
/// boundary. However, if the entire string is passed , but with
/// @start_position set to 4, it finds the second occurrence of "iss" because
/// it is able to look behind the starting point to discover that it is
/// preceded by a letter.
/// </para>
/// <para>
/// Note that, unless you set the %G_REGEX_RAW flag, all the strings passed
/// to these functions must be encoded in UTF-8. The lengths and the positions
/// inside the strings are in bytes and not in characters, so, for instance,
/// "\xc3\xa0" (i.e. "à") is two bytes long but it is treated as a
/// single character. If you set %G_REGEX_RAW the strings can be non-valid
/// UTF-8 strings and a byte is treated as a character, so "\xc3\xa0" is two
/// bytes and two characters long.
/// </para>
/// <para>
/// When matching a pattern, "\n" matches only against a "\n" character in
/// the string, and "\r" matches only a "\r" character. To match any newline
/// sequence use "\R". This particular group matches either the two-character
/// sequence CR + LF ("\r\n"), or one of the single characters LF (linefeed,
/// U+000A, "\n"), VT vertical tab, U+000B, "\v"), FF (formfeed, U+000C, "\f"),
/// CR (carriage return, U+000D, "\r"), NEL (next line, U+0085), LS (line
/// separator, U+2028), or PS (paragraph separator, U+2029).
/// </para>
/// <para>
/// The behaviour of the dot, circumflex, and dollar metacharacters are
/// affected by newline characters, the default is to recognize any newline
/// character (the same characters recognized by "\R"). This can be changed
/// with `G_REGEX_NEWLINE_CR`, `G_REGEX_NEWLINE_LF` and `G_REGEX_NEWLINE_CRLF`
/// compile options, and with `G_REGEX_MATCH_NEWLINE_ANY`,
/// `G_REGEX_MATCH_NEWLINE_CR`, `G_REGEX_MATCH_NEWLINE_LF` and
/// `G_REGEX_MATCH_NEWLINE_CRLF` match options. These settings are also
/// relevant when compiling a pattern if `G_REGEX_EXTENDED` is set, and an
/// unescaped "#" outside a character class is encountered. This indicates
/// a comment that lasts until after the next newline.
/// </para>
/// <para>
/// Creating and manipulating the same `GRegex` structure from different
/// threads is not a problem as `GRegex` does not modify its internal
/// state between creation and destruction, on the other hand `GMatchInfo`
/// is not threadsafe.
/// </para>
/// <para>
/// The regular expressions low-level functionalities are obtained through
/// the excellent [PCRE](http://www.pcre.org/) library written by Philip Hazel.
/// </para>
/// </summary>

public class GRegexHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Compiles the regular expression to an internal form, and does
/// the initial setup of the #GRegex structure.
/// </para>
/// </summary>

/// <param name="pattern">
/// the regular expression
/// </param>
/// <param name="compile_options">
/// compile options for the regular expression, or 0
/// </param>
/// <param name="match_options">
/// match options for the regular expression, or 0
/// </param>
/// <return>
/// a #GRegex structure or %NULL if an error occurred. Call
///   g_regex_unref() when you are done with it
/// </return>

	public static MentorLake.GLib.GRegexHandle New(string pattern, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		var externCallResult = GRegexExterns.g_regex_new(pattern, compile_options, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GRegexExtensions
{
/// <summary>
/// <para>
/// Returns the number of capturing subpatterns in the pattern.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>
/// <return>
/// the number of capturing subpatterns
/// </return>

	public static int GetCaptureCount(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_capture_count(regex);
	}

/// <summary>
/// <para>
/// Returns the compile options that @regex was created with.
/// </para>
/// <para>
/// Depending on the version of PCRE that is used, this may or may not
/// include flags set by option expressions such as `(?i)` found at the
/// top-level within the compiled pattern.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>
/// <return>
/// flags from #GRegexCompileFlags
/// </return>

	public static MentorLake.GLib.GRegexCompileFlags GetCompileFlags(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_compile_flags(regex);
	}

/// <summary>
/// <para>
/// Checks whether the pattern contains explicit CR or LF references.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <return>
/// %TRUE if the pattern contains explicit CR or LF references
/// </return>

	public static bool GetHasCrOrLf(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_has_cr_or_lf(regex);
	}

/// <summary>
/// <para>
/// Returns the match options that @regex was created with.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>
/// <return>
/// flags from #GRegexMatchFlags
/// </return>

	public static MentorLake.GLib.GRegexMatchFlags GetMatchFlags(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_match_flags(regex);
	}

/// <summary>
/// <para>
/// Returns the number of the highest back reference
/// in the pattern, or 0 if the pattern does not contain
/// back references.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>
/// <return>
/// the number of the highest back reference
/// </return>

	public static int GetMaxBackref(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_max_backref(regex);
	}

/// <summary>
/// <para>
/// Gets the number of characters in the longest lookbehind assertion in the
/// pattern. This information is useful when doing multi-segment matching using
/// the partial matching facilities.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <return>
/// the number of characters in the longest lookbehind assertion.
/// </return>

	public static int GetMaxLookbehind(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_max_lookbehind(regex);
	}

/// <summary>
/// <para>
/// Gets the pattern string associated with @regex, i.e. a copy of
/// the string passed to g_regex_new().
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <return>
/// the pattern of @regex
/// </return>

	public static string GetPattern(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_pattern(regex);
	}

/// <summary>
/// <para>
/// Retrieves the number of the subexpression named @name.
/// </para>
/// </summary>

/// <param name="regex">
/// #GRegex structure
/// </param>
/// <param name="name">
/// name of the subexpression
/// </param>
/// <return>
/// The number of the subexpression or -1 if @name
///   does not exists
/// </return>

	public static int GetStringNumber(this MentorLake.GLib.GRegexHandle regex, string name)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_get_string_number(regex, name);
	}

/// <summary>
/// <para>
/// Scans for a match in @string for the pattern in @regex.
/// The @match_options are combined with the match options specified
/// when the @regex structure was created, letting you have more
/// flexibility in reusing #GRegex structures.
/// </para>
/// <para>
/// Unless %G_REGEX_RAW is specified in the options, @string must be valid UTF-8.
/// </para>
/// <para>
/// A #GMatchInfo structure, used to get information on the match,
/// is stored in @match_info if not %NULL. Note that if @match_info
/// is not %NULL then it is created even if the function returns %FALSE,
/// i.e. you must free it regardless if regular expression actually matched.
/// </para>
/// <para>
/// To retrieve all the non-overlapping matches of the pattern in
/// string you can use g_match_info_next().
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// print_uppercase_words (const gchar *string)
/// {
///   // Print all uppercase-only words.
///   GRegex *regex;
///   GMatchInfo *match_info;
/// </para>
/// <para>
///   regex = g_regex_new ("[A-Z]+", G_REGEX_DEFAULT, G_REGEX_MATCH_DEFAULT, NULL);
///   g_regex_match (regex, string, 0, &match_info);
///   while (g_match_info_matches (match_info))
///     {
///       gchar *word = g_match_info_fetch (match_info, 0);
///       g_print ("Found: %s\n", word);
///       g_free (word);
///       g_match_info_next (match_info, NULL);
///     }
///   g_match_info_free (match_info);
///   g_regex_unref (regex);
/// }
/// ]|
/// </para>
/// <para>
/// @string is not copied and is used in #GMatchInfo internally. If
/// you use any #GMatchInfo method (except g_match_info_free()) after
/// freeing or modifying @string then the behaviour is undefined.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure from g_regex_new()
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="match_options">
/// match options
/// </param>
/// <param name="match_info">
/// pointer to location where to store
///     the #GMatchInfo, or %NULL if you do not need it
/// </param>
/// <return>
/// %TRUE is the string matched, %FALSE otherwise
/// </return>

	public static bool Match(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_match(regex, @string, match_options, out match_info);
	}

/// <summary>
/// <para>
/// Using the standard algorithm for regular expression matching only
/// the longest match in the string is retrieved. This function uses
/// a different algorithm so it can retrieve all the possible matches.
/// For more documentation see g_regex_match_all_full().
/// </para>
/// <para>
/// A #GMatchInfo structure, used to get information on the match, is
/// stored in @match_info if not %NULL. Note that if @match_info is
/// not %NULL then it is created even if the function returns %FALSE,
/// i.e. you must free it regardless if regular expression actually
/// matched.
/// </para>
/// <para>
/// @string is not copied and is used in #GMatchInfo internally. If
/// you use any #GMatchInfo method (except g_match_info_free()) after
/// freeing or modifying @string then the behaviour is undefined.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure from g_regex_new()
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="match_options">
/// match options
/// </param>
/// <param name="match_info">
/// pointer to location where to store
///     the #GMatchInfo, or %NULL if you do not need it
/// </param>
/// <return>
/// %TRUE is the string matched, %FALSE otherwise
/// </return>

	public static bool MatchAll(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_match_all(regex, @string, match_options, out match_info);
	}

/// <summary>
/// <para>
/// Using the standard algorithm for regular expression matching only
/// the longest match in the @string is retrieved, it is not possible
/// to obtain all the available matches. For instance matching
/// `"<a> <b> <c>"` against the pattern `"<.*>"`
/// you get `"<a> <b> <c>"`.
/// </para>
/// <para>
/// This function uses a different algorithm (called DFA, i.e. deterministic
/// finite automaton), so it can retrieve all the possible matches, all
/// starting at the same point in the string. For instance matching
/// `"<a> <b> <c>"` against the pattern `"<.*>"`
/// you would obtain three matches: `"<a> <b> <c>"`,
/// `"<a> <b>"` and `"<a>"`.
/// </para>
/// <para>
/// The number of matched strings is retrieved using
/// g_match_info_get_match_count(). To obtain the matched strings and
/// their position you can use, respectively, g_match_info_fetch() and
/// g_match_info_fetch_pos(). Note that the strings are returned in
/// reverse order of length; that is, the longest matching string is
/// given first.
/// </para>
/// <para>
/// Note that the DFA algorithm is slower than the standard one and it
/// is not able to capture substrings, so backreferences do not work.
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a shortened
/// string and setting %G_REGEX_MATCH_NOTBOL in the case of a pattern
/// that begins with any kind of lookbehind assertion, such as "\b".
/// </para>
/// <para>
/// Unless %G_REGEX_RAW is specified in the options, @string must be valid UTF-8.
/// </para>
/// <para>
/// A #GMatchInfo structure, used to get information on the match, is
/// stored in @match_info if not %NULL. Note that if @match_info is
/// not %NULL then it is created even if the function returns %FALSE,
/// i.e. you must free it regardless if regular expression actually
/// matched.
/// </para>
/// <para>
/// @string is not copied and is used in #GMatchInfo internally. If
/// you use any #GMatchInfo method (except g_match_info_free()) after
/// freeing or modifying @string then the behaviour is undefined.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure from g_regex_new()
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="match_options">
/// match options
/// </param>
/// <param name="match_info">
/// pointer to location where to store
///     the #GMatchInfo, or %NULL if you do not need it
/// </param>
/// <return>
/// %TRUE is the string matched, %FALSE otherwise
/// </return>

	public static bool MatchAllFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_match_all_full(regex, @string, string_len, start_position, match_options, out match_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Scans for a match in @string for the pattern in @regex.
/// The @match_options are combined with the match options specified
/// when the @regex structure was created, letting you have more
/// flexibility in reusing #GRegex structures.
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a shortened
/// string and setting %G_REGEX_MATCH_NOTBOL in the case of a pattern
/// that begins with any kind of lookbehind assertion, such as "\b".
/// </para>
/// <para>
/// Unless %G_REGEX_RAW is specified in the options, @string must be valid UTF-8.
/// </para>
/// <para>
/// A #GMatchInfo structure, used to get information on the match, is
/// stored in @match_info if not %NULL. Note that if @match_info is
/// not %NULL then it is created even if the function returns %FALSE,
/// i.e. you must free it regardless if regular expression actually
/// matched.
/// </para>
/// <para>
/// @string is not copied and is used in #GMatchInfo internally. If
/// you use any #GMatchInfo method (except g_match_info_free()) after
/// freeing or modifying @string then the behaviour is undefined.
/// </para>
/// <para>
/// To retrieve all the non-overlapping matches of the pattern in
/// string you can use g_match_info_next().
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// print_uppercase_words (const gchar *string)
/// {
///   // Print all uppercase-only words.
///   GRegex *regex;
///   GMatchInfo *match_info;
///   GError *error = NULL;
/// </para>
/// <para>
///   regex = g_regex_new ("[A-Z]+", G_REGEX_DEFAULT, G_REGEX_MATCH_DEFAULT, NULL);
///   g_regex_match_full (regex, string, -1, 0, 0, &match_info, &error);
///   while (g_match_info_matches (match_info))
///     {
///       gchar *word = g_match_info_fetch (match_info, 0);
///       g_print ("Found: %s\n", word);
///       g_free (word);
///       g_match_info_next (match_info, &error);
///     }
///   g_match_info_free (match_info);
///   g_regex_unref (regex);
///   if (error != NULL)
///     {
///       g_printerr ("Error while matching: %s\n", error->message);
///       g_error_free (error);
///     }
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure from g_regex_new()
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="match_options">
/// match options
/// </param>
/// <param name="match_info">
/// pointer to location where to store
///     the #GMatchInfo, or %NULL if you do not need it
/// </param>
/// <return>
/// %TRUE is the string matched, %FALSE otherwise
/// </return>

	public static bool MatchFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GMatchInfoHandle match_info)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_match_full(regex, @string, string_len, start_position, match_options, out match_info, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increases reference count of @regex by 1.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>
/// <return>
/// @regex
/// </return>

	public static MentorLake.GLib.GRegexHandle Ref(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_ref(regex);
	}

/// <summary>
/// <para>
/// Replaces all occurrences of the pattern in @regex with the
/// replacement text. Backreferences of the form `\number` or
/// `\g<number>` in the replacement text are interpolated by the
/// number-th captured subexpression of the match, `\g<name>` refers
/// to the captured subexpression with the given name. `\0` refers
/// to the complete match, but `\0` followed by a number is the octal
/// representation of a character. To include a literal `\` in the
/// replacement, write `\\\\`.
/// </para>
/// <para>
/// There are also escapes that changes the case of the following text:
/// </para>
/// <para>
/// - \l: Convert to lower case the next character
/// - \u: Convert to upper case the next character
/// - \L: Convert to lower case till \E
/// - \U: Convert to upper case till \E
/// - \E: End case modification
/// </para>
/// <para>
/// If you do not need to use backreferences use g_regex_replace_literal().
/// </para>
/// <para>
/// The @replacement string must be UTF-8 encoded even if %G_REGEX_RAW was
/// passed to g_regex_new(). If you want to use not UTF-8 encoded strings
/// you can use g_regex_replace_literal().
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a shortened
/// string and setting %G_REGEX_MATCH_NOTBOL in the case of a pattern that
/// begins with any kind of lookbehind assertion, such as "\b".
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <param name="@string">
/// the string to perform matches against
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="replacement">
/// text to replace each match with
/// </param>
/// <param name="match_options">
/// options for the match
/// </param>
/// <return>
/// a newly allocated string containing the replacements
/// </return>

	public static string Replace(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_replace(regex, @string, string_len, start_position, replacement, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Replaces occurrences of the pattern in regex with the output of
/// @eval for that occurrence.
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a shortened
/// string and setting %G_REGEX_MATCH_NOTBOL in the case of a pattern
/// that begins with any kind of lookbehind assertion, such as "\b".
/// </para>
/// <para>
/// The following example uses g_regex_replace_eval() to replace multiple
/// strings at once:
/// |[<!-- language="C" -->
/// static gboolean
/// eval_cb (const GMatchInfo *info,
///          GString          *res,
///          gpointer          data)
/// {
///   gchar *match;
///   gchar *r;
/// </para>
/// <para>
///    match = g_match_info_fetch (info, 0);
///    r = g_hash_table_lookup ((GHashTable *)data, match);
///    g_string_append (res, r);
///    g_free (match);
/// </para>
/// <para>
///    return FALSE;
/// }
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// GRegex *reg;
/// GHashTable *h;
/// gchar *res;
/// </para>
/// <para>
/// h = g_hash_table_new (g_str_hash, g_str_equal);
/// </para>
/// <para>
/// g_hash_table_insert (h, "1", "ONE");
/// g_hash_table_insert (h, "2", "TWO");
/// g_hash_table_insert (h, "3", "THREE");
/// g_hash_table_insert (h, "4", "FOUR");
/// </para>
/// <para>
/// reg = g_regex_new ("1|2|3|4", G_REGEX_DEFAULT, G_REGEX_MATCH_DEFAULT, NULL);
/// res = g_regex_replace_eval (reg, text, -1, 0, 0, eval_cb, h, NULL);
/// g_hash_table_destroy (h);
/// </para>
/// <para>
/// ...
/// ]|
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure from g_regex_new()
/// </param>
/// <param name="@string">
/// string to perform matches against
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="match_options">
/// options for the match
/// </param>
/// <param name="eval">
/// a function to call for each match
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// a newly allocated string containing the replacements
/// </return>

	public static string ReplaceEval(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, MentorLake.GLib.GRegexEvalCallback eval, IntPtr user_data)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_replace_eval(regex, @string, string_len, start_position, match_options, eval, user_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Replaces all occurrences of the pattern in @regex with the
/// replacement text. @replacement is replaced literally, to
/// include backreferences use g_regex_replace().
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a
/// shortened string and setting %G_REGEX_MATCH_NOTBOL in the
/// case of a pattern that begins with any kind of lookbehind
/// assertion, such as "\b".
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <param name="@string">
/// the string to perform matches against
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="replacement">
/// text to replace each match with
/// </param>
/// <param name="match_options">
/// options for the match
/// </param>
/// <return>
/// a newly allocated string containing the replacements
/// </return>

	public static string ReplaceLiteral(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_replace_literal(regex, @string, string_len, start_position, replacement, match_options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Breaks the string on the pattern, and returns an array of the tokens.
/// If the pattern contains capturing parentheses, then the text for each
/// of the substrings will also be returned. If the pattern does not match
/// anywhere in the string, then the whole string is returned as the first
/// token.
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string "" is an
/// empty vector, not a vector containing a single string. The reason for
/// this special case is that being able to represent an empty vector is
/// typically more useful than consistent handling of empty elements. If
/// you do need to represent empty elements, you'll need to check for the
/// empty string before calling this function.
/// </para>
/// <para>
/// A pattern that can match empty strings splits @string into separate
/// characters wherever it matches the empty string between characters.
/// For example splitting "ab c" using as a separator "\s*", you will get
/// "a", "b" and "c".
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <param name="@string">
/// the string to split with the pattern
/// </param>
/// <param name="match_options">
/// match time option flags
/// </param>
/// <return>
/// a %NULL-terminated gchar ** array. Free
/// it using g_strfreev()
/// </return>

	public static string[] Split(this MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		return GRegexExterns.g_regex_split(regex, @string, match_options);
	}

/// <summary>
/// <para>
/// Breaks the string on the pattern, and returns an array of the tokens.
/// If the pattern contains capturing parentheses, then the text for each
/// of the substrings will also be returned. If the pattern does not match
/// anywhere in the string, then the whole string is returned as the first
/// token.
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string "" is an
/// empty vector, not a vector containing a single string. The reason for
/// this special case is that being able to represent an empty vector is
/// typically more useful than consistent handling of empty elements. If
/// you do need to represent empty elements, you'll need to check for the
/// empty string before calling this function.
/// </para>
/// <para>
/// A pattern that can match empty strings splits @string into separate
/// characters wherever it matches the empty string between characters.
/// For example splitting "ab c" using as a separator "\s*", you will get
/// "a", "b" and "c".
/// </para>
/// <para>
/// Setting @start_position differs from just passing over a shortened
/// string and setting %G_REGEX_MATCH_NOTBOL in the case of a pattern
/// that begins with any kind of lookbehind assertion, such as "\b".
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex structure
/// </param>
/// <param name="@string">
/// the string to split with the pattern
/// </param>
/// <param name="string_len">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <param name="start_position">
/// starting index of the string to match, in bytes
/// </param>
/// <param name="match_options">
/// match time option flags
/// </param>
/// <param name="max_tokens">
/// the maximum number of tokens to split @string into.
///   If this is less than 1, the string is split completely
/// </param>
/// <return>
/// a %NULL-terminated gchar ** array. Free
/// it using g_strfreev()
/// </return>

	public static string[] SplitFull(this MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, int max_tokens)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		var externCallResult = GRegexExterns.g_regex_split_full(regex, @string, string_len, start_position, match_options, max_tokens, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Decreases reference count of @regex by 1. When reference count drops
/// to zero, it frees all the memory associated with the regex structure.
/// </para>
/// </summary>

/// <param name="regex">
/// a #GRegex
/// </param>

	public static void Unref(this MentorLake.GLib.GRegexHandle regex)
	{
		if (regex.IsInvalid) throw new Exception("Invalid handle (GRegex)");
		GRegexExterns.g_regex_unref(regex);
	}


	public static GRegex Dereference(this GRegexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRegex>(x.DangerousGetHandle());
}
internal class GRegexExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))]
	internal static extern MentorLake.GLib.GRegexHandle g_regex_new(string pattern, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_capture_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexCompileFlags g_regex_get_compile_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_get_has_cr_or_lf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRegexMatchFlags g_regex_get_match_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_max_backref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_max_lookbehind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_get_pattern([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_regex_get_string_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_all_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMatchInfoHandle>))] out MentorLake.GLib.GMatchInfoHandle match_info, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))]
	internal static extern MentorLake.GLib.GRegexHandle g_regex_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace_eval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, MentorLake.GLib.GRegexEvalCallback eval, IntPtr user_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_replace_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, string replacement, MentorLake.GLib.GRegexMatchFlags match_options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string @string, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex, string[] @string, UIntPtr string_len, int start_position, MentorLake.GLib.GRegexMatchFlags match_options, int max_tokens, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_regex_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRegexHandle>))] MentorLake.GLib.GRegexHandle regex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_check_replacement(string replacement, out bool has_references, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_regex_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_nul(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_string(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

}

/// <summary>
/// <para>
/// A `GRegex` is the "compiled" form of a regular expression pattern.
/// </para>
/// <para>
/// `GRegex` implements regular expression pattern matching using syntax and
/// semantics similar to Perl regular expression. See the
/// [PCRE documentation](man:pcrepattern(3)) for the syntax definition.
/// </para>
/// <para>
/// Some functions accept a @start_position argument, setting it differs
/// from just passing over a shortened string and setting %G_REGEX_MATCH_NOTBOL
/// in the case of a pattern that begins with any kind of lookbehind assertion.
/// For example, consider the pattern "\Biss\B" which finds occurrences of "iss"
/// in the middle of words. ("\B" matches only if the current position in the
/// subject is not a word boundary.) When applied to the string "Mississipi"
/// from the fourth byte, namely "issipi", it does not match, because "\B" is
/// always false at the start of the subject, which is deemed to be a word
/// boundary. However, if the entire string is passed , but with
/// @start_position set to 4, it finds the second occurrence of "iss" because
/// it is able to look behind the starting point to discover that it is
/// preceded by a letter.
/// </para>
/// <para>
/// Note that, unless you set the %G_REGEX_RAW flag, all the strings passed
/// to these functions must be encoded in UTF-8. The lengths and the positions
/// inside the strings are in bytes and not in characters, so, for instance,
/// "\xc3\xa0" (i.e. "à") is two bytes long but it is treated as a
/// single character. If you set %G_REGEX_RAW the strings can be non-valid
/// UTF-8 strings and a byte is treated as a character, so "\xc3\xa0" is two
/// bytes and two characters long.
/// </para>
/// <para>
/// When matching a pattern, "\n" matches only against a "\n" character in
/// the string, and "\r" matches only a "\r" character. To match any newline
/// sequence use "\R". This particular group matches either the two-character
/// sequence CR + LF ("\r\n"), or one of the single characters LF (linefeed,
/// U+000A, "\n"), VT vertical tab, U+000B, "\v"), FF (formfeed, U+000C, "\f"),
/// CR (carriage return, U+000D, "\r"), NEL (next line, U+0085), LS (line
/// separator, U+2028), or PS (paragraph separator, U+2029).
/// </para>
/// <para>
/// The behaviour of the dot, circumflex, and dollar metacharacters are
/// affected by newline characters, the default is to recognize any newline
/// character (the same characters recognized by "\R"). This can be changed
/// with `G_REGEX_NEWLINE_CR`, `G_REGEX_NEWLINE_LF` and `G_REGEX_NEWLINE_CRLF`
/// compile options, and with `G_REGEX_MATCH_NEWLINE_ANY`,
/// `G_REGEX_MATCH_NEWLINE_CR`, `G_REGEX_MATCH_NEWLINE_LF` and
/// `G_REGEX_MATCH_NEWLINE_CRLF` match options. These settings are also
/// relevant when compiling a pattern if `G_REGEX_EXTENDED` is set, and an
/// unescaped "#" outside a character class is encountered. This indicates
/// a comment that lasts until after the next newline.
/// </para>
/// <para>
/// Creating and manipulating the same `GRegex` structure from different
/// threads is not a problem as `GRegex` does not modify its internal
/// state between creation and destruction, on the other hand `GMatchInfo`
/// is not threadsafe.
/// </para>
/// <para>
/// The regular expressions low-level functionalities are obtained through
/// the excellent [PCRE](http://www.pcre.org/) library written by Philip Hazel.
/// </para>
/// </summary>

public struct GRegex
{
/// <summary>
/// <para>
/// Checks whether @replacement is a valid replacement string
/// (see g_regex_replace()), i.e. that all escape sequences in
/// it are valid.
/// </para>
/// <para>
/// If @has_references is not %NULL then @replacement is checked
/// for pattern references. For instance, replacement text 'foo\n'
/// does not contain references and may be evaluated without information
/// about actual match, but '\0\1' (whole match followed by first
/// subpattern) requires valid #GMatchInfo object.
/// </para>
/// </summary>

/// <param name="replacement">
/// the replacement string
/// </param>
/// <param name="has_references">
/// location to store information about
///   references in @replacement or %NULL
/// </param>
/// <return>
/// whether @replacement is a valid replacement string
/// </return>

	public static bool CheckReplacement(string replacement, out bool has_references)
	{
		var externCallResult = GRegexExterns.g_regex_check_replacement(replacement, out has_references, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GRegexExterns.g_regex_error_quark();
	}

/// <summary>
/// <para>
/// Escapes the nul characters in @string to "\x00".  It can be used
/// to compile a regex with embedded nul characters.
/// </para>
/// <para>
/// For completeness, @length can be -1 for a nul-terminated string.
/// In this case the output string will be of course equal to @string.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to escape
/// </param>
/// <param name="length">
/// the length of @string
/// </param>
/// <return>
/// a newly-allocated escaped string
/// </return>

	public static string EscapeNul(string @string, int length)
	{
		return GRegexExterns.g_regex_escape_nul(@string, length);
	}

/// <summary>
/// <para>
/// Escapes the special characters used for regular expressions
/// in @string, for instance "a.b*c" becomes "a\.b\*c". This
/// function is useful to dynamically generate regular expressions.
/// </para>
/// <para>
/// @string can contain nul characters that are replaced with "\0",
/// in this case remember to specify the correct length of @string
/// in @length.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to escape
/// </param>
/// <param name="length">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <return>
/// a newly-allocated escaped string
/// </return>

	public static string EscapeString(string @string, int length)
	{
		return GRegexExterns.g_regex_escape_string(@string, length);
	}

/// <summary>
/// <para>
/// Scans for a match in @string for @pattern.
/// </para>
/// <para>
/// This function is equivalent to g_regex_match() but it does not
/// require to compile the pattern with g_regex_new(), avoiding some
/// lines of code when you need just to do a match without extracting
/// substrings, capture counts, and so on.
/// </para>
/// <para>
/// If this function is to be called on the same @pattern more than
/// once, it's more efficient to compile the pattern once with
/// g_regex_new() and then use g_regex_match().
/// </para>
/// </summary>

/// <param name="pattern">
/// the regular expression
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="compile_options">
/// compile options for the regular expression, or 0
/// </param>
/// <param name="match_options">
/// match options, or 0
/// </param>
/// <return>
/// %TRUE if the string matched, %FALSE otherwise
/// </return>

	public static bool MatchSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_match_simple(pattern, @string, compile_options, match_options);
	}

/// <summary>
/// <para>
/// Breaks the string on the pattern, and returns an array of
/// the tokens. If the pattern contains capturing parentheses,
/// then the text for each of the substrings will also be returned.
/// If the pattern does not match anywhere in the string, then the
/// whole string is returned as the first token.
/// </para>
/// <para>
/// This function is equivalent to g_regex_split() but it does
/// not require to compile the pattern with g_regex_new(), avoiding
/// some lines of code when you need just to do a split without
/// extracting substrings, capture counts, and so on.
/// </para>
/// <para>
/// If this function is to be called on the same @pattern more than
/// once, it's more efficient to compile the pattern once with
/// g_regex_new() and then use g_regex_split().
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string ""
/// is an empty vector, not a vector containing a single string.
/// The reason for this special case is that being able to represent
/// an empty vector is typically more useful than consistent handling
/// of empty elements. If you do need to represent empty elements,
/// you'll need to check for the empty string before calling this
/// function.
/// </para>
/// <para>
/// A pattern that can match empty strings splits @string into
/// separate characters wherever it matches the empty string between
/// characters. For example splitting "ab c" using as a separator
/// "\s*", you will get "a", "b" and "c".
/// </para>
/// </summary>

/// <param name="pattern">
/// the regular expression
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="compile_options">
/// compile options for the regular expression, or 0
/// </param>
/// <param name="match_options">
/// match options, or 0
/// </param>
/// <return>
/// a %NULL-terminated array of strings. Free
/// it using g_strfreev()
/// </return>

	public static string[] SplitSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GRegexExterns.g_regex_split_simple(pattern, @string, compile_options, match_options);
	}

}
