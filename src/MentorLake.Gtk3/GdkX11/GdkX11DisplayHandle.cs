namespace MentorLake.GdkX11;

public class GdkX11DisplayHandle : GdkDisplayHandle
{
	public static bool GetGlxVersion(MentorLake.Gdk.GdkDisplayHandle display, out int major, out int minor)
	{
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_glx_version(display, out major, out minor);
	}

}

public static class GdkX11DisplayHandleExtensions
{
	public static T BroadcastStartupMessage<T>(this T display, string message_type, IntPtr @__arglist) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_broadcast_startup_message(display, message_type, @__arglist);
		return display;
	}

	public static int ErrorTrapPop(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_pop(display);
	}

	public static T ErrorTrapPopIgnored<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_pop_ignored(display);
		return display;
	}

	public static T ErrorTrapPush<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_error_trap_push(display);
		return display;
	}

	public static string GetStartupNotificationId(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_startup_notification_id(display);
	}

	public static uint GetUserTime(this MentorLake.GdkX11.GdkX11DisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_user_time(display);
	}

	public static MentorLake.xlib.DisplayHandle GetXdisplay(this MentorLake.Gdk.GdkDisplayHandle display)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_get_xdisplay(display);
	}

	public static T Grab<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_grab(display);
		return display;
	}

	public static T SetCursorTheme<T>(this T display, string theme, int size) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_cursor_theme(display, theme, size);
		return display;
	}

	public static T SetStartupNotificationId<T>(this T display, string startup_id) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_startup_notification_id(display, startup_id);
		return display;
	}

	public static T SetWindowScale<T>(this T display, int scale) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_set_window_scale(display, scale);
		return display;
	}

	public static int StringToCompoundText(this MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, out char[] ctext, out int length)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_string_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

	public static int TextPropertyToTextList(this MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, char text, int length, string list)
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		return GdkX11DisplayHandleExterns.gdk_x11_display_text_property_to_text_list(display, encoding, format, text, length, list);
	}

	public static T Ungrab<T>(this T display) where T : GdkX11DisplayHandle
	{
		if (display.IsInvalid) throw new Exception("Invalid handle (GdkX11DisplayHandle)");
		GdkX11DisplayHandleExterns.gdk_x11_display_ungrab(display);
		return display;
	}

	public static bool Utf8ToCompoundText(this MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, out char[] ctext, out int length)
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
	internal static extern int gdk_x11_display_string_to_compound_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out char[] ctext, out int length);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_display_text_property_to_text_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, char text, int length, string list);

	[DllImport(GdkX11Library.Name)]
	internal static extern void gdk_x11_display_ungrab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_display_utf8_to_compound_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11DisplayHandle>))] MentorLake.GdkX11.GdkX11DisplayHandle display, string str, out MentorLake.Gdk.GdkAtom encoding, out int format, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out char[] ctext, out int length);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_display_get_glx_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, out int major, out int minor);

}
