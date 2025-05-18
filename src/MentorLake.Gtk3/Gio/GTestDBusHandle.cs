namespace MentorLake.Gio;

public class GTestDBusHandle : GObjectHandle
{
	public static MentorLake.Gio.GTestDBusHandle New(MentorLake.Gio.GTestDBusFlags flags)
	{
		return GTestDBusHandleExterns.g_test_dbus_new(flags);
	}

	public static void Unset()
	{
		GTestDBusHandleExterns.g_test_dbus_unset();
	}

}

public static class GTestDBusHandleExtensions
{
	public static T AddServiceDir<T>(this T self, string path) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_add_service_dir(self, path);
		return self;
	}

	public static T Down<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_down(self);
		return self;
	}

	public static string GetBusAddress(this MentorLake.Gio.GTestDBusHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		return GTestDBusHandleExterns.g_test_dbus_get_bus_address(self);
	}

	public static MentorLake.Gio.GTestDBusFlags GetFlags(this MentorLake.Gio.GTestDBusHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		return GTestDBusHandleExterns.g_test_dbus_get_flags(self);
	}

	public static T Stop<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_stop(self);
		return self;
	}

	public static T Up<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_up(self);
		return self;
	}

}

internal class GTestDBusHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))]
	internal static extern MentorLake.Gio.GTestDBusHandle g_test_dbus_new(MentorLake.Gio.GTestDBusFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_add_service_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_dbus_get_bus_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTestDBusFlags g_test_dbus_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_unset();

}
