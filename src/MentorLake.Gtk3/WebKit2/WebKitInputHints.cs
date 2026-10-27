namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to describe hints that might be taken into account by input methods.
/// </para>
/// </summary>

[Flags]
public enum WebKitInputHints : uint
{
/// <summary>
/// <para>
/// No special behavior suggested
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_NONE = 0,
/// <summary>
/// <para>
/// Suggest spell checking
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_SPELLCHECK = 1,
/// <summary>
/// <para>
/// Suggest to not autocapitlize
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_LOWERCASE = 2,
/// <summary>
/// <para>
/// Suggest to capitalize all text
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_UPPERCASE_CHARS = 4,
/// <summary>
/// <para>
/// Suggest to capitalize the first character of each word
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_UPPERCASE_WORDS = 8,
/// <summary>
/// <para>
/// Suggest to capitalize the first word of each sentence
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_UPPERCASE_SENTENCES = 16,
/// <summary>
/// <para>
/// Suggest to not show an onscreen keyboard
/// </para>
/// </summary>

	WEBKIT_INPUT_HINT_INHIBIT_OSK = 32
}
