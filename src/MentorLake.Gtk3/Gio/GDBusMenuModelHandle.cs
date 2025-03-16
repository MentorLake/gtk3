namespace MentorLake.Gio;

public class GDBusMenuModelHandle : GMenuModelHandle
{
	public static MentorLake.Gio.GDBusMenuModelHandle Get(MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusMenuModelHandleExterns.g_dbus_menu_model_get(connection, bus_name, object_path);
	}

}

public static class GDBusMenuModelHandleExtensions
{
}

internal class GDBusMenuModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMenuModelHandle g_dbus_menu_model_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path);

}
