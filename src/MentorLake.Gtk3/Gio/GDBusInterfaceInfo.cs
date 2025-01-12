namespace MentorLake.Gtk3.Gio;

public class GDBusInterfaceInfoHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceInfoHandleExtensions
{
	public static T GDbusInterfaceInfoCacheBuild<T>(this T info) where T : GDBusInterfaceInfoHandle
	{
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_build(info);
		return info;
	}

	public static T GDbusInterfaceInfoCacheRelease<T>(this T info) where T : GDBusInterfaceInfoHandle
	{
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_release(info);
		return info;
	}

	public static T GDbusInterfaceInfoGenerateXml<T>(this T info, uint indent, GStringHandle string_builder) where T : GDBusInterfaceInfoHandle
	{
		GDBusInterfaceInfoExterns.g_dbus_interface_info_generate_xml(info, indent, string_builder);
		return info;
	}

	public static GDBusMethodInfoHandle GDbusInterfaceInfoLookupMethod(this GDBusInterfaceInfoHandle info, string name)
	{
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_method(info, name);
	}

	public static GDBusPropertyInfoHandle GDbusInterfaceInfoLookupProperty(this GDBusInterfaceInfoHandle info, string name)
	{
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_property(info, name);
	}

	public static GDBusSignalInfoHandle GDbusInterfaceInfoLookupSignal(this GDBusInterfaceInfoHandle info, string name)
	{
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_signal(info, name);
	}

	public static GDBusInterfaceInfoHandle GDbusInterfaceInfoRef(this GDBusInterfaceInfoHandle info)
	{
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_ref(info);
	}

	public static T GDbusInterfaceInfoUnref<T>(this T info) where T : GDBusInterfaceInfoHandle
	{
		GDBusInterfaceInfoExterns.g_dbus_interface_info_unref(info);
		return info;
	}

}
internal class GDBusInterfaceInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_info_cache_build(GDBusInterfaceInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_info_cache_release(GDBusInterfaceInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_info_generate_xml(GDBusInterfaceInfoHandle info, uint indent, GStringHandle string_builder);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMethodInfoHandle g_dbus_interface_info_lookup_method(GDBusInterfaceInfoHandle info, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusPropertyInfoHandle g_dbus_interface_info_lookup_property(GDBusInterfaceInfoHandle info, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusSignalInfoHandle g_dbus_interface_info_lookup_signal(GDBusInterfaceInfoHandle info, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_interface_info_ref(GDBusInterfaceInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_info_unref(GDBusInterfaceInfoHandle info);

}

public struct GDBusInterfaceInfo
{
	public int ref_count;
	public string name;
	public GDBusMethodInfoHandle[] methods;
	public GDBusSignalInfoHandle[] signals;
	public GDBusPropertyInfoHandle[] properties;
	public GDBusAnnotationInfoHandle[] annotations;
}
