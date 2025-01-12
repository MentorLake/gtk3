namespace MentorLake.Gtk3.GLib;

public class GListHandle : BaseSafeHandle
{
}


public static class GListHandleExtensions
{
	public static GListHandle Alloc()
	{
		return GListExterns.g_list_alloc();
	}

	public static GListHandle Append(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_append(list, data);
	}

	public static GListHandle Concat(this GListHandle list1, GListHandle list2)
	{
		return GListExterns.g_list_concat(list1, list2);
	}

	public static GListHandle Copy(this GListHandle list)
	{
		return GListExterns.g_list_copy(list);
	}

	public static GListHandle CopyDeep(this GListHandle list, GCopyFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_copy_deep(list, func, user_data);
	}

	public static GListHandle DeleteLink(this GListHandle list, GListHandle link_)
	{
		return GListExterns.g_list_delete_link(list, link_);
	}

	public static GListHandle Find(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_find(list, data);
	}

	public static GListHandle FindCustom(this GListHandle list, IntPtr data, GCompareFunc func)
	{
		return GListExterns.g_list_find_custom(list, data, func);
	}

	public static GListHandle First(this GListHandle list)
	{
		return GListExterns.g_list_first(list);
	}

	public static T Foreach<T>(this T list, GFunc func, IntPtr user_data) where T : GListHandle
	{
		GListExterns.g_list_foreach(list, func, user_data);
		return list;
	}

	public static T Free<T>(this T list) where T : GListHandle
	{
		GListExterns.g_list_free(list);
		return list;
	}

	public static T Free1<T>(this T list) where T : GListHandle
	{
		GListExterns.g_list_free_1(list);
		return list;
	}

	public static T FreeFull<T>(this T list, GDestroyNotify free_func) where T : GListHandle
	{
		GListExterns.g_list_free_full(list, free_func);
		return list;
	}

	public static int Index(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_index(list, data);
	}

	public static GListHandle Insert(this GListHandle list, IntPtr data, int position)
	{
		return GListExterns.g_list_insert(list, data, position);
	}

	public static GListHandle InsertBefore(this GListHandle list, GListHandle sibling, IntPtr data)
	{
		return GListExterns.g_list_insert_before(list, sibling, data);
	}

	public static GListHandle InsertBeforeLink(this GListHandle list, GListHandle sibling, GListHandle link_)
	{
		return GListExterns.g_list_insert_before_link(list, sibling, link_);
	}

	public static GListHandle InsertSorted(this GListHandle list, IntPtr data, GCompareFunc func)
	{
		return GListExterns.g_list_insert_sorted(list, data, func);
	}

	public static GListHandle InsertSortedWithData(this GListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_insert_sorted_with_data(list, data, func, user_data);
	}

	public static GListHandle Last(this GListHandle list)
	{
		return GListExterns.g_list_last(list);
	}

	public static uint Length(this GListHandle list)
	{
		return GListExterns.g_list_length(list);
	}

	public static GListHandle Nth(this GListHandle list, uint n)
	{
		return GListExterns.g_list_nth(list, n);
	}

	public static IntPtr NthData(this GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_data(list, n);
	}

	public static GListHandle NthPrev(this GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_prev(list, n);
	}

	public static void PopAllocator()
	{
		GListExterns.g_list_pop_allocator();
	}

	public static int Position(this GListHandle list, GListHandle llink)
	{
		return GListExterns.g_list_position(list, llink);
	}

	public static GListHandle Prepend(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_prepend(list, data);
	}

	public static void PushAllocator(GAllocatorHandle allocator)
	{
		GListExterns.g_list_push_allocator(allocator);
	}

	public static GListHandle Remove(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove(list, data);
	}

	public static GListHandle RemoveAll(this GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove_all(list, data);
	}

	public static GListHandle RemoveLink(this GListHandle list, GListHandle llink)
	{
		return GListExterns.g_list_remove_link(list, llink);
	}

	public static GListHandle Reverse(this GListHandle list)
	{
		return GListExterns.g_list_reverse(list);
	}

	public static GListHandle Sort(this GListHandle list, GCompareFunc compare_func)
	{
		return GListExterns.g_list_sort(list, compare_func);
	}

	public static GListHandle SortWithData(this GListHandle list, GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GListExterns.g_list_sort_with_data(list, compare_func, user_data);
	}

}
internal class GListExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_alloc();

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_append(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_concat(GListHandle list1, GListHandle list2);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_copy(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_copy_deep(GListHandle list, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_delete_link(GListHandle list, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_find(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_find_custom(GListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_first(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_foreach(GListHandle list, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_free(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_free_1(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_free_full(GListHandle list, GDestroyNotify free_func);

	[DllImport(Libraries.GLib)]
	internal static extern int g_list_index(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_insert(GListHandle list, IntPtr data, int position);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_insert_before(GListHandle list, GListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_insert_before_link(GListHandle list, GListHandle sibling, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_insert_sorted(GListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_insert_sorted_with_data(GListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_last(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_list_length(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_nth(GListHandle list, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_list_nth_data(GListHandle list, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_nth_prev(GListHandle list, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_pop_allocator();

	[DllImport(Libraries.GLib)]
	internal static extern int g_list_position(GListHandle list, GListHandle llink);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_prepend(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_list_push_allocator(GAllocatorHandle allocator);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_remove(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_remove_all(GListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_remove_link(GListHandle list, GListHandle llink);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_reverse(GListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_sort(GListHandle list, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_list_sort_with_data(GListHandle list, GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GList
{
	public IntPtr data;
	public GListHandle next;
	public GListHandle prev;
}
