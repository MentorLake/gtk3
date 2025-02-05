namespace MentorLake.Gtk3.Gio;

public interface GDBusInterfaceHandle
{
}

internal class GDBusInterfaceHandleImpl : BaseSafeHandle, GDBusInterfaceHandle
{
}

public static class GDBusInterfaceHandleExtensions
{
	public static GDBusObjectHandle GDbusInterfaceDupObject(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_dup_object(interface_);
	}

	public static GDBusInterfaceInfoHandle GDbusInterfaceGetInfo(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_get_info(interface_);
	}

	public static GDBusObjectHandle GDbusInterfaceGetObject(this GDBusInterfaceHandle interface_)
	{
		return GDBusInterfaceExterns.g_dbus_interface_get_object(interface_);
	}

	public static T GDbusInterfaceSetObject<T>(this T interface_, GDBusObjectHandle @object) where T : GDBusInterfaceHandle
	{
		GDBusInterfaceExterns.g_dbus_interface_set_object(interface_, @object);
		return interface_;
	}

}

internal class GDBusInterfaceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_interface_dup_object(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_interface_get_info(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusObjectHandle g_dbus_interface_get_object(GDBusInterfaceHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_set_object(GDBusInterfaceHandle interface_, GDBusObjectHandle @object);

}
