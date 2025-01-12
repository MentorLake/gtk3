namespace MentorLake.Gtk3.Gio;

public interface GRemoteActionGroupHandle
{
}

internal class GRemoteActionGroupHandleImpl : BaseSafeHandle, GRemoteActionGroupHandle
{
}

public static class GRemoteActionGroupHandleExtensions
{
	public static T ActivateActionFull<T>(this T remote, string action_name, GVariantHandle parameter, GVariantHandle platform_data) where T : GRemoteActionGroupHandle
	{
		GRemoteActionGroupExterns.g_remote_action_group_activate_action_full(remote, action_name, parameter, platform_data);
		return remote;
	}

	public static T ChangeActionStateFull<T>(this T remote, string action_name, GVariantHandle value, GVariantHandle platform_data) where T : GRemoteActionGroupHandle
	{
		GRemoteActionGroupExterns.g_remote_action_group_change_action_state_full(remote, action_name, value, platform_data);
		return remote;
	}

}

internal class GRemoteActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_remote_action_group_activate_action_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle parameter, GVariantHandle platform_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_remote_action_group_change_action_state_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle value, GVariantHandle platform_data);

}
