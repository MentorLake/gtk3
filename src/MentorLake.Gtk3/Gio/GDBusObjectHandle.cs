namespace MentorLake.Gio;

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
	public static MentorLake.Gio.GDBusInterfaceHandle GetInterface(this MentorLake.Gio.GDBusObjectHandle @object, string interface_name)
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_interface(@object, interface_name);
	}

	public static MentorLake.GLib.GListHandle GetInterfaces(this MentorLake.Gio.GDBusObjectHandle @object)
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_interfaces(@object);
	}

	public static string GetObjectPath(this MentorLake.Gio.GDBusObjectHandle @object)
	{
		if (@object.IsInvalid || @object.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectHandle)");
		return GDBusObjectHandleExterns.g_dbus_object_get_object_path(@object);
	}

}

internal class GDBusObjectHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceHandle g_dbus_object_get_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object, string interface_name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_dbus_object_get_interfaces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_object_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

}
