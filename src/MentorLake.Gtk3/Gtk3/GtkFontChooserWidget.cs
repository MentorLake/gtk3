namespace MentorLake.Gtk3.Gtk3;

public class GtkFontChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFontChooserHandle, GtkOrientableHandle
{
	public static GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetExterns.gtk_font_chooser_widget_new();
	}

}

public static class GtkFontChooserWidgetHandleExtensions
{
}

internal class GtkFontChooserWidgetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontChooserWidgetHandle gtk_font_chooser_widget_new();

}
