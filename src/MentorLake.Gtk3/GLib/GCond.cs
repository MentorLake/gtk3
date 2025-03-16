namespace MentorLake.GLib;

public class GCondHandle : BaseSafeHandle
{
}


public static class GCondExtensions
{
	public static void Broadcast(this MentorLake.GLib.GCondHandle cond)
	{
		GCondExterns.g_cond_broadcast(cond);
	}

	public static void Clear(this MentorLake.GLib.GCondHandle cond)
	{
		GCondExterns.g_cond_clear(cond);
	}

	public static void Free(this MentorLake.GLib.GCondHandle cond)
	{
		GCondExterns.g_cond_free(cond);
	}

	public static void Init(this MentorLake.GLib.GCondHandle cond)
	{
		GCondExterns.g_cond_init(cond);
	}

	public static void Signal(this MentorLake.GLib.GCondHandle cond)
	{
		GCondExterns.g_cond_signal(cond);
	}

	public static bool TimedWait(this MentorLake.GLib.GCondHandle cond, MentorLake.GLib.GMutexHandle mutex, MentorLake.GLib.GTimeValHandle abs_time)
	{
		return GCondExterns.g_cond_timed_wait(cond, mutex, abs_time);
	}

	public static void Wait(this MentorLake.GLib.GCondHandle cond, MentorLake.GLib.GMutexHandle mutex)
	{
		GCondExterns.g_cond_wait(cond, mutex);
	}

	public static bool WaitUntil(this MentorLake.GLib.GCondHandle cond, MentorLake.GLib.GMutexHandle mutex, long end_time)
	{
		return GCondExterns.g_cond_wait_until(cond, mutex, end_time);
	}


	public static GCond Dereference(this GCondHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCond>(x.DangerousGetHandle());
}
internal class GCondExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_broadcast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_cond_timed_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle abs_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cond_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_cond_wait_until([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex, long end_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GCondHandle g_cond_new();

}

public struct GCond
{
	public static MentorLake.GLib.GCondHandle New()
	{
		return GCondExterns.g_cond_new();
	}

}
