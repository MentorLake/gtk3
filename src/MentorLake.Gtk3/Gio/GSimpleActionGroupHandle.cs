namespace MentorLake.Gio;

public class GSimpleActionGroupHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static MentorLake.Gio.GSimpleActionGroupHandle New()
	{
		return GSimpleActionGroupHandleExterns.g_simple_action_group_new();
	}

}

public static class GSimpleActionGroupHandleExtensions
{
	public static T AddEntries<T>(this T simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupHandleExterns.g_simple_action_group_add_entries(simple, entries, n_entries, user_data);
		return simple;
	}

	public static T Insert<T>(this T simple, MentorLake.Gio.GActionHandle action) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupHandleExterns.g_simple_action_group_insert(simple, action);
		return simple;
	}

	public static MentorLake.Gio.GActionHandle Lookup(this MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name)
	{
		return GSimpleActionGroupHandleExterns.g_simple_action_group_lookup(simple, action_name);
	}

	public static T Remove<T>(this T simple, string action_name) where T : GSimpleActionGroupHandle
	{
		GSimpleActionGroupHandleExterns.g_simple_action_group_remove(simple, action_name);
		return simple;
	}

}

internal class GSimpleActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleActionGroupHandle g_simple_action_group_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_add_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, MentorLake.Gio.GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GActionHandle g_simple_action_group_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_group_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionGroupHandle>))] MentorLake.Gio.GSimpleActionGroupHandle simple, string action_name);

}
