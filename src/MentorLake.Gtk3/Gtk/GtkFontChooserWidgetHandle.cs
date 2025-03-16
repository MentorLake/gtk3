namespace MentorLake.Gtk;

public class GtkFontChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetHandleExterns.gtk_font_chooser_widget_new();
	}

}

public static class GtkFontChooserWidgetHandleExtensions
{
}

internal class GtkFontChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontChooserWidgetHandle gtk_font_chooser_widget_new();

}
