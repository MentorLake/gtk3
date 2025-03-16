namespace MentorLake.Gtk;

public class GtkRecentChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new(title, parent, first_button_text, @__arglist);
	}

	public static MentorLake.Gtk.GtkRecentChooserDialogHandle NewForManager(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new_for_manager(title, parent, manager, first_button_text, @__arglist);
	}

}

public static class GtkRecentChooserDialogHandleExtensions
{
}

internal class GtkRecentChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new_for_manager(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist);

}
