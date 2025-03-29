namespace MentorLake.Gio;

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
	public static MentorLake.Gio.GDBusObjectHandle DupObject(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_dup_object(interface_);
	}

	public static MentorLake.Gio.GDBusInterfaceInfoHandle GetInfo(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_get_info(interface_);
	}

	public static MentorLake.Gio.GDBusObjectHandle GetObject(this MentorLake.Gio.GDBusInterfaceHandle interface_)
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceHandle)");
		return GDBusInterfaceHandleExterns.g_dbus_interface_get_object(interface_);
	}

	public static T SetObject<T>(this T interface_, MentorLake.Gio.GDBusObjectHandle @object) where T : GDBusInterfaceHandle
	{
		if (interface_.IsInvalid || interface_.IsClosed) throw new Exception("Invalid or closed handle (GDBusInterfaceHandle)");
		GDBusInterfaceHandleExterns.g_dbus_interface_set_object(interface_, @object);
		return interface_;
	}

}

internal class GDBusInterfaceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_interface_dup_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_interface_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectHandle g_dbus_interface_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_set_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceHandleImpl>))] MentorLake.Gio.GDBusInterfaceHandle interface_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectHandleImpl>))] MentorLake.Gio.GDBusObjectHandle @object);

}
