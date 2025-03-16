namespace MentorLake.Gtk;

public class GtkWindowGroupHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkWindowGroupHandle New()
	{
		return GtkWindowGroupHandleExterns.gtk_window_group_new();
	}

}

public static class GtkWindowGroupHandleExtensions
{
	public static T AddWindow<T>(this T window_group, MentorLake.Gtk.GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		GtkWindowGroupHandleExterns.gtk_window_group_add_window(window_group, window);
		return window_group;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetCurrentDeviceGrab(this MentorLake.Gtk.GtkWindowGroupHandle window_group, MentorLake.Gdk.GdkDeviceHandle device)
	{
		return GtkWindowGroupHandleExterns.gtk_window_group_get_current_device_grab(window_group, device);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetCurrentGrab(this MentorLake.Gtk.GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupHandleExterns.gtk_window_group_get_current_grab(window_group);
	}

	public static MentorLake.GLib.GListHandle ListWindows(this MentorLake.Gtk.GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupHandleExterns.gtk_window_group_list_windows(window_group);
	}

	public static T RemoveWindow<T>(this T window_group, MentorLake.Gtk.GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		GtkWindowGroupHandleExterns.gtk_window_group_remove_window(window_group, window);
		return window_group;
	}

}

internal class GtkWindowGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowGroupHandle gtk_window_group_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_group_add_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_group_get_current_device_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_group_get_current_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_window_group_list_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_group_remove_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

}
