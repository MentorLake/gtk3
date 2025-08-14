namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about a signal on a D-Bus interface.
/// </para>
/// </summary>

public class GDBusSignalInfoHandle : BaseSafeHandle
{
}


public static class GDBusSignalInfoExtensions
{
/// <summary>
/// <para>
/// If @info is statically allocated does nothing. Otherwise increases
/// the reference count.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusSignalInfo
/// </param>
/// <return>
/// The same @info.
/// </return>

	public static MentorLake.Gio.GDBusSignalInfoHandle Ref(this MentorLake.Gio.GDBusSignalInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusSignalInfo)");
		return GDBusSignalInfoExterns.g_dbus_signal_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusSignalInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusSignalInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusSignalInfo)");
		GDBusSignalInfoExterns.g_dbus_signal_info_unref(info);
	}


	public static GDBusSignalInfo Dereference(this GDBusSignalInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusSignalInfo>(x.DangerousGetHandle());
}
internal class GDBusSignalInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSignalInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusSignalInfoHandle g_dbus_signal_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSignalInfoHandle>))] MentorLake.Gio.GDBusSignalInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_signal_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSignalInfoHandle>))] MentorLake.Gio.GDBusSignalInfoHandle info);

}

/// <summary>
/// <para>
/// Information about a signal on a D-Bus interface.
/// </para>
/// </summary>

public struct GDBusSignalInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The name of the D-Bus signal, e.g. "NameOwnerChanged".
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusArgInfo structures or %NULL if there are no arguments.
/// </para>
/// </summary>

public IntPtr args;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
}
