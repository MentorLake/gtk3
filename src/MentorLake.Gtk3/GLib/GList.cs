namespace MentorLake.GLib;

public class GListHandle : BaseSafeHandle
{
}


public static class GListExtensions
{

	public static GList Dereference(this GListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GList>(x.DangerousGetHandle());
}
internal class GListExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_alloc();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_concat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_delete_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_find_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free_1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_list_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, int position);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_before_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_sorted_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_list_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_list_nth_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_nth_prev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_list_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle llink);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_remove_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle llink);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_list_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GList
{
	public IntPtr data;
	public IntPtr next;
	public IntPtr prev;
	public static MentorLake.GLib.GListHandle Alloc()
	{
		return GListExterns.g_list_alloc();
	}

	public static MentorLake.GLib.GListHandle Append(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_append(list, data);
	}

	public static MentorLake.GLib.GListHandle Concat(MentorLake.GLib.GListHandle list1, MentorLake.GLib.GListHandle list2)
	{
		return GListExterns.g_list_concat(list1, list2);
	}

	public static MentorLake.GLib.GListHandle Copy(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_copy(list);
	}

	public static MentorLake.GLib.GListHandle CopyDeep(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_copy_deep(list, func, user_data);
	}

	public static MentorLake.GLib.GListHandle DeleteLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle link_)
	{
		return GListExterns.g_list_delete_link(list, link_);
	}

	public static MentorLake.GLib.GListHandle Find(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_find(list, data);
	}

	public static MentorLake.GLib.GListHandle FindCustom(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GListExterns.g_list_find_custom(list, data, func);
	}

	public static MentorLake.GLib.GListHandle First(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_first(list);
	}

	public static void Foreach(MentorLake.GLib.GListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GListExterns.g_list_foreach(list, func, user_data);
	}

	public static void Free(MentorLake.GLib.GListHandle list)
	{
		GListExterns.g_list_free(list);
	}

	public static void Free1(MentorLake.GLib.GListHandle list)
	{
		GListExterns.g_list_free_1(list);
	}

	public static void FreeFull(MentorLake.GLib.GListHandle list, MentorLake.GLib.GDestroyNotify free_func)
	{
		GListExterns.g_list_free_full(list, free_func);
	}

	public static int Index(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_index(list, data);
	}

	public static MentorLake.GLib.GListHandle Insert(MentorLake.GLib.GListHandle list, IntPtr data, int position)
	{
		return GListExterns.g_list_insert(list, data, position);
	}

	public static MentorLake.GLib.GListHandle InsertBefore(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		return GListExterns.g_list_insert_before(list, sibling, data);
	}

	public static MentorLake.GLib.GListHandle InsertBeforeLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		return GListExterns.g_list_insert_before_link(list, sibling, link_);
	}

	public static MentorLake.GLib.GListHandle InsertSorted(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GListExterns.g_list_insert_sorted(list, data, func);
	}

	public static MentorLake.GLib.GListHandle InsertSortedWithData(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_insert_sorted_with_data(list, data, func, user_data);
	}

	public static MentorLake.GLib.GListHandle Last(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_last(list);
	}

	public static uint Length(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_length(list);
	}

	public static MentorLake.GLib.GListHandle Nth(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth(list, n);
	}

	public static IntPtr NthData(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_data(list, n);
	}

	public static MentorLake.GLib.GListHandle NthPrev(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_prev(list, n);
	}

	public static void PopAllocator()
	{
		GListExterns.g_list_pop_allocator();
	}

	public static int Position(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle llink)
	{
		return GListExterns.g_list_position(list, llink);
	}

	public static MentorLake.GLib.GListHandle Prepend(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_prepend(list, data);
	}

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GListExterns.g_list_push_allocator(allocator);
	}

	public static MentorLake.GLib.GListHandle Remove(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove(list, data);
	}

	public static MentorLake.GLib.GListHandle RemoveAll(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove_all(list, data);
	}

	public static MentorLake.GLib.GListHandle RemoveLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle llink)
	{
		return GListExterns.g_list_remove_link(list, llink);
	}

	public static MentorLake.GLib.GListHandle Reverse(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_reverse(list);
	}

	public static MentorLake.GLib.GListHandle Sort(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareFunc compare_func)
	{
		return GListExterns.g_list_sort(list, compare_func);
	}

	public static MentorLake.GLib.GListHandle SortWithData(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GListExterns.g_list_sort_with_data(list, compare_func, user_data);
	}

}
