namespace MentorLake.Gtk3.Gio;

public class GSimpleActionGroupHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static GSimpleActionGroupHandle New()
	{
		return GSimpleActionGroupExterns.g_simple_action_group_new();
	}

}

public static class GSimpleActionGroupHandleExtensions
{
	public static T AddEntries<T>(this T simple, GActionEntry[] entries, int n_entries, IntPtr user_data) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupExterns.g_simple_action_group_add_entries(simple, entries, n_entries, user_data);
		return simple;
	}

	public static T Insert<T>(this T simple, GActionHandle action) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupExterns.g_simple_action_group_insert(simple, action);
		return simple;
	}

	public static GActionHandle Lookup(this GSimpleActionGroupHandle simple, string action_name)
	{
		return GSimpleActionGroupExterns.g_simple_action_group_lookup(simple, action_name);
	}

	public static T Remove<T>(this T simple, string action_name) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupExterns.g_simple_action_group_remove(simple, action_name);
		return simple;
	}

}

internal class GSimpleActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionGroupHandle g_simple_action_group_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_add_entries(GSimpleActionGroupHandle simple, GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_insert(GSimpleActionGroupHandle simple, GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GActionHandle g_simple_action_group_lookup(GSimpleActionGroupHandle simple, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_remove(GSimpleActionGroupHandle simple, string action_name);

}
