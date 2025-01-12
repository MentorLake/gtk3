namespace MentorLake.Gtk3.GLib;

public class GTimerHandle : BaseSafeHandle
{
}


public static class GTimerHandleExtensions
{
	public static T Continue<T>(this T timer) where T : GTimerHandle
	{
		GTimerExterns.g_timer_continue(timer);
		return timer;
	}

	public static T Destroy<T>(this T timer) where T : GTimerHandle
	{
		GTimerExterns.g_timer_destroy(timer);
		return timer;
	}

	public static double Elapsed(this GTimerHandle timer, out ulong microseconds)
	{
		return GTimerExterns.g_timer_elapsed(timer, out microseconds);
	}

	public static bool IsActive(this GTimerHandle timer)
	{
		return GTimerExterns.g_timer_is_active(timer);
	}

	public static T Reset<T>(this T timer) where T : GTimerHandle
	{
		GTimerExterns.g_timer_reset(timer);
		return timer;
	}

	public static T Start<T>(this T timer) where T : GTimerHandle
	{
		GTimerExterns.g_timer_start(timer);
		return timer;
	}

	public static T Stop<T>(this T timer) where T : GTimerHandle
	{
		GTimerExterns.g_timer_stop(timer);
		return timer;
	}

	public static GTimerHandle New()
	{
		return GTimerExterns.g_timer_new();
	}

}
internal class GTimerExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_continue(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_destroy(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern double g_timer_elapsed(GTimerHandle timer, out ulong microseconds);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_timer_is_active(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_reset(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_start(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_timer_stop(GTimerHandle timer);

	[DllImport(Libraries.GLib)]
	internal static extern GTimerHandle g_timer_new();

}

public struct GTimer
{
}
