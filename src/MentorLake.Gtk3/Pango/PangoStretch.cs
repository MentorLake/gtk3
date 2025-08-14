namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration specifying the width of the font relative to other designs
/// within a family.
/// </para>
/// </summary>

[Flags]
public enum PangoStretch
{
/// <summary>
/// <para>
/// ultra condensed width
/// </para>
/// </summary>

	PANGO_STRETCH_ULTRA_CONDENSED = 0,
/// <summary>
/// <para>
/// extra condensed width
/// </para>
/// </summary>

	PANGO_STRETCH_EXTRA_CONDENSED = 1,
/// <summary>
/// <para>
/// condensed width
/// </para>
/// </summary>

	PANGO_STRETCH_CONDENSED = 2,
/// <summary>
/// <para>
/// semi condensed width
/// </para>
/// </summary>

	PANGO_STRETCH_SEMI_CONDENSED = 3,
/// <summary>
/// <para>
/// the normal width
/// </para>
/// </summary>

	PANGO_STRETCH_NORMAL = 4,
/// <summary>
/// <para>
/// semi expanded width
/// </para>
/// </summary>

	PANGO_STRETCH_SEMI_EXPANDED = 5,
/// <summary>
/// <para>
/// expanded width
/// </para>
/// </summary>

	PANGO_STRETCH_EXPANDED = 6,
/// <summary>
/// <para>
/// extra expanded width
/// </para>
/// </summary>

	PANGO_STRETCH_EXTRA_EXPANDED = 7,
/// <summary>
/// <para>
/// ultra expanded width
/// </para>
/// </summary>

	PANGO_STRETCH_ULTRA_EXPANDED = 8
}
