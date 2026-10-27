namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify search options.
/// </para>
/// </summary>

[Flags]
public enum WebKitFindOptions : uint
{
/// <summary>
/// <para>
/// no search flags, this means a case
///   sensitive, no wrap, forward only search.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_NONE = 0,
/// <summary>
/// <para>
/// case insensitive search.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_CASE_INSENSITIVE = 1,
/// <summary>
/// <para>
/// search text only at the
///   begining of the words.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_AT_WORD_STARTS = 2,
/// <summary>
/// <para>
/// treat
///   capital letters in the middle of words as word start.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_TREAT_MEDIAL_CAPITAL_AS_WORD_START = 4,
/// <summary>
/// <para>
/// search backwards.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_BACKWARDS = 8,
/// <summary>
/// <para>
/// if not present search will stop
///   at the end of the document.
/// </para>
/// </summary>

	WEBKIT_FIND_OPTIONS_WRAP_AROUND = 16
}
