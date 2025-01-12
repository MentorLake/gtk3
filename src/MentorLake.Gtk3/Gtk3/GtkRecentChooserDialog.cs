namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static GtkRecentChooserDialogHandle New(string title, GtkWindowHandle parent, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogExterns.gtk_recent_chooser_dialog_new(title, parent, first_button_text, @__arglist);
	}

	public static GtkRecentChooserDialogHandle NewForManager(string title, GtkWindowHandle parent, GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogExterns.gtk_recent_chooser_dialog_new_for_manager(title, parent, manager, first_button_text, @__arglist);
	}

}

public static class GtkRecentChooserDialogHandleExtensions
{
}

internal class GtkRecentChooserDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new(string title, GtkWindowHandle parent, string first_button_text, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new_for_manager(string title, GtkWindowHandle parent, GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist);

}
