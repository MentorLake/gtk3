namespace MentorLake.Atk;

public interface AtkActionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkActionHandleImpl : BaseSafeHandle, AtkActionHandle
{
}

public static class AtkActionHandleExtensions
{
	public static bool DoAction(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_do_action(action, i);
	}

	public static string GetDescription(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_description(action, i);
	}

	public static string GetKeybinding(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_keybinding(action, i);
	}

	public static string GetLocalizedName(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_localized_name(action, i);
	}

	public static int GetNActions(this MentorLake.Atk.AtkActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_n_actions(action);
	}

	public static string GetName(this MentorLake.Atk.AtkActionHandle action, int i)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_get_name(action, i);
	}

	public static bool SetDescription(this MentorLake.Atk.AtkActionHandle action, int i, string desc)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (AtkActionHandle)");
		return AtkActionHandleExterns.atk_action_set_description(action, i, desc);
	}

}

internal class AtkActionHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_action_do_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_keybinding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_localized_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_action_get_n_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_action_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkActionHandleImpl>))] MentorLake.Atk.AtkActionHandle action, int i, string desc);

}
