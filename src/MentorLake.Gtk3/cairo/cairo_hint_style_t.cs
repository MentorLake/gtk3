namespace MentorLake.cairo;

/// <summary>
/// <para>
/// Specifies the type of hinting to do on font outlines. Hinting
/// is the process of fitting outlines to the pixel grid in order
/// to improve the appearance of the result. Since hinting outlines
/// involves distorting them, it also reduces the faithfulness
/// to the original outline shapes. Not all of the outline hinting
/// styles are supported by all font backends.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_hint_style_t
{
/// <summary>
/// <para>
/// Use the default hint style for
///   font backend and target device, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_STYLE_DEFAULT = 0,
/// <summary>
/// <para>
/// Do not hint outlines, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_STYLE_NONE = 1,
/// <summary>
/// <para>
/// Hint outlines slightly to improve
///   contrast while retaining good fidelity to the original
///   shapes, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_STYLE_SLIGHT = 2,
/// <summary>
/// <para>
/// Hint outlines with medium strength
///   giving a compromise between fidelity to the original shapes
///   and contrast, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_STYLE_MEDIUM = 3,
/// <summary>
/// <para>
/// Hint outlines to maximize contrast, since 1.0
/// </para>
/// </summary>

	CAIRO_HINT_STYLE_FULL = 4
}
