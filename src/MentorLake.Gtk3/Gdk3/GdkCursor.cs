namespace MentorLake.Gtk3.Gdk3;

public class GdkCursorHandle : GObjectHandle
{
	public static GdkCursorHandle New(GdkCursorType cursor_type)
	{
		return GdkCursorExterns.gdk_cursor_new(cursor_type);
	}

	public static GdkCursorHandle NewForDisplay(GdkDisplayHandle display, GdkCursorType cursor_type)
	{
		return GdkCursorExterns.gdk_cursor_new_for_display(display, cursor_type);
	}

	public static GdkCursorHandle NewFromName(GdkDisplayHandle display, string name)
	{
		return GdkCursorExterns.gdk_cursor_new_from_name(display, name);
	}

	public static GdkCursorHandle NewFromPixbuf(GdkDisplayHandle display, GdkPixbufHandle pixbuf, int x, int y)
	{
		return GdkCursorExterns.gdk_cursor_new_from_pixbuf(display, pixbuf, x, y);
	}

	public static GdkCursorHandle NewFromSurface(GdkDisplayHandle display, cairo_surface_tHandle surface, double x, double y)
	{
		return GdkCursorExterns.gdk_cursor_new_from_surface(display, surface, x, y);
	}

}

public static class GdkCursorHandleExtensions
{
	public static GdkCursorType GetCursorType(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_cursor_type(cursor);
	}

	public static GdkDisplayHandle GetDisplay(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_display(cursor);
	}

	public static GdkPixbufHandle GetImage(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_get_image(cursor);
	}

	public static cairo_surface_tHandle GetSurface(this GdkCursorHandle cursor, out double x_hot, out double y_hot)
	{
		return GdkCursorExterns.gdk_cursor_get_surface(cursor, out x_hot, out y_hot);
	}

	public static GdkCursorHandle Ref(this GdkCursorHandle cursor)
	{
		return GdkCursorExterns.gdk_cursor_ref(cursor);
	}

	public static GdkCursorHandle Unref(this GdkCursorHandle cursor)
	{
		GdkCursorExterns.gdk_cursor_unref(cursor);
		return cursor;
	}

}

internal class GdkCursorExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_new(GdkCursorType cursor_type);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_new_for_display(GdkDisplayHandle display, GdkCursorType cursor_type);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_new_from_name(GdkDisplayHandle display, string name);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_new_from_pixbuf(GdkDisplayHandle display, GdkPixbufHandle pixbuf, int x, int y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_new_from_surface(GdkDisplayHandle display, cairo_surface_tHandle surface, double x, double y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorType gdk_cursor_get_cursor_type(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDisplayHandle gdk_cursor_get_display(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkPixbufHandle gdk_cursor_get_image(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_surface_tHandle gdk_cursor_get_surface(GdkCursorHandle cursor, out double x_hot, out double y_hot);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkCursorHandle gdk_cursor_ref(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cursor_unref(GdkCursorHandle cursor);

}
