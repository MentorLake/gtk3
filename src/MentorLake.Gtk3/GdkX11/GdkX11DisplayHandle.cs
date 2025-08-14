namespace MentorLake.GdkX11;


public class GdkX11DisplayHandle : GdkDisplayHandle
{
/// <summary>
/// <para>
/// Retrieves the version of the GLX implementation.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="major">
/// return location for the GLX major version
/// </param>
/// <param name="minor">
/// return location for the GLX minor version
/// </param>
/// <return>
/// %TRUE if GLX is available
/// </return>

	public static bool GetGlxVersion(MentorLake.Gdk.GdkDisplayHandle display, out int major, out int minor)
	{
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_glx_version(display, out major, out minor);
	}

}

public static class GdkX11DisplayHandleExtensions
{
/// <summary>
/// <para>
/// Sends a startup notification message of type @message_type to
/// @display.
/// </para>
/// <para>
/// This is a convenience function for use by code that implements the
/// freedesktop startup notification specification. Applications should
/// not normally need to call it directly. See the
/// [Startup Notification Protocol specification](http://standards.freedesktop.org/startup-notification-spec/startup-notification-latest.txt)
/// for definitions of the message types and keys that can be used.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="message_type">
/// startup notification message type ("new", "change",
/// or "remove")
/// </param>
/// <param name="@__arglist">
/// a list of key/value pairs (as strings), terminated by a
/// %NULL key. (A %NULL value for a key will cause that key to be
/// skipped in the output.)
/// </param>

	public static T BroadcastStartupMessage<T>(this T display, string message_type, IntPtr @__arglist) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_broadcast_startup_message(display, message_type, @__arglist);
		return display;
	}

/// <summary>
/// <para>
/// Pops the error trap pushed by gdk_x11_display_error_trap_push().
/// Will XSync() if necessary and will always block until
/// the error is known to have occurred or not occurred,
/// so the error code can be returned.
/// </para>
/// <para>
/// If you don’t need to use the return value,
/// gdk_x11_display_error_trap_pop_ignored() would be more efficient.
/// </para>
/// <para>
/// See gdk_error_trap_pop() for the all-displays-at-once
/// equivalent.
/// </para>
/// </summary>

/// <param name="display">
/// the display
/// </param>
/// <return>
/// X error code or 0 on success
/// </return>

	public static int ErrorTrapPop(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_pop(display);
	}

/// <summary>
/// <para>
/// Pops the error trap pushed by gdk_x11_display_error_trap_push().
/// Does not block to see if an error occurred; merely records the
/// range of requests to ignore errors for, and ignores those errors
/// if they arrive asynchronously.
/// </para>
/// <para>
/// See gdk_error_trap_pop_ignored() for the all-displays-at-once
/// equivalent.
/// </para>
/// </summary>

/// <param name="display">
/// the display
/// </param>

	public static T ErrorTrapPopIgnored<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_pop_ignored(display);
		return display;
	}

/// <summary>
/// <para>
/// Begins a range of X requests on @display for which X error events
/// will be ignored. Unignored errors (when no trap is pushed) will abort
/// the application. Use gdk_x11_display_error_trap_pop() or
/// gdk_x11_display_error_trap_pop_ignored()to lift a trap pushed
/// with this function.
/// </para>
/// <para>
/// See also gdk_error_trap_push() to push a trap on all displays.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T ErrorTrapPush<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_push(display);
		return display;
	}

/// <summary>
/// <para>
/// Gets the startup notification ID for a display.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the startup notification ID for @display
/// </return>

	public static string GetStartupNotificationId(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_startup_notification_id(display);
	}

/// <summary>
/// <para>
/// Returns the timestamp of the last user interaction on
/// @display. The timestamp is taken from events caused
/// by user interaction such as key presses or pointer
/// movements. See gdk_x11_window_set_user_time().
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// the timestamp of the last user interaction
/// </return>

	public static uint GetUserTime(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_user_time(display);
	}

/// <summary>
/// <para>
/// Returns the X display of a #GdkDisplay.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <return>
/// an X display
/// </return>

	public static MentorLake.xlib.DisplayHandle GetXdisplay(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_xdisplay(display);
	}

/// <summary>
/// <para>
/// Call XGrabServer() on @display.
/// To ungrab the display again, use gdk_x11_display_ungrab().
/// </para>
/// <para>
/// gdk_x11_display_grab()/gdk_x11_display_ungrab() calls can be nested.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Grab<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_grab(display);
		return display;
	}

/// <summary>
/// <para>
/// Sets the cursor theme from which the images for cursor
/// should be taken.
/// </para>
/// <para>
/// If the windowing system supports it, existing cursors created
/// with gdk_cursor_new(), gdk_cursor_new_for_display() and
/// gdk_cursor_new_from_name() are updated to reflect the theme
/// change. Custom cursors constructed with
/// gdk_cursor_new_from_pixbuf() will have to be handled
/// by the application (GTK+ applications can learn about
/// cursor theme changes by listening for change notification
/// for the corresponding #GtkSetting).
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="theme">
/// the name of the cursor theme to use, or %NULL to unset
///         a previously set value
/// </param>
/// <param name="size">
/// the cursor size to use, or 0 to keep the previous size
/// </param>

	public static T SetCursorTheme<T>(this T display, string theme, int size) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_cursor_theme(display, theme, size);
		return display;
	}

