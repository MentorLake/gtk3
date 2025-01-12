namespace MentorLake.Gtk3.Gtk3;

public class GtkFileChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle
{
	public static GtkFileChooserDialogHandle New(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}

}

public static class GtkFileChooserDialogHandleExtensions
{
}

internal class GtkFileChooserDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, GtkWindowHandle parent, GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);

}
