namespace MentorLake.Gtk3.Gio;

public interface GDBusObjectManagerHandle
{
}

internal class GDBusObjectManagerHandleImpl : BaseSafeHandle, GDBusObjectManagerHandle
{
}

public static class GDBusObjectManagerHandleExtensions
{
	public static GDBusInterfaceHandle GDbusObjectManagerGetInterface(this GDBusObjectManagerHandle manager, string object_path, string interface_name)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_interface(manager, object_path, interface_name);
	}

	public static GDBusObjectHandle GDbusObjectManagerGetObject(this GDBusObjectManagerHandle manager, string object_path)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_object(manager, object_path);
	}

	public static string GDbusObjectManagerGetObjectPath(this GDBusObjectManagerHandle manager)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_object_path(manager);
	}

	public static GListHandle GDbusObjectManagerGetObjects(this GDBusObjectManagerHandle manager)
	{
		return GDBusObjectManagerExterns.g_dbus_object_manager_get_objects(manager);
	}

}

internal class GDBusObjectManagerExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceHandle g_dbus_object_manager_get_interface(GDBusObjectManagerHandle manager, string object_path, string interface_name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_object_manager_get_object(GDBusObjectManagerHandle manager, string object_path);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_object_manager_get_object_path(GDBusObjectManagerHandle manager);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dbus_object_manager_get_objects(GDBusObjectManagerHandle manager);

}
