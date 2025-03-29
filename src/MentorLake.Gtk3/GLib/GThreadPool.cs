namespace MentorLake.GLib;

public class GThreadPoolHandle : BaseSafeHandle
{
}


public static class GThreadPoolExtensions
{
	public static void Free(this MentorLake.GLib.GThreadPoolHandle pool, bool immediate, bool wait_)
	{
		GThreadPoolExterns.g_thread_pool_free(pool, immediate, wait_);
	}

	public static int GetMaxThreads(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_max_threads(pool);
	}

	public static uint GetNumThreads(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_get_num_threads(pool);
	}

	public static bool MoveToFront(this MentorLake.GLib.GThreadPoolHandle pool, IntPtr data)
	{
		return GThreadPoolExterns.g_thread_pool_move_to_front(pool, data);
	}

	public static bool Push(this MentorLake.GLib.GThreadPoolHandle pool, IntPtr data, IntPtr error)
	{
		return GThreadPoolExterns.g_thread_pool_push(pool, data, error);
	}

	public static bool SetMaxThreads(this MentorLake.GLib.GThreadPoolHandle pool, int max_threads, IntPtr error)
	{
		return GThreadPoolExterns.g_thread_pool_set_max_threads(pool, max_threads, error);
	}

	public static void SetSortFunction(this MentorLake.GLib.GThreadPoolHandle pool, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		GThreadPoolExterns.g_thread_pool_set_sort_function(pool, func, user_data);
	}

	public static uint Unprocessed(this MentorLake.GLib.GThreadPoolHandle pool)
	{
		return GThreadPoolExterns.g_thread_pool_unprocessed(pool);
	}


	public static GThreadPool Dereference(this GThreadPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadPool>(x.DangerousGetHandle());
}
internal class GThreadPoolExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, bool immediate, bool wait_);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_move_to_front([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, IntPtr data, IntPtr error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_pool_set_max_threads([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, int max_threads, IntPtr error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_sort_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_unprocessed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadPoolHandle>))] MentorLake.GLib.GThreadPoolHandle pool);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadPoolHandle g_thread_pool_new(MentorLake.GLib.GFunc func, IntPtr user_data, int max_threads, bool exclusive, IntPtr error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadPoolHandle g_thread_pool_new_full(MentorLake.GLib.GFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify item_free_func, int max_threads, bool exclusive, IntPtr error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_stop_unused_threads();

}

public struct GThreadPool
{
	public GFunc func;
	public IntPtr user_data;
	public bool exclusive;
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

	public static MentorLake.GLib.GThreadPoolHandle New(MentorLake.GLib.GFunc func, IntPtr user_data, int max_threads, bool exclusive, IntPtr error)
	{
		return GThreadPoolExterns.g_thread_pool_new(func, user_data, max_threads, exclusive, error);
	}

	public static MentorLake.GLib.GThreadPoolHandle NewFull(MentorLake.GLib.GFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify item_free_func, int max_threads, bool exclusive, IntPtr error)
	{
		return GThreadPoolExterns.g_thread_pool_new_full(func, user_data, item_free_func, max_threads, exclusive, error);
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
