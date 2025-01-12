namespace MentorLake.Gtk3.GLib;

public class GPtrArrayHandle : BaseSafeHandle
{
}


public static class GPtrArrayHandleExtensions
{
	public static void Add(GPtrArray[] array, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_add(array, data);
	}

	public static IntPtr Copy(GPtrArray[] array, GCopyFunc func, IntPtr user_data)
	{
		return GPtrArrayExterns.g_ptr_array_copy(array, func, user_data);
	}

	public static void Extend(GPtrArray[] array_to_extend, GPtrArray[] array, GCopyFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_extend(array_to_extend, array, func, user_data);
	}

	public static void ExtendAndSteal(GPtrArray[] array_to_extend, GPtrArray[] array)
	{
		GPtrArrayExterns.g_ptr_array_extend_and_steal(array_to_extend, array);
	}

	public static bool Find(GPtrArray[] haystack, IntPtr needle, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find(haystack, needle, out index_);
	}

	public static bool FindWithEqualFunc(GPtrArray[] haystack, IntPtr needle, GEqualFunc equal_func, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

	public static void Foreach(GPtrArray[] array, GFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_foreach(array, func, user_data);
	}

	public static IntPtr Free(GPtrArray[] array, bool free_seg)
	{
		return GPtrArrayExterns.g_ptr_array_free(array, free_seg);
	}

	public static void Insert(GPtrArray[] array, int index_, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_insert(array, index_, data);
	}

	public static bool IsNullTerminated(GPtrArray[] array)
	{
		return GPtrArrayExterns.g_ptr_array_is_null_terminated(array);
	}

	public static IntPtr New()
	{
		return GPtrArrayExterns.g_ptr_array_new();
	}

	public static IntPtr NewFromArray(IntPtr[] data, UIntPtr len, GCopyFunc copy_func, IntPtr copy_func_user_data, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_array(data, len, copy_func, copy_func_user_data, element_free_func);
	}

	public static IntPtr NewFromNullTerminatedArray(IntPtr[] data, GCopyFunc copy_func, IntPtr copy_func_user_data, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_null_terminated_array(data, copy_func, copy_func_user_data, element_free_func);
	}

	public static IntPtr NewFull(uint reserved_size, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_full(reserved_size, element_free_func);
	}

	public static IntPtr NewNullTerminated(uint reserved_size, GDestroyNotify element_free_func, bool null_terminated)
	{
		return GPtrArrayExterns.g_ptr_array_new_null_terminated(reserved_size, element_free_func, null_terminated);
	}

	public static IntPtr NewTake(IntPtr[] data, UIntPtr len, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take(data, len, element_free_func);
	}

	public static IntPtr NewTakeNullTerminated(IntPtr[] data, GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take_null_terminated(data, element_free_func);
	}

	public static IntPtr NewWithFreeFunc(GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_with_free_func(element_free_func);
	}

	public static IntPtr Ref(GPtrArray[] array)
	{
		return GPtrArrayExterns.g_ptr_array_ref(array);
	}

	public static bool Remove(GPtrArray[] array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove(array, data);
	}

	public static bool RemoveFast(GPtrArray[] array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove_fast(array, data);
	}

	public static IntPtr RemoveIndex(GPtrArray[] array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index(array, index_);
	}

	public static IntPtr RemoveIndexFast(GPtrArray[] array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index_fast(array, index_);
	}

	public static IntPtr RemoveRange(GPtrArray[] array, uint index_, uint length)
	{
		return GPtrArrayExterns.g_ptr_array_remove_range(array, index_, length);
	}

	public static void SetFreeFunc(GPtrArray[] array, GDestroyNotify element_free_func)
	{
		GPtrArrayExterns.g_ptr_array_set_free_func(array, element_free_func);
	}

	public static void SetSize(GPtrArray[] array, int length)
	{
		GPtrArrayExterns.g_ptr_array_set_size(array, length);
	}

	public static IntPtr SizedNew(uint reserved_size)
	{
		return GPtrArrayExterns.g_ptr_array_sized_new(reserved_size);
	}

	public static void Sort(GPtrArray[] array, GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort(array, compare_func);
	}

	public static void SortValues(GPtrArray[] array, GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort_values(array, compare_func);
	}

	public static void SortValuesWithData(GPtrArray[] array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_values_with_data(array, compare_func, user_data);
	}

	public static void SortWithData(GPtrArray[] array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_with_data(array, compare_func, user_data);
	}

	public static IntPtr Steal(GPtrArray[] array, out UIntPtr len)
	{
		return GPtrArrayExterns.g_ptr_array_steal(array, out len);
	}

	public static IntPtr StealIndex(GPtrArray[] array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index(array, index_);
	}

	public static IntPtr StealIndexFast(GPtrArray[] array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index_fast(array, index_);
	}

	public static void Unref(GPtrArray[] array)
	{
		GPtrArrayExterns.g_ptr_array_unref(array);
	}

}
internal class GPtrArrayExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_add(GPtrArray[] array, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_copy(GPtrArray[] array, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_extend(GPtrArray[] array_to_extend, GPtrArray[] array, GCopyFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_extend_and_steal(GPtrArray[] array_to_extend, GPtrArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ptr_array_find(GPtrArray[] haystack, IntPtr needle, out uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ptr_array_find_with_equal_func(GPtrArray[] haystack, IntPtr needle, GEqualFunc equal_func, out uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_foreach(GPtrArray[] array, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_free(GPtrArray[] array, bool free_seg);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_insert(GPtrArray[] array, int index_, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ptr_array_is_null_terminated(GPtrArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_from_array(IntPtr[] data, UIntPtr len, GCopyFunc copy_func, IntPtr copy_func_user_data, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_from_null_terminated_array(IntPtr[] data, GCopyFunc copy_func, IntPtr copy_func_user_data, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_full(uint reserved_size, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_null_terminated(uint reserved_size, GDestroyNotify element_free_func, bool null_terminated);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_take(IntPtr[] data, UIntPtr len, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_take_null_terminated(IntPtr[] data, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_new_with_free_func(GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_ref(GPtrArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ptr_array_remove(GPtrArray[] array, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_ptr_array_remove_fast(GPtrArray[] array, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_remove_index(GPtrArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_remove_index_fast(GPtrArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_remove_range(GPtrArray[] array, uint index_, uint length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_set_free_func(GPtrArray[] array, GDestroyNotify element_free_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_set_size(GPtrArray[] array, int length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_sized_new(uint reserved_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_sort(GPtrArray[] array, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_sort_values(GPtrArray[] array, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_sort_values_with_data(GPtrArray[] array, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_sort_with_data(GPtrArray[] array, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_steal(GPtrArray[] array, out UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_steal_index(GPtrArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_ptr_array_steal_index_fast(GPtrArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_ptr_array_unref(GPtrArray[] array);

}

public struct GPtrArray
{
	public IntPtr[] pdata;
	public uint len;
}
