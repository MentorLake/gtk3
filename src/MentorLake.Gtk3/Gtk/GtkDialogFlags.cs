namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Flags used to influence dialog construction.
/// </para>
/// </summary>

[Flags]
public enum GtkDialogFlags : uint
{
/// <summary>
/// <para>
/// Make the constructed dialog modal,
///     see gtk_window_set_modal()
/// </para>
/// </summary>

	GTK_DIALOG_MODAL = 1,
/// <summary>
/// <para>
/// Destroy the dialog when its
///     parent is destroyed, see gtk_window_set_destroy_with_parent()
/// </para>
/// </summary>

	GTK_DIALOG_DESTROY_WITH_PARENT = 2,
/// <summary>
/// <para>
/// Create dialog with actions in header
///     bar instead of action area. Since 3.12.
/// </para>
/// </summary>

	GTK_DIALOG_USE_HEADER_BAR = 4
}
