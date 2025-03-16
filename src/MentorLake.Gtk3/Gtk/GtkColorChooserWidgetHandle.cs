namespace MentorLake.Gtk;

public class GtkColorChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetHandleExterns.gtk_color_chooser_widget_new();
	}

}

public static class GtkColorChooserWidgetHandleExtensions
{
}

internal class GtkColorChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkColorChooserWidgetHandle gtk_color_chooser_widget_new();

}
