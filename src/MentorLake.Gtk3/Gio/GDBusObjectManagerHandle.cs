namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GDBusObjectManager` type is the base type for service- and
/// client-side implementations of the standardized
/// <see href="http://dbus.freedesktop.org/doc/dbus-specification.html#standard-interfaces-objectmanager">org.freedesktop.DBus.ObjectManager</see>
/// interface.
/// </para>
/// <para>
/// See [class@Gio.DBusObjectManagerClient] for the client-side implementation
/// and [class@Gio.DBusObjectManagerServer] for the service-side implementation.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets the interface proxy for @interface_name at @object_path, if
/// any.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManager.
/// </param>
/// <param name="object_path">
/// Object path to look up.
/// </param>
/// <param name="interface_name">
/// D-Bus interface name to look up.
/// </param>
/// <return>
/// A #GDBusInterface instance or %NULL. Free
///   with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusInterfaceHandle GetInterface(this MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path, string interface_name)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_interface(manager, object_path, interface_name);
	}

/// <summary>
/// <para>
/// Gets the #GDBusObject at @object_path, if any.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManager.
/// </param>
/// <param name="object_path">
/// Object path to look up.
/// </param>
/// <return>
/// A #GDBusObject or %NULL. Free with
///   g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectHandle GetObject(this MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_object(manager, object_path);
	}

/// <summary>
/// <para>
/// Gets the object path that @manager is for.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManager.
/// </param>
/// <return>
/// A string owned by @manager. Do not free.
/// </return>

	public static string GetObjectPath(this MentorLake.Gio.GDBusObjectManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_object_path(manager);
	}

/// <summary>
/// <para>
/// Gets all #GDBusObject objects known to @manager.
/// </para>
/// </summary>

/// <param name="manager">
/// A #GDBusObjectManager.
/// </param>
/// <return>
/// A list of
///   #GDBusObject objects. The returned list should be freed with
///   g_list_free() after each element has been freed with
///   g_object_unref().
/// </return>

	public static MentorLake.GLib.GListHandle GetObjects(this MentorLake.Gio.GDBusObjectManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GDBusObjectManagerHandle)");
		return GDBusObjectManagerHandleExterns.g_dbus_object_manager_get_objects(manager);
	}

}

internal class GDBusObjectManagerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))]
	internal static extern MentorLake.Gio.GDBusInterfaceHandle g_dbus_object_manager_get_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path, string interface_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_object_manager_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager, string object_path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_manager_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_dbus_object_manager_get_objects([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerHandleImpl>))] MentorLake.Gio.GDBusObjectManagerHandle manager);

}
