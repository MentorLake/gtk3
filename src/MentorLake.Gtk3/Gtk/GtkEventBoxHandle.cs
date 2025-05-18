namespace MentorLake.Gtk;

public class GtkEventBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkEventBoxHandle New()
	{
		return GtkEventBoxHandleExterns.gtk_event_box_new();
	}

}

public static class GtkEventBoxHandleExtensions
{
	public static bool GetAboveChild(this MentorLake.Gtk.GtkEventBoxHandle event_box)
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		return GtkEventBoxHandleExterns.gtk_event_box_get_above_child(event_box);
	}

	public static bool GetVisibleWindow(this MentorLake.Gtk.GtkEventBoxHandle event_box)
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		return GtkEventBoxHandleExterns.gtk_event_box_get_visible_window(event_box);
	}

	public static T SetAboveChild<T>(this T event_box, bool above_child) where T : GtkEventBoxHandle
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		GtkEventBoxHandleExterns.gtk_event_box_set_above_child(event_box, above_child);
		return event_box;
	}

	public static T SetVisibleWindow<T>(this T event_box, bool visible_window) where T : GtkEventBoxHandle
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		GtkEventBoxHandleExterns.gtk_event_box_set_visible_window(event_box, visible_window);
		return event_box;
	}

}

internal class GtkEventBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkEventBoxHandle gtk_event_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_box_get_above_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_box_get_visible_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_box_set_above_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box, bool above_child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_box_set_visible_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box, bool visible_window);

}
