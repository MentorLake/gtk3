namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_settings_set_quality().
/// </para>
/// </summary>

[Flags]
public enum GtkPrintQuality
{
/// <summary>
/// <para>
/// Low quality.
/// </para>
/// </summary>

	GTK_PRINT_QUALITY_LOW = 0,
/// <summary>
/// <para>
/// Normal quality.
/// </para>
/// </summary>

	GTK_PRINT_QUALITY_NORMAL = 1,
/// <summary>
/// <para>
/// High quality.
/// </para>
/// </summary>

	GTK_PRINT_QUALITY_HIGH = 2,
/// <summary>
/// <para>
/// Draft quality.
/// </para>
/// </summary>

	GTK_PRINT_QUALITY_DRAFT = 3
}
