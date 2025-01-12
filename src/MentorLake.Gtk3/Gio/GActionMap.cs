namespace MentorLake.Gtk3.Gio;

public interface GActionMapHandle
{
}

internal class GActionMapHandleImpl : BaseSafeHandle, GActionMapHandle
{
}

public static class GActionMapHandleExtensions
{
	public static T AddAction<T>(this T action_map, GActionHandle action) where T : GActionMapHandle
	{
		GActionMapExterns.g_action_map_add_action(action_map, action);
		return action_map;
	}

	public static T AddActionEntries<T>(this T action_map, GActionEntry[] entries, int n_entries, IntPtr user_data) where T : GActionMapHandle
	{
		GActionMapExterns.g_action_map_add_action_entries(action_map, entries, n_entries, user_data);
		return action_map;
	}

	public static GActionHandle LookupAction(this GActionMapHandle action_map, string action_name)
	{
		return GActionMapExterns.g_action_map_lookup_action(action_map, action_name);
	}

	public static T RemoveAction<T>(this T action_map, string action_name) where T : GActionMapHandle
	{
		GActionMapExterns.g_action_map_remove_action(action_map, action_name);
		return action_map;
	}

	public static T RemoveActionEntries<T>(this T action_map, GActionEntry[] entries, int n_entries) where T : GActionMapHandle
	{
		GActionMapExterns.g_action_map_remove_action_entries(action_map, entries, n_entries);
		return action_map;
	}

}

internal class GActionMapExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_add_action(GActionMapHandle action_map, GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_add_action_entries(GActionMapHandle action_map, GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GActionHandle g_action_map_lookup_action(GActionMapHandle action_map, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_remove_action(GActionMapHandle action_map, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_remove_action_entries(GActionMapHandle action_map, GActionEntry[] entries, int n_entries);

}
