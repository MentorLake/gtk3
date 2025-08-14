namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about nodes in a remote object hierarchy.
/// </para>
/// </summary>

public class GDBusNodeInfoHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Parses @xml_data and returns a #GDBusNodeInfo representing the data.
/// </para>
/// <para>
/// The introspection XML must contain exactly one top-level
/// `<node>` element.
/// </para>
/// <para>
/// Note that this routine is using a
/// [GMarkup][glib-Simple-XML-Subset-Parser.description]-based
/// parser that only accepts a subset of valid XML documents.
/// </para>
/// </summary>

/// <param name="xml_data">
/// Valid D-Bus introspection XML.
/// </param>
/// <return>
/// A #GDBusNodeInfo structure or %NULL if @error is set. Free
/// with g_dbus_node_info_unref().
/// </return>

	public static MentorLake.Gio.GDBusNodeInfoHandle NewForXml(string xml_data)
	{
		var externCallResult = GDBusNodeInfoExterns.g_dbus_node_info_new_for_xml(xml_data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GDBusNodeInfoExtensions
{
/// <summary>
/// <para>
/// Appends an XML representation of @info (and its children) to @string_builder.
/// </para>
/// <para>
/// This function is typically used for generating introspection XML documents at run-time for
/// handling the `org.freedesktop.DBus.Introspectable.Introspect`  method.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusNodeInfo.
/// </param>
/// <param name="indent">
/// Indentation level.
/// </param>
/// <param name="string_builder">
/// A #GString to to append XML data to.
/// </param>

	public static void GenerateXml(this MentorLake.Gio.GDBusNodeInfoHandle info, uint indent, MentorLake.GLib.GStringHandle string_builder)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusNodeInfo)");
		GDBusNodeInfoExterns.g_dbus_node_info_generate_xml(info, indent, string_builder);
	}

/// <summary>
/// <para>
/// Looks up information about an interface.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of interfaces.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusNodeInfo.
/// </param>
/// <param name="name">
/// A D-Bus interface name.
/// </param>
/// <return>
/// A #GDBusInterfaceInfo or %NULL if not found. Do not free, it is owned by @info.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceInfoHandle LookupInterface(this MentorLake.Gio.GDBusNodeInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusNodeInfo)");
		return GDBusNodeInfoExterns.g_dbus_node_info_lookup_interface(info, name);
	}

/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusNodeInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusNodeInfoHandle Ref(this MentorLake.Gio.GDBusNodeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusNodeInfo)");
		return GDBusNodeInfoExterns.g_dbus_node_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusNodeInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusNodeInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusNodeInfo)");
		GDBusNodeInfoExterns.g_dbus_node_info_unref(info);
	}


	public static GDBusNodeInfo Dereference(this GDBusNodeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusNodeInfo>(x.DangerousGetHandle());
}
internal class GDBusNodeInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusNodeInfoHandle g_dbus_node_info_new_for_xml(string xml_data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_node_info_generate_xml([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info, uint indent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle string_builder);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusInterfaceInfoHandle g_dbus_node_info_lookup_interface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusNodeInfoHandle g_dbus_node_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_node_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusNodeInfoHandle>))] MentorLake.Gio.GDBusNodeInfoHandle info);

}

/// <summary>
/// <para>
/// Information about nodes in a remote object hierarchy.
/// </para>
/// </summary>

public struct GDBusNodeInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The path of the node or %NULL if omitted. Note that this may be a relative path. See the D-Bus specification for more details.
/// </para>
/// </summary>

public string path;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusInterfaceInfo structures or %NULL if there are no interfaces.
/// </para>
/// </summary>

public IntPtr interfaces;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusNodeInfo structures or %NULL if there are no nodes.
/// </para>
/// </summary>

public IntPtr nodes;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
