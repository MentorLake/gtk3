namespace MentorLake.Gio;

public interface GDBusObjectManagerHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDBusObjectManagerHandleImpl : BaseSafeHandle, GDBusObjectManagerHandle
{
}

public static class GDBusObjectManagerHandleExtensions
{
	public static MentorLake.Gio.GDBusInterfaceHandle GetInterface(this MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path, string interface_name)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_interface(manager, object_path, interface_name);
	}

	public static MentorLake.Gio.GDBusObjectHandle GetObject(this MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_object(manager, object_path);
	}

	public static string GetObjectPath(this MentorLake.Gio.GDBusObjectManagerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_object_path(manager);
	}

	public static MentorLake.GLib.GListHandle GetObjects(this MentorLake.Gio.GDBusObjectManagerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_objects(manager);
	}

}

internal class GDBusObjectManagerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceHandle g_dbus_object_manager_get_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path, string interface_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_object_manager_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_dbus_object_manager_get_objects([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager);

}
