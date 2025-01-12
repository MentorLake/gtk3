namespace MentorLake.Gtk3.GLib;

public class GMainLoopHandle : BaseSafeHandle
{
	public static GMainLoopHandle New(GMainContextHandle context, bool is_running)
	{
		return GMainLoopExterns.g_main_loop_new(context, is_running);
	}

}


public static class GMainLoopHandleExtensions
{
	public static GMainContextHandle GetContext(this GMainLoopHandle loop)
	{
		return GMainLoopExterns.g_main_loop_get_context(loop);
	}

	public static bool IsRunning(this GMainLoopHandle loop)
	{
		return GMainLoopExterns.g_main_loop_is_running(loop);
	}

	public static T Quit<T>(this T loop) where T : GMainLoopHandle
	{
		GMainLoopExterns.g_main_loop_quit(loop);
		return loop;
	}

	public static GMainLoopHandle Ref(this GMainLoopHandle loop)
	{
		return GMainLoopExterns.g_main_loop_ref(loop);
	}

	public static T Run<T>(this T loop) where T : GMainLoopHandle
	{
		GMainLoopExterns.g_main_loop_run(loop);
		return loop;
	}

	public static T Unref<T>(this T loop) where T : GMainLoopHandle
	{
		GMainLoopExterns.g_main_loop_unref(loop);
		return loop;
	}

}
internal class GMainLoopExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainLoopHandle g_main_loop_new(GMainContextHandle context, bool is_running);

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_loop_get_context(GMainLoopHandle loop);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_main_loop_is_running(GMainLoopHandle loop);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_loop_quit(GMainLoopHandle loop);

	[DllImport(Libraries.GLib)]
	internal static extern GMainLoopHandle g_main_loop_ref(GMainLoopHandle loop);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_loop_run(GMainLoopHandle loop);

	[DllImport(Libraries.GLib)]
	internal static extern void g_main_loop_unref(GMainLoopHandle loop);

}

public struct GMainLoop
{
}
