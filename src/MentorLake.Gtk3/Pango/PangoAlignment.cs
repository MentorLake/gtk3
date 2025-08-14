namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoAlignment` describes how to align the lines of a `PangoLayout`
/// within the available space.
/// </para>
/// <para>
/// If the `PangoLayout` is set to justify using [method@Pango.Layout.set_justify],
/// this only affects partial lines.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_auto_dir] for how text direction affects
/// the interpretation of `PangoAlignment` values.
/// </para>
/// </summary>

[Flags]
public enum PangoAlignment
{
/// <summary>
/// <para>
/// Put all available space on the right
/// </para>
/// </summary>

	PANGO_ALIGN_LEFT = 0,
/// <summary>
/// <para>
/// Center the line within the available space
/// </para>
/// </summary>

	PANGO_ALIGN_CENTER = 1,
/// <summary>
/// <para>
/// Put all available space on the left
/// </para>
/// </summary>

	PANGO_ALIGN_RIGHT = 2
}
