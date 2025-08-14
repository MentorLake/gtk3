namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_settings_set_orientation().
/// </para>
/// </summary>

[Flags]
public enum GtkPageOrientation
{
/// <summary>
/// <para>
/// Portrait mode.
/// </para>
/// </summary>

	GTK_PAGE_ORIENTATION_PORTRAIT = 0,
/// <summary>
/// <para>
/// Landscape mode.
/// </para>
/// </summary>

	GTK_PAGE_ORIENTATION_LANDSCAPE = 1,
/// <summary>
/// <para>
/// Reverse portrait mode.
/// </para>
/// </summary>

	GTK_PAGE_ORIENTATION_REVERSE_PORTRAIT = 2,
/// <summary>
/// <para>
/// Reverse landscape mode.
/// </para>
/// </summary>

	GTK_PAGE_ORIENTATION_REVERSE_LANDSCAPE = 3
}
