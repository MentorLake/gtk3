namespace MentorLake.Gtk3.GLib;

public class GByteArrayHandle : BaseSafeHandle
{
}


public static class GByteArrayHandleExtensions
{
	public static IntPtr Append(GByteArray[] array, ref byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_append(array, ref data, len);
	}

	public static IntPtr Free(GByteArray[] array, bool free_segment)
	{
		return GByteArrayExterns.g_byte_array_free(array, free_segment);
	}

	public static GBytesHandle FreeToBytes(GByteArray[] array)
	{
		return GByteArrayExterns.g_byte_array_free_to_bytes(array);
	}

	public static IntPtr New()
	{
		return GByteArrayExterns.g_byte_array_new();
	}

	public static IntPtr NewTake(byte[] data, UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_new_take(data, len);
	}

	public static IntPtr Prepend(GByteArray[] array, ref byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_prepend(array, ref data, len);
	}

	public static IntPtr Ref(GByteArray[] array)
	{
		return GByteArrayExterns.g_byte_array_ref(array);
	}

	public static IntPtr RemoveIndex(GByteArray[] array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index(array, index_);
	}

	public static IntPtr RemoveIndexFast(GByteArray[] array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index_fast(array, index_);
	}

	public static IntPtr RemoveRange(GByteArray[] array, uint index_, uint length)
	{
		return GByteArrayExterns.g_byte_array_remove_range(array, index_, length);
	}

	public static IntPtr SetSize(GByteArray[] array, uint length)
	{
		return GByteArrayExterns.g_byte_array_set_size(array, length);
	}

	public static IntPtr SizedNew(uint reserved_size)
	{
		return GByteArrayExterns.g_byte_array_sized_new(reserved_size);
	}

	public static void Sort(GByteArray[] array, GCompareFunc compare_func)
	{
		GByteArrayExterns.g_byte_array_sort(array, compare_func);
	}

	public static void SortWithData(GByteArray[] array, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GByteArrayExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
	}

	public static IntPtr Steal(GByteArray[] array, out UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_steal(array, out len);
	}

	public static void Unref(GByteArray[] array)
	{
		GByteArrayExterns.g_byte_array_unref(array);
	}

}
internal class GByteArrayExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_append(GByteArray[] array, ref byte data, uint len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_free(GByteArray[] array, bool free_segment);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_byte_array_free_to_bytes(GByteArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_new();

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_new_take(byte[] data, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_prepend(GByteArray[] array, ref byte data, uint len);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_ref(GByteArray[] array);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_remove_index(GByteArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_remove_index_fast(GByteArray[] array, uint index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_remove_range(GByteArray[] array, uint index_, uint length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_set_size(GByteArray[] array, uint length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_sized_new(uint reserved_size);

	[DllImport(Libraries.GLib)]
	internal static extern void g_byte_array_sort(GByteArray[] array, GCompareFunc compare_func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_byte_array_sort_with_data(GByteArray[] array, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_byte_array_steal(GByteArray[] array, out UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern void g_byte_array_unref(GByteArray[] array);

}

public struct GByteArray
{
	public byte[] data;
	public uint len;
}
