namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies variants of a font face based on their weight.
/// </para>
/// </summary>

[Flags]
public enum cairo_font_weight_t
{
/// <summary>
/// <para>
/// Normal font weight, since 1.0
/// </para>
/// </summary>

	CAIRO_FONT_WEIGHT_NORMAL = 0,
/// <summary>
/// <para>
/// Bold font weight, since 1.0
/// </para>
/// </summary>

	CAIRO_FONT_WEIGHT_BOLD = 1
}
