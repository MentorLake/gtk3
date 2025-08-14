namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_settings_set_duplex().
/// </para>
/// </summary>

[Flags]
public enum GtkPrintDuplex
{
/// <summary>
/// <para>
/// No duplex.
/// </para>
/// </summary>

	GTK_PRINT_DUPLEX_SIMPLEX = 0,
/// <summary>
/// <para>
/// Horizontal duplex.
/// </para>
/// </summary>

	GTK_PRINT_DUPLEX_HORIZONTAL = 1,
/// <summary>
/// <para>
/// Vertical duplex.
/// </para>
/// </summary>

	GTK_PRINT_DUPLEX_VERTICAL = 2
}
