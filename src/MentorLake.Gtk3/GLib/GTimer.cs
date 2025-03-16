namespace MentorLake.GLib;

public class GTimerHandle : BaseSafeHandle
{
}


public static class GTimerExtensions
{
	public static void Continue(this MentorLake.GLib.GTimerHandle timer)
	{
		GTimerExterns.g_timer_continue(timer);
	}

	public static void Destroy(this MentorLake.GLib.GTimerHandle timer)
	{
		GTimerExterns.g_timer_destroy(timer);
	}

	public static double Elapsed(this MentorLake.GLib.GTimerHandle timer, ulong microseconds)
	{
		return GTimerExterns.g_timer_elapsed(timer, microseconds);
	}

	public static bool IsActive(this MentorLake.GLib.GTimerHandle timer)
	{
		return GTimerExterns.g_timer_is_active(timer);
	}

	public static void Reset(this MentorLake.GLib.GTimerHandle timer)
	{
		GTimerExterns.g_timer_reset(timer);
	}

	public static void Start(this MentorLake.GLib.GTimerHandle timer)
	{
		GTimerExterns.g_timer_start(timer);
	}

	public static void Stop(this MentorLake.GLib.GTimerHandle timer)
	{
		GTimerExterns.g_timer_stop(timer);
	}


	public static GTimer Dereference(this GTimerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimer>(x.DangerousGetHandle());
}
internal class GTimerExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_timer_continue([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_timer_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_timer_elapsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer, ulong microseconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_timer_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_timer_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_timer_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_timer_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))] MentorLake.GLib.GTimerHandle timer);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTimerHandle g_timer_new();

}

public struct GTimer
{
	public static MentorLake.GLib.GTimerHandle New()
	{
		return GTimerExterns.g_timer_new();
	}

}
