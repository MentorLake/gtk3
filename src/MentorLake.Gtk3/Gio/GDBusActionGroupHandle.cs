namespace MentorLake.Gio;

public class GDBusActionGroupHandle : GObjectHandle, GActionGroupHandle, GRemoteActionGroupHandle
{
	public static MentorLake.Gio.GDBusActionGroupHandle Get(MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusActionGroupHandleExterns.g_dbus_action_group_get(connection, bus_name, object_path);
	}

}

public static class GDBusActionGroupHandleExtensions
{
}

internal class GDBusActionGroupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusActionGroupHandle g_dbus_action_group_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path);

}
