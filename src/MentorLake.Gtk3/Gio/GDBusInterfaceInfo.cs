namespace MentorLake.Gio;

public class GDBusInterfaceInfoHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceInfoExtensions
{
	public static void CacheBuild(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_build(info);
	}

	public static void CacheRelease(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_release(info);
	}

	public static void GenerateXml(this MentorLake.Gio.GDBusInterfaceInfoHandle info, uint indent, MentorLake.GLib.GStringHandle string_builder)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_generate_xml(info, indent, string_builder);
	}

	public static MentorLake.Gio.GDBusMethodInfoHandle LookupMethod(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_method(info, name);
	}

	public static MentorLake.Gio.GDBusPropertyInfoHandle LookupProperty(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_property(info, name);
	}

	public static MentorLake.Gio.GDBusSignalInfoHandle LookupSignal(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_signal(info, name);
	}

	public static MentorLake.Gio.GDBusInterfaceInfoHandle Ref(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_unref(info);
	}


	public static GDBusInterfaceInfo Dereference(this GDBusInterfaceInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceInfo>(x.DangerousGetHandle());
}
internal class GDBusInterfaceInfoExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_info_cache_build([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_info_cache_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_info_generate_xml([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, uint indent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle string_builder);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusMethodInfoHandle g_dbus_interface_info_lookup_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusPropertyInfoHandle g_dbus_interface_info_lookup_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSignalInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusSignalInfoHandle g_dbus_interface_info_lookup_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_interface_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_interface_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle info);

}

public struct GDBusInterfaceInfo
{
	public int ref_count;
	public string name;
	public IntPtr methods;
	public IntPtr signals;
	public IntPtr properties;
	public IntPtr annotations;
}
