namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkWindowGroup restricts the effect of grabs to windows
/// in the same group, thereby making window groups almost behave
/// like separate applications.
/// </para>
/// <para>
/// A window can be a member in at most one window group at a time.
/// Windows that have not been explicitly assigned to a group are
/// implicitly treated like windows of the default window group.
/// </para>
/// <para>
/// GtkWindowGroup objects are referenced by each window in the group,
/// so once you have added all windows to a GtkWindowGroup, you can drop
/// the initial reference to the window group with g_object_unref(). If the
/// windows in the window group are subsequently destroyed, then they will
/// be removed from the window group and drop their references on the window
/// group; when all window have been removed, the window group will be
/// freed.
/// </para>
/// </summary>

public class GtkWindowGroupHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkWindowGroup object. Grabs added with
/// gtk_grab_add() only affect windows within the same #GtkWindowGroup.
/// </para>
/// </summary>

/// <return>
/// a new #GtkWindowGroup.
/// </return>

	public static MentorLake.Gtk.GtkWindowGroupHandle New()
	{
		return GtkWindowGroupHandleExterns.gtk_window_group_new();
	}

}

public static class GtkWindowGroupHandleExtensions
{
/// <summary>
/// <para>
/// Adds a window to a #GtkWindowGroup.
/// </para>
/// </summary>

/// <param name="window_group">
/// a #GtkWindowGroup
/// </param>
/// <param name="window">
/// the #GtkWindow to add
/// </param>

	public static T AddWindow<T>(this T window_group, MentorLake.Gtk.GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		if (window_group.IsInvalid) throw new Exception("Invalid handle (GtkWindowGroupHandle)");
		GtkWindowGroupHandleExterns.gtk_window_group_add_window(window_group, window);
		return window_group;
	}

/// <summary>
/// <para>
/// Returns the current grab widget for @device, or %NULL if none.
/// </para>
/// </summary>

/// <param name="window_group">
/// a #GtkWindowGroup
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>
/// <return>
/// The grab widget, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCurrentDeviceGrab(this MentorLake.Gtk.GtkWindowGroupHandle window_group, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (window_group.IsInvalid) throw new Exception("Invalid handle (GtkWindowGroupHandle)");
		return GtkWindowGroupHandleExterns.gtk_window_group_get_current_device_grab(window_group, device);
	}

/// <summary>
/// <para>
/// Gets the current grab widget of the given group,
/// see gtk_grab_add().
/// </para>
/// </summary>

/// <param name="window_group">
/// a #GtkWindowGroup
/// </param>
/// <return>
/// the current grab widget of the group
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCurrentGrab(this MentorLake.Gtk.GtkWindowGroupHandle window_group)
	{
		if (window_group.IsInvalid) throw new Exception("Invalid handle (GtkWindowGroupHandle)");
		return GtkWindowGroupHandleExterns.gtk_window_group_get_current_grab(window_group);
	}

/// <summary>
/// <para>
/// Returns a list of the #GtkWindows that belong to @window_group.
/// </para>
/// </summary>

/// <param name="window_group">
/// a #GtkWindowGroup
/// </param>
/// <return>
/// A
///   newly-allocated list of windows inside the group.
/// </return>

	public static MentorLake.GLib.GListHandle ListWindows(this MentorLake.Gtk.GtkWindowGroupHandle window_group)
	{
		if (window_group.IsInvalid) throw new Exception("Invalid handle (GtkWindowGroupHandle)");
		return GtkWindowGroupHandleExterns.gtk_window_group_list_windows(window_group);
	}

/// <summary>
/// <para>
/// Removes a window from a #GtkWindowGroup.
/// </para>
/// </summary>

/// <param name="window_group">
/// a #GtkWindowGroup
/// </param>
/// <param name="window">
/// the #GtkWindow to remove
/// </param>

	public static T RemoveWindow<T>(this T window_group, MentorLake.Gtk.GtkWindowHandle window) where T : GtkWindowGroupHandle
	{
		if (window_group.IsInvalid) throw new Exception("Invalid handle (GtkWindowGroupHandle)");
		GtkWindowGroupHandleExterns.gtk_window_group_remove_window(window_group, window);
		return window_group;
	}

}

internal class GtkWindowGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowGroupHandle gtk_window_group_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_group_add_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_group_get_current_device_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_window_group_get_current_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_window_group_list_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_window_group_remove_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowGroupHandle>))] MentorLake.Gtk.GtkWindowGroupHandle window_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

}
