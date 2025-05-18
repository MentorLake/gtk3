namespace MentorLake.Gio;

public class GDBusMethodInfoHandle : BaseSafeHandle
{
}


public static class GDBusMethodInfoExtensions
{
	public static MentorLake.Gio.GDBusMethodInfoHandle Ref(this MentorLake.Gio.GDBusMethodInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusMethodInfo)");
		return GDBusMethodInfoExterns.g_dbus_method_info_ref(info);
	}

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

public struct GDBusMethodInfo
{
	public int ref_count;
	public string name;
	public IntPtr in_args;
	public IntPtr out_args;
	public IntPtr annotations;
}
