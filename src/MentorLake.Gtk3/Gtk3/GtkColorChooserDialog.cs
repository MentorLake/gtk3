namespace MentorLake.Gtk3.Gtk3;

public class GtkColorChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle
{
	public static GtkColorChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkColorChooserDialogExterns.gtk_color_chooser_dialog_new(title, parent);
	}

}

public static class GtkColorChooserDialogHandleExtensions
{
}

internal class GtkColorChooserDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorChooserDialogHandle gtk_color_chooser_dialog_new(string title, GtkWindowHandle parent);

}
