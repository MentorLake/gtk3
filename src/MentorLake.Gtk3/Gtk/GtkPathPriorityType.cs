namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Priorities for path lookups.
/// See also gtk_binding_set_add_path().
/// </para>
/// </summary>

[Flags]
public enum GtkPathPriorityType
{
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_LOWEST = 0,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_GTK = 4,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_APPLICATION = 8,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_THEME = 10,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_RC = 12,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_PATH_PRIO_HIGHEST = 15
}
