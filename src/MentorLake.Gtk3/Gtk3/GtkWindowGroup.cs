namespace MentorLake.Gtk3.Gtk3;

public class GtkWindowGroupHandle : GObjectHandle
{
	public static GtkWindowGroupHandle New()
	{
		return GtkWindowGroupExterns.gtk_window_group_new();
	}

}

public static class GtkWindowGroupHandleExtensions
{
	public static T AddWindow<T>(this T window_group, GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		GtkWindowGroupExterns.gtk_window_group_add_window(window_group, window);
		return window_group;
	}

	public static GtkWidgetHandle GetCurrentDeviceGrab(this GtkWindowGroupHandle window_group, GdkDeviceHandle device)
	{
		return GtkWindowGroupExterns.gtk_window_group_get_current_device_grab(window_group, device);
	}

	public static GtkWidgetHandle GetCurrentGrab(this GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupExterns.gtk_window_group_get_current_grab(window_group);
	}

	public static GListHandle ListWindows(this GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupExterns.gtk_window_group_list_windows(window_group);
	}

	public static T RemoveWindow<T>(this T window_group, GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		GtkWindowGroupExterns.gtk_window_group_remove_window(window_group, window);
		return window_group;
	}

}

internal class GtkWindowGroupExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowGroupHandle gtk_window_group_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_group_add_window(GtkWindowGroupHandle window_group, GtkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_group_get_current_device_grab(GtkWindowGroupHandle window_group, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_window_group_get_current_grab(GtkWindowGroupHandle window_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_window_group_list_windows(GtkWindowGroupHandle window_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_window_group_remove_window(GtkWindowGroupHandle window_group, GtkWindowHandle window);

}
