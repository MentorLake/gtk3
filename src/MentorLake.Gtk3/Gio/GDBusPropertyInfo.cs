namespace MentorLake.Gio;

public class GDBusPropertyInfoHandle : BaseSafeHandle
{
}


public static class GDBusPropertyInfoExtensions
{
	public static MentorLake.Gio.GDBusPropertyInfoHandle Ref(this MentorLake.Gio.GDBusPropertyInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusPropertyInfo)");
		return GDBusPropertyInfoExterns.g_dbus_property_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusPropertyInfoHandle info)
	{
		if (info.IsInvalid || info.IsClosed) throw new Exception("Invalid or closed handle (GDBusPropertyInfo)");
		GDBusPropertyInfoExterns.g_dbus_property_info_unref(info);
	}


	public static GDBusPropertyInfo Dereference(this GDBusPropertyInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusPropertyInfo>(x.DangerousGetHandle());
}
internal class GDBusPropertyInfoExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusPropertyInfoHandle g_dbus_property_info_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))] MentorLake.Gio.GDBusPropertyInfoHandle info);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_property_info_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusPropertyInfoHandle>))] MentorLake.Gio.GDBusPropertyInfoHandle info);

}

public struct GDBusPropertyInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusPropertyInfoFlags flags;
	public IntPtr annotations;
}
