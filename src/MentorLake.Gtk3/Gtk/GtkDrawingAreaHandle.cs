namespace MentorLake.Gtk;

public class GtkDrawingAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaHandleExterns.gtk_drawing_area_new();
	}

}

public static class GtkDrawingAreaHandleExtensions
{
}

internal class GtkDrawingAreaHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkDrawingAreaHandle gtk_drawing_area_new();

}
