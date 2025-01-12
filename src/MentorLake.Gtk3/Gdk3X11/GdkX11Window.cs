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
	public static uint GetDesktop(GdkWindowHandle window)
	{
		return GdkX11WindowExterns.gdk_x11_window_get_desktop(window);
	}

	public static IntPtr GetXid(GdkWindowHandle window)
	{
		return GdkX11WindowExterns.gdk_x11_window_get_xid(window);
	}

	public static void MoveToCurrentDesktop(GdkWindowHandle window)
	{
		GdkX11WindowExterns.gdk_x11_window_move_to_current_desktop(window);
	}

	public static void MoveToDesktop(GdkWindowHandle window, uint desktop)
	{
		GdkX11WindowExterns.gdk_x11_window_move_to_desktop(window, desktop);
	}

	public static void SetFrameExtents(GdkWindowHandle window, int left, int right, int top, int bottom)
	{
		GdkX11WindowExterns.gdk_x11_window_set_frame_extents(window, left, right, top, bottom);
	}

	public static void SetFrameSyncEnabled(GdkWindowHandle window, bool frame_sync_enabled)
	{
		GdkX11WindowExterns.gdk_x11_window_set_frame_sync_enabled(window, frame_sync_enabled);
	}

	public static void SetHideTitlebarWhenMaximized(GdkWindowHandle window, bool hide_titlebar_when_maximized)
	{
		GdkX11WindowExterns.gdk_x11_window_set_hide_titlebar_when_maximized(window, hide_titlebar_when_maximized);
	}

	public static void SetThemeVariant(GdkWindowHandle window, string variant)
	{
		GdkX11WindowExterns.gdk_x11_window_set_theme_variant(window, variant);
	}

	public static void SetUserTime(GdkWindowHandle window, uint timestamp)
	{
		GdkX11WindowExterns.gdk_x11_window_set_user_time(window, timestamp);
	}

	public static void SetUtf8Property(GdkWindowHandle window, string name, string value)
	{
		GdkX11WindowExterns.gdk_x11_window_set_utf8_property(window, name, value);
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
