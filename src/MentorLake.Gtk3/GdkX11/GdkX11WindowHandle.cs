namespace MentorLake.GdkX11;

public class GdkX11WindowHandle : GdkWindowHandle
{
	public static MentorLake.GdkX11.GdkX11WindowHandle ForeignNewForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_foreign_new_for_display(display, window);
	}

	public static MentorLake.GdkX11.GdkX11WindowHandle LookupForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_lookup_for_display(display, window);
	}

}

public static class GdkX11WindowHandleExtensions
{
	public static uint GetDesktop(this MentorLake.GdkX11.GdkX11WindowHandle window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_get_desktop(window);
	}

	public static MentorLake.xlib.Window GetXid(this MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_get_xid(window);
	}

	public static T MoveToCurrentDesktop<T>(this T window) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_move_to_current_desktop(window);
		return window;
	}

	public static T MoveToDesktop<T>(this T window, uint desktop) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_move_to_desktop(window, desktop);
		return window;
	}

	public static T SetFrameExtents<T>(this T window, int left, int right, int top, int bottom) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_frame_extents(window, left, right, top, bottom);
		return window;
	}

	public static T SetFrameSyncEnabled<T>(this T window, bool frame_sync_enabled) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_frame_sync_enabled(window, frame_sync_enabled);
		return window;
	}

	public static T SetHideTitlebarWhenMaximized<T>(this T window, bool hide_titlebar_when_maximized) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_hide_titlebar_when_maximized(window, hide_titlebar_when_maximized);
		return window;
	}

	public static T SetThemeVariant<T>(this T window, string variant) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_theme_variant(window, variant);
		return window;
	}

	public static T SetUserTime<T>(this T window, uint timestamp) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_user_time(window, timestamp);
		return window;
	}

	public static T SetUtf8Property<T>(this T window, string name, string value) where T : GdkX11WindowHandle
	{
		GdkX11WindowHandleExterns.gdk_x11_window_set_utf8_property(window, name, value);
		return window;
	}

}

internal class GdkX11WindowHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.GdkX11.GdkX11WindowHandle gdk_x11_window_foreign_new_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window);

	[DllImport(GdkX11Library.Name)]
	internal static extern uint gdk_x11_window_get_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Window gdk_x11_window_get_xid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_move_to_current_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_move_to_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, uint desktop);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_frame_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, int left, int right, int top, int bottom);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_frame_sync_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, bool frame_sync_enabled);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_hide_titlebar_when_maximized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, bool hide_titlebar_when_maximized);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_theme_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, string variant);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_user_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, uint timestamp);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_window_set_utf8_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))] MentorLake.GdkX11.GdkX11WindowHandle window, string name, string value);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.GdkX11.GdkX11WindowHandle gdk_x11_window_lookup_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window);

}
