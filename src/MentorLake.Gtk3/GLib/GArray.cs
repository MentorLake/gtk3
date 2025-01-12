namespace MentorLake.Gtk3.GLib;

public class GArrayHandle : BaseSafeHandle
{
}


public static class GArrayHandleExtensions
{
	public static IntPtr AppendVals(GArray[] array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_append_vals(array, data, len);
	}

	public static bool BinarySearch(GArray[] array, IntPtr target, GCompareFunc compare_func, out uint out_match_index)
	{
		return GArrayExterns.g_array_binary_search(array, target, compare_func, out out_match_index);
	}

	public static IntPtr Copy(GArray[] array)
	{
		return GArrayExterns.g_array_copy(array);
	}

	public static string Free(GArray[] array, bool free_segment)
	{
		return GArrayExterns.g_array_free(array, free_segment);
	}

	public static uint GetElementSize(GArray[] array)
	{
		return GArrayExterns.g_array_get_element_size(array);
	}

	public static IntPtr InsertVals(GArray[] array, uint index_, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_insert_vals(array, index_, data, len);
	}

	public static IntPtr New(bool zero_terminated, bool clear_, uint element_size)
	{
		return GArrayExterns.g_array_new(zero_terminated, clear_, element_size);
	}

	public static IntPtr NewTake(IntPtr data, UIntPtr len, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take(data, len, clear, element_size);
	}

	public static IntPtr NewTakeZeroTerminated(IntPtr data, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take_zero_terminated(data, clear, element_size);
	}

	public static IntPtr PrependVals(GArray[] array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_prepend_vals(array, data, len);
	}

	public static IntPtr Ref(GArray[] array)
	{
		return GArrayExterns.g_array_ref(array);
	}

	public static IntPtr RemoveIndex(GArray[] array, uint index_)
	{
		return GArrayExterns.g_array_remove_index(array, index_);
	}

	public static IntPtr RemoveIndexFast(GArray[] array, uint index_)
	{
		return GArrayExterns.g_array_remove_index_fast(array, index_);
	}

	public static IntPtr RemoveRange(GArray[] array, uint index_, uint length)
	{
		return GArrayExterns.g_array_remove_range(array, index_, length);
	}

	public static void SetClearFunc(GArray[] array, GDestroyNotify clear_func)
	{
		GArrayExterns.g_array_set_clear_func(array, clear_func);
	}

	public static IntPtr SetSize(GArray[] array, uint length)
	{
		return GArrayExterns.g_array_set_size(array, length);
	}

	public static IntPtr SizedNew(bool zero_terminated, bool clear_, uint element_size, uint reserved_size)
	{
		return GArrayExterns.g_array_sized_new(zero_terminated, clear_, element_size, reserved_size);
	}

	public static void Sort(GArray[] array, GCompareFunc compare_func)
	{
		GArrayExterns.g_array_sort(array, compare_func);
	}

	public static void SortWithData(GArray[] array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GArrayExterns.g_array_sort_with_data(array, compare_func, user_data);
	}

	public static IntPtr Steal(GArray[] array, out UIntPtr len)
	{
		return GArrayExterns.g_array_steal(array, out len);
	}

	public static void Unref(GArray[] array)
	{
		GArrayExterns.g_array_unref(array);
	}

}
internal class GArrayExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_append_vals(GArray[] array, IntPtr data, uint len);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_array_binary_search(GArray[] array, IntPtr target, GCompareFunc compare_func, out uint out_match_index);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_copy(GArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern string g_array_free(GArray[] array, bool free_segment);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_array_get_element_size(GArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_insert_vals(GArray[] array, uint index_, IntPtr data, uint len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_new(bool zero_terminated, bool clear_, uint element_size);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_new_take(IntPtr data, UIntPtr len, bool clear, UIntPtr element_size);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_new_take_zero_terminated(IntPtr data, bool clear, UIntPtr element_size);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_prepend_vals(GArray[] array, IntPtr data, uint len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_ref(GArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_remove_index(GArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_remove_index_fast(GArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_remove_range(GArray[] array, uint index_, uint length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_array_set_clear_func(GArray[] array, GDestroyNotify clear_func);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_set_size(GArray[] array, uint length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_sized_new(bool zero_terminated, bool clear_, uint element_size, uint reserved_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_array_sort(GArray[] array, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_array_sort_with_data(GArray[] array, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_array_steal(GArray[] array, out UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern void g_array_unref(GArray[] array);

}

public struct GArray
{
	public string data;
	public uint len;
}
