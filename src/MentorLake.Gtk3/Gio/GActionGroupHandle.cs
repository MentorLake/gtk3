namespace MentorLake.Gio;

public interface GActionGroupHandle
{
}

internal class GActionGroupHandleImpl : BaseSafeHandle, GActionGroupHandle
{
}

public static class GActionGroupHandleExtensions
{
	public static T ActionAdded<T>(this T action_group, string action_name) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_action_added(action_group, action_name);
		return action_group;
	}

	public static T ActionEnabledChanged<T>(this T action_group, string action_name, bool enabled) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_action_enabled_changed(action_group, action_name, enabled);
		return action_group;
	}

	public static T ActionRemoved<T>(this T action_group, string action_name) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_action_removed(action_group, action_name);
		return action_group;
	}

	public static T ActionStateChanged<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle state) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_action_state_changed(action_group, action_name, state);
		return action_group;
	}

	public static T ActivateAction<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_activate_action(action_group, action_name, parameter);
		return action_group;
	}

	public static T ChangeActionState<T>(this T action_group, string action_name, MentorLake.GLib.GVariantHandle value) where T : GActionGroupHandle
	{
		GActionGroupHandleExterns.g_action_group_change_action_state(action_group, action_name, value);
		return action_group;
	}

	public static bool GetActionEnabled(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_get_action_enabled(action_group, action_name);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetActionParameterType(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_get_action_parameter_type(action_group, action_name);
	}

	public static MentorLake.GLib.GVariantHandle GetActionState(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_get_action_state(action_group, action_name);
	}

	public static MentorLake.GLib.GVariantHandle GetActionStateHint(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_get_action_state_hint(action_group, action_name);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetActionStateType(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_get_action_state_type(action_group, action_name);
	}

	public static bool HasAction(this MentorLake.Gio.GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupHandleExterns.g_action_group_has_action(action_group, action_name);
	}

	public static string[] ListActions(this MentorLake.Gio.GActionGroupHandle action_group)
	{
		return GActionGroupHandleExterns.g_action_group_list_actions(action_group);
	}

	public static bool QueryAction(this MentorLake.Gio.GActionGroupHandle action_group, string action_name, out bool enabled, out MentorLake.GLib.GVariantTypeHandle parameter_type, out MentorLake.GLib.GVariantTypeHandle state_type, out MentorLake.GLib.GVariantHandle state_hint, out MentorLake.GLib.GVariantHandle state)
	{
		return GActionGroupHandleExterns.g_action_group_query_action(action_group, action_name, out enabled, out parameter_type, out state_type, out state_hint, out state);
	}

}

internal class GActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, bool enabled);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle state);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_activate_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_group_change_action_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_get_action_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_group_get_action_parameter_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_action_group_get_action_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_action_group_get_action_state_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_group_get_action_state_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_has_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_action_group_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_group_query_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, string action_name, out bool enabled, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] out MentorLake.GLib.GVariantTypeHandle parameter_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] out MentorLake.GLib.GVariantTypeHandle state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle state_hint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle state);

}
