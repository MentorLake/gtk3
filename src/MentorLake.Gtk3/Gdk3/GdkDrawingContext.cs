namespace MentorLake.Gtk3.Gdk3;

public class GdkDrawingContextHandle : GObjectHandle
{
}

public static class GdkDrawingContextHandleExtensions
{
	public static cairo_tHandle GetCairoContext(this GdkDrawingContextHandle context)
	{
		return GdkDrawingContextExterns.gdk_drawing_context_get_cairo_context(context);
	}

	public static cairo_region_tHandle GetClip(this GdkDrawingContextHandle context)
	{
		return GdkDrawingContextExterns.gdk_drawing_context_get_clip(context);
	}

	public static GdkWindowHandle GetWindow(this GdkDrawingContextHandle context)
	{
		return GdkDrawingContextExterns.gdk_drawing_context_get_window(context);
	}

	public static bool IsValid(this GdkDrawingContextHandle context)
	{
		return GdkDrawingContextExterns.gdk_drawing_context_is_valid(context);
	}

}

internal class GdkDrawingContextExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_tHandle gdk_drawing_context_get_cairo_context(GdkDrawingContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_drawing_context_get_clip(GdkDrawingContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_drawing_context_get_window(GdkDrawingContextHandle context);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_drawing_context_is_valid(GdkDrawingContextHandle context);

}
