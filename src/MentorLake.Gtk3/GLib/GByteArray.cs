namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Contains the public fields of a GByteArray.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Contains the public fields of a GByteArray.
/// </para>
/// </summary>

public struct GByteArray
{
	/// <summary>
/// <para>
/// a pointer to the element data. The data may be moved as
///     elements are added to the #GByteArray
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// the number of elements in the #GByteArray
/// </para>
/// </summary>

public uint len;
/// <summary>
/// <para>
/// Adds the given bytes to the end of the #GByteArray.
/// The array will grow in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="data">
/// the byte data to be added
/// </param>
/// <param name="len">
/// the number of bytes to add
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle Append(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_append(array, data, len);
	}

/// <summary>
/// <para>
/// Frees the memory allocated by the #GByteArray. If @free_segment is
/// %TRUE it frees the actual byte data. If the reference count of
/// @array is greater than one, the #GByteArray wrapper is preserved but
/// the size of @array will be set to zero.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="free_segment">
/// if %TRUE the actual byte data is freed as well
/// </param>
/// <return>
/// the element data if @free_segment is %FALSE, otherwise
///          %NULL.  The element data should be freed using g_free().
/// </return>

	public static byte Free(MentorLake.GLib.GByteArrayHandle array, bool free_segment)
	{
		return GByteArrayExterns.g_byte_array_free(array, free_segment);
	}

/// <summary>
/// <para>
/// Transfers the data from the #GByteArray into a new immutable #GBytes.
/// </para>
/// <para>
/// The #GByteArray is freed unless the reference count of @array is greater
/// than one, the #GByteArray wrapper is preserved but the size of @array
/// will be set to zero.
/// </para>
/// <para>
/// This is identical to using g_bytes_new_take() and g_byte_array_free()
/// together.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <return>
/// a new immutable #GBytes representing same
///     byte data that was in the array
/// </return>

	public static MentorLake.GLib.GBytesHandle FreeToBytes(MentorLake.GLib.GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_free_to_bytes(array);
	}

/// <summary>
/// <para>
/// Creates a new #GByteArray with a reference count of 1.
/// </para>
/// </summary>

/// <return>
/// the new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle New()
	{
		return GByteArrayExterns.g_byte_array_new();
	}

/// <summary>
/// <para>
/// Creates a byte array containing the @data.
/// After this call, @data belongs to the #GByteArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GByteArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// byte data for the array
/// </param>
/// <param name="len">
/// length of @data
/// </param>
/// <return>
/// a new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle NewTake(byte[] data, UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_new_take(data, len);
	}

/// <summary>
/// <para>
/// Adds the given data to the start of the #GByteArray.
/// The array will grow in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="data">
/// the byte data to be added
/// </param>
/// <param name="len">
/// the number of bytes to add
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle Prepend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GByteArrayExterns.g_byte_array_prepend(array, data, len);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @array by one.
/// This function is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GByteArray
/// </param>
/// <return>
/// The passed in #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle Ref(MentorLake.GLib.GByteArrayHandle array)
	{
		return GByteArrayExterns.g_byte_array_ref(array);
	}

/// <summary>
/// <para>
/// Removes the byte at the given index from a #GByteArray.
/// The following bytes are moved down one place.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="index_">
/// the index of the byte to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle RemoveIndex(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index(array, index_);
	}

/// <summary>
/// <para>
/// Removes the byte at the given index from a #GByteArray. The last
/// element in the array is used to fill in the space, so this function
/// does not preserve the order of the #GByteArray. But it is faster
/// than g_byte_array_remove_index().
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="index_">
/// the index of the byte to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle RemoveIndexFast(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GByteArrayExterns.g_byte_array_remove_index_fast(array, index_);
	}

/// <summary>
/// <para>
/// Removes the given number of bytes starting at the given index from a
/// #GByteArray.  The following elements are moved to close the gap.
/// </para>
/// </summary>

/// <param name="array">
/// a @GByteArray
/// </param>
/// <param name="index_">
/// the index of the first byte to remove
/// </param>
/// <param name="length">
/// the number of bytes to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle RemoveRange(MentorLake.GLib.GByteArrayHandle array, uint index_, uint length)
	{
		return GByteArrayExterns.g_byte_array_remove_range(array, index_, length);
	}

/// <summary>
/// <para>
/// Sets the size of the #GByteArray, expanding it if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="length">
/// the new size of the #GByteArray
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle SetSize(MentorLake.GLib.GByteArrayHandle array, uint length)
	{
		return GByteArrayExterns.g_byte_array_set_size(array, length);
	}

/// <summary>
/// <para>
/// Creates a new #GByteArray with @reserved_size bytes preallocated.
/// This avoids frequent reallocation, if you are going to add many
/// bytes to the array. Note however that the size of the array is still
/// 0.
/// </para>
/// </summary>

/// <param name="reserved_size">
/// number of bytes preallocated
/// </param>
/// <return>
/// the new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle SizedNew(uint reserved_size)
	{
		return GByteArrayExterns.g_byte_array_sized_new(reserved_size);
	}

/// <summary>
/// <para>
/// Sorts a byte array, using @compare_func which should be a
/// qsort()-style comparison function (returns less than zero for first
/// arg is less than second arg, zero for equal, greater than zero if
/// first arg is greater than second arg).
/// </para>
/// <para>
/// If two array elements compare equal, their order in the sorted array
/// is undefined. If you want equal elements to keep their order (i.e.
/// you want a stable sort) you can write a comparison function that,
/// if two elements would otherwise compare equal, compares them by
/// their addresses.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>

	public static void Sort(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GByteArrayExterns.g_byte_array_sort(array, compare_func);
	}

/// <summary>
/// <para>
/// Like g_byte_array_sort(), but the comparison function takes an extra
/// user data argument.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void SortWithData(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GByteArrayExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Frees the data in the array and resets the size to zero, while
/// the underlying array is preserved for use elsewhere and returned
/// to the caller.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray.
/// </param>
/// <param name="len">
/// pointer to retrieve the number of
///    elements of the original array
/// </param>
/// <return>
/// the element data, which should be
///     freed using g_free().
/// </return>

	public static byte Steal(MentorLake.GLib.GByteArrayHandle array, out UIntPtr len)
	{
		return GByteArrayExterns.g_byte_array_steal(array, out len);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @array by one. If the
/// reference count drops to 0, all memory allocated by the array is
/// released. This function is thread-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GByteArray
/// </param>

	public static void Unref(MentorLake.GLib.GByteArrayHandle array)
	{
		GByteArrayExterns.g_byte_array_unref(array);
	}

}
