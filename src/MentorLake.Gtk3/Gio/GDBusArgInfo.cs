namespace MentorLake.Gio;

public class GDBusArgInfoHandle : BaseSafeHandle
{
}


public static class GDBusArgInfoExtensions
{
	public static MentorLake.Gio.GDBusArgInfoHandle Ref(this MentorLake.Gio.GDBusArgInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusArgInfo)");
		return GDBusArgInfoExterns.g_dbus_arg_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusArgInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusArgInfo)");
		GDBusArgInfoExterns.g_dbus_arg_info_unref(info);
	}


	public static GDBusArgInfo Dereference(this GDBusArgInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusArgInfo>(x.DangerousGetHandle());
}
internal class GDBusArgInfoExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusArgInfoHandle g_dbus_arg_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusArgInfoHandle>))] MentorLake.Gio.GDBusArgInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_arg_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusArgInfoHandle>))] MentorLake.Gio.GDBusArgInfoHandle info);

}

public struct GDBusArgInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public IntPtr annotations;
}
