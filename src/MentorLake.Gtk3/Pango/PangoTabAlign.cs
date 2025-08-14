namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoTabAlign` specifies where the text appears relative to the tab stop
/// position.
/// </para>
/// </summary>

[Flags]
public enum PangoTabAlign
{
/// <summary>
/// <para>
/// the text appears to the right of the tab stop position
/// </para>
/// </summary>

	PANGO_TAB_LEFT = 0,
/// <summary>
/// <para>
/// the text appears to the left of the tab stop position
///   until the available space is filled. Since: 1.50
/// </para>
/// </summary>

	PANGO_TAB_RIGHT = 1,
/// <summary>
/// <para>
/// the text is centered at the tab stop position
///   until the available space is filled. Since: 1.50
/// </para>
/// </summary>

	PANGO_TAB_CENTER = 2,
/// <summary>
/// <para>
/// text before the first occurrence of the decimal point
///   character appears to the left of the tab stop position (until the available
///   space is filled), the rest to the right. Since: 1.50
/// </para>
/// </summary>

	PANGO_TAB_DECIMAL = 3
}
