namespace MentorLake.Gio;

public class GDBusNodeInfoHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GDBusNodeInfoHandle NewForXml(string xml_data, IntPtr error)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_new_for_xml(xml_data, error);
	}

}


public static class GDBusNodeInfoExtensions
{
	public static void GenerateXml(this MentorLake.Gio.GDBusNodeInfoHandle info, uint indent, MentorLake.GLib.GStringHandle string_builder)
	{
		GDBusNodeInfoExterns.g_dbus_node_info_generate_xml(info, indent, string_builder);
	}

	public static MentorLake.Gio.GDBusInterfaceInfoHandle LookupInterface(this MentorLake.Gio.GDBusNodeInfoHandle info, string name)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_lookup_interface(info, name);
	}

	public static MentorLake.Gio.GDBusNodeInfoHandle Ref(this MentorLake.Gio.GDBusNodeInfoHandle info)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusNodeInfoHandle info)
	{
		GDBusNodeInfoExterns.g_dbus_node_info_unref(info);
	}


	public static GDBusNodeInfo Dereference(this GDBusNodeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusNodeInfo>(x.DangerousGetHandle());
}
internal class GDBusNodeInfoExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusNodeInfoHandle g_dbus_node_info_new_for_xml(string xml_data, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_node_info_generate_xml([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info, uint indent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle string_builder);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_node_info_lookup_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusNodeInfoHandle g_dbus_node_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_node_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info);

}

public struct GDBusNodeInfo
{
	public int ref_count;
	public string path;
	public IntPtr interfaces;
	public IntPtr nodes;
	public IntPtr annotations;
}
