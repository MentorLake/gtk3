namespace MentorLake.Gio;

public class GDBusObjectProxyHandle : GObjectHandle, GDBusObjectHandle
{
	public static MentorLake.Gio.GDBusObjectProxyHandle New(MentorLake.Gio.GDBusConnectionHandle connection, string object_path)
	{
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_new(connection, object_path);
	}

}

public static class GDBusObjectProxyHandleExtensions
{
	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectProxyHandle proxy)
	{
		if (proxy.IsInvalid || proxy.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectProxyHandle)");
		return GDBusObjectProxyHandleExterns.g_dbus_object_proxy_get_connection(proxy);
	}

}

internal class GDBusObjectProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectProxyHandle g_dbus_object_proxy_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_proxy_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectProxyHandle>))] MentorLake.Gio.GDBusObjectProxyHandle proxy);

}
