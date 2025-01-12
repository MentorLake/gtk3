namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11WindowHandle : GdkWindowHandle
{
	public static GdkX11WindowHandle ForeignNewForDisplay(GdkDisplayHandle display, IntPtr window)
	{
		return GdkX11WindowExterns.gdk_x11_window_foreign_new_for_display(display, window);
	}

	public static GdkWindowHandle LookupForDisplay(GdkDisplayHandle display, IntPtr window)
	{
		return GdkX11WindowExterns.gdk_x11_window_lookup_for_display(display, window);
	}

}

public static class GdkX11WindowHandleExtensions
{
	public static uint GetDesktop(this GdkX11WindowHandle window)
	{
		return GdkX11WindowExterns.gdk_x11_window_get_desktop(window);
	}

	public static IntPtr GetXid(this GdkX11WindowHandle window)
	{
		return GdkX11WindowExterns.gdk_x11_window_get_xid(window);
	}

	public static GdkX11WindowHandle MoveToCurrentDesktop(this GdkX11WindowHandle window)
	{
		GdkX11WindowExterns.gdk_x11_window_move_to_current_desktop(window);
		return window;
	}

	public static GdkX11WindowHandle MoveToDesktop(this GdkX11WindowHandle window, uint desktop)
	{
		GdkX11WindowExterns.gdk_x11_window_move_to_desktop(window, desktop);
		return window;
	}

	public static GdkX11WindowHandle SetFrameExtents(this GdkX11WindowHandle window, int left, int right, int top, int bottom)
	{
		GdkX11WindowExterns.gdk_x11_window_set_frame_extents(window, left, right, top, bottom);
		return window;
	}

	public static GdkX11WindowHandle SetFrameSyncEnabled(this GdkX11WindowHandle window, bool frame_sync_enabled)
	{
		GdkX11WindowExterns.gdk_x11_window_set_frame_sync_enabled(window, frame_sync_enabled);
		return window;
	}

	public static GdkX11WindowHandle SetHideTitlebarWhenMaximized(this GdkX11WindowHandle window, bool hide_titlebar_when_maximized)
	{
		GdkX11WindowExterns.gdk_x11_window_set_hide_titlebar_when_maximized(window, hide_titlebar_when_maximized);
		return window;
	}

	public static GdkX11WindowHandle SetThemeVariant(this GdkX11WindowHandle window, string variant)
	{
		GdkX11WindowExterns.gdk_x11_window_set_theme_variant(window, variant);
		return window;
	}

	public static GdkX11WindowHandle SetUserTime(this GdkX11WindowHandle window, uint timestamp)
	{
		GdkX11WindowExterns.gdk_x11_window_set_user_time(window, timestamp);
		return window;
	}

	public static GdkX11WindowHandle SetUtf8Property(this GdkX11WindowHandle window, string name, string value)
	{
		GdkX11WindowExterns.gdk_x11_window_set_utf8_property(window, name, value);
		return window;
	}

}

internal class GdkX11WindowExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern GdkX11WindowHandle gdk_x11_window_foreign_new_for_display(GdkDisplayHandle display, IntPtr window);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern uint gdk_x11_window_get_desktop(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern IntPtr gdk_x11_window_get_xid(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_move_to_current_desktop(GdkWindowHandle window);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_move_to_desktop(GdkWindowHandle window, uint desktop);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_frame_extents(GdkWindowHandle window, int left, int right, int top, int bottom);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_frame_sync_enabled(GdkWindowHandle window, bool frame_sync_enabled);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_hide_titlebar_when_maximized(GdkWindowHandle window, bool hide_titlebar_when_maximized);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_theme_variant(GdkWindowHandle window, string variant);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_user_time(GdkWindowHandle window, uint timestamp);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_window_set_utf8_property(GdkWindowHandle window, string name, string value);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern GdkWindowHandle gdk_x11_window_lookup_for_display(GdkDisplayHandle display, IntPtr window);

}
