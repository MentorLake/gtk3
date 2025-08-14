namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoOverline` enumeration is used to specify whether text
/// should be overlined, and if so, the type of line.
/// </para>
/// </summary>

[Flags]
public enum PangoOverline
{
/// <summary>
/// <para>
/// no overline should be drawn
/// </para>
/// </summary>

	PANGO_OVERLINE_NONE = 0,
/// <summary>
/// <para>
/// Draw a single line above the ink
///   extents of the text being underlined.
/// </para>
/// </summary>

	PANGO_OVERLINE_SINGLE = 1
}
