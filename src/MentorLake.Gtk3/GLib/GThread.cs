namespace MentorLake.Gtk3.GLib;

public class GThreadHandle : BaseSafeHandle
{
	public static GThreadHandle New(string name, GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

	public static GThreadHandle TryNew(string name, GThreadFunc func, IntPtr data, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_try_new(name, func, data, out error);
	}

}


public static class GThreadHandleExtensions
{
	public static IntPtr Join(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_join(thread);
	}

	public static GThreadHandle Ref(this GThreadHandle thread)
	{
		return GThreadExterns.g_thread_ref(thread);
	}

	public static GThreadHandle SetPriority(this GThreadHandle thread, GThreadPriority priority)
	{
		GThreadExterns.g_thread_set_priority(thread, priority);
		return thread;
	}

	public static GThreadHandle Unref(this GThreadHandle thread)
	{
		GThreadExterns.g_thread_unref(thread);
		return thread;
	}

	public static GThreadHandle Create(GThreadFunc func, IntPtr data, bool joinable, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_create(func, data, joinable, out error);
	}

	public static GThreadHandle CreateFull(GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, GThreadPriority priority, out GErrorHandle error)
	{
		return GThreadExterns.g_thread_create_full(func, data, stack_size, joinable, bound, priority, out error);
	}

	public static GQuark ErrorQuark()
	{
		return GThreadExterns.g_thread_error_quark();
	}

	public static void Exit(IntPtr retval)
	{
		GThreadExterns.g_thread_exit(retval);
	}

	public static void Foreach(GFunc thread_func, IntPtr user_data)
	{
		GThreadExterns.g_thread_foreach(thread_func, user_data);
	}

	public static bool GetInitialized()
	{
		return GThreadExterns.g_thread_get_initialized();
	}

	public static void Init(IntPtr vtable)
	{
		GThreadExterns.g_thread_init(vtable);
	}

	public static void InitWithErrorcheckMutexes(IntPtr vtable)
	{
		GThreadExterns.g_thread_init_with_errorcheck_mutexes(vtable);
	}

	public static GThreadHandle Self()
	{
		return GThreadExterns.g_thread_self();
	}

	public static void Yield()
	{
		GThreadExterns.g_thread_yield();
	}

}
internal class GThreadExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_new(string name, GThreadFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_try_new(string name, GThreadFunc func, IntPtr data, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_thread_join(GThreadHandle thread);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_ref(GThreadHandle thread);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_set_priority(GThreadHandle thread, GThreadPriority priority);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_unref(GThreadHandle thread);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_create(GThreadFunc func, IntPtr data, bool joinable, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_create_full(GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, GThreadPriority priority, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern GQuark g_thread_error_quark();

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_exit(IntPtr retval);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_foreach(GFunc thread_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_thread_get_initialized();

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_init(IntPtr vtable);

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(Libraries.GLib)]
	internal static extern GThreadHandle g_thread_self();

	[DllImport(Libraries.GLib)]
	internal static extern void g_thread_yield();

}

public struct GThread
{
}
