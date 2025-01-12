namespace MentorLake.Gtk3.Gio;

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
		GActionGroupExterns.g_action_group_action_added(action_group, action_name);
		return action_group;
	}

	public static T ActionEnabledChanged<T>(this T action_group, string action_name, bool enabled) where T : GActionGroupHandle
	{
		GActionGroupExterns.g_action_group_action_enabled_changed(action_group, action_name, enabled);
		return action_group;
	}

	public static T ActionRemoved<T>(this T action_group, string action_name) where T : GActionGroupHandle
	{
		GActionGroupExterns.g_action_group_action_removed(action_group, action_name);
		return action_group;
	}

	public static T ActionStateChanged<T>(this T action_group, string action_name, GVariantHandle state) where T : GActionGroupHandle
	{
		GActionGroupExterns.g_action_group_action_state_changed(action_group, action_name, state);
		return action_group;
	}

	public static T ActivateAction<T>(this T action_group, string action_name, GVariantHandle parameter) where T : GActionGroupHandle
	{
		GActionGroupExterns.g_action_group_activate_action(action_group, action_name, parameter);
		return action_group;
	}

	public static T ChangeActionState<T>(this T action_group, string action_name, GVariantHandle value) where T : GActionGroupHandle
	{
		GActionGroupExterns.g_action_group_change_action_state(action_group, action_name, value);
		return action_group;
	}

	public static bool GetActionEnabled(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_get_action_enabled(action_group, action_name);
	}

	public static GVariantTypeHandle GetActionParameterType(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_get_action_parameter_type(action_group, action_name);
	}

	public static GVariantHandle GetActionState(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_get_action_state(action_group, action_name);
	}

	public static GVariantHandle GetActionStateHint(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_get_action_state_hint(action_group, action_name);
	}

	public static GVariantTypeHandle GetActionStateType(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_get_action_state_type(action_group, action_name);
	}

	public static bool HasAction(this GActionGroupHandle action_group, string action_name)
	{
		return GActionGroupExterns.g_action_group_has_action(action_group, action_name);
	}

	public static IntPtr ListActions(this GActionGroupHandle action_group)
	{
		return GActionGroupExterns.g_action_group_list_actions(action_group);
	}

	public static bool QueryAction(this GActionGroupHandle action_group, string action_name, out bool enabled, out GVariantTypeHandle parameter_type, out GVariantTypeHandle state_type, out GVariantHandle state_hint, out GVariantHandle state)
	{
		return GActionGroupExterns.g_action_group_query_action(action_group, action_name, out enabled, out parameter_type, out state_type, out state_hint, out state);
	}

}

internal class GActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_action_added(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_action_enabled_changed(GActionGroupHandle action_group, string action_name, bool enabled);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_action_removed(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_action_state_changed(GActionGroupHandle action_group, string action_name, GVariantHandle state);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_activate_action(GActionGroupHandle action_group, string action_name, GVariantHandle parameter);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_group_change_action_state(GActionGroupHandle action_group, string action_name, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_group_get_action_enabled(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_group_get_action_parameter_type(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_group_get_action_state(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_group_get_action_state_hint(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_group_get_action_state_type(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_group_has_action(GActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_action_group_list_actions(GActionGroupHandle action_group);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_group_query_action(GActionGroupHandle action_group, string action_name, out bool enabled, out GVariantTypeHandle parameter_type, out GVariantTypeHandle state_type, out GVariantHandle state_hint, out GVariantHandle state);

}
