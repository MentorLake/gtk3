namespace MentorLake.Gio;

public class GDBusAnnotationInfoHandle : BaseSafeHandle
{
}


public static class GDBusAnnotationInfoExtensions
{
	public static MentorLake.Gio.GDBusAnnotationInfoHandle Ref(this MentorLake.Gio.GDBusAnnotationInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusAnnotationInfo)");
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusAnnotationInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusAnnotationInfo)");
		GDBusAnnotationInfoExterns.g_dbus_annotation_info_unref(info);
	}


	public static GDBusAnnotationInfo Dereference(this GDBusAnnotationInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusAnnotationInfo>(x.DangerousGetHandle());
}
internal class GDBusAnnotationInfoExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusAnnotationInfoHandle g_dbus_annotation_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_annotation_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle info);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_annotation_info_lookup([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAnnotationInfoHandle>))] MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name);

}

public struct GDBusAnnotationInfo
{
	public int ref_count;
	public string key;
	public string value;
	public IntPtr annotations;
	public static string Lookup(MentorLake.Gio.GDBusAnnotationInfoHandle[] annotations, string name)
	{
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_lookup(annotations, name);
	}

}
