namespace MentorLake.GLib;

public class GSequenceHandle : BaseSafeHandle
{
}


public static class GSequenceExtensions
{
	public static MentorLake.GLib.GSequenceIterHandle Append(this MentorLake.GLib.GSequenceHandle seq, IntPtr data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_append(seq, data);
	}

	public static void Foreach(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_foreach(seq, func, user_data);
	}

	public static void Free(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_free(seq);
	}

	public static MentorLake.GLib.GSequenceIterHandle GetBeginIter(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_begin_iter(seq);
	}

	public static MentorLake.GLib.GSequenceIterHandle GetEndIter(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_end_iter(seq);
	}

	public static MentorLake.GLib.GSequenceIterHandle GetIterAtPos(this MentorLake.GLib.GSequenceHandle seq, int pos)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_iter_at_pos(seq, pos);
	}

	public static int GetLength(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_length(seq);
	}

	public static MentorLake.GLib.GSequenceIterHandle InsertSorted(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_insert_sorted(seq, data, cmp_func, cmp_data);
	}

	public static MentorLake.GLib.GSequenceIterHandle InsertSortedIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_insert_sorted_iter(seq, data, iter_cmp, cmp_data);
	}

	public static bool IsEmpty(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_is_empty(seq);
	}

	public static MentorLake.GLib.GSequenceIterHandle Lookup(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_lookup(seq, data, cmp_func, cmp_data);
	}

	public static MentorLake.GLib.GSequenceIterHandle LookupIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_lookup_iter(seq, data, iter_cmp, cmp_data);
	}

	public static MentorLake.GLib.GSequenceIterHandle Prepend(this MentorLake.GLib.GSequenceHandle seq, IntPtr data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_prepend(seq, data);
	}

	public static MentorLake.GLib.GSequenceIterHandle Search(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_search(seq, data, cmp_func, cmp_data);
	}

	public static MentorLake.GLib.GSequenceIterHandle SearchIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_search_iter(seq, data, iter_cmp, cmp_data);
	}

	public static void Sort(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_sort(seq, cmp_func, cmp_data);
	}

	public static void SortIter(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GSequenceIterCompareFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_sort_iter(seq, cmp_func, cmp_data);
	}


	public static GSequence Dereference(this GSequenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSequence>(x.DangerousGetHandle());
}
internal class GSequenceExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_begin_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_end_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_iter_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, int pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_sorted_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_lookup_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_search_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GSequenceIterCompareFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_sequence_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))]
	internal static extern MentorLake.GLib.GSequenceHandle g_sequence_new(MentorLake.GLib.GDestroyNotify data_destroy);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_range_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

}

public struct GSequence
{
	public static void ForeachRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GSequenceExterns.g_sequence_foreach_range(begin, end, func, user_data);
	}

	public static IntPtr Get(MentorLake.GLib.GSequenceIterHandle iter)
	{
		return GSequenceExterns.g_sequence_get(iter);
	}

	public static MentorLake.GLib.GSequenceIterHandle InsertBefore(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		return GSequenceExterns.g_sequence_insert_before(iter, data);
	}

	public static void Move(MentorLake.GLib.GSequenceIterHandle src, MentorLake.GLib.GSequenceIterHandle dest)
	{
		GSequenceExterns.g_sequence_move(src, dest);
	}

	public static void MoveRange(MentorLake.GLib.GSequenceIterHandle dest, MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_move_range(dest, begin, end);
	}

	public static MentorLake.GLib.GSequenceHandle New(MentorLake.GLib.GDestroyNotify data_destroy)
	{
		return GSequenceExterns.g_sequence_new(data_destroy);
	}

	public static MentorLake.GLib.GSequenceIterHandle RangeGetMidpoint(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		return GSequenceExterns.g_sequence_range_get_midpoint(begin, end);
	}

	public static void Remove(MentorLake.GLib.GSequenceIterHandle iter)
	{
		GSequenceExterns.g_sequence_remove(iter);
	}

	public static void RemoveRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_remove_range(begin, end);
	}

	public static void Set(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		GSequenceExterns.g_sequence_set(iter, data);
	}

	public static void SortChanged(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
	}

	public static void SortChangedIter(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
	}

	public static void Swap(MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		GSequenceExterns.g_sequence_swap(a, b);
	}

}
