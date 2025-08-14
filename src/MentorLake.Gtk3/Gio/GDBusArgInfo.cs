namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about an argument for a method or a signal.
/// </para>
/// </summary>

public class GDBusArgInfoHandle : BaseSafeHandle
{
}


public static class GDBusArgInfoExtensions
{
/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusArgInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusArgInfoHandle Ref(this MentorLake.Gio.GDBusArgInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusArgInfo)");
		return GDBusArgInfoExterns.g_dbus_arg_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusArgInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusArgInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusArgInfo)");
		GDBusArgInfoExterns.g_dbus_arg_info_unref(info);
	}


	public static GDBusArgInfo Dereference(this GDBusArgInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusArgInfo>(x.DangerousGetHandle());
}
internal class GDBusArgInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusArgInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusArgInfoHandle g_dbus_arg_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusArgInfoHandle>))] MentorLake.Gio.GDBusArgInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_arg_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusArgInfoHandle>))] MentorLake.Gio.GDBusArgInfoHandle info);

}

/// <summary>
/// <para>
/// Information about an argument for a method or a signal.
/// </para>
/// </summary>

public struct GDBusArgInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// Name of the argument, e.g. @unix_user_id.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// D-Bus signature of the argument (a single complete type).
/// </para>
/// </summary>

public string signature;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
