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
	public static GdkX11DisplayHandle BroadcastStartupMessage(this GdkX11DisplayHandle display, string message_type, IntPtr @__arglist)
	{
		GdkX11DisplayExterns.gdk_x11_display_broadcast_startup_message(display, message_type, @__arglist);
		return display;
	}

	public static int ErrorTrapPop(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_error_trap_pop(display);
	}

	public static GdkX11DisplayHandle ErrorTrapPopIgnored(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_pop_ignored(display);
		return display;
	}

	public static GdkX11DisplayHandle ErrorTrapPush(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_push(display);
		return display;
	}

	public static string GetStartupNotificationId(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_startup_notification_id(display);
	}

	public static uint GetUserTime(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_user_time(display);
	}

	public static IntPtr GetXdisplay(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xdisplay(display);
	}

	public static GdkX11DisplayHandle Grab(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_grab(display);
		return display;
	}

	public static GdkX11DisplayHandle SetCursorTheme(this GdkX11DisplayHandle display, string theme, int size)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_cursor_theme(display, theme, size);
		return display;
	}

	public static GdkX11DisplayHandle SetStartupNotificationId(this GdkX11DisplayHandle display, string startup_id)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_startup_notification_id(display, startup_id);
		return display;
	}

	public static GdkX11DisplayHandle SetWindowScale(this GdkX11DisplayHandle display, int scale)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_window_scale(display, scale);
		return display;
	}

	public static int StringToCompoundText(this GdkX11DisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length)
	{
		return GdkX11DisplayExterns.gdk_x11_display_string_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

	public static int TextPropertyToTextList(this GdkX11DisplayHandle display, GdkAtom encoding, int format, string text, int length, ref string[] list)
	{
		return GdkX11DisplayExterns.gdk_x11_display_text_property_to_text_list(display, encoding, format, text, length, ref list);
	}

	public static GdkX11DisplayHandle Ungrab(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_ungrab(display);
		return display;
	}

	public static bool Utf8ToCompoundText(this GdkX11DisplayHandle display, string str, out GdkAtom encoding, out int format, out string ctext, out int length)
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
