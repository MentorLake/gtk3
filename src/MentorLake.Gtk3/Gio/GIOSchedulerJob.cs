namespace MentorLake.Gtk3.Gio;

public class GIOSchedulerJobHandle : BaseSafeHandle
{
}


public static class GIOSchedulerJobHandleExtensions
{
	public static bool GIoSchedulerJobSendToMainloop(this GIOSchedulerJobHandle job, GSourceFunc func, IntPtr user_data, GDestroyNotify notify)
	{
		return GIOSchedulerJobExterns.g_io_scheduler_job_send_to_mainloop(job, func, user_data, notify);
	}

	public static T GIoSchedulerJobSendToMainloopAsync<T>(this T job, GSourceFunc func, IntPtr user_data, GDestroyNotify notify) where T : GIOSchedulerJobHandle
	{
		GIOSchedulerJobExterns.g_io_scheduler_job_send_to_mainloop_async(job, func, user_data, notify);
		return job;
	}

}
internal class GIOSchedulerJobExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_io_scheduler_job_send_to_mainloop(GIOSchedulerJobHandle job, GSourceFunc func, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_scheduler_job_send_to_mainloop_async(GIOSchedulerJobHandle job, GSourceFunc func, IntPtr user_data, GDestroyNotify notify);

}

public struct GIOSchedulerJob
{
}
