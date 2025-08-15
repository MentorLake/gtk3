namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about a D-Bus property on a D-Bus interface.
/// </para>
/// </summary>

public class GDBusPropertyInfoHandle : BaseSafeHandle
{
}


public static class GDBusPropertyInfoExtensions
{
/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusPropertyInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusPropertyInfoHandle Ref(this MentorLake.Gio.GDBusPropertyInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusPropertyInfo)");
		return GDBusPropertyInfoExterns.g_dbus_property_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusPropertyInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusPropertyInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusPropertyInfo)");
		GDBusPropertyInfoExterns.g_dbus_property_info_unref(info);
	}


	public static GDBusPropertyInfo Dereference(this GDBusPropertyInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusPropertyInfo>(x.DangerousGetHandle());
}
internal class GDBusPropertyInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusPropertyInfoHandle g_dbus_property_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))] MentorLake.Gio.GDBusPropertyInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_property_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))] MentorLake.Gio.GDBusPropertyInfoHandle info);

}

/// <summary>
/// <para>
/// Information about a D-Bus property on a D-Bus interface.
/// </para>
/// </summary>

public struct GDBusPropertyInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The name of the D-Bus property, e.g. &quot;SupportedFilesystems&quot;.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// The D-Bus signature of the property (a single complete type).
/// </para>
/// </summary>

public string signature;
	/// <summary>
/// <para>
/// Access control flags for the property.
/// </para>
/// </summary>

public GDBusPropertyInfoFlags flags;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
