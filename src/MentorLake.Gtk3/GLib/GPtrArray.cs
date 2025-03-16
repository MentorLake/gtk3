namespace MentorLake.GLib;

public class GPtrArrayHandle : BaseSafeHandle
{
}


public static class GPtrArrayExtensions
{

	public static GPtrArray Dereference(this GPtrArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPtrArray>(x.DangerousGetHandle());
}
internal class GPtrArrayExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_extend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array_to_extend, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_extend_and_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array_to_extend, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find_with_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, int index_, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_is_null_terminated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_array(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_null_terminated_array(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_full(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_null_terminated(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func, bool null_terminated);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take_null_terminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_with_free_func(MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_remove_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_remove_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_remove_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_set_free_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_sized_new(uint reserved_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_sort_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_sort_values_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, out UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_steal_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_ptr_array_steal_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array);

}

public struct GPtrArray
{
	public IntPtr pdata;
	public uint len;
	public static void Add(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_add(array, data);
	}

	public static MentorLake.GLib.GPtrArrayHandle Copy(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GPtrArrayExterns.g_ptr_array_copy(array, func, user_data);
	}

	public static void Extend(MentorLake.GLib.GPtrArrayHandle array_to_extend, MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_extend(array_to_extend, array, func, user_data);
	}

	public static void ExtendAndSteal(MentorLake.GLib.GPtrArrayHandle array_to_extend, MentorLake.GLib.GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_extend_and_steal(array_to_extend, array);
	}

	public static bool Find(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find(haystack, needle, out index_);
	}

	public static bool FindWithEqualFunc(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

	public static void Foreach(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_foreach(array, func, user_data);
	}

	public static IntPtr Free(MentorLake.GLib.GPtrArrayHandle array, bool free_segment)
	{
		return GPtrArrayExterns.g_ptr_array_free(array, free_segment);
	}

	public static void Insert(MentorLake.GLib.GPtrArrayHandle array, int index_, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_insert(array, index_, data);
	}

	public static bool IsNullTerminated(MentorLake.GLib.GPtrArrayHandle array)
	{
		return GPtrArrayExterns.g_ptr_array_is_null_terminated(array);
	}

	public static MentorLake.GLib.GPtrArrayHandle New()
	{
		return GPtrArrayExterns.g_ptr_array_new();
	}

	public static MentorLake.GLib.GPtrArrayHandle NewFromArray(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_array(data, len, copy_func, copy_func_user_data, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewFromNullTerminatedArray(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_null_terminated_array(data, copy_func, copy_func_user_data, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewFull(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_full(reserved_size, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewNullTerminated(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func, bool null_terminated)
	{
		return GPtrArrayExterns.g_ptr_array_new_null_terminated(reserved_size, element_free_func, null_terminated);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewTake(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take(data, len, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewTakeNullTerminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take_null_terminated(data, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle NewWithFreeFunc(MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_with_free_func(element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle Ref(MentorLake.GLib.GPtrArrayHandle array)
	{
		return GPtrArrayExterns.g_ptr_array_ref(array);
	}

	public static bool Remove(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove(array, data);
	}

	public static bool RemoveFast(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove_fast(array, data);
	}

	public static IntPtr RemoveIndex(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index(array, index_);
	}

	public static IntPtr RemoveIndexFast(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index_fast(array, index_);
	}

	public static MentorLake.GLib.GPtrArrayHandle RemoveRange(MentorLake.GLib.GPtrArrayHandle array, uint index_, uint length)
	{
		return GPtrArrayExterns.g_ptr_array_remove_range(array, index_, length);
	}

	public static void SetFreeFunc(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		GPtrArrayExterns.g_ptr_array_set_free_func(array, element_free_func);
	}

	public static void SetSize(MentorLake.GLib.GPtrArrayHandle array, int length)
	{
		GPtrArrayExterns.g_ptr_array_set_size(array, length);
	}

	public static MentorLake.GLib.GPtrArrayHandle SizedNew(uint reserved_size)
	{
		return GPtrArrayExterns.g_ptr_array_sized_new(reserved_size);
	}

	public static void Sort(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort(array, compare_func);
	}

	public static void SortValues(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort_values(array, compare_func);
	}

	public static void SortValuesWithData(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_values_with_data(array, compare_func, user_data);
	}

	public static void SortWithData(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_with_data(array, compare_func, user_data);
	}

	public static IntPtr Steal(MentorLake.GLib.GPtrArrayHandle array, out UIntPtr len)
	{
		return GPtrArrayExterns.g_ptr_array_steal(array, out len);
	}

	public static IntPtr StealIndex(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index(array, index_);
	}

	public static IntPtr StealIndexFast(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index_fast(array, index_);
	}

	public static void Unref(MentorLake.GLib.GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_unref(array);
	}

}
