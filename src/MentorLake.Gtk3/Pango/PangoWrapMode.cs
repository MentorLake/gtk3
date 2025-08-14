namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoWrapMode` describes how to wrap the lines of a `PangoLayout`
/// to the desired width.
/// </para>
/// <para>
/// For @PANGO_WRAP_WORD, Pango uses break opportunities that are determined
/// by the Unicode line breaking algorithm. For @PANGO_WRAP_CHAR, Pango allows
/// breaking at grapheme boundaries that are determined by the Unicode text
/// segmentation algorithm.
/// </para>
/// </summary>

[Flags]
public enum PangoWrapMode
{
/// <summary>
/// <para>
/// wrap lines at word boundaries.
/// </para>
/// </summary>

	PANGO_WRAP_WORD = 0,
/// <summary>
/// <para>
/// wrap lines at character boundaries.
/// </para>
/// </summary>

	PANGO_WRAP_CHAR = 1,
/// <summary>
/// <para>
/// wrap lines at word boundaries, but fall back to
///   character boundaries if there is not enough space for a full word.
/// </para>
/// </summary>

	PANGO_WRAP_WORD_CHAR = 2,
/// <summary>
/// <para>
/// do not wrap.
/// </para>
/// </summary>

	PANGO_WRAP_NONE = 3
}
