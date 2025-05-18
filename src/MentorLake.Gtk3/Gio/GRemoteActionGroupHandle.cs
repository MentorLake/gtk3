namespace MentorLake.Gio;

public interface GRemoteActionGroupHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GRemoteActionGroupHandleImpl : BaseSafeHandle, GRemoteActionGroupHandle
{
}

public static class GRemoteActionGroupHandleExtensions
{
	public static T ActivateActionFull<T>(this T remote, string action_name, MentorLake.GLib.GVariantHandle parameter, MentorLake.GLib.GVariantHandle platform_data) where T : GRemoteActionGroupHandle
	{
		if (remote.IsInvalid) throw new Exception("Invalid handle (GRemoteActionGroupHandle)");
		GRemoteActionGroupHandleExterns.g_remote_action_group_activate_action_full(remote, action_name, parameter, platform_data);
		return remote;
	}

	public static T ChangeActionStateFull<T>(this T remote, string action_name, MentorLake.GLib.GVariantHandle value, MentorLake.GLib.GVariantHandle platform_data) where T : GRemoteActionGroupHandle
	{
		if (remote.IsInvalid) throw new Exception("Invalid handle (GRemoteActionGroupHandle)");
		GRemoteActionGroupHandleExterns.g_remote_action_group_change_action_state_full(remote, action_name, value, platform_data);
		return remote;
	}

}

internal class GRemoteActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_remote_action_group_activate_action_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GRemoteActionGroupHandleImpl>))] MentorLake.Gio.GRemoteActionGroupHandle remote, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_remote_action_group_change_action_state_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GRemoteActionGroupHandleImpl>))] MentorLake.Gio.GRemoteActionGroupHandle remote, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle platform_data);

}
