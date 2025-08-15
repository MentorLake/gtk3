namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GTimer` records a start time, and counts microseconds elapsed since
/// that time.
/// </para>
/// <para>
/// This is done somewhat differently on different platforms, and can be
/// tricky to get exactly right, so `GTimer` provides a portable/convenient interface.
/// </para>
/// </summary>

public class GTimerHandle : BaseSafeHandle
{
}


public static class GTimerExtensions
{
/// <summary>
/// <para>
/// Resumes a timer that has previously been stopped with
/// g_timer_stop(). g_timer_stop() must be called before using this
/// function.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>

	public static void Continue(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		GTimerExterns.g_timer_continue(timer);
	}

/// <summary>
/// <para>
/// Destroys a timer, freeing associated resources.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer to destroy.
/// </param>

	public static void Destroy(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		GTimerExterns.g_timer_destroy(timer);
	}

/// <summary>
/// <para>
/// If @timer has been started but not stopped, obtains the time since
/// the timer was started. If @timer has been stopped, obtains the
/// elapsed time between the time it was started and the time it was
/// stopped. The return value is the number of seconds elapsed,
/// including any fractional part. The @microseconds out parameter is
/// essentially useless.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>
/// <param name="microseconds">
/// return location for the fractional part of seconds
///                elapsed, in microseconds (that is, the total number
///                of microseconds elapsed, modulo 1000000), or %NULL
/// </param>
/// <return>
/// seconds elapsed as a floating point value, including any
///          fractional part.
/// </return>

	public static double Elapsed(this MentorLake.GLib.GTimerHandle timer, ulong microseconds)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		return GTimerExterns.g_timer_elapsed(timer, microseconds);
	}

/// <summary>
/// <para>
/// Exposes whether the timer is currently active.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>
/// <return>
/// %TRUE if the timer is running, %FALSE otherwise
/// </return>

	public static bool IsActive(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		return GTimerExterns.g_timer_is_active(timer);
	}

/// <summary>
/// <para>
/// This function is useless; it&apos;s fine to call g_timer_start() on an
/// already-started timer to reset the start time, so g_timer_reset()
/// serves no purpose.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>

	public static void Reset(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		GTimerExterns.g_timer_reset(timer);
	}

/// <summary>
/// <para>
/// Marks a start time, so that future calls to g_timer_elapsed() will
/// report the time since g_timer_start() was called. g_timer_new()
/// automatically marks the start time, so no need to call
/// g_timer_start() immediately after creating the timer.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>

	public static void Start(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
		GTimerExterns.g_timer_start(timer);
	}

/// <summary>
/// <para>
/// Marks an end time, so calls to g_timer_elapsed() will return the
/// difference between this end time and the start time.
/// </para>
/// </summary>

/// <param name="timer">
/// a #GTimer.
/// </param>

	public static void Stop(this MentorLake.GLib.GTimerHandle timer)
	{
		if (timer.IsInvalid) throw new Exception("Invalid handle (GTimer)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimerHandle>))]
	internal static extern MentorLake.GLib.GTimerHandle g_timer_new();

}

/// <summary>
/// <para>
/// `GTimer` records a start time, and counts microseconds elapsed since
/// that time.
/// </para>
/// <para>
/// This is done somewhat differently on different platforms, and can be
/// tricky to get exactly right, so `GTimer` provides a portable/convenient interface.
/// </para>
/// </summary>

public struct GTimer
{
/// <summary>
/// <para>
/// Creates a new timer, and starts timing (i.e. g_timer_start() is
/// implicitly called for you).
/// </para>
/// </summary>

/// <return>
/// a new #GTimer.
/// </return>

	public static MentorLake.GLib.GTimerHandle New()
	{
		return GTimerExterns.g_timer_new();
	}

}
