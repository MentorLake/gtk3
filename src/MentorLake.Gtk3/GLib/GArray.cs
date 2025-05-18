namespace MentorLake.GLib;

public class GArrayHandle : BaseSafeHandle
{
}


public static class GArrayExtensions
{

	public static GArray Dereference(this GArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GArray>(x.DangerousGetHandle());
}
internal class GArrayExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_append_vals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, IntPtr data, uint len);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_array_binary_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, IntPtr target, MentorLake.GLib.GCompareFunc compare_func, out uint out_match_index);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_array_get_element_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_insert_vals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, uint index_, IntPtr data, uint len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new(bool zero_terminated, bool clear_, uint element_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take_zero_terminated(IntPtr[] data, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_prepend_vals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, IntPtr data, uint len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_remove_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_remove_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_array_set_clear_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GDestroyNotify clear_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_sized_new(bool zero_terminated, bool clear_, uint element_size, uint reserved_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_array_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array, out UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_array_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))] MentorLake.GLib.GArrayHandle array);

}

public struct GArray
{
	public string data;
	public uint len;
	public static MentorLake.GLib.GArrayHandle AppendVals(MentorLake.GLib.GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_append_vals(array, data, len);
	}

	public static bool BinarySearch(MentorLake.GLib.GArrayHandle array, IntPtr target, MentorLake.GLib.GCompareFunc compare_func, out uint out_match_index)
	{
		return GArrayExterns.g_array_binary_search(array, target, compare_func, out out_match_index);
	}

	public static MentorLake.GLib.GArrayHandle Copy(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_copy(array);
	}

	public static string Free(MentorLake.GLib.GArrayHandle array, bool free_segment)
	{
		return GArrayExterns.g_array_free(array, free_segment);
	}

	public static uint GetElementSize(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_get_element_size(array);
	}

	public static MentorLake.GLib.GArrayHandle InsertVals(MentorLake.GLib.GArrayHandle array, uint index_, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_insert_vals(array, index_, data, len);
	}

	public static MentorLake.GLib.GArrayHandle New(bool zero_terminated, bool clear_, uint element_size)
	{
		return GArrayExterns.g_array_new(zero_terminated, clear_, element_size);
	}

	public static MentorLake.GLib.GArrayHandle NewTake(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take(data, len, clear, element_size);
	}

	public static MentorLake.GLib.GArrayHandle NewTakeZeroTerminated(IntPtr[] data, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take_zero_terminated(data, clear, element_size);
	}

	public static MentorLake.GLib.GArrayHandle PrependVals(MentorLake.GLib.GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_prepend_vals(array, data, len);
	}

	public static MentorLake.GLib.GArrayHandle Ref(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_ref(array);
	}

	public static MentorLake.GLib.GArrayHandle RemoveIndex(MentorLake.GLib.GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index(array, index_);
	}

	public static MentorLake.GLib.GArrayHandle RemoveIndexFast(MentorLake.GLib.GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index_fast(array, index_);
	}

	public static MentorLake.GLib.GArrayHandle RemoveRange(MentorLake.GLib.GArrayHandle array, uint index_, uint length)
	{
		return GArrayExterns.g_array_remove_range(array, index_, length);
	}

	public static void SetClearFunc(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GArrayExterns.g_array_set_clear_func(array, clear_func);
	}

	public static MentorLake.GLib.GArrayHandle SetSize(MentorLake.GLib.GArrayHandle array, uint length)
	{
		return GArrayExterns.g_array_set_size(array, length);
	}

	public static MentorLake.GLib.GArrayHandle SizedNew(bool zero_terminated, bool clear_, uint element_size, uint reserved_size)
	{
		return GArrayExterns.g_array_sized_new(zero_terminated, clear_, element_size, reserved_size);
	}

	public static void Sort(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GArrayExterns.g_array_sort(array, compare_func);
	}

	public static void SortWithData(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GArrayExterns.g_array_sort_with_data(array, compare_func, user_data);
	}

	public static IntPtr Steal(MentorLake.GLib.GArrayHandle array, out UIntPtr len)
	{
		return GArrayExterns.g_array_steal(array, out len);
	}

	public static void Unref(MentorLake.GLib.GArrayHandle array)
	{
		GArrayExterns.g_array_unref(array);
	}

}
