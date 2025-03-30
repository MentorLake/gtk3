namespace MentorLake.Gtk;

[Flags]
public enum GtkDialogFlags : uint
{
	GTK_DIALOG_MODAL = 1,
	GTK_DIALOG_DESTROY_WITH_PARENT = 2,
	GTK_DIALOG_USE_HEADER_BAR = 4
}
