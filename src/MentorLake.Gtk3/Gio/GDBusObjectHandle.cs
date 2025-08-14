namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GDBusObject` type is the base type for D-Bus objects on both
/// the service side (see [class@Gio.DBusObjectSkeleton]) and the client side
/// (see [class@Gio.DBusObjectProxy]). It is essentially just a container of
/// interfaces.
/// </para>
/// </summary>

public interface GDBusObjectHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDBusObjectHandleImpl : BaseSafeHandle, GDBusObjectHandle
{
}

public static class GDBusObjectHandleExtensions
{
/// <summary>
/// <para>
/// Gets the D-Bus interface with name @interface_name associated with
/// @object, if any.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObject.
/// </param>
/// <param name="interface_name">
/// A D-Bus interface name.
/// </param>
/// <return>
/// %NULL if not found, otherwise a
///   #GDBusInterface that must be freed with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusInterfaceHandle GetInterface(this MentorLake.Gio.GDBusObjectHandle @object, string interface_name)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_interface(@object, interface_name);
	}

/// <summary>
/// <para>
/// Gets the D-Bus interfaces associated with @object.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObject.
/// </param>
/// <return>
/// A list of #GDBusInterface instances.
///   The returned list must be freed by g_list_free() after each element has been freed
///   with g_object_unref().
/// </return>

	public static MentorLake.GLib.GListHandle GetInterfaces(this MentorLake.Gio.GDBusObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_interfaces(@object);
	}

/// <summary>
/// <para>
/// Gets the object path for @object.
/// </para>
/// </summary>

/// <param name="@object">
/// A #GDBusObject.
/// </param>
/// <return>
/// A string owned by @object. Do not free.
/// </return>

	public static string GetObjectPath(this MentorLake.Gio.GDBusObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_object_path(@object);
	}

}

internal class GDBusObjectHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))]
	internal static extern MentorLake.Gio.GDBusInterfaceHandle g_dbus_object_get_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, string interface_name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_dbus_object_get_interfaces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

}
