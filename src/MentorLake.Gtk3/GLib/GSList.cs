namespace MentorLake.GLib;

public class GSListHandle : BaseSafeHandle
{
}


public static class GSListExtensions
{

	public static GSList Dereference(this GSListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSList>(x.DangerousGetHandle());
}
internal class GSListExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_alloc();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_concat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_delete_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_find_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free_1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_slist_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, int position);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle slist, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_sorted_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_slist_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slist_nth_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_slist_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle llink);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

public struct GSList
{
	public IntPtr data;
	public IntPtr next;
	public static MentorLake.GLib.GSListHandle Alloc()
	{
		return GSListExterns.g_slist_alloc();
	}

	public static MentorLake.GLib.GSListHandle Append(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_append(list, data);
	}

	public static MentorLake.GLib.GSListHandle Concat(MentorLake.GLib.GSListHandle list1, MentorLake.GLib.GSListHandle list2)
	{
		return GSListExterns.g_slist_concat(list1, list2);
	}

	public static MentorLake.GLib.GSListHandle Copy(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_copy(list);
	}

	public static MentorLake.GLib.GSListHandle CopyDeep(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_copy_deep(list, func, user_data);
	}

	public static MentorLake.GLib.GSListHandle DeleteLink(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle link_)
	{
		return GSListExterns.g_slist_delete_link(list, link_);
	}

	public static MentorLake.GLib.GSListHandle Find(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_find(list, data);
	}

	public static MentorLake.GLib.GSListHandle FindCustom(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GSListExterns.g_slist_find_custom(list, data, func);
	}

	public static void Foreach(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GSListExterns.g_slist_foreach(list, func, user_data);
	}

	public static void Free(MentorLake.GLib.GSListHandle list)
	{
		GSListExterns.g_slist_free(list);
	}

	public static void Free1(MentorLake.GLib.GSListHandle list)
	{
		GSListExterns.g_slist_free_1(list);
	}

	public static void FreeFull(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GDestroyNotify free_func)
	{
		GSListExterns.g_slist_free_full(list, free_func);
	}

	public static int Index(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_index(list, data);
	}

	public static MentorLake.GLib.GSListHandle Insert(MentorLake.GLib.GSListHandle list, IntPtr data, int position)
	{
		return GSListExterns.g_slist_insert(list, data, position);
	}

	public static MentorLake.GLib.GSListHandle InsertBefore(MentorLake.GLib.GSListHandle slist, MentorLake.GLib.GSListHandle sibling, IntPtr data)
	{
		return GSListExterns.g_slist_insert_before(slist, sibling, data);
	}

	public static MentorLake.GLib.GSListHandle InsertSorted(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GSListExterns.g_slist_insert_sorted(list, data, func);
	}

	public static MentorLake.GLib.GSListHandle InsertSortedWithData(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_insert_sorted_with_data(list, data, func, user_data);
	}

	public static MentorLake.GLib.GSListHandle Last(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_last(list);
	}

	public static uint Length(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_length(list);
	}

	public static MentorLake.GLib.GSListHandle Nth(MentorLake.GLib.GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth(list, n);
	}

	public static IntPtr NthData(MentorLake.GLib.GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth_data(list, n);
	}

	public static void PopAllocator()
	{
		GSListExterns.g_slist_pop_allocator();
	}

	public static int Position(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle llink)
	{
		return GSListExterns.g_slist_position(list, llink);
	}

	public static MentorLake.GLib.GSListHandle Prepend(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_prepend(list, data);
	}

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GSListExterns.g_slist_push_allocator(allocator);
	}

	public static MentorLake.GLib.GSListHandle Remove(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove(list, data);
	}

	public static MentorLake.GLib.GSListHandle RemoveAll(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove_all(list, data);
	}

	public static MentorLake.GLib.GSListHandle RemoveLink(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle link_)
	{
		return GSListExterns.g_slist_remove_link(list, link_);
	}

	public static MentorLake.GLib.GSListHandle Reverse(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_reverse(list);
	}

	public static MentorLake.GLib.GSListHandle Sort(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareFunc compare_func)
	{
		return GSListExterns.g_slist_sort(list, compare_func);
	}

	public static MentorLake.GLib.GSListHandle SortWithData(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GSListExterns.g_slist_sort_with_data(list, compare_func, user_data);
	}

}