/// <summary>
/// <para>
/// Sets the startup notification ID for a display.
/// </para>
/// <para>
/// This is usually taken from the value of the DESKTOP_STARTUP_ID
/// environment variable, but in some cases (such as the application not
/// being launched using exec()) it can come from other sources.
/// </para>
/// <para>
/// If the ID contains the string "_TIME" then the portion following that
/// string is taken to be the X11 timestamp of the event that triggered
/// the application to be launched and the GDK current event time is set
/// accordingly.
/// </para>
/// <para>
/// The startup ID is also what is used to signal that the startup is
/// complete (for example, when opening a window or when calling
/// gdk_notify_startup_complete()).
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="startup_id">
/// the startup notification ID (must be valid utf8)
/// </param>

	public static T SetStartupNotificationId<T>(this T display, string startup_id) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_startup_notification_id(display, startup_id);
		return display;
	}

/// <summary>
/// <para>
/// Forces a specific window scale for all windows on this display,
/// instead of using the default or user configured scale. This
/// is can be used to disable scaling support by setting @scale to
/// 1, or to programmatically set the window scale.
/// </para>
/// <para>
/// Once the scale is set by this call it will not change in response
/// to later user configuration changes.
/// </para>
/// </summary>

/// <param name="display">
/// the display
/// </param>
/// <param name="scale">
/// The new scale value
/// </param>

	public static T SetWindowScale<T>(this T display, int scale) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_window_scale(display, scale);
		return display;
	}

/// <summary>
/// <para>
/// Convert a string from the encoding of the current
/// locale into a form suitable for storing in a window property.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay where the encoding is defined
/// </param>
/// <param name="str">
/// a nul-terminated string
/// </param>
/// <param name="encoding">
/// location to store the encoding atom
///     (to be used as the type for the property)
/// </param>
/// <param name="format">
/// location to store the format of the property
/// </param>
/// <param name="ctext">
/// location to store newly
///     allocated data for the property
/// </param>
/// <param name="length">
/// the length of @ctext, in bytes
/// </param>
/// <return>
/// 0 upon success, non-zero upon failure
/// </return>

	public static int StringToCompoundText(this MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, out byte[] ctext, out int length)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_string_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

/// <summary>
/// <para>
/// Convert a text string from the encoding as it is stored
/// in a property into an array of strings in the encoding of
/// the current locale. (The elements of the array represent the
/// nul-separated elements of the original text string.)
/// </para>
/// </summary>

/// <param name="display">
/// The #GdkDisplay where the encoding is defined
/// </param>
/// <param name="encoding">
/// an atom representing the encoding. The most
///    common values for this are STRING, or COMPOUND_TEXT.
///    This is value used as the type for the property
/// </param>
/// <param name="format">
/// the format of the property
/// </param>
/// <param name="text">
/// The text data
/// </param>
/// <param name="length">
/// The number of items to transform
/// </param>
/// <param name="list">
/// location to store an  array of strings in
///    the encoding of the current locale. This array should be
///    freed using gdk_free_text_list().
/// </param>
/// <return>
/// the number of strings stored in list, or 0,
///     if the conversion failed
/// </return>

	public static int TextPropertyToTextList(this MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, byte text, int length, string list)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_text_property_to_text_list(display, encoding, format, text, length, list);
	}

/// <summary>
/// <para>
/// Ungrab @display after it has been grabbed with
/// gdk_x11_display_grab().
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T Ungrab<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_ungrab(display);
		return display;
	}

/// <summary>
/// <para>
/// Converts from UTF-8 to compound text.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="str">
/// a UTF-8 string
/// </param>
/// <param name="encoding">
/// location to store resulting encoding
/// </param>
/// <param name="format">
/// location to store format of the result
/// </param>
/// <param name="ctext">
/// location to store the data of the result
/// </param>
/// <param name="length">
/// location to store the length of the data
///     stored in @ctext
/// </param>
/// <return>
/// %TRUE if the conversion succeeded,
///     otherwise %FALSE
/// </return>

	public static bool Utf8ToCompoundText(this MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, out byte[] ctext, out int length)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_utf8_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

}

internal class GdkX11DisplayHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_broadcast_startup_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string message_type, IntPtr @__arglist);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_display_error_trap_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_error_trap_pop_ignored([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_error_trap_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_display_get_startup_notification_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern uint gdk_x11_display_get_user_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))]
	internal static extern MentorLake.xlib.DisplayHandle gdk_x11_display_get_xdisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_set_cursor_theme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string theme, int size);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_set_startup_notification_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string startup_id);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_set_window_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, int scale);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_display_string_to_compound_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out byte[] ctext, out int length);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_display_text_property_to_text_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, byte text, int length, string list);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_display_utf8_to_compound_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out byte[] ctext, out int length);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_display_get_glx_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, out int major, out int minor);

}
