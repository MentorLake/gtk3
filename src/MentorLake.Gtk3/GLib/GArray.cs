namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Contains the public fields of a GArray.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Contains the public fields of a GArray.
/// </para>
/// </summary>

public struct GArray
{
	/// <summary>
/// <para>
/// a pointer to the element data. The data may be moved as
///     elements are added to the #GArray.
/// </para>
/// </summary>

public string data;
	/// <summary>
/// <para>
/// the number of elements in the #GArray not including the
///     possible terminating zero element.
/// </para>
/// </summary>

public uint len;
/// <summary>
/// <para>
/// Adds @len elements onto the end of the array.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="data">
/// a pointer to the elements to append to the end of the array
/// </param>
/// <param name="len">
/// the number of elements to append
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle AppendVals(MentorLake.GLib.GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_append_vals(array, data, len);
	}

/// <summary>
/// <para>
/// Checks whether @target exists in @array by performing a binary
/// search based on the given comparison function @compare_func which
/// get pointers to items as arguments. If the element is found, %TRUE
/// is returned and the element’s index is returned in @out_match_index
/// (if non-%NULL). Otherwise, %FALSE is returned and @out_match_index
/// is undefined. If @target exists multiple times in @array, the index
/// of the first instance is returned. This search is using a binary
/// search, so the @array must absolutely be sorted to return a correct
/// result (if not, the function may produce false-negative).
/// </para>
/// <para>
/// This example defines a comparison function and search an element in a #GArray:
/// |[<!-- language="C" -->
/// static gint
/// cmpint (gconstpointer a, gconstpointer b)
/// {
///   const gint *_a = a;
///   const gint *_b = b;
/// </para>
/// <para>
///   return *_a - *_b;
/// }
/// ...
/// gint i = 424242;
/// guint matched_index;
/// gboolean result = g_array_binary_search (garray, &i, cmpint, &matched_index);
/// ...
/// ]|
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray.
/// </param>
/// <param name="target">
/// a pointer to the item to look up.
/// </param>
/// <param name="compare_func">
/// A #GCompareFunc used to locate @target.
/// </param>
/// <param name="out_match_index">
/// return location
///    for the index of the element, if found.
/// </param>
/// <return>
/// %TRUE if @target is one of the elements of @array, %FALSE otherwise.
/// </return>

	public static bool BinarySearch(MentorLake.GLib.GArrayHandle array, IntPtr target, MentorLake.GLib.GCompareFunc compare_func, out uint out_match_index)
	{
		return GArrayExterns.g_array_binary_search(array, target, compare_func, out out_match_index);
	}

/// <summary>
/// <para>
/// Create a shallow copy of a #GArray. If the array elements consist of
/// pointers to data, the pointers are copied but the actual data is not.
/// </para>
/// </summary>

/// <param name="array">
/// A #GArray.
/// </param>
/// <return>
/// A copy of @array.
/// </return>

