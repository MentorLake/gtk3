namespace MentorLake.Gtk3.GLib;

public class GSListHandle : BaseSafeHandle
{
}


public static class GSListHandleExtensions
{
	public static GSListHandle GSlistAlloc()
	{
		return GSListExterns.g_slist_alloc();
	}

	public static GSListHandle GSlistAppend(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_append(list, data);
	}

	public static GSListHandle GSlistConcat(this GSListHandle list1, GSListHandle list2)
	{
		return GSListExterns.g_slist_concat(list1, list2);
	}

	public static GSListHandle GSlistCopy(this GSListHandle list)
	{
		return GSListExterns.g_slist_copy(list);
	}

	public static GSListHandle GSlistCopyDeep(this GSListHandle list, GCopyFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_copy_deep(list, func, user_data);
	}

	public static GSListHandle GSlistDeleteLink(this GSListHandle list, GSListHandle link_)
	{
		return GSListExterns.g_slist_delete_link(list, link_);
	}

	public static GSListHandle GSlistFind(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_find(list, data);
	}

	public static GSListHandle GSlistFindCustom(this GSListHandle list, IntPtr data, GCompareFunc func)
	{
		return GSListExterns.g_slist_find_custom(list, data, func);
	}

	public static T GSlistForeach<T>(this T list, GFunc func, IntPtr user_data) where T : GSListHandle
	{
		GSListExterns.g_slist_foreach(list, func, user_data);
		return list;
	}

	public static T GSlistFree<T>(this T list) where T : GSListHandle
	{
		GSListExterns.g_slist_free(list);
		return list;
	}

	public static T GSlistFree1<T>(this T list) where T : GSListHandle
	{
		GSListExterns.g_slist_free_1(list);
		return list;
	}

	public static T GSlistFreeFull<T>(this T list, GDestroyNotify free_func) where T : GSListHandle
	{
		GSListExterns.g_slist_free_full(list, free_func);
		return list;
	}

	public static int GSlistIndex(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_index(list, data);
	}

	public static GSListHandle GSlistInsert(this GSListHandle list, IntPtr data, int position)
	{
		return GSListExterns.g_slist_insert(list, data, position);
	}

	public static GSListHandle GSlistInsertBefore(this GSListHandle slist, GSListHandle sibling, IntPtr data)
	{
		return GSListExterns.g_slist_insert_before(slist, sibling, data);
	}

	public static GSListHandle GSlistInsertSorted(this GSListHandle list, IntPtr data, GCompareFunc func)
	{
		return GSListExterns.g_slist_insert_sorted(list, data, func);
	}

	public static GSListHandle GSlistInsertSortedWithData(this GSListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_insert_sorted_with_data(list, data, func, user_data);
	}

	public static GSListHandle GSlistLast(this GSListHandle list)
	{
		return GSListExterns.g_slist_last(list);
	}

	public static uint GSlistLength(this GSListHandle list)
	{
		return GSListExterns.g_slist_length(list);
	}

	public static GSListHandle GSlistNth(this GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth(list, n);
	}

	public static IntPtr GSlistNthData(this GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth_data(list, n);
	}

	public static void GSlistPopAllocator()
	{
		GSListExterns.g_slist_pop_allocator();
	}

	public static int GSlistPosition(this GSListHandle list, GSListHandle llink)
	{
		return GSListExterns.g_slist_position(list, llink);
	}

	public static GSListHandle GSlistPrepend(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_prepend(list, data);
	}

	public static void GSlistPushAllocator(GAllocatorHandle allocator)
	{
		GSListExterns.g_slist_push_allocator(allocator);
	}

	public static GSListHandle GSlistRemove(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove(list, data);
	}

	public static GSListHandle GSlistRemoveAll(this GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove_all(list, data);
	}

	public static GSListHandle GSlistRemoveLink(this GSListHandle list, GSListHandle link_)
	{
		return GSListExterns.g_slist_remove_link(list, link_);
	}

	public static GSListHandle GSlistReverse(this GSListHandle list)
	{
		return GSListExterns.g_slist_reverse(list);
	}

	public static GSListHandle GSlistSort(this GSListHandle list, GCompareFunc compare_func)
	{
		return GSListExterns.g_slist_sort(list, compare_func);
	}

	public static GSListHandle GSlistSortWithData(this GSListHandle list, GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GSListExterns.g_slist_sort_with_data(list, compare_func, user_data);
	}

}
internal class GSListExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_alloc();

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_append(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_concat(GSListHandle list1, GSListHandle list2);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_copy(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_copy_deep(GSListHandle list, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_delete_link(GSListHandle list, GSListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_find(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_find_custom(GSListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_foreach(GSListHandle list, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_free(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_free_1(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_free_full(GSListHandle list, GDestroyNotify free_func);

	[DllImport(Libraries.GLib)]
	internal static extern int g_slist_index(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_insert(GSListHandle list, IntPtr data, int position);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_insert_before(GSListHandle slist, GSListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_insert_sorted(GSListHandle list, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_insert_sorted_with_data(GSListHandle list, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_last(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_slist_length(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_nth(GSListHandle list, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_slist_nth_data(GSListHandle list, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_pop_allocator();

	[DllImport(Libraries.GLib)]
	internal static extern int g_slist_position(GSListHandle list, GSListHandle llink);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_prepend(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_slist_push_allocator(GAllocatorHandle allocator);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_remove(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_remove_all(GSListHandle list, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_remove_link(GSListHandle list, GSListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_reverse(GSListHandle list);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_sort(GSListHandle list, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern GSListHandle g_slist_sort_with_data(GSListHandle list, GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GSList
{
	public IntPtr data;
	public GSListHandle next;
}
