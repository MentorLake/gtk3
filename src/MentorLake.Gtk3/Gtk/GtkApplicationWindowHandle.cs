namespace MentorLake.Gtk;

public class GtkApplicationWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GActionGroupHandle, GActionMapHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkApplicationWindowHandle New(MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_new(application);
	}

}

public static class GtkApplicationWindowHandleExtensions
{
	public static MentorLake.Gtk.GtkShortcutsWindowHandle GetHelpOverlay(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_help_overlay(window);
	}

	public static uint GetId(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_id(window);
	}

	public static bool GetShowMenubar(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_show_menubar(window);
	}

	public static T SetHelpOverlay<T>(this T window, MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay) where T : GtkApplicationWindowHandle
	{
		GtkApplicationWindowHandleExterns.gtk_application_window_set_help_overlay(window, help_overlay);
		return window;
	}

	public static T SetShowMenubar<T>(this T window, bool show_menubar) where T : GtkApplicationWindowHandle
	{
		GtkApplicationWindowHandleExterns.gtk_application_window_set_show_menubar(window, show_menubar);
		return window;
	}

}

internal class GtkApplicationWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkApplicationWindowHandle gtk_application_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShortcutsWindowHandle gtk_application_window_get_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_window_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_window_get_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, bool show_menubar);

}
