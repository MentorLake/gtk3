namespace MentorLake.Gtk3.GLib;

public class GSequenceHandle : BaseSafeHandle
{
}


public static class GSequenceHandleExtensions
{
	public static GSequenceIterHandle Append(this GSequenceHandle seq, IntPtr data)
	{
		return GSequenceExterns.g_sequence_append(seq, data);
	}

	public static T Foreach<T>(this T seq, GFunc func, IntPtr user_data) where T : GSequenceHandle
	{
		GSequenceExterns.g_sequence_foreach(seq, func, user_data);
		return seq;
	}

	public static T Free<T>(this T seq) where T : GSequenceHandle
	{
		GSequenceExterns.g_sequence_free(seq);
		return seq;
	}

	public static GSequenceIterHandle GetBeginIter(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_begin_iter(seq);
	}

	public static GSequenceIterHandle GetEndIter(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_end_iter(seq);
	}

	public static GSequenceIterHandle GetIterAtPos(this GSequenceHandle seq, int pos)
	{
		return GSequenceExterns.g_sequence_get_iter_at_pos(seq, pos);
	}

	public static int GetLength(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_get_length(seq);
	}

	public static GSequenceIterHandle InsertSorted(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_insert_sorted(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle InsertSortedIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_insert_sorted_iter(seq, data, iter_cmp, cmp_data);
	}

	public static bool IsEmpty(this GSequenceHandle seq)
	{
		return GSequenceExterns.g_sequence_is_empty(seq);
	}

	public static GSequenceIterHandle Lookup(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_lookup(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle LookupIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_lookup_iter(seq, data, iter_cmp, cmp_data);
	}

	public static GSequenceIterHandle Prepend(this GSequenceHandle seq, IntPtr data)
	{
		return GSequenceExterns.g_sequence_prepend(seq, data);
	}

	public static GSequenceIterHandle Search(this GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_search(seq, data, cmp_func, cmp_data);
	}

	public static GSequenceIterHandle SearchIter(this GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		return GSequenceExterns.g_sequence_search_iter(seq, data, iter_cmp, cmp_data);
	}

	public static T Sort<T>(this T seq, GCompareDataFunc cmp_func, IntPtr cmp_data) where T : GSequenceHandle
	{
		GSequenceExterns.g_sequence_sort(seq, cmp_func, cmp_data);
		return seq;
	}

	public static T SortIter<T>(this T seq, GSequenceIterCompareFunc cmp_func, IntPtr cmp_data) where T : GSequenceHandle
	{
		GSequenceExterns.g_sequence_sort_iter(seq, cmp_func, cmp_data);
		return seq;
	}

	public static void ForeachRange(GSequenceIterHandle begin, GSequenceIterHandle end, GFunc func, IntPtr user_data)
	{
		GSequenceExterns.g_sequence_foreach_range(begin, end, func, user_data);
	}

	public static IntPtr Get(GSequenceIterHandle iter)
	{
		return GSequenceExterns.g_sequence_get(iter);
	}

	public static GSequenceIterHandle InsertBefore(GSequenceIterHandle iter, IntPtr data)
	{
		return GSequenceExterns.g_sequence_insert_before(iter, data);
	}

	public static void Move(GSequenceIterHandle src, GSequenceIterHandle dest)
	{
		GSequenceExterns.g_sequence_move(src, dest);
	}

	public static void MoveRange(GSequenceIterHandle dest, GSequenceIterHandle begin, GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_move_range(dest, begin, end);
	}

	public static GSequenceHandle New(GDestroyNotify data_destroy)
	{
		return GSequenceExterns.g_sequence_new(data_destroy);
	}

	public static GSequenceIterHandle RangeGetMidpoint(GSequenceIterHandle begin, GSequenceIterHandle end)
	{
		return GSequenceExterns.g_sequence_range_get_midpoint(begin, end);
	}

	public static void Remove(GSequenceIterHandle iter)
	{
		GSequenceExterns.g_sequence_remove(iter);
	}

	public static void RemoveRange(GSequenceIterHandle begin, GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_remove_range(begin, end);
	}

	public static void Set(GSequenceIterHandle iter, IntPtr data)
	{
		GSequenceExterns.g_sequence_set(iter, data);
	}

	public static void SortChanged(GSequenceIterHandle iter, GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
	}

	public static void SortChangedIter(GSequenceIterHandle iter, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
	}

	public static void Swap(GSequenceIterHandle a, GSequenceIterHandle b)
	{
		GSequenceExterns.g_sequence_swap(a, b);
	}

}
internal class GSequenceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_append(GSequenceHandle seq, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_foreach(GSequenceHandle seq, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_free(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_begin_iter(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_end_iter(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_get_iter_at_pos(GSequenceHandle seq, int pos);

	[DllImport(Libraries.GLib)]
	internal static extern int g_sequence_get_length(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_insert_sorted(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_insert_sorted_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_sequence_is_empty(GSequenceHandle seq);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_lookup(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_lookup_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_prepend(GSequenceHandle seq, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_search(GSequenceHandle seq, IntPtr data, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_search_iter(GSequenceHandle seq, IntPtr data, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort(GSequenceHandle seq, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort_iter(GSequenceHandle seq, GSequenceIterCompareFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_foreach_range(GSequenceIterHandle begin, GSequenceIterHandle end, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_sequence_get(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_insert_before(GSequenceIterHandle iter, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_move(GSequenceIterHandle src, GSequenceIterHandle dest);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_move_range(GSequenceIterHandle dest, GSequenceIterHandle begin, GSequenceIterHandle end);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceHandle g_sequence_new(GDestroyNotify data_destroy);

	[DllImport(Libraries.GLib)]
	internal static extern GSequenceIterHandle g_sequence_range_get_midpoint(GSequenceIterHandle begin, GSequenceIterHandle end);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_remove(GSequenceIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_remove_range(GSequenceIterHandle begin, GSequenceIterHandle end);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_set(GSequenceIterHandle iter, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort_changed(GSequenceIterHandle iter, GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_sort_changed_iter(GSequenceIterHandle iter, GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_sequence_swap(GSequenceIterHandle a, GSequenceIterHandle b);

}

public struct GSequence
{
}
