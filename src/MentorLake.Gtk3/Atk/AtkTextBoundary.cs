namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Text boundary types used for specifying boundaries for regions of text.
/// This enumeration is deprecated since 2.9.4 and should not be used. Use
/// AtkTextGranularity with #atk_text_get_string_at_offset instead.
/// </para>
/// </summary>

[Flags]
public enum AtkTextBoundary
{
/// <summary>
/// <para>
/// Boundary is the boundary between characters
/// (including non-printing characters)
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_CHAR = 0,
/// <summary>
/// <para>
/// Boundary is the start (i.e. first character) of a word.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_WORD_START = 1,
/// <summary>
/// <para>
/// Boundary is the end (i.e. last
/// character) of a word.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_WORD_END = 2,
/// <summary>
/// <para>
/// Boundary is the first character in a sentence.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_SENTENCE_START = 3,
/// <summary>
/// <para>
/// Boundary is the last (terminal)
/// character in a sentence; in languages which use &quot;sentence stop&quot;
/// punctuation such as English, the boundary is thus the &apos;.&apos;, &apos;?&apos;, or
/// similar terminal punctuation character.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_SENTENCE_END = 4,
/// <summary>
/// <para>
/// Boundary is the initial character of the content or a
/// character immediately following a newline, linefeed, or return character.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_LINE_START = 5,
/// <summary>
/// <para>
/// Boundary is the linefeed, or return
/// character.
/// </para>
/// </summary>

	ATK_TEXT_BOUNDARY_LINE_END = 6
}
