namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11CursorHandle : GdkCursorHandle
{
}

public static class GdkX11CursorHandleExtensions
{
	public static IntPtr GetXcursor(GdkCursorHandle cursor)
	{
		return GdkX11CursorExterns.gdk_x11_cursor_get_xcursor(cursor);
	}

	public static IntPtr GetXdisplay(GdkCursorHandle cursor)
	{
		return GdkX11CursorExterns.gdk_x11_cursor_get_xdisplay(cursor);
	}

}

internal class GdkX11CursorExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern IntPtr gdk_x11_cursor_get_xcursor(GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern IntPtr gdk_x11_cursor_get_xdisplay(GdkCursorHandle cursor);

}
