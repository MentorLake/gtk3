namespace MentorLake.Gtk3.Atk;

public interface AtkActionHandle
{
}

internal class AtkActionHandleImpl : BaseSafeHandle, AtkActionHandle
{
}

public static class AtkActionHandleExtensions
{
	public static bool DoAction(this AtkActionHandle action, int i)
	{
		return AtkActionExterns.atk_action_do_action(action, i);
	}

	public static string GetDescription(this AtkActionHandle action, int i)
	{
		return AtkActionExterns.atk_action_get_description(action, i);
	}

	public static string GetKeybinding(this AtkActionHandle action, int i)
	{
		return AtkActionExterns.atk_action_get_keybinding(action, i);
	}

	public static string GetLocalizedName(this AtkActionHandle action, int i)
	{
		return AtkActionExterns.atk_action_get_localized_name(action, i);
	}

	public static int GetNActions(this AtkActionHandle action)
	{
		return AtkActionExterns.atk_action_get_n_actions(action);
	}

	public static string GetName(this AtkActionHandle action, int i)
	{
		return AtkActionExterns.atk_action_get_name(action, i);
	}

	public static bool SetDescription(this AtkActionHandle action, int i, string desc)
	{
		return AtkActionExterns.atk_action_set_description(action, i, desc);
	}

}

internal class AtkActionExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern bool atk_action_do_action(AtkActionHandle action, int i);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_description(AtkActionHandle action, int i);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_keybinding(AtkActionHandle action, int i);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_localized_name(AtkActionHandle action, int i);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_action_get_n_actions(AtkActionHandle action);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_name(AtkActionHandle action, int i);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_action_set_description(AtkActionHandle action, int i, string desc);

}
