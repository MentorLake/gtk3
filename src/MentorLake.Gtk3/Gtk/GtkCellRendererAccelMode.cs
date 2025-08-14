namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Determines if the edited accelerators are GTK+ accelerators. If
/// they are, consumed modifiers are suppressed, only accelerators
/// accepted by GTK+ are allowed, and the accelerators are rendered
/// in the same way as they are in menus.
/// </para>
/// </summary>

[Flags]
public enum GtkCellRendererAccelMode
{
/// <summary>
/// <para>
/// GTK+ accelerators mode
/// </para>
/// </summary>

	GTK_CELL_RENDERER_ACCEL_MODE_GTK = 0,
/// <summary>
/// <para>
/// Other accelerator mode
/// </para>
/// </summary>

	GTK_CELL_RENDERER_ACCEL_MODE_OTHER = 1
}
