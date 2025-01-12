namespace MentorLake.Gtk3.Gio;

public interface GActionHandle
{
}

internal class GActionHandleImpl : BaseSafeHandle, GActionHandle
{
}

public static class GActionHandleExtensions
{
	public static T Activate<T>(this T action, GVariantHandle parameter) where T : GActionHandle
	{
		GActionExterns.g_action_activate(action, parameter);
		return action;
	}

	public static T ChangeState<T>(this T action, GVariantHandle value) where T : GActionHandle
	{
		GActionExterns.g_action_change_state(action, value);
		return action;
	}

	public static bool GetEnabled(this GActionHandle action)
	{
		return GActionExterns.g_action_get_enabled(action);
	}

	public static string GetName(this GActionHandle action)
	{
		return GActionExterns.g_action_get_name(action);
	}

	public static GVariantTypeHandle GetParameterType(this GActionHandle action)
	{
		return GActionExterns.g_action_get_parameter_type(action);
	}

	public static GVariantHandle GetState(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state(action);
	}

	public static GVariantHandle GetStateHint(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state_hint(action);
	}

	public static GVariantTypeHandle GetStateType(this GActionHandle action)
	{
		return GActionExterns.g_action_get_state_type(action);
	}

	public static bool NameIsValid(string action_name)
	{
		return GActionExterns.g_action_name_is_valid(action_name);
	}

	public static bool ParseDetailedName(string detailed_name, out string action_name, out GVariantHandle target_value, out GErrorHandle error)
	{
		return GActionExterns.g_action_parse_detailed_name(detailed_name, out action_name, out target_value, out error);
	}

	public static string PrintDetailedName(string action_name, GVariantHandle target_value)
	{
		return GActionExterns.g_action_print_detailed_name(action_name, target_value);
	}

}

internal class GActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_action_activate(GActionHandle action, GVariantHandle parameter);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_change_state(GActionHandle action, GVariantHandle value);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_get_enabled(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern string g_action_get_name(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_get_parameter_type(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_get_state(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_action_get_state_hint(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantTypeHandle g_action_get_state_type(GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_name_is_valid(string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_action_parse_detailed_name(string detailed_name, out string action_name, out GVariantHandle target_value, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_action_print_detailed_name(string action_name, GVariantHandle target_value);

}
