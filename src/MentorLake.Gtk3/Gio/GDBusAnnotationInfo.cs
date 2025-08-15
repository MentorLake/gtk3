namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Information about an annotation.
/// </para>
/// </summary>

public class GDBusAnnotationInfoHandle : BaseSafeHandle
{
}


public static class GDBusAnnotationInfoExtensions
{
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

	public static MentorLake.Gio.GDBusAnnotationInfoHandle Ref(this MentorLake.Gio.GDBusAnnotationInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusAnnotationInfo)");
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_ref(info);
	}

/// <summary>
/// <para>
/// If @info is statically allocated, does nothing. Otherwise decreases
/// the reference count of @info. When its reference count drops to 0,
/// the memory used is freed.
/// </para>
/// </summary>

/// <param name="info">
/// A #GDBusAnnotationInfo.
/// </param>

	public static void Unref(this MentorLake.Gio.GDBusAnnotationInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusAnnotationInfo)");
		GDBusAnnotationInfoExterns.g_dbus_annotation_info_unref(info);
	}


	public static GDBusAnnotationInfo Dereference(this GDBusAnnotationInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusAnnotationInfo>(x.DangerousGetHandle());
}
internal class GDBusAnnotationInfoExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))]
	internal static extern MentorLake.Gio.GDBusAnnotationInfoHandle g_dbus_annotation_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_annotation_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_annotation_info_lookup([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name);

}

/// <summary>
/// <para>
/// Information about an annotation.
/// </para>
/// </summary>

public struct GDBusAnnotationInfo
{
	/// <summary>
/// <para>
/// The reference count or -1 if statically allocated.
/// </para>
/// </summary>

public int ref_count;
	/// <summary>
/// <para>
/// The name of the annotation, e.g. &quot;org.freedesktop.DBus.Deprecated&quot;.
/// </para>
/// </summary>

public string key;
	/// <summary>
/// <para>
/// The value of the annotation.
/// </para>
/// </summary>

public string value;
	/// <summary>
/// <para>
/// A pointer to a %NULL-terminated array of pointers to #GDBusAnnotationInfo structures or %NULL if there are no annotations.
/// </para>
/// </summary>

public IntPtr annotations;
/// <summary>
/// <para>
/// Looks up the value of an annotation.
/// </para>
/// <para>
/// The cost of this function is O(n) in number of annotations.
/// </para>
/// </summary>

/// <param name="annotations">
/// A %NULL-terminated array of annotations or %NULL.
/// </param>
/// <param name="name">
/// The name of the annotation to look up.
/// </param>
/// <return>
/// The value or %NULL if not found. Do not free, it is owned by @annotations.
/// </return>

	public static string Lookup(MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name)
	{
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_lookup(annotations, name);
	}

}
