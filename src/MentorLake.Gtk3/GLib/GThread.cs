namespace MentorLake.GLib;

public class GThreadHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GThreadHandle New(string name, MentorLake.GLib.GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_new(name, func, data);
	}

	public static MentorLake.GLib.GThreadHandle TryNew(string name, MentorLake.GLib.GThreadFunc func, IntPtr data)
	{
		return GThreadExterns.g_thread_try_new(name, func, data);
	}

}


public static class GThreadExtensions
{
	public static string GetName(this MentorLake.GLib.GThreadHandle thread)
	{
		return GThreadExterns.g_thread_get_name(thread);
	}

	public static IntPtr Join(this MentorLake.GLib.GThreadHandle thread)
	{
		return GThreadExterns.g_thread_join(thread);
	}

	public static MentorLake.GLib.GThreadHandle Ref(this MentorLake.GLib.GThreadHandle thread)
	{
		return GThreadExterns.g_thread_ref(thread);
	}

	public static void SetPriority(this MentorLake.GLib.GThreadHandle thread, MentorLake.GLib.GThreadPriority priority)
	{
		GThreadExterns.g_thread_set_priority(thread, priority);
	}

	public static void Unref(this MentorLake.GLib.GThreadHandle thread)
	{
		GThreadExterns.g_thread_unref(thread);
	}


	public static GThread Dereference(this GThreadHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThread>(x.DangerousGetHandle());
}
internal class GThreadExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_new(string name, MentorLake.GLib.GThreadFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_try_new(string name, MentorLake.GLib.GThreadFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_thread_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_thread_join([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread, MentorLake.GLib.GThreadPriority priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))] MentorLake.GLib.GThreadHandle thread);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create_full(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_thread_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_exit(IntPtr retval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_get_initialized();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_self();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_yield();

}

public struct GThread
{
	public static MentorLake.GLib.GThreadHandle Create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable)
	{
		return GThreadExterns.g_thread_create(func, data, joinable);
	}

	public static MentorLake.GLib.GThreadHandle CreateFull(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority)
	{
		return GThreadExterns.g_thread_create_full(func, data, stack_size, joinable, bound, priority);
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GThreadExterns.g_thread_error_quark();
	}

	public static void Exit(IntPtr retval)
	{
		GThreadExterns.g_thread_exit(retval);
	}

	public static void Foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data)
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

	public static MentorLake.GLib.GThreadHandle Self()
	{
		return GThreadExterns.g_thread_self();
	}

	public static void Yield()
	{
		GThreadExterns.g_thread_yield();
	}

}
