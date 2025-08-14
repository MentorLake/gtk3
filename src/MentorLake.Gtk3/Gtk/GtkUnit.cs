namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_settings_set_paper_width().
/// </para>
/// </summary>

[Flags]
public enum GtkUnit
{
/// <summary>
/// <para>
/// No units.
/// </para>
/// </summary>

	GTK_UNIT_NONE = 0,
/// <summary>
/// <para>
/// Dimensions in points.
/// </para>
/// </summary>

	GTK_UNIT_POINTS = 1,
/// <summary>
/// <para>
/// Dimensions in inches.
/// </para>
/// </summary>

	GTK_UNIT_INCH = 2,
/// <summary>
/// <para>
/// Dimensions in millimeters
/// </para>
/// </summary>

	GTK_UNIT_MM = 3
}
