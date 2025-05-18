namespace MentorLake.Gio;

public interface GActionMapHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GActionMapHandleImpl : BaseSafeHandle, GActionMapHandle
{
}

public static class GActionMapHandleExtensions
{
	public static T AddAction<T>(this T action_map, MentorLake.Gio.GActionHandle action) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_add_action(action_map, action);
		return action_map;
	}

	public static T AddActionEntries<T>(this T action_map, MentorLake.Gio.GActionEntryHandle[] entries, int n_entries, IntPtr user_data) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_add_action_entries(action_map, entries, n_entries, user_data);
		return action_map;
	}

	public static MentorLake.Gio.GActionHandle LookupAction(this MentorLake.Gio.GActionMapHandle action_map, string action_name)
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		return GActionMapHandleExterns.g_action_map_lookup_action(action_map, action_name);
	}

	public static T RemoveAction<T>(this T action_map, string action_name) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_remove_action(action_map, action_name);
		return action_map;
	}

	public static T RemoveActionEntries<T>(this T action_map, MentorLake.Gio.GActionEntryHandle[] entries, int n_entries) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_remove_action_entries(action_map, entries, n_entries);
		return action_map;
	}

}

internal class GActionMapHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_add_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_add_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionEntryHandle>))] MentorLake.Gio.GActionEntryHandle[] entries, int n_entries, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))]
	internal static extern MentorLake.Gio.GActionHandle g_action_map_lookup_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_remove_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_remove_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionEntryHandle>))] MentorLake.Gio.GActionEntryHandle[] entries, int n_entries);

}
