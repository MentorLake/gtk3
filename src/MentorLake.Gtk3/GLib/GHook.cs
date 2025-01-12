namespace MentorLake.Gtk3.GLib;

public class GHookHandle : BaseSafeHandle
{
}


public static class GHookHandleExtensions
{
	public static int CompareIds(this GHookHandle new_hook, GHookHandle sibling)
	{
		return GHookExterns.g_hook_compare_ids(new_hook, sibling);
	}

	public static GHookHandle Alloc(GHookListHandle hook_list)
	{
		return GHookExterns.g_hook_alloc(hook_list);
	}

	public static bool Destroy(GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_destroy(hook_list, hook_id);
	}

	public static void DestroyLink(GHookListHandle hook_list, GHookHandle hook)
	{
		GHookExterns.g_hook_destroy_link(hook_list, hook);
	}

	public static GHookHandle Find(GHookListHandle hook_list, bool need_valids, GHookFindFunc func, IntPtr data)
	{
		return GHookExterns.g_hook_find(hook_list, need_valids, func, data);
	}

	public static GHookHandle FindData(GHookListHandle hook_list, bool need_valids, IntPtr data)
	{
		return GHookExterns.g_hook_find_data(hook_list, need_valids, data);
	}

	public static GHookHandle FindFunc(GHookListHandle hook_list, bool need_valids, IntPtr func)
	{
		return GHookExterns.g_hook_find_func(hook_list, need_valids, func);
	}

	public static GHookHandle FindFuncData(GHookListHandle hook_list, bool need_valids, IntPtr func, IntPtr data)
	{
		return GHookExterns.g_hook_find_func_data(hook_list, need_valids, func, data);
	}

	public static GHookHandle FirstValid(GHookListHandle hook_list, bool may_be_in_call)
	{
		return GHookExterns.g_hook_first_valid(hook_list, may_be_in_call);
	}

	public static void Free(GHookListHandle hook_list, GHookHandle hook)
	{
		GHookExterns.g_hook_free(hook_list, hook);
	}

	public static GHookHandle Get(GHookListHandle hook_list, ulong hook_id)
	{
		return GHookExterns.g_hook_get(hook_list, hook_id);
	}

	public static void InsertBefore(GHookListHandle hook_list, GHookHandle sibling, GHookHandle hook)
	{
		GHookExterns.g_hook_insert_before(hook_list, sibling, hook);
	}

	public static void InsertSorted(GHookListHandle hook_list, GHookHandle hook, GHookCompareFunc func)
	{
		GHookExterns.g_hook_insert_sorted(hook_list, hook, func);
	}

	public static GHookHandle NextValid(GHookListHandle hook_list, GHookHandle hook, bool may_be_in_call)
	{
		return GHookExterns.g_hook_next_valid(hook_list, hook, may_be_in_call);
	}

	public static void Prepend(GHookListHandle hook_list, GHookHandle hook)
	{
		GHookExterns.g_hook_prepend(hook_list, hook);
	}

	public static GHookHandle Ref(GHookListHandle hook_list, GHookHandle hook)
	{
		return GHookExterns.g_hook_ref(hook_list, hook);
	}

	public static void Unref(GHookListHandle hook_list, GHookHandle hook)
	{
		GHookExterns.g_hook_unref(hook_list, hook);
	}

}
internal class GHookExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_hook_compare_ids(GHookHandle new_hook, GHookHandle sibling);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_alloc(GHookListHandle hook_list);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hook_destroy(GHookListHandle hook_list, ulong hook_id);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_destroy_link(GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_find(GHookListHandle hook_list, bool need_valids, GHookFindFunc func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_find_data(GHookListHandle hook_list, bool need_valids, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_find_func(GHookListHandle hook_list, bool need_valids, IntPtr func);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_find_func_data(GHookListHandle hook_list, bool need_valids, IntPtr func, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_first_valid(GHookListHandle hook_list, bool may_be_in_call);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_free(GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_get(GHookListHandle hook_list, ulong hook_id);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_insert_before(GHookListHandle hook_list, GHookHandle sibling, GHookHandle hook);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_insert_sorted(GHookListHandle hook_list, GHookHandle hook, GHookCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_next_valid(GHookListHandle hook_list, GHookHandle hook, bool may_be_in_call);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_prepend(GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib)]
	internal static extern GHookHandle g_hook_ref(GHookListHandle hook_list, GHookHandle hook);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hook_unref(GHookListHandle hook_list, GHookHandle hook);

}

public struct GHook
{
	public IntPtr data;
	public GHookHandle next;
	public GHookHandle prev;
	public uint ref_count;
	public ulong hook_id;
	public uint flags;
	public IntPtr func;
	public GDestroyNotify destroy;
}
