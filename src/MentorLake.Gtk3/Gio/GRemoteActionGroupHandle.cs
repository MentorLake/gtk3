namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GRemoteActionGroup` interface is implemented by [iface@Gio.ActionGroup]
/// instances that either transmit action invocations to other processes
/// or receive action invocations in the local process from other
/// processes.
/// </para>
/// <para>
/// The interface has `_full` variants of the two
/// methods on [iface@Gio.ActionGroup] used to activate actions:
/// [method@Gio.ActionGroup.activate_action] and
/// [method@Gio.ActionGroup.change_action_state]. These variants allow a
/// ‘platform data’ [struct@GLib.Variant] to be specified: a dictionary providing
/// context for the action invocation (for example: timestamps, startup
/// notification IDs, etc).
/// </para>
/// <para>
/// [class@Gio.DBusActionGroup] implements `GRemoteActionGroup`.  This provides a
/// mechanism to send platform data for action invocations over D-Bus.
/// </para>
/// <para>
/// Additionally, [method@Gio.DBusConnection.export_action_group] will check if
/// the exported [iface@Gio.ActionGroup] implements `GRemoteActionGroup` and use
/// the `_full` variants of the calls if available.  This
/// provides a mechanism by which to receive platform data for action
/// invocations that arrive by way of D-Bus.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Activates the remote action.
/// </para>
/// <para>
/// This is the same as g_action_group_activate_action() except that it
/// allows for provision of "platform data" to be sent along with the
/// activation request.  This typically contains details such as the user
/// interaction timestamp or startup notification information.
/// </para>
/// <para>
/// @platform_data must be non-%NULL and must have the type
/// %G_VARIANT_TYPE_VARDICT.  If it is floating, it will be consumed.
/// </para>
/// </summary>

/// <param name="remote">
/// a #GDBusActionGroup
/// </param>
/// <param name="action_name">
/// the name of the action to activate
/// </param>
/// <param name="parameter">
/// the optional parameter to the activation
/// </param>
/// <param name="platform_data">
/// the platform data to send
/// </param>

	public static T ActivateActionFull<T>(this T remote, string action_name, MentorLake.GLib.GVariantHandle parameter, MentorLake.GLib.GVariantHandle platform_data) where T : GRemoteActionGroupHandle
	{
		if (remote.IsInvalid) throw new Exception("Invalid handle (GRemoteActionGroupHandle)");
		GRemoteActionGroupHandleExterns.g_remote_action_group_activate_action_full(remote, action_name, parameter, platform_data);
		return remote;
	}

/// <summary>
/// <para>
/// Changes the state of a remote action.
/// </para>
/// <para>
/// This is the same as g_action_group_change_action_state() except that
/// it allows for provision of "platform data" to be sent along with the
/// state change request.  This typically contains details such as the
/// user interaction timestamp or startup notification information.
/// </para>
/// <para>
/// @platform_data must be non-%NULL and must have the type
/// %G_VARIANT_TYPE_VARDICT.  If it is floating, it will be consumed.
/// </para>
/// </summary>

/// <param name="remote">
/// a #GRemoteActionGroup
/// </param>
/// <param name="action_name">
/// the name of the action to change the state of
/// </param>
/// <param name="value">
/// the new requested value for the state
/// </param>
/// <param name="platform_data">
/// the platform data to send
/// </param>

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
