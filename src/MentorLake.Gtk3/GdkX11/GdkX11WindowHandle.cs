namespace MentorLake.GdkX11;


public class GdkX11WindowHandle : GdkWindowHandle
{
/// <summary>
/// <para>
/// Wraps a native window in a #GdkWindow. The function will try to
/// look up the window using gdk_x11_window_lookup_for_display() first.
/// If it does not find it there, it will create a new window.
/// </para>
/// <para>
/// This may fail if the window has been destroyed. If the window
/// was already known to GDK, a new reference to the existing
/// #GdkWindow is returned.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay where the window handle comes from.
/// </param>
/// <param name="window">
/// an Xlib Window
/// </param>
/// <return>
/// a #GdkWindow wrapper for the native
///   window, or %NULL if the window has been destroyed. The wrapper
///   will be newly created, if one doesn’t exist already.
/// </return>

	public static MentorLake.GdkX11.GdkX11WindowHandle ForeignNewForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_foreign_new_for_display(display, window);
	}

/// <summary>
/// <para>
/// Looks up the #GdkWindow that wraps the given native window handle.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay corresponding to the
///           window handle
/// </param>
/// <param name="window">
/// an Xlib Window
/// </param>
/// <return>
/// the #GdkWindow wrapper for the native
///    window, or %NULL if there is none.
/// </return>

	public static MentorLake.GdkX11.GdkX11WindowHandle LookupForDisplay(MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window)
	{
		return GdkX11WindowHandleExterns.gdk_x11_window_lookup_for_display(display, window);
	}

}

public static class GdkX11WindowHandleExtensions
{
/// <summary>
/// <para>
/// Gets the number of the workspace @window is on.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the current workspace of @window
/// </return>

	public static uint GetDesktop(this MentorLake.GdkX11.GdkX11WindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		return GdkX11WindowHandleExterns.gdk_x11_window_get_desktop(window);
	}

/// <summary>
/// <para>
/// Returns the X resource (window) belonging to a #GdkWindow.
/// </para>
/// </summary>

/// <param name="window">
/// a native #GdkWindow.
/// </param>
/// <return>
/// the ID of @drawable’s X resource.
/// </return>

	public static MentorLake.xlib.Window GetXid(this MentorLake.Gdk.GdkWindowHandle window)
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		return GdkX11WindowHandleExterns.gdk_x11_window_get_xid(window);
	}

/// <summary>
/// <para>
/// Moves the window to the correct workspace when running under a
/// window manager that supports multiple workspaces, as described
/// in the [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec) specification.
/// Will not do anything if the window is already on all workspaces.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T MoveToCurrentDesktop<T>(this T window) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_move_to_current_desktop(window);
		return window;
	}

/// <summary>
/// <para>
/// Moves the window to the given workspace when running unde a
/// window manager that supports multiple workspaces, as described
/// in the [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec) specification.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="desktop">
/// the number of the workspace to move the window to
/// </param>

	public static T MoveToDesktop<T>(this T window, uint desktop) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_move_to_desktop(window, desktop);
		return window;
	}

/// <summary>
/// <para>
/// This is the same as gdk_window_set_shadow_width() but it only works
/// on GdkX11Window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="left">
/// The left extent
/// </param>
/// <param name="right">
/// The right extent
/// </param>
/// <param name="top">
/// The top extent
/// </param>
/// <param name="bottom">
/// The bottom extent
/// </param>

	public static T SetFrameExtents<T>(this T window, int left, int right, int top, int bottom) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_frame_extents(window, left, right, top, bottom);
		return window;
	}

/// <summary>
/// <para>
/// This function can be used to disable frame synchronization for a window.
/// Normally frame synchronziation will be enabled or disabled based on whether
/// the system has a compositor that supports frame synchronization, but if
/// the window is not directly managed by the window manager, then frame
/// synchronziation may need to be disabled. This is the case for a window
/// embedded via the XEMBED protocol.
/// </para>
/// </summary>

/// <param name="window">
/// a native #GdkWindow
/// </param>
/// <param name="frame_sync_enabled">
/// whether frame-synchronization should be enabled
/// </param>

	public static T SetFrameSyncEnabled<T>(this T window, bool frame_sync_enabled) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_frame_sync_enabled(window, frame_sync_enabled);
		return window;
	}

/// <summary>
/// <para>
/// Set a hint for the window manager, requesting that the titlebar
/// should be hidden when the window is maximized.
/// </para>
/// <para>
/// Note that this property is automatically updated by GTK+, so this
/// function should only be used by applications which do not use GTK+
/// to create toplevel windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="hide_titlebar_when_maximized">
/// whether to hide the titlebar when
///                                maximized
/// </param>

	public static T SetHideTitlebarWhenMaximized<T>(this T window, bool hide_titlebar_when_maximized) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_hide_titlebar_when_maximized(window, hide_titlebar_when_maximized);
		return window;
	}

/// <summary>
/// <para>
/// GTK+ applications can request a dark theme variant. In order to
/// make other applications - namely window managers using GTK+ for
/// themeing - aware of this choice, GTK+ uses this function to
/// export the requested theme variant as _GTK_THEME_VARIANT property
/// on toplevel windows.
/// </para>
/// <para>
/// Note that this property is automatically updated by GTK+, so this
/// function should only be used by applications which do not use GTK+
/// to create toplevel windows.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="variant">
/// the theme variant to export
/// </param>

	public static T SetThemeVariant<T>(this T window, string variant) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_theme_variant(window, variant);
		return window;
	}

/// <summary>
/// <para>
/// The application can use this call to update the _NET_WM_USER_TIME
/// property on a toplevel window.  This property stores an Xserver
/// time which represents the time of the last user input event
/// received for this window.  This property may be used by the window
/// manager to alter the focus, stacking, and/or placement behavior of
/// windows when they are mapped depending on whether the new window
/// was created by a user action or is a "pop-up" window activated by a
/// timer or some other event.
/// </para>
/// <para>
/// Note that this property is automatically updated by GDK, so this
/// function should only be used by applications which handle input
/// events bypassing GDK.
/// </para>
/// </summary>

/// <param name="window">
/// A toplevel #GdkWindow
/// </param>
/// <param name="timestamp">
/// An XServer timestamp to which the property should be set
/// </param>

	public static T SetUserTime<T>(this T window, uint timestamp) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_user_time(window, timestamp);
		return window;
	}

/// <summary>
/// <para>
/// This function modifies or removes an arbitrary X11 window
/// property of type UTF8_STRING.  If the given @window is
/// not a toplevel window, it is ignored.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="name">
/// Property name, will be interned as an X atom
/// </param>
/// <param name="value">
/// Property value, or %NULL to delete
/// </param>

	public static T SetUtf8Property<T>(this T window, string name, string value) where T : GdkX11WindowHandle
	{
		if (window.IsInvalid) throw new Exception("Invalid handle (GdkX11WindowHandle)");
		GdkX11WindowHandleExterns.gdk_x11_window_set_utf8_property(window, name, value);
		return window;
	}

}

internal class GdkX11WindowHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11WindowHandle>))]
	internal static extern MentorLake.GdkX11.GdkX11WindowHandle gdk_x11_window_lookup_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.xlib.Window window);

}
