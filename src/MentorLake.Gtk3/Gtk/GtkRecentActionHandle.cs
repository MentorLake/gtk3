namespace MentorLake.Gtk;

public class GtkRecentActionHandle : GtkActionHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new(name, label, tooltip, stock_id);
	}

	public static MentorLake.Gtk.GtkRecentActionHandle NewForManager(string name, string label, string tooltip, string stock_id, MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new_for_manager(name, label, tooltip, stock_id, manager);
	}

}

public static class GtkRecentActionHandleExtensions
{
	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentActionHandle action)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_get_show_numbers(action);
	}

	public static T SetShowNumbers<T>(this T action, bool show_numbers) where T : GtkRecentActionHandle
	{
		GtkRecentActionHandleExterns.gtk_recent_action_set_show_numbers(action, show_numbers);
		return action;
	}

}

internal class GtkRecentActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_action_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_action_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action, bool show_numbers);

}
