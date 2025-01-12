namespace MentorLake.Gtk3.Gtk3;

public class GtkColorSelectionDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkColorSelectionDialogHandle New(string title)
	{
		return GtkColorSelectionDialogExterns.gtk_color_selection_dialog_new(title);
	}

}

public static class GtkColorSelectionDialogHandleExtensions
{
	public static GtkWidgetHandle GetColorSelection(this GtkColorSelectionDialogHandle colorsel)
	{
		return GtkColorSelectionDialogExterns.gtk_color_selection_dialog_get_color_selection(colorsel);
	}

}

internal class GtkColorSelectionDialogExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorSelectionDialogHandle gtk_color_selection_dialog_new(string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_color_selection_dialog_get_color_selection(GtkColorSelectionDialogHandle colorsel);

}
