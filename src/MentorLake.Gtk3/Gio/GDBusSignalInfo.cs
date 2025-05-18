namespace MentorLake.Gio;

public class GDBusSignalInfoHandle : BaseSafeHandle
{
}


public static class GDBusSignalInfoExtensions
{
	public static MentorLake.Gio.GDBusSignalInfoHandle Ref(this MentorLake.Gio.GDBusSignalInfoHandle info)
	{
		if (info.IsInvalid) throw new Exception("Invalid handle (GDBusSignalInfo)");
		return GDBusSignalInfoExterns.g_dbus_signal_info_ref(info);
	}

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

public struct GDBusSignalInfo
{
	public int ref_count;
	public string name;
	public IntPtr args;
	public IntPtr annotations;
}
