namespace MentorLake.Gtk3.Gio;

public class GTestDBusHandle : GObjectHandle
{
	public static GTestDBusHandle GTestDbusNew(GTestDBusFlags flags)
	{
		return GTestDBusExterns.g_test_dbus_new(flags);
	}

	public static void GTestDbusUnset()
	{
		GTestDBusExterns.g_test_dbus_unset();
	}

}

public static class GTestDBusHandleExtensions
{
	public static T GTestDbusAddServiceDir<T>(this T self, string path) where T : GTestDBusHandle
	{
		GTestDBusExterns.g_test_dbus_add_service_dir(self, path);
		return self;
	}

	public static T GTestDbusDown<T>(this T self) where T : GTestDBusHandle
	{
		GTestDBusExterns.g_test_dbus_down(self);
		return self;
	}

	public static string GTestDbusGetBusAddress(this GTestDBusHandle self)
	{
		return GTestDBusExterns.g_test_dbus_get_bus_address(self);
	}

	public static GTestDBusFlags GTestDbusGetFlags(this GTestDBusHandle self)
	{
		return GTestDBusExterns.g_test_dbus_get_flags(self);
	}

	public static T GTestDbusStop<T>(this T self) where T : GTestDBusHandle
	{
		GTestDBusExterns.g_test_dbus_stop(self);
		return self;
	}

	public static T GTestDbusUp<T>(this T self) where T : GTestDBusHandle
	{
		GTestDBusExterns.g_test_dbus_up(self);
		return self;
	}

}

internal class GTestDBusExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTestDBusHandle g_test_dbus_new(GTestDBusFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_add_service_dir(GTestDBusHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_down(GTestDBusHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern string g_test_dbus_get_bus_address(GTestDBusHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern GTestDBusFlags g_test_dbus_get_flags(GTestDBusHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_stop(GTestDBusHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_up(GTestDBusHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern void g_test_dbus_unset();

}
