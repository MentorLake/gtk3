namespace MentorLake.Gtk3.Gio;

public class GDBusArgInfoHandle : BaseSafeHandle
{
}


public static class GDBusArgInfoHandleExtensions
{
	public static GDBusArgInfoHandle GDbusArgInfoRef(this GDBusArgInfoHandle info)
	{
		return GDBusArgInfoExterns.g_dbus_arg_info_ref(info);
	}

	public static T GDbusArgInfoUnref<T>(this T info) where T : GDBusArgInfoHandle
	{
		GDBusArgInfoExterns.g_dbus_arg_info_unref(info);
		return info;
	}

}
internal class GDBusArgInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusArgInfoHandle g_dbus_arg_info_ref(GDBusArgInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_arg_info_unref(GDBusArgInfoHandle info);

}

public struct GDBusArgInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusAnnotationInfoHandle[] annotations;
}
