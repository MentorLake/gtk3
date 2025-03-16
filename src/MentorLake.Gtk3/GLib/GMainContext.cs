namespace MentorLake.GLib;

public class GMainContextHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

	public static MentorLake.GLib.GMainContextHandle NewWithFlags(MentorLake.GLib.GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}

}


public static class GMainContextExtensions
{
	public static bool Acquire(this MentorLake.GLib.GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_acquire(context);
	}

	public static void AddPoll(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFDHandle fd, int priority)
	{
		GMainContextExterns.g_main_context_add_poll(context, fd, priority);
	}

	public static bool Check(this MentorLake.GLib.GMainContextHandle context, int max_priority, MentorLake.GLib.GPollFD[] fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_check(context, max_priority, fds, n_fds);
	}

	public static void Dispatch(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_dispatch(context);
	}

	public static MentorLake.GLib.GSourceHandle FindSourceByFuncsUserData(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_funcs_user_data(context, funcs, user_data);
	}

	public static MentorLake.GLib.GSourceHandle FindSourceById(this MentorLake.GLib.GMainContextHandle context, uint source_id)
	{
		return GMainContextExterns.g_main_context_find_source_by_id(context, source_id);
	}

	public static MentorLake.GLib.GSourceHandle FindSourceByUserData(this MentorLake.GLib.GMainContextHandle context, IntPtr user_data)
	{
		return GMainContextExterns.g_main_context_find_source_by_user_data(context, user_data);
	}

	public static MentorLake.GLib.GPollFunc GetPollFunc(this MentorLake.GLib.GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_get_poll_func(context);
	}

	public static void Invoke(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		GMainContextExterns.g_main_context_invoke(context, function, data);
	}

	public static void InvokeFull(this MentorLake.GLib.GMainContextHandle context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GMainContextExterns.g_main_context_invoke_full(context, priority, function, data, notify);
	}

	public static bool IsOwner(this MentorLake.GLib.GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_is_owner(context);
	}

	public static bool Iteration(this MentorLake.GLib.GMainContextHandle context, bool may_block)
	{
		return GMainContextExterns.g_main_context_iteration(context, may_block);
	}

	public static bool Pending(this MentorLake.GLib.GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_pending(context);
	}

	public static void PopThreadDefault(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_pop_thread_default(context);
	}

	public static bool Prepare(this MentorLake.GLib.GMainContextHandle context, out int priority)
	{
		return GMainContextExterns.g_main_context_prepare(context, out priority);
	}

	public static void PushThreadDefault(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_push_thread_default(context);
	}

	public static MentorLake.GLib.GMainContextPusherHandle PusherNew(this MentorLake.GLib.GMainContextHandle main_context)
	{
		return GMainContextExterns.g_main_context_pusher_new(main_context);
	}

	public static int Query(this MentorLake.GLib.GMainContextHandle context, int max_priority, out int timeout_, out MentorLake.GLib.GPollFD[] fds, int n_fds)
	{
		return GMainContextExterns.g_main_context_query(context, max_priority, out timeout_, out fds, n_fds);
	}

	public static MentorLake.GLib.GMainContextHandle Ref(this MentorLake.GLib.GMainContextHandle context)
	{
		return GMainContextExterns.g_main_context_ref(context);
	}

	public static void Release(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_release(context);
	}

	public static void RemovePoll(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFDHandle fd)
	{
		GMainContextExterns.g_main_context_remove_poll(context, fd);
	}

	public static void SetPollFunc(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFunc func)
	{
		GMainContextExterns.g_main_context_set_poll_func(context, func);
	}

	public static void Unref(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_unref(context);
	}

	public static bool Wait(this MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GCondHandle cond, MentorLake.GLib.GMutexHandle mutex)
	{
		return GMainContextExterns.g_main_context_wait(context, cond, mutex);
	}

	public static void Wakeup(this MentorLake.GLib.GMainContextHandle context)
	{
		GMainContextExterns.g_main_context_wakeup(context);
	}


	public static GMainContext Dereference(this GMainContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMainContext>(x.DangerousGetHandle());
}
internal class GMainContextExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_new_with_flags(MentorLake.GLib.GMainContextFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_acquire([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_add_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd, int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int max_priority, MentorLake.GLib.GPollFD[] fds, int n_fds);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_dispatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, uint source_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_main_context_find_source_by_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPollFunc g_main_context_get_poll_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_invoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_invoke_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_is_owner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_iteration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, bool may_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_pending([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_pop_thread_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, out int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_push_thread_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextPusherHandle g_main_context_pusher_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle main_context);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_main_context_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, int max_priority, out int timeout_, out MentorLake.GLib.GPollFD[] fds, int n_fds);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_remove_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_set_poll_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, MentorLake.GLib.GPollFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_main_context_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))] MentorLake.GLib.GCondHandle cond, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_wakeup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_get_thread_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_main_context_pusher_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextPusherHandle>))] MentorLake.GLib.GMainContextPusherHandle pusher);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref_thread_default();

}

public struct GMainContext
{
	public static MentorLake.GLib.GMainContextHandle Default()
	{
		return GMainContextExterns.g_main_context_default();
	}

	public static MentorLake.GLib.GMainContextHandle GetThreadDefault()
	{
		return GMainContextExterns.g_main_context_get_thread_default();
	}

	public static void PusherFree(MentorLake.GLib.GMainContextPusherHandle pusher)
	{
		GMainContextExterns.g_main_context_pusher_free(pusher);
	}

	public static MentorLake.GLib.GMainContextHandle RefThreadDefault()
	{
		return GMainContextExterns.g_main_context_ref_thread_default();
	}

}
