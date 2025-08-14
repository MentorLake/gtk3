namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about a method on a D-Bus interface.
/// </para>
/// </summary>

public class GDBusMethodInfoHandle : BaseSafeHandle
{
}


public static class GDBusMethodInfoExtensions
{
/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusMethodInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusMethodInfoHandle Ref(this MentorLake.Gio.GDBusMethodInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInfo)");
		return GDBusMethodInfoExterns.g_dbus_method_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusMethodInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusMethodInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInfo)");
		GDBusMethodInfoExterns.g_dbus_method_info_unref(info);
	}


	public static GDBusMethodInfo Dereference(this GDBusMethodInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusMethodInfo>(x.DangerousGetHandle());
}
internal class GDBusMethodInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusMethodInfoHandle g_dbus_method_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInfoHandle>))] MentorLake.Gio.GDBusMethodInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInfoHandle>))] MentorLake.Gio.GDBusMethodInfoHandle info);

}

/// <summary>
/// <para>
/// Information about a method on a D-Bus interface.
/// </para>
/// </summary>

public struct GDBusMethodInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The name of the D-Bus method, e.g. @RequestName.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusArgInfo structures or %NULL if there are no in arguments.
/// </para>
/// </summary>

public IntPtr in_args;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusArgInfo structures or %NULL if there are no out arguments.
/// </para>
/// </summary>

public IntPtr out_args;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
