namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentActionHandle : GtkActionHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static GtkRecentActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkRecentActionExterns.gtk_recent_action_new(name, label, tooltip, stock_id);
	}

	public static GtkRecentActionHandle NewForManager(string name, string label, string tooltip, string stock_id, GtkRecentManagerHandle manager)
	{
		return GtkRecentActionExterns.gtk_recent_action_new_for_manager(name, label, tooltip, stock_id, manager);
	}

}

public static class GtkRecentActionHandleExtensions
{
	public static bool GetShowNumbers(this GtkRecentActionHandle action)
	{
		return GtkRecentActionExterns.gtk_recent_action_get_show_numbers(action);
	}

	public static GtkRecentActionHandle SetShowNumbers(this GtkRecentActionHandle action, bool show_numbers)
	{
		GtkRecentActionExterns.gtk_recent_action_set_show_numbers(action, show_numbers);
		return action;
	}

}

internal class GtkRecentActionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentActionHandle gtk_recent_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentActionHandle gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, GtkRecentManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_recent_action_get_show_numbers(GtkRecentActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_recent_action_set_show_numbers(GtkRecentActionHandle action, bool show_numbers);

}
