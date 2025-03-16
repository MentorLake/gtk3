namespace MentorLake.Gio;

public interface GActionHandle
{
}

internal class GActionHandleImpl : BaseSafeHandle, GActionHandle
{
}

public static class GActionHandleExtensions
{
	public static T Activate<T>(this T action, MentorLake.GLib.GVariantHandle parameter) where T : GActionHandle
	{
		GActionHandleExterns.g_action_activate(action, parameter);
		return action;
	}

	public static T ChangeState<T>(this T action, MentorLake.GLib.GVariantHandle value) where T : GActionHandle
	{
		GActionHandleExterns.g_action_change_state(action, value);
		return action;
	}

	public static bool GetEnabled(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_enabled(action);
	}

	public static string GetName(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_name(action);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetParameterType(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_parameter_type(action);
	}

	public static MentorLake.GLib.GVariantHandle GetState(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_state(action);
	}

	public static MentorLake.GLib.GVariantHandle GetStateHint(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_state_hint(action);
	}

	public static MentorLake.GLib.GVariantTypeHandle GetStateType(this MentorLake.Gio.GActionHandle action)
	{
		return GActionHandleExterns.g_action_get_state_type(action);
	}

	public static bool NameIsValid(string action_name)
	{
		return GActionHandleExterns.g_action_name_is_valid(action_name);
	}

	public static bool ParseDetailedName(string detailed_name, out string action_name, out MentorLake.GLib.GVariantHandle target_value)
	{
		return GActionHandleExterns.g_action_parse_detailed_name(detailed_name, out action_name, out target_value);
	}

	public static string PrintDetailedName(string action_name, MentorLake.GLib.GVariantHandle target_value)
	{
		return GActionHandleExterns.g_action_print_detailed_name(action_name, target_value);
	}

}

internal class GActionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_change_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_get_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_get_parameter_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_action_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_action_get_state_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_action_get_state_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_name_is_valid(string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_action_parse_detailed_name(string detailed_name, out string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle target_value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_action_print_detailed_name(string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target_value);

}
