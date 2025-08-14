namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Text granularity types used for specifying the granularity of the region of
/// text we are interested in.
/// </para>
/// </summary>

[Flags]
public enum AtkTextGranularity
{
/// <summary>
/// <para>
/// Granularity is defined by the boundaries between characters
/// (including non-printing characters)
/// </para>
/// </summary>

	ATK_TEXT_GRANULARITY_CHAR = 0,
/// <summary>
/// <para>
/// Granularity is defined by the boundaries of a word,
/// starting at the beginning of the current word and finishing at the beginning of
/// the following one, if present.
/// </para>
/// </summary>

	ATK_TEXT_GRANULARITY_WORD = 1,
/// <summary>
/// <para>
/// Granularity is defined by the boundaries of a sentence,
/// starting at the beginning of the current sentence and finishing at the beginning of
/// the following one, if present.
/// </para>
/// </summary>

	ATK_TEXT_GRANULARITY_SENTENCE = 2,
/// <summary>
/// <para>
/// Granularity is defined by the boundaries of a line,
/// starting at the beginning of the current line and finishing at the beginning of
/// the following one, if present.
/// </para>
/// </summary>

	ATK_TEXT_GRANULARITY_LINE = 3,
/// <summary>
/// <para>
/// Granularity is defined by the boundaries of a paragraph,
/// starting at the beginning of the current paragraph and finishing at the beginning of
/// the following one, if present.
/// </para>
/// </summary>

	ATK_TEXT_GRANULARITY_PARAGRAPH = 4
}
