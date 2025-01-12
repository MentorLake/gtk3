namespace MentorLake.Gtk3.GLib;

public class GSourceHandle : BaseSafeHandle
{
	public static GSourceHandle New(GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

}


public static class GSourceHandleExtensions
{
	public static T AddChildSource<T>(this T source, GSourceHandle child_source) where T : GSourceHandle
	{
		GSourceExterns.g_source_add_child_source(source, child_source);
		return source;
	}

	public static T AddPoll<T>(this T source, GPollFDHandle fd) where T : GSourceHandle
	{
		GSourceExterns.g_source_add_poll(source, fd);
		return source;
	}

	public static IntPtr AddUnixFd(this GSourceHandle source, int fd, GIOCondition events)
	{
		return GSourceExterns.g_source_add_unix_fd(source, fd, events);
	}

	public static uint Attach(this GSourceHandle source, GMainContextHandle context)
	{
		return GSourceExterns.g_source_attach(source, context);
	}

	public static T Destroy<T>(this T source) where T : GSourceHandle
	{
		GSourceExterns.g_source_destroy(source);
		return source;
	}

	public static bool GetCanRecurse(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_can_recurse(source);
	}

	public static GMainContextHandle GetContext(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_context(source);
	}

	public static T GetCurrentTime<T>(this T source, GTimeValHandle timeval) where T : GSourceHandle
	{
		GSourceExterns.g_source_get_current_time(source, timeval);
		return source;
	}

	public static uint GetId(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_id(source);
	}

	public static string GetName(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_name(source);
	}

	public static int GetPriority(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_priority(source);
	}

	public static long GetReadyTime(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_ready_time(source);
	}

	public static long GetTime(this GSourceHandle source)
	{
		return GSourceExterns.g_source_get_time(source);
	}

	public static bool IsDestroyed(this GSourceHandle source)
	{
		return GSourceExterns.g_source_is_destroyed(source);
	}

	public static T ModifyUnixFd<T>(this T source, IntPtr tag, GIOCondition new_events) where T : GSourceHandle
	{
		GSourceExterns.g_source_modify_unix_fd(source, tag, new_events);
		return source;
	}

	public static GIOCondition QueryUnixFd(this GSourceHandle source, IntPtr tag)
	{
		return GSourceExterns.g_source_query_unix_fd(source, tag);
	}

	public static GSourceHandle Ref(this GSourceHandle source)
	{
		return GSourceExterns.g_source_ref(source);
	}

	public static T RemoveChildSource<T>(this T source, GSourceHandle child_source) where T : GSourceHandle
	{
		GSourceExterns.g_source_remove_child_source(source, child_source);
		return source;
	}

	public static T RemovePoll<T>(this T source, GPollFDHandle fd) where T : GSourceHandle
	{
		GSourceExterns.g_source_remove_poll(source, fd);
		return source;
	}

	public static T RemoveUnixFd<T>(this T source, IntPtr tag) where T : GSourceHandle
	{
		GSourceExterns.g_source_remove_unix_fd(source, tag);
		return source;
	}

	public static T SetCallback<T>(this T source, GSourceFunc func, IntPtr data, GDestroyNotify notify) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_callback(source, func, data, notify);
		return source;
	}

	public static T SetCallbackIndirect<T>(this T source, IntPtr callback_data, GSourceCallbackFuncsHandle callback_funcs) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_callback_indirect(source, callback_data, callback_funcs);
		return source;
	}

	public static T SetCanRecurse<T>(this T source, bool can_recurse) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_can_recurse(source, can_recurse);
		return source;
	}

	public static T SetDisposeFunction<T>(this T source, GSourceDisposeFunc dispose) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_dispose_function(source, dispose);
		return source;
	}

	public static T SetFuncs<T>(this T source, GSourceFuncsHandle funcs) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_funcs(source, funcs);
		return source;
	}

	public static T SetName<T>(this T source, string name) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_name(source, name);
		return source;
	}

	public static T SetPriority<T>(this T source, int priority) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_priority(source, priority);
		return source;
	}

	public static T SetReadyTime<T>(this T source, long ready_time) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_ready_time(source, ready_time);
		return source;
	}

	public static T SetStaticName<T>(this T source, string name) where T : GSourceHandle
	{
		GSourceExterns.g_source_set_static_name(source, name);
		return source;
	}

	public static T Unref<T>(this T source) where T : GSourceHandle
	{
		GSourceExterns.g_source_unref(source);
		return source;
	}

	public static bool Remove(uint tag)
	{
		return GSourceExterns.g_source_remove(tag);
	}

	public static bool RemoveByFuncsUserData(GSourceFuncsHandle funcs, IntPtr user_data)
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
internal class GSourceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_source_new(GSourceFuncsHandle source_funcs, uint struct_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_add_child_source(GSourceHandle source, GSourceHandle child_source);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_add_poll(GSourceHandle source, GPollFDHandle fd);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_source_add_unix_fd(GSourceHandle source, int fd, GIOCondition events);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_source_attach(GSourceHandle source, GMainContextHandle context);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_destroy(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_source_get_can_recurse(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_source_get_context(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_get_current_time(GSourceHandle source, GTimeValHandle timeval);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_source_get_id(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern string g_source_get_name(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern int g_source_get_priority(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern long g_source_get_ready_time(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern long g_source_get_time(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_source_is_destroyed(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_modify_unix_fd(GSourceHandle source, IntPtr tag, GIOCondition new_events);

	[DllImport(Libraries.GLib)]
	internal static extern GIOCondition g_source_query_unix_fd(GSourceHandle source, IntPtr tag);

	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_source_ref(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_remove_child_source(GSourceHandle source, GSourceHandle child_source);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_remove_poll(GSourceHandle source, GPollFDHandle fd);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_remove_unix_fd(GSourceHandle source, IntPtr tag);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_callback(GSourceHandle source, GSourceFunc func, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_callback_indirect(GSourceHandle source, IntPtr callback_data, GSourceCallbackFuncsHandle callback_funcs);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_can_recurse(GSourceHandle source, bool can_recurse);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_dispose_function(GSourceHandle source, GSourceDisposeFunc dispose);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_funcs(GSourceHandle source, GSourceFuncsHandle funcs);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_name(GSourceHandle source, string name);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_priority(GSourceHandle source, int priority);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_ready_time(GSourceHandle source, long ready_time);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_static_name(GSourceHandle source, string name);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_unref(GSourceHandle source);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_source_remove(uint tag);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_source_remove_by_funcs_user_data(GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_source_set_name_by_id(uint tag, string name);

}

public struct GSource
{
}
