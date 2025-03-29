namespace MentorLake.Gtk;

public class GtkPadControllerHandle : GtkEventControllerHandle
{
	public static MentorLake.Gtk.GtkPadControllerHandle New(MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gio.GActionGroupHandle group, MentorLake.Gdk.GdkDeviceHandle pad)
	{
		return GtkPadControllerHandleExterns.gtk_pad_controller_new(window, group, pad);
	}

}

public static class GtkPadControllerHandleExtensions
{
	public static T SetAction<T>(this T controller, MentorLake.Gtk.GtkPadActionType type, int index, int mode, string label, string action_name) where T : GtkPadControllerHandle
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkPadControllerHandle)");
		GtkPadControllerHandleExterns.gtk_pad_controller_set_action(controller, type, index, mode, label, action_name);
		return controller;
	}

	public static T SetActionEntries<T>(this T controller, MentorLake.Gtk.GtkPadActionEntry[] entries, int n_entries) where T : GtkPadControllerHandle
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkPadControllerHandle)");
		GtkPadControllerHandleExterns.gtk_pad_controller_set_action_entries(controller, entries, n_entries);
		return controller;
	}

}

internal class GtkPadControllerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPadControllerHandle gtk_pad_controller_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle pad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_pad_controller_set_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPadControllerHandle>))] MentorLake.Gtk.GtkPadControllerHandle controller, MentorLake.Gtk.GtkPadActionType type, int index, int mode, string label, string action_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_pad_controller_set_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPadControllerHandle>))] MentorLake.Gtk.GtkPadControllerHandle controller, MentorLake.Gtk.GtkPadActionEntry[] entries, int n_entries);

}
