namespace MentorLake.Gtk;

public class GtkRecentChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle New()
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new();
	}

	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new_for_manager(manager);
	}

}

public static class GtkRecentChooserWidgetHandleExtensions
{
}

internal class GtkRecentChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

}
