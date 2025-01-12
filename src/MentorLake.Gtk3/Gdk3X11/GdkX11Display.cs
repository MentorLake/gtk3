namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11DisplayHandle : GdkDisplayHandle
{
	public static bool GetGlxVersion(GdkDisplayHandle display, out int major, out int minor)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_glx_version(display, out major, out minor);
	}

}

public static class GdkX11DisplayHandleExtensions
{
	public static void BroadcastStartupMessage(GdkDisplayHandle display, string message_type, IntPtr @__arglist)
	{
		GdkX11DisplayExterns.gdk_x11_display_broadcast_startup_message(display, message_type, @__arglist);
	}

	public static int ErrorTrapPop(GdkDisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_error_trap_pop(display);
	}

	public static void ErrorTrapPopIgnored(GdkDisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_pop_ignored(display);
	}

	public static void ErrorTrapPush(GdkDisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_push(display);
	}

	public static string GetStartupNotificationId(GdkDisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_startup_notification_id(display);
	}

	public static uint GetUserTime(GdkDisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_user_time(display);
	}

	public static IntPtr GetXdisplay(GdkDisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xdisplay(display);
	}

	public static void Grab(GdkDisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_grab(display);
	}

	public static void SetCursorTheme(GdkDisplayHandle display, string theme, int size)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_cursor_theme(display, theme, size);
	}

	public static void SetStartupNotificationId(GdkDisplayHandle display, string startup_id)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_startup_notification_id(display, startup_id);
	}

	public static void SetWindowScale(GdkDisplayHandle display, int scale)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_window_scale(display, scale);
	}

	public static int StringToCompoundText(GdkDisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length)
	{
		return GdkX11DisplayExterns.gdk_x11_display_string_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

	public static int TextPropertyToTextList(GdkDisplayHandle display, GdkAtom encoding, int format, string text, int length, ref string[] list)
	{
		return GdkX11DisplayExterns.gdk_x11_display_text_property_to_text_list(display, encoding, format, text, length, ref list);
	}

	public static void Ungrab(GdkDisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_ungrab(display);
	}

	public static bool Utf8ToCompoundText(GdkDisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length)
	{
		return GdkX11DisplayExterns.gdk_x11_display_utf8_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

}

internal class GdkX11DisplayExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_broadcast_startup_message(GdkDisplayHandle display, string message_type, IntPtr @__arglist);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern int gdk_x11_display_error_trap_pop(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_error_trap_pop_ignored(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_error_trap_push(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_display_get_startup_notification_id(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern uint gdk_x11_display_get_user_time(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern IntPtr gdk_x11_display_get_xdisplay(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_grab(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_set_cursor_theme(GdkDisplayHandle display, string theme, int size);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_set_startup_notification_id(GdkDisplayHandle display, string startup_id);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_set_window_scale(GdkDisplayHandle display, int scale);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern int gdk_x11_display_string_to_compound_text(GdkDisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern int gdk_x11_display_text_property_to_text_list(GdkDisplayHandle display, GdkAtom encoding, int format, string text, int length, ref string[] list);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern void gdk_x11_display_ungrab(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern bool gdk_x11_display_utf8_to_compound_text(GdkDisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern bool gdk_x11_display_get_glx_version(GdkDisplayHandle display, out int major, out int minor);

}
