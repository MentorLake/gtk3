namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Opaque class for defining and scheduling IO jobs.
/// </para>
/// </summary>

public class GIOSchedulerJobHandle : BaseSafeHandle
{
}


public static class GIOSchedulerJobExtensions
{
/// <summary>
/// <para>
/// Used from an I/O job to send a callback to be run in the thread
/// that the job was started from, waiting for the result (and thus
/// blocking the I/O job).
/// </para>
/// </summary>

/// <param name="job">
/// a #GIOSchedulerJob
/// </param>
/// <param name="func">
/// a #GSourceFunc callback that will be called in the original thread
/// </param>
/// <param name="user_data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// a #GDestroyNotify for @user_data, or %NULL
/// </param>
/// <return>
/// The return value of @func
/// </return>

	public static bool SendToMainloop(this MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (job.IsInvalid) throw new Exception("Invalid handle (GIOSchedulerJob)");
		return GIOSchedulerJobExterns.g_io_scheduler_job_send_to_mainloop(job, func, user_data, notify);
	}

/// <summary>
/// <para>
/// Used from an I/O job to send a callback to be run asynchronously in
/// the thread that the job was started from. The callback will be run
/// when the main loop is available, but at that time the I/O job might
/// have finished. The return value from the callback is ignored.
/// </para>
/// <para>
/// Note that if you are passing the @user_data from g_io_scheduler_push_job()
/// on to this function you have to ensure that it is not freed before
/// @func is called, either by passing %NULL as @notify to
/// g_io_scheduler_push_job() or by using refcounting for @user_data.
/// </para>
/// </summary>

/// <param name="job">
/// a #GIOSchedulerJob
/// </param>
/// <param name="func">
/// a #GSourceFunc callback that will be called in the original thread
/// </param>
/// <param name="user_data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// a #GDestroyNotify for @user_data, or %NULL
/// </param>

	public static void SendToMainloopAsync(this MentorLake.Gio.GIOSchedulerJobHandle job, MentorLake.GLib.GSourceFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (job.IsInvalid) throw new Exception("Invalid handle (GIOSchedulerJob)");
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

/// <summary>
/// <para>
/// Opaque class for defining and scheduling IO jobs.
/// </para>
/// </summary>

public struct GIOSchedulerJob
{
}
