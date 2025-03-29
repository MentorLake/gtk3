namespace MentorLake.Gtk;

public class GtkLockButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkLockButtonHandle New(MentorLake.Gio.GPermissionHandle permission)
	{
		return GtkLockButtonHandleExterns.gtk_lock_button_new(permission);
	}

}

public static class GtkLockButtonHandleExtensions
{
	public static MentorLake.Gio.GPermissionHandle GetPermission(this MentorLake.Gtk.GtkLockButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkLockButtonHandle)");
		return GtkLockButtonHandleExterns.gtk_lock_button_get_permission(button);
	}

	public static T SetPermission<T>(this T button, MentorLake.Gio.GPermissionHandle permission) where T : GtkLockButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkLockButtonHandle)");
		GtkLockButtonHandleExterns.gtk_lock_button_set_permission(button, permission);
		return button;
	}

}

internal class GtkLockButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLockButtonHandle gtk_lock_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GPermissionHandle gtk_lock_button_get_permission([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLockButtonHandle>))] MentorLake.Gtk.GtkLockButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_lock_button_set_permission([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLockButtonHandle>))] MentorLake.Gtk.GtkLockButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GPermissionHandle>))] MentorLake.Gio.GPermissionHandle permission);

}
