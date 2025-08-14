namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoCoverageLevel` is used to indicate how well a font can
/// represent a particular Unicode character for a particular script.
/// </para>
/// <para>
/// Since 1.44, only %PANGO_COVERAGE_NONE and %PANGO_COVERAGE_EXACT
/// will be returned.
/// </para>
/// </summary>

[Flags]
public enum PangoCoverageLevel
{
/// <summary>
/// <para>
/// The character is not representable with
///   the font.
/// </para>
/// </summary>

	PANGO_COVERAGE_NONE = 0,
/// <summary>
/// <para>
/// The character is represented in a
///   way that may be comprehensible but is not the correct
///   graphical form. For instance, a Hangul character represented
///   as a a sequence of Jamos, or a Latin transliteration of a
///   Cyrillic word.
/// </para>
/// </summary>

	PANGO_COVERAGE_FALLBACK = 1,
/// <summary>
/// <para>
/// The character is represented as
///   basically the correct graphical form, but with a stylistic
///   variant inappropriate for the current script.
/// </para>
/// </summary>

	PANGO_COVERAGE_APPROXIMATE = 2,
/// <summary>
/// <para>
/// The character is represented as the
///   correct graphical form.
/// </para>
/// </summary>

	PANGO_COVERAGE_EXACT = 3
}