	public static MentorLake.GLib.GArrayHandle Copy(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_copy(array);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GArray. If @free_segment is
/// %TRUE it frees the memory block holding the elements as well. Pass
/// %FALSE if you want to free the #GArray wrapper but preserve the
/// underlying array for use elsewhere. If the reference count of
/// @array is greater than one, the #GArray wrapper is preserved but
/// the size of  @array will be set to zero.
/// </para>
/// <para>
/// If array contents point to dynamically-allocated memory, they should
/// be freed separately if @free_segment is %TRUE and no @clear_func
/// function has been set for @array.
/// </para>
/// <para>
/// This function is not thread-safe. If using a #GArray from multiple
/// threads, use only the atomic g_array_ref() and g_array_unref()
/// functions.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="free_segment">
/// if %TRUE the actual element data is freed as well
/// </param>
/// <return>
/// the element data if @free_segment is %FALSE, otherwise
///     %NULL. The element data should be freed using g_free().
/// </return>

	public static string Free(MentorLake.GLib.GArrayHandle array, bool free_segment)
	{
		return GArrayExterns.g_array_free(array, free_segment);
	}

/// <summary>
/// <para>
/// Gets the size of the elements in @array.
/// </para>
/// </summary>

/// <param name="array">
/// A #GArray
/// </param>
/// <return>
/// Size of each element, in bytes
/// </return>

	public static uint GetElementSize(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_get_element_size(array);
	}

/// <summary>
/// <para>
/// Inserts @len elements into a #GArray at the given index.
/// </para>
/// <para>
/// If @index_ is greater than the array’s current length, the array is expanded.
/// The elements between the old end of the array and the newly inserted elements
/// will be initialised to zero if the array was configured to clear elements;
/// otherwise their values will be undefined.
/// </para>
/// <para>
/// If @index_ is less than the array’s current length, new entries will be
/// inserted into the array, and the existing entries above @index_ will be moved
/// upwards.
/// </para>
/// <para>
/// @data may be %NULL if (and only if) @len is zero. If @len is zero, this
/// function is a no-op.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="index_">
/// the index to place the elements at
/// </param>
/// <param name="data">
/// a pointer to the elements to insert
/// </param>
/// <param name="len">
/// the number of elements to insert
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle InsertVals(MentorLake.GLib.GArrayHandle array, uint index_, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_insert_vals(array, index_, data, len);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with a reference count of 1.
/// </para>
/// </summary>

/// <param name="zero_terminated">
/// %TRUE if the array should have an extra element at
///     the end which is set to 0
/// </param>
/// <param name="clear_">
/// %TRUE if #GArray elements should be automatically cleared
///     to 0 when they are allocated
/// </param>
/// <param name="element_size">
/// the size of each element in bytes
/// </param>
/// <return>
/// the new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle New(bool zero_terminated, bool clear_, uint element_size)
	{
		return GArrayExterns.g_array_new(zero_terminated, clear_, element_size);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with @data as array data, @len as length and a
/// reference count of 1.
/// </para>
/// <para>
/// This avoids having to copy the data manually, when it can just be
/// inherited.
/// After this call, @data belongs to the #GArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// In case the elements need to be cleared when the array is freed, use
/// g_array_set_clear_func() to set a #GDestroyNotify function to perform
/// such task.
/// </para>
/// <para>
/// Do not use it if @len or @element_size are greater than %G_MAXUINT.
/// #GArray stores the length of its data in #guint, which may be shorter
/// than #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of
///   elements of @element_size, or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of elements in @data
/// </param>
/// <param name="clear">
/// %TRUE if #GArray elements should be automatically cleared
///     to 0 when they are allocated
/// </param>
/// <param name="element_size">
/// the size of each element in bytes
/// </param>
/// <return>
/// A new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle NewTake(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take(data, len, clear, element_size);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with @data as array data, computing the length of it
/// and setting the reference count to 1.
/// </para>
/// <para>
/// This avoids having to copy the data manually, when it can just be
/// inherited.
/// After this call, @data belongs to the #GArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// The length is calculated by iterating through @data until the first %NULL
/// element is found.
/// </para>
/// <para>
/// In case the elements need to be cleared when the array is freed, use
/// g_array_set_clear_func() to set a #GDestroyNotify function to perform
/// such task.
/// </para>
/// <para>
/// Do not use it if @data length or @element_size are greater than %G_MAXUINT.
/// #GArray stores the length of its data in #guint, which may be shorter
/// than #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of elements of @element_size
/// </param>
/// <param name="clear">
/// %TRUE if #GArray elements should be automatically cleared
///     to 0 when they are allocated
/// </param>
/// <param name="element_size">
/// the size of each element in bytes
/// </param>
/// <return>
/// A new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle NewTakeZeroTerminated(IntPtr[] data, bool clear, UIntPtr element_size)
	{
		return GArrayExterns.g_array_new_take_zero_terminated(data, clear, element_size);
	}

/// <summary>
/// <para>
/// Adds @len elements onto the start of the array.
/// </para>
/// <para>
/// @data may be %NULL if (and only if) @len is zero. If @len is zero, this
/// function is a no-op.
/// </para>
/// <para>
/// This operation is slower than g_array_append_vals() since the
/// existing elements in the array have to be moved to make space for
/// the new elements.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="data">
/// a pointer to the elements to prepend to the start of the array
/// </param>
/// <param name="len">
/// the number of elements to prepend, which may be zero
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle PrependVals(MentorLake.GLib.GArrayHandle array, IntPtr data, uint len)
	{
		return GArrayExterns.g_array_prepend_vals(array, data, len);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @array by one.
/// This function is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GArray
/// </param>
/// <return>
/// The passed in #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle Ref(MentorLake.GLib.GArrayHandle array)
	{
		return GArrayExterns.g_array_ref(array);
	}

/// <summary>
/// <para>
/// Removes the element at the given index from a #GArray. The following
/// elements are moved down one place.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="index_">
/// the index of the element to remove
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle RemoveIndex(MentorLake.GLib.GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index(array, index_);
	}

/// <summary>
/// <para>
/// Removes the element at the given index from a #GArray. The last
/// element in the array is used to fill in the space, so this function
/// does not preserve the order of the #GArray. But it is faster than
/// g_array_remove_index().
/// </para>
/// </summary>

/// <param name="array">
/// a @GArray
/// </param>
/// <param name="index_">
/// the index of the element to remove
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle RemoveIndexFast(MentorLake.GLib.GArrayHandle array, uint index_)
	{
		return GArrayExterns.g_array_remove_index_fast(array, index_);
	}

/// <summary>
/// <para>
/// Removes the given number of elements starting at the given index
/// from a #GArray.  The following elements are moved to close the gap.
/// </para>
/// </summary>

/// <param name="array">
/// a @GArray
/// </param>
/// <param name="index_">
/// the index of the first element to remove
/// </param>
/// <param name="length">
/// the number of elements to remove
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle RemoveRange(MentorLake.GLib.GArrayHandle array, uint index_, uint length)
	{
		return GArrayExterns.g_array_remove_range(array, index_, length);
	}

/// <summary>
/// <para>
/// Sets a function to clear an element of @array.
/// </para>
/// <para>
/// The @clear_func will be called when an element in the array
/// data segment is removed and when the array is freed and data
/// segment is deallocated as well. @clear_func will be passed a
/// pointer to the element to clear, rather than the element itself.
/// </para>
/// <para>
/// Note that in contrast with other uses of #GDestroyNotify
/// functions, @clear_func is expected to clear the contents of
/// the array element it is given, but not free the element itself.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// typedef struct
/// {
///   gchar *str;
///   GObject *obj;
/// } ArrayElement;
/// </para>
/// <para>
/// static void
/// array_element_clear (ArrayElement *element)
/// {
///   g_clear_pointer (&element->str, g_free);
///   g_clear_object (&element->obj);
/// }
/// </para>
/// <para>
/// // main code
/// GArray *garray = g_array_new (FALSE, FALSE, sizeof (ArrayElement));
/// g_array_set_clear_func (garray, (GDestroyNotify) array_element_clear);
/// // assign data to the structure
/// g_array_free (garray, TRUE);
/// ]|
/// </para>
/// </summary>

/// <param name="array">
/// A #GArray
/// </param>
/// <param name="clear_func">
/// a function to clear an element of @array
/// </param>

	public static void SetClearFunc(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GArrayExterns.g_array_set_clear_func(array, clear_func);
	}

/// <summary>
/// <para>
/// Sets the size of the array, expanding it if necessary. If the array
/// was created with @clear_ set to %TRUE, the new elements are set to 0.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="length">
/// the new size of the #GArray
/// </param>
/// <return>
/// the #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle SetSize(MentorLake.GLib.GArrayHandle array, uint length)
	{
		return GArrayExterns.g_array_set_size(array, length);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with @reserved_size elements preallocated and
/// a reference count of 1. This avoids frequent reallocation, if you
/// are going to add many elements to the array. Note however that the
/// size of the array is still 0.
/// </para>
/// </summary>

/// <param name="zero_terminated">
/// %TRUE if the array should have an extra element at
///     the end with all bits cleared
/// </param>
/// <param name="clear_">
/// %TRUE if all bits in the array should be cleared to 0 on
///     allocation
/// </param>
/// <param name="element_size">
/// size of each element in the array
/// </param>
/// <param name="reserved_size">
/// number of elements preallocated
/// </param>
/// <return>
/// the new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle SizedNew(bool zero_terminated, bool clear_, uint element_size, uint reserved_size)
	{
		return GArrayExterns.g_array_sized_new(zero_terminated, clear_, element_size, reserved_size);
	}

/// <summary>
/// <para>
/// Sorts a #GArray using @compare_func which should be a qsort()-style
/// comparison function (returns less than zero for first arg is less
/// than second arg, zero for equal, greater zero if first arg is
/// greater than second arg).
/// </para>
/// <para>
/// This is guaranteed to be a stable sort since version 2.32.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>

	public static void Sort(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GArrayExterns.g_array_sort(array, compare_func);
	}

/// <summary>
/// <para>
/// Like g_array_sort(), but the comparison function receives an extra
/// user data argument.
/// </para>
/// <para>
/// This is guaranteed to be a stable sort since version 2.32.
/// </para>
/// <para>
/// There used to be a comment here about making the sort stable by
/// using the addresses of the elements in the comparison function.
/// This did not actually work, so any such code should be removed.
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void SortWithData(MentorLake.GLib.GArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GArrayExterns.g_array_sort_with_data(array, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Frees the data in the array and resets the size to zero, while
/// the underlying array is preserved for use elsewhere and returned
/// to the caller.
/// </para>
/// <para>
/// If the array was created with the @zero_terminate property
/// set to %TRUE, the returned data is zero terminated too.
/// </para>
/// <para>
/// If array elements contain dynamically-allocated memory,
/// the array elements should also be freed by the caller.
/// </para>
/// <para>
/// A short example of use:
/// |[<!-- language="C" -->
/// ...
/// gpointer data;
/// gsize data_len;
/// data = g_array_steal (some_array, &data_len);
/// ...
/// ]|
/// </para>
/// </summary>

/// <param name="array">
/// a #GArray.
/// </param>
/// <param name="len">
/// pointer to retrieve the number of
///    elements of the original array
/// </param>
/// <return>
/// the element data, which should be
///     freed using g_free().
/// </return>

	public static IntPtr Steal(MentorLake.GLib.GArrayHandle array, out UIntPtr len)
	{
		return GArrayExterns.g_array_steal(array, out len);
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
/// A #GArray
/// </param>

	public static void Unref(MentorLake.GLib.GArrayHandle array)
	{
		GArrayExterns.g_array_unref(array);
	}

}
