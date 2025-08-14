namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkLockButton is a widget that can be used in control panels or
/// preference dialogs to allow users to obtain and revoke authorizations
/// needed to operate the controls. The required authorization is represented
/// by a #GPermission object. Concrete implementations of #GPermission may use
/// PolicyKit or some other authorization framework. To obtain a PolicyKit-based
/// #GPermission, use polkit_permission_new().
/// </para>
/// <para>
/// If the user is not currently allowed to perform the action, but can obtain
/// the permission, the widget looks like this:
/// </para>
/// <para>
/// ![](lockbutton-locked.png)
/// </para>
/// <para>
/// and the user can click the button to request the permission. Depending
/// on the platform, this may pop up an authentication dialog or ask the user
/// to authenticate in some other way. Once the user has obtained the permission,
/// the widget changes to this:
/// </para>
/// <para>
/// ![](lockbutton-unlocked.png)
/// </para>
/// <para>
/// and the permission can be dropped again by clicking the button. If the user
/// is not able to obtain the permission at all, the widget looks like this:
/// </para>
/// <para>
/// ![](lockbutton-sorry.png)
/// </para>
/// <para>
/// If the user has the permission and cannot drop it, the button is hidden.
/// </para>
/// <para>
/// The text (and tooltips) that are shown in the various cases can be adjusted
/// with the #GtkLockButton:text-lock, #GtkLockButton:text-unlock,
/// #GtkLockButton:tooltip-lock, #GtkLockButton:tooltip-unlock and
/// #GtkLockButton:tooltip-not-authorized properties.
/// </para>
/// </summary>

public class GtkLockButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new lock button which reflects the @permission.
/// </para>
/// </summary>

/// <param name="permission">
/// a #GPermission
/// </param>
/// <return>
/// a new #GtkLockButton
/// </return>

	public static MentorLake.Gtk.GtkLockButtonHandle New(MentorLake.Gio.GPermissionHandle permission)
	{
		return GtkLockButtonHandleExterns.gtk_lock_button_new(permission);
	}

}

public static class GtkLockButtonHandleExtensions
{
/// <summary>
/// <para>
/// Obtains the #GPermission object that controls @button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkLockButton
/// </param>
/// <return>
/// the #GPermission of @button
/// </return>

	public static MentorLake.Gio.GPermissionHandle GetPermission(this MentorLake.Gtk.GtkLockButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkLockButtonHandle)");
		return GtkLockButtonHandleExterns.gtk_lock_button_get_permission(button);
	}

/// <summary>
/// <para>
/// Sets the #GPermission object that controls @button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkLockButton
/// </param>
/// <param name="permission">
/// a #GPermission object, or %NULL
/// </param>

	public static T SetPermission<T>(this T button, MentorLake.Gio.GPermissionHandle permission) where T : GtkLockButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkLockButtonHandle)");
		GtkLockButtonHandleExterns.gtk_lock_button_set_permission(button, permission);
		return button;
	}

}

internal class GtkLockButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLockButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkLockButtonHandle gtk_lock_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))]
	internal static extern MentorLake.Gio.GPermissionHandle gtk_lock_button_get_permission([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLockButtonHandle>))] MentorLake.Gtk.GtkLockButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_lock_button_set_permission([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLockButtonHandle>))] MentorLake.Gtk.GtkLockButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

}
