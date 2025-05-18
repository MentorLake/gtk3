namespace MentorLake.GLib;

public class GStaticMutexHandle : BaseSafeHandle
{
}


public static class GStaticMutexExtensions
{
	public static void Free(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		GStaticMutexExterns.g_static_mutex_free(mutex);
	}

	public static MentorLake.GLib.GMutexHandle GetMutexImpl(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		return GStaticMutexExterns.g_static_mutex_get_mutex_impl(mutex);
	}

	public static void Init(this MentorLake.GLib.GStaticMutexHandle mutex)
	{
		if (mutex.IsInvalid) throw new Exception("Invalid handle (GStaticMutex)");
		GStaticMutexExterns.g_static_mutex_init(mutex);
	}


	public static GStaticMutex Dereference(this GStaticMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticMutex>(x.DangerousGetHandle());
}
internal class GStaticMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))]
	internal static extern MentorLake.GLib.GMutexHandle g_static_mutex_get_mutex_impl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticMutexHandle>))] MentorLake.GLib.GStaticMutexHandle mutex);

}

public struct GStaticMutex
{
	public IntPtr mutex;
}
