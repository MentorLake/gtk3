namespace MentorLake.GLib;

public class GByteArrayHandle : BaseSafeHandle
{
}


public static class GByteArrayExtensions
{

	public static GByteArray Dereference(this GByteArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GByteArray>(x.DangerousGetHandle());
}
internal class GByteArrayExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_byte_array_free_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new_take(byte[] data, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_sized_new(uint reserved_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, out UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

}

public struct GByteArray
{
	public IntPtr data;
	public uint len;
	public static MentorLake.GLib.GByteArrayHandle Append(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_append(array, data, len);
	}

	public static byte Free(MentorLake.GLib.GByteArrayHandle array, bool free_segment)
	{
		return GByteArrayExterns.g_byte_array_free(array, free_segment);
	}

	public static MentorLake.GLib.GBytesHandle FreeToBytes(MentorLake.GLib.GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_free_to_bytes(array);
	}

	public static MentorLake.GLib.GByteArrayHandle New()
	{
		return GByteArrayExterns.g_byte_array_new();
	}

	public static MentorLake.GLib.GByteArrayHandle NewTake(byte[] data, UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_new_take(data, len);
	}

	public static MentorLake.GLib.GByteArrayHandle Prepend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_prepend(array, data, len);
	}

	public static MentorLake.GLib.GByteArrayHandle Ref(MentorLake.GLib.GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_ref(array);
	}

	public static MentorLake.GLib.GByteArrayHandle RemoveIndex(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index(array, index_);
	}

	public static MentorLake.GLib.GByteArrayHandle RemoveIndexFast(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index_fast(array, index_);
	}

	public static MentorLake.GLib.GByteArrayHandle RemoveRange(MentorLake.GLib.GByteArrayHandle array, uint index_, uint length)
	{
		return GByteArrayExterns.g_byte_array_remove_range(array, index_, length);
	}

	public static MentorLake.GLib.GByteArrayHandle SetSize(MentorLake.GLib.GByteArrayHandle array, uint length)
	{
		return GByteArrayExterns.g_byte_array_set_size(array, length);
	}

	public static MentorLake.GLib.GByteArrayHandle SizedNew(uint reserved_size)
	{
		return GByteArrayExterns.g_byte_array_sized_new(reserved_size);
	}

	public static void Sort(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GByteArrayExterns.g_byte_array_sort(array, compare_func);
	}

	public static void SortWithData(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GByteArrayExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
	}

	public static byte Steal(MentorLake.GLib.GByteArrayHandle array, out UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_steal(array, out len);
	}

	public static void Unref(MentorLake.GLib.GByteArrayHandle array)
	{
		GByteArrayExterns.g_byte_array_unref(array);
	}

}
