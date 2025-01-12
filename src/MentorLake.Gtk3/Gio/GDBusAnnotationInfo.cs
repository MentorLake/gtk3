namespace MentorLake.Gtk3.Gio;

public class GDBusAnnotationInfoHandle : BaseSafeHandle
{
}


public static class GDBusAnnotationInfoHandleExtensions
{
	public static GDBusAnnotationInfoHandle GDbusAnnotationInfoRef(this GDBusAnnotationInfoHandle info)
	{
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_ref(info);
	}

	public static T GDbusAnnotationInfoUnref<T>(this T info) where T : GDBusAnnotationInfoHandle
	{
		GDBusAnnotationInfoExterns.g_dbus_annotation_info_unref(info);
		return info;
	}

	public static string GDbusAnnotationInfoLookup(GDBusAnnotationInfoHandle[] annotations, string name)
	{
		return GDBusAnnotationInfoExterns.g_dbus_annotation_info_lookup(annotations, name);
	}

}
internal class GDBusAnnotationInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusAnnotationInfoHandle g_dbus_annotation_info_ref(GDBusAnnotationInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_annotation_info_unref(GDBusAnnotationInfoHandle info);

	[DllImport(Libraries.Gio)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_annotation_info_lookup(GDBusAnnotationInfoHandle[] annotations, string name);

}

public struct GDBusAnnotationInfo
{
	public int ref_count;
	public string key;
	public string value;
	public GDBusAnnotationInfoHandle[] annotations;
}
