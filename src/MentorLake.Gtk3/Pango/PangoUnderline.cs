namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoUnderline` enumeration is used to specify whether text
/// should be underlined, and if so, the type of underlining.
/// </para>
/// </summary>

[Flags]
public enum PangoUnderline
{
/// <summary>
/// <para>
/// no underline should be drawn
/// </para>
/// </summary>

	PANGO_UNDERLINE_NONE = 0,
/// <summary>
/// <para>
/// a single underline should be drawn
/// </para>
/// </summary>

	PANGO_UNDERLINE_SINGLE = 1,
/// <summary>
/// <para>
/// a double underline should be drawn
/// </para>
/// </summary>

	PANGO_UNDERLINE_DOUBLE = 2,
/// <summary>
/// <para>
/// a single underline should be drawn at a
///   position beneath the ink extents of the text being
///   underlined. This should be used only for underlining
///   single characters, such as for keyboard accelerators.
///   %PANGO_UNDERLINE_SINGLE should be used for extended
///   portions of text.
/// </para>
/// </summary>

	PANGO_UNDERLINE_LOW = 3,
/// <summary>
/// <para>
/// an underline indicating an error should
///   be drawn below. The exact style of rendering is up to the
///   `PangoRenderer` in use, but typical styles include wavy
///   or dotted lines.
///   This underline is typically used to indicate an error such
///   as a possible mispelling; in some cases a contrasting color
///   may automatically be used. This type of underlining is
///   available since Pango 1.4.
/// </para>
/// </summary>

	PANGO_UNDERLINE_ERROR = 4,
/// <summary>
/// <para>
/// Like @PANGO_UNDERLINE_SINGLE, but
///   drawn continuously across multiple runs. This type
///   of underlining is available since Pango 1.46.
/// </para>
/// </summary>

	PANGO_UNDERLINE_SINGLE_LINE = 5,
/// <summary>
/// <para>
/// Like @PANGO_UNDERLINE_DOUBLE, but
///   drawn continuously across multiple runs. This type
///   of underlining is available since Pango 1.46.
/// </para>
/// </summary>

	PANGO_UNDERLINE_DOUBLE_LINE = 6,
/// <summary>
/// <para>
/// Like @PANGO_UNDERLINE_ERROR, but
///   drawn continuously across multiple runs. This type
///   of underlining is available since Pango 1.46.
/// </para>
/// </summary>

	PANGO_UNDERLINE_ERROR_LINE = 7
}
