namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoLogAttr` structure stores information about the attributes of a
/// single character.
/// </para>
/// </summary>

public class PangoLogAttrHandle : BaseSafeHandle
{
}


public static class PangoLogAttrExtensions
{

	public static PangoLogAttr Dereference(this PangoLogAttrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLogAttr>(x.DangerousGetHandle());
}
internal class PangoLogAttrExterns
{
}

/// <summary>
/// <para>
/// The `PangoLogAttr` structure stores information about the attributes of a
/// single character.
/// </para>
/// </summary>

public struct PangoLogAttr
{
	/// <summary>
/// <para>
/// if set, can break line in front of character
/// </para>
/// </summary>

public uint is_line_break;
	/// <summary>
/// <para>
/// if set, must break line in front of character
/// </para>
/// </summary>

public uint is_mandatory_break;
	/// <summary>
/// <para>
/// if set, can break here when doing character wrapping
/// </para>
/// </summary>

public uint is_char_break;
	/// <summary>
/// <para>
/// is whitespace character
/// </para>
/// </summary>

public uint is_white;
	/// <summary>
/// <para>
/// if set, cursor can appear in front of character.
///   i.e. this is a grapheme boundary, or the first character in the text.
///   This flag implements Unicode's
///   [Grapheme Cluster Boundaries](http://www.unicode.org/reports/tr29/)
///   semantics.
/// </para>
/// </summary>

public uint is_cursor_position;
	/// <summary>
/// <para>
/// is first character in a word
/// </para>
/// </summary>

public uint is_word_start;
	/// <summary>
/// <para>
/// is first non-word char after a word
///   Note that in degenerate cases, you could have both @is_word_start
///   and @is_word_end set for some character.
/// </para>
/// </summary>

public uint is_word_end;
	/// <summary>
/// <para>
/// is a sentence boundary.
///   There are two ways to divide sentences. The first assigns all
///   inter-sentence whitespace/control/format chars to some sentence,
///   so all chars are in some sentence; @is_sentence_boundary denotes
///   the boundaries there. The second way doesn't assign
///   between-sentence spaces, etc. to any sentence, so
///   @is_sentence_start/@is_sentence_end mark the boundaries of those sentences.
/// </para>
/// </summary>

public uint is_sentence_boundary;
	/// <summary>
/// <para>
/// is first character in a sentence
/// </para>
/// </summary>

public uint is_sentence_start;
	/// <summary>
/// <para>
/// is first char after a sentence.
///   Note that in degenerate cases, you could have both @is_sentence_start
///   and @is_sentence_end set for some character. (e.g. no space after a
///   period, so the next sentence starts right away)
/// </para>
/// </summary>

public uint is_sentence_end;
	/// <summary>
/// <para>
/// if set, backspace deletes one character
///   rather than the entire grapheme cluster. This field is only meaningful
///   on grapheme boundaries (where @is_cursor_position is set). In some languages,
///   the full grapheme (e.g. letter + diacritics) is considered a unit, while in
///   others, each decomposed character in the grapheme is a unit. In the default
///   implementation of [func@break], this bit is set on all grapheme boundaries
///   except those following Latin, Cyrillic or Greek base characters.
/// </para>
/// </summary>

public uint backspace_deletes_character;
	/// <summary>
/// <para>
/// is a whitespace character that can possibly be
///   expanded for justification purposes. (Since: 1.18)
/// </para>
/// </summary>

public uint is_expandable_space;
	/// <summary>
/// <para>
/// is a word boundary, as defined by UAX#29.
///   More specifically, means that this is not a position in the middle of a word.
///   For example, both sides of a punctuation mark are considered word boundaries.
///   This flag is particularly useful when selecting text word-by-word. This flag
///   implements Unicode's [Word Boundaries](http://www.unicode.org/reports/tr29/)
///   semantics. (Since: 1.22)
/// </para>
/// </summary>

public uint is_word_boundary;
	/// <summary>
/// <para>
/// when breaking lines before this char, insert a hyphen.
///   Since: 1.50
/// </para>
/// </summary>

public uint break_inserts_hyphen;
	/// <summary>
/// <para>
/// when breaking lines before this char, remove the
///   preceding char. Since 1.50
/// </para>
/// </summary>

public uint break_removes_preceding;
	
public uint reserved;
}
