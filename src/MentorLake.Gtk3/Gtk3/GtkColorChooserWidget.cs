namespace MentorLake.Gtk3.Gtk3;

public class GtkColorChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkOrientableHandle
{
	public static GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetExterns.gtk_color_chooser_widget_new();
	}

}

public static class GtkColorChooserWidgetHandleExtensions
{
}

internal class GtkColorChooserWidgetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkColorChooserWidgetHandle gtk_color_chooser_widget_new();

}
