namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Base type for D-Bus interfaces.
/// </para>
/// <para>
/// The `GDBusInterface` type is the base type for D-Bus interfaces both
/// on the service side (see [class@Gio.DBusInterfaceSkeleton]) and client side
/// (see [class@Gio.DBusProxy]).
/// </para>
/// </summary>

public interface GDBusInterfaceHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDBusInterfaceHandleImpl : BaseSafeHandle, GDBusInterfaceHandle
{
}

public static class GDBusInterfaceHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GDBusObject that @interface_ belongs to, if any.
/// </para>
/// </summary>

/// <param name="interface_">
/// An exported D-Bus interface.
/// </param>
/// <return>
/// A #GDBusObject or %NULL. The returned
/// reference should be freed with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusObjectHandle DupObject(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_dup_object(interface_);
	}

/// <summary>
/// <para>
/// Gets D-Bus introspection information for the D-Bus interface
/// implemented by @interface_.
/// </para>
/// </summary>

/// <param name="interface_">
/// An exported D-Bus interface.
/// </param>
/// <return>
/// A #GDBusInterfaceInfo. Do not free.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInfo(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_get_info(interface_);
	}

/// <summary>
/// <para>
/// Gets the #GDBusObject that @interface_ belongs to, if any.
/// </para>
/// <para>
/// It is not safe to use the returned object if @interface_ or
/// the returned object is being used from other threads. See
/// g_dbus_interface_dup_object() for a thread-safe alternative.
/// </para>
/// </summary>

/// <param name="interface_">
/// An exported D-Bus interface
/// </param>
/// <return>
/// A #GDBusObject or %NULL. The returned
///     reference belongs to @interface_ and should not be freed.
/// </return>

	public static MentorLake.Gio.GDBusObjectHandle GetObject(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_get_object(interface_);
	}

/// <summary>
/// <para>
/// Sets the #GDBusObject for @interface_ to @object.
/// </para>
/// <para>
/// Note that @interface_ will hold a weak reference to @object.
/// </para>
/// </summary>

/// <param name="interface_">
/// An exported D-Bus interface.
/// </param>
/// <param name="@object">
/// A #GDBusObject or %NULL.
/// </param>

	public static T SetObject<T>(this T interface_, MentorLake.Gio.GDBusObjectHandle @object) where T : GDBusInterfaceHandle
	{
		if (interface_.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceHandle)");
		GDBusInterfaceHandleExterns.g_dbus_interface_set_object(interface_, @object);
		return interface_;
	}

}

internal class GDBusInterfaceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_interface_dup_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_interface_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_interface_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_set_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

}
