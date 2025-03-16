namespace MentorLake.Gio;

public class GIOSchedulerJobHandle : BaseSafeHandle
{
}


public static class GIOSchedulerJobExtensions
{
	public static bool SendToMainloop(this MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GIOSchedulerJobExterns.g_io_scheduler_job_send_to_mainloop(job, func, user_data, notify);
	}

	public static void SendToMainloopAsync(this MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		GIOSchedulerJobExterns.g_io_scheduler_job_send_to_mainloop_async(job, func, user_data, notify);
	}


	public static GIOSchedulerJob Dereference(this GIOSchedulerJobHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOSchedulerJob>(x.DangerousGetHandle());
}
internal class GIOSchedulerJobExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_io_scheduler_job_send_to_mainloop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOSchedulerJobHandle>))] MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_scheduler_job_send_to_mainloop_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOSchedulerJobHandle>))] MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

}

public struct GIOSchedulerJob
{
}
