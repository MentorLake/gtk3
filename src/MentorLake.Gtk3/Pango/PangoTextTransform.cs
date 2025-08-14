namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration that affects how Pango treats characters during shaping.
/// </para>
/// </summary>

[Flags]
public enum PangoTextTransform
{
/// <summary>
/// <para>
/// Leave text unchanged
/// </para>
/// </summary>

	PANGO_TEXT_TRANSFORM_NONE = 0,
/// <summary>
/// <para>
/// Display letters and numbers as lowercase
/// </para>
/// </summary>

	PANGO_TEXT_TRANSFORM_LOWERCASE = 1,
/// <summary>
/// <para>
/// Display letters and numbers as uppercase
/// </para>
/// </summary>

	PANGO_TEXT_TRANSFORM_UPPERCASE = 2,
/// <summary>
/// <para>
/// Display the first character of a word
///   in titlecase
/// </para>
/// </summary>

	PANGO_TEXT_TRANSFORM_CAPITALIZE = 3
}
