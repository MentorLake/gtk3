namespace MentorLake.Gio;

public class GDBusSignalInfoHandle : BaseSafeHandle
{
}


public static class GDBusSignalInfoExtensions
{
	public static MentorLake.Gio.GDBusSignalInfoHandle Ref(this MentorLake.Gio.GDBusSignalInfoHandle info)
	{
		return GDBusSignalInfoExterns.g_dbus_signal_info_ref(info);
	}

	public static void Unref(this MentorLake.Gio.GDBusSignalInfoHandle info)
	{
		GDBusSignalInfoExterns.g_dbus_signal_info_unref(info);
	}


	public static GDBusSignalInfo Dereference(this GDBusSignalInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusSignalInfo>(x.DangerousGetHandle());
}
internal class GDBusSignalInfoExterns
{
	[DllImport(GioLibrary.Name)]
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
