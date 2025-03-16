namespace MentorLake.GLib;

public class GSourceHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GSourceHandle New(MentorLake.GLib.GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

}


public static class GSourceExtensions
{
	public static void AddChildSource(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceHandle child_source)
	{
		GSourceExterns.g_source_add_child_source(source, child_source);
	}

	public static void AddPoll(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GPollFDHandle fd)
	{
		GSourceExterns.g_source_add_poll(source, fd);
	}

	public static IntPtr AddUnixFd(this MentorLake.GLib.GSourceHandle source, int fd, MentorLake.GLib.GIOCondition events)
	{
		return GSourceExterns.g_source_add_unix_fd(source, fd, events);
	}

	public static uint Attach(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GMainContextHandle context)
	{
		return GSourceExterns.g_source_attach(source, context);
	}

	public static void Destroy(this MentorLake.GLib.GSourceHandle source)
	{
		GSourceExterns.g_source_destroy(source);
	}

	public static bool GetCanRecurse(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_can_recurse(source);
	}

	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_context(source);
	}

	public static void GetCurrentTime(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GTimeValHandle timeval)
	{
		GSourceExterns.g_source_get_current_time(source, timeval);
	}

	public static uint GetId(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_id(source);
	}

	public static string GetName(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_name(source);
	}

	public static int GetPriority(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_priority(source);
	}

	public static long GetReadyTime(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_ready_time(source);
	}

	public static long GetTime(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_get_time(source);
	}

	public static bool IsDestroyed(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_is_destroyed(source);
	}

	public static void ModifyUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag, MentorLake.GLib.GIOCondition new_events)
	{
		GSourceExterns.g_source_modify_unix_fd(source, tag, new_events);
	}

	public static MentorLake.GLib.GIOCondition QueryUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag)
	{
		return GSourceExterns.g_source_query_unix_fd(source, tag);
	}

	public static MentorLake.GLib.GSourceHandle Ref(this MentorLake.GLib.GSourceHandle source)
	{
		return GSourceExterns.g_source_ref(source);
	}

	public static void RemoveChildSource(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceHandle child_source)
	{
		GSourceExterns.g_source_remove_child_source(source, child_source);
	}

	public static void RemovePoll(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GPollFDHandle fd)
	{
		GSourceExterns.g_source_remove_poll(source, fd);
	}

	public static void RemoveUnixFd(this MentorLake.GLib.GSourceHandle source, IntPtr tag)
	{
		GSourceExterns.g_source_remove_unix_fd(source, tag);
	}

	public static void SetCallback(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GSourceExterns.g_source_set_callback(source, func, data, notify);
	}

	public static void SetCallbackIndirect(this MentorLake.GLib.GSourceHandle source, IntPtr callback_data, MentorLake.GLib.GSourceCallbackFuncsHandle callback_funcs)
	{
		GSourceExterns.g_source_set_callback_indirect(source, callback_data, callback_funcs);
	}

	public static void SetCanRecurse(this MentorLake.GLib.GSourceHandle source, bool can_recurse)
	{
		GSourceExterns.g_source_set_can_recurse(source, can_recurse);
	}

	public static void SetDisposeFunction(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceDisposeFunc dispose)
	{
		GSourceExterns.g_source_set_dispose_function(source, dispose);
	}

	public static void SetFuncs(this MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFuncsHandle funcs)
	{
		GSourceExterns.g_source_set_funcs(source, funcs);
	}

	public static void SetName(this MentorLake.GLib.GSourceHandle source, string name)
	{
		GSourceExterns.g_source_set_name(source, name);
	}

	public static void SetPriority(this MentorLake.GLib.GSourceHandle source, int priority)
	{
		GSourceExterns.g_source_set_priority(source, priority);
	}

	public static void SetReadyTime(this MentorLake.GLib.GSourceHandle source, long ready_time)
	{
		GSourceExterns.g_source_set_ready_time(source, ready_time);
	}

	public static void SetStaticName(this MentorLake.GLib.GSourceHandle source, string name)
	{
		GSourceExterns.g_source_set_static_name(source, name);
	}

	public static void Unref(this MentorLake.GLib.GSourceHandle source)
	{
		GSourceExterns.g_source_unref(source);
	}


	public static GSource Dereference(this GSourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSource>(x.DangerousGetHandle());
}
internal class GSourceExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle source_funcs, uint struct_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_add_child_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_add_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_source_add_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, int fd, MentorLake.GLib.GIOCondition events);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_source_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))] MentorLake.GLib.GMainContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_get_can_recurse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_source_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_get_current_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle timeval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_source_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_source_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_source_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_source_get_ready_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_source_get_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_is_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_modify_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag, MentorLake.GLib.GIOCondition new_events);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_source_query_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_source_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_child_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle child_source);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_remove_unix_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_callback_indirect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, IntPtr callback_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceCallbackFuncsHandle>))] MentorLake.GLib.GSourceCallbackFuncsHandle callback_funcs);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_can_recurse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, bool can_recurse);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_dispose_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceDisposeFunc dispose);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_funcs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, int priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_ready_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, long ready_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_static_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove(uint tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name_by_id(uint tag, string name);

}

public struct GSource
{
	public static bool Remove(uint tag)
	{
		return GSourceExterns.g_source_remove(tag);
	}

	public static bool RemoveByFuncsUserData(MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GSourceExterns.g_source_remove_by_funcs_user_data(funcs, user_data);
	}

	public static bool RemoveByUserData(IntPtr user_data)
	{
		return GSourceExterns.g_source_remove_by_user_data(user_data);
	}

	public static void SetNameById(uint tag, string name)
	{
		GSourceExterns.g_source_set_name_by_id(tag, name);
	}

}
