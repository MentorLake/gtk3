namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Widget path types.
/// See also gtk_binding_set_add_path().
/// </para>
/// </summary>

[Flags]
public enum GtkPathType
{
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_WIDGET = 0,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_WIDGET_CLASS = 1,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_CLASS = 2
}
