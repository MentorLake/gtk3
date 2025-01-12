namespace MentorLake.Gtk3.GLib;

public class GThreadPoolHandle : BaseSafeHandle
{
}


public static class GThreadPoolHandleExtensions
{
	public static T Free<T>(this T pool, bool immediate, bool wait_) where T : GThreadPoolHandle
	{
		GThreadPoolExterns.g_thread_pool_free(pool, immediate, wait_);
		return pool;
	}

	public static int GetMaxThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_max_threads(pool);
	}

	public static uint GetNumThreads(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_num_threads(pool);
	}

	public static bool MoveToFront(this GThreadPoolHandle pool, IntPtr data)
	{
		return GThreadPoolExterns.g_thread_pool_move_to_front(pool, data);
	}

	public static bool Push(this GThreadPoolHandle pool, IntPtr data, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_push(pool, data, out error);
	}

	public static bool SetMaxThreads(this GThreadPoolHandle pool, int max_threads, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_set_max_threads(pool, max_threads, out error);
	}

	public static T SetSortFunction<T>(this T pool, GCompareDataFunc func, IntPtr user_data) where T : GThreadPoolHandle
	{
		GThreadPoolExterns.g_thread_pool_set_sort_function(pool, func, user_data);
		return pool;
	}

	public static uint Unprocessed(this GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_unprocessed(pool);
	}

	public static uint GetMaxIdleTime()
	{
		return GThreadPoolExterns.g_thread_pool_get_max_idle_time();
	}

	public static int GetMaxUnusedThreads()
	{
		return GThreadPoolExterns.g_thread_pool_get_max_unused_threads();
	}

	public static uint GetNumUnusedThreads()
	{
		return GThreadPoolExterns.g_thread_pool_get_num_unused_threads();
	}

	public static GThreadPoolHandle New(GFunc func, IntPtr user_data, int max_threads, bool exclusive, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_new(func, user_data, max_threads, exclusive, out error);
	}

	public static GThreadPoolHandle NewFull(GFunc func, IntPtr user_data, GDestroyNotify item_free_func, int max_threads, bool exclusive, out GErrorHandle error)
	{
		return GThreadPoolExterns.g_thread_pool_new_full(func, user_data, item_free_func, max_threads, exclusive, out error);
	}

	public static void SetMaxIdleTime(uint interval)
	{
		GThreadPoolExterns.g_thread_pool_set_max_idle_time(interval);
	}

	public static void SetMaxUnusedThreads(int max_threads)
	{
		GThreadPoolExterns.g_thread_pool_set_max_unused_threads(max_threads);
	}

	public static void StopUnusedThreads()
	{
		GThreadPoolExterns.g_thread_pool_stop_unused_threads();
	}

}
internal class GThreadPoolExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_free(GThreadPoolHandle pool, bool immediate, bool wait_);

	[DllImport(Libraries.GLib)]
	internal static extern int g_thread_pool_get_max_threads(GThreadPoolHandle pool);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_get_num_threads(GThreadPoolHandle pool);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_move_to_front(GThreadPoolHandle pool, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_push(GThreadPoolHandle pool, IntPtr data, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_pool_set_max_threads(GThreadPoolHandle pool, int max_threads, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_set_sort_function(GThreadPoolHandle pool, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_unprocessed(GThreadPoolHandle pool);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(Libraries.GLib)]
	internal static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(Libraries.GLib)]
	internal static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(Libraries.GLib)]
	internal static extern GThreadPoolHandle g_thread_pool_new(GFunc func, IntPtr user_data, int max_threads, bool exclusive, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadPoolHandle g_thread_pool_new_full(GFunc func, IntPtr user_data, GDestroyNotify item_free_func, int max_threads, bool exclusive, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_pool_stop_unused_threads();

}

public struct GThreadPool
{
	public GFunc func;
	public IntPtr user_data;
	public bool exclusive;
}
