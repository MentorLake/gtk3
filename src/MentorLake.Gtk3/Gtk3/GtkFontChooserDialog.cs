namespace MentorLake.Gtk3.Gtk3;

public class GtkFontChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle
{
	public static GtkFontChooserDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkFontChooserDialogExterns.gtk_font_chooser_dialog_new(title, parent);
	}

}

public static class GtkFontChooserDialogHandleExtensions
{
}

internal class GtkFontChooserDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontChooserDialogHandle gtk_font_chooser_dialog_new(string title, GtkWindowHandle parent);

}
