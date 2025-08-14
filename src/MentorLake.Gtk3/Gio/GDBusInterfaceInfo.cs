namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about a D-Bus interface.
/// </para>
/// </summary>

public class GDBusInterfaceInfoHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceInfoExtensions
{
/// <summary>
/// <para>
/// Builds a lookup-cache to speed up
/// g_dbus_interface_info_lookup_method(),
/// g_dbus_interface_info_lookup_signal() and
/// g_dbus_interface_info_lookup_property().
/// </para>
/// <para>
/// If this has already been called with @info, the existing cache is
/// used and its use count is increased.
/// </para>
/// <para>
/// Note that @info cannot be modified until
/// g_dbus_interface_info_cache_release() is called.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo.
/// </param>

	public static void CacheBuild(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_build(info);
	}

/// <summary>
/// <para>
/// Decrements the usage count for the cache for @info built by
/// g_dbus_interface_info_cache_build() (if any) and frees the
/// resources used by the cache if the usage count drops to zero.
/// </para>
/// </summary>

/// <param name="info">
/// A GDBusInterfaceInfo
/// </param>

	public static void CacheRelease(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_cache_release(info);
	}

/// <summary>
/// <para>
/// Appends an XML representation of @info (and its children) to @string_builder.
/// </para>
/// <para>
/// This function is typically used for generating introspection XML
/// documents at run-time for handling the
/// `org.freedesktop.DBus.Introspectable.Introspect`
/// method.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusNodeInfo
/// </param>
/// <param name="indent">
/// Indentation level.
/// </param>
/// <param name="string_builder">
/// A #GString to to append XML data to.
/// </param>

	public static void GenerateXml(this MentorLake.Gio.GDBusInterfaceInfoHandle info, uint indent, MentorLake.GLib.GStringHandle string_builder)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		GDBusInterfaceInfoExterns.g_dbus_interface_info_generate_xml(info, indent, string_builder);
	}

/// <summary>
/// <para>
/// Looks up information about a method.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of methods unless
/// g_dbus_interface_info_cache_build() has been used on @info.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo.
/// </param>
/// <param name="name">
/// A D-Bus method name (typically in CamelCase)
/// </param>
/// <return>
/// A #GDBusMethodInfo or %NULL if not found. Do not free, it is owned by @info.
/// </return>

	public static MentorLake.Gio.GDBusMethodInfoHandle LookupMethod(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_method(info, name);
	}

/// <summary>
/// <para>
/// Looks up information about a property.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of properties unless
/// g_dbus_interface_info_cache_build() has been used on @info.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo.
/// </param>
/// <param name="name">
/// A D-Bus property name (typically in CamelCase).
/// </param>
/// <return>
/// A #GDBusPropertyInfo or %NULL if not found. Do not free, it is owned by @info.
/// </return>

	public static MentorLake.Gio.GDBusPropertyInfoHandle LookupProperty(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_property(info, name);
	}

/// <summary>
/// <para>
/// Looks up information about a signal.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of signals unless
/// g_dbus_interface_info_cache_build() has been used on @info.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo.
/// </param>
/// <param name="name">
/// A D-Bus signal name (typically in CamelCase)
/// </param>
/// <return>
/// A #GDBusSignalInfo or %NULL if not found. Do not free, it is owned by @info.
/// </return>

	public static MentorLake.Gio.GDBusSignalInfoHandle LookupSignal(this MentorLake.Gio.GDBusInterfaceInfoHandle info, string name)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_lookup_signal(info, name);
	}

/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusInterfaceInfoHandle Ref(this MentorLake.Gio.GDBusInterfaceInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusInterfaceInfo)");
		return GDBusInterfaceInfoExterns.g_dbus_interface_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusInterfaceInfo.
/// </param>

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

/// <summary>
/// <para>
/// Information about a D-Bus interface.
/// </para>
/// </summary>

public struct GDBusInterfaceInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The name of the D-Bus interface, e.g. "org.freedesktop.DBus.Properties".
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusMethodInfo structures or %NULL if there are no methods.
/// </para>
/// </summary>

public IntPtr methods;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusSignalInfo structures or %NULL if there are no signals.
/// </para>
/// </summary>

public IntPtr signals;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusPropertyInfo structures or %NULL if there are no properties.
/// </para>
/// </summary>

public IntPtr properties;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
