namespace MentorLake.Gtk3.Gtk3;

public class GtkDrawingAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaExterns.gtk_drawing_area_new();
	}

}

public static class GtkDrawingAreaHandleExtensions
{
}

internal class GtkDrawingAreaExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkDrawingAreaHandle gtk_drawing_area_new();

}
