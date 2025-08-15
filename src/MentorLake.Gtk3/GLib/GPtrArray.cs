namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Contains the public fields of a pointer array.
/// </para>
/// </summary>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_array(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_null_terminated_array(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_full(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_null_terminated(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func, bool null_terminated);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take_null_terminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_with_free_func(MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_set_free_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ptr_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
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

/// <summary>
/// <para>
/// Contains the public fields of a pointer array.
/// </para>
/// </summary>

public struct GPtrArray
{
	/// <summary>
/// <para>
/// points to the array of pointers, which may be moved when the
///     array grows
/// </para>
/// </summary>

public IntPtr pdata;
	/// <summary>
/// <para>
/// number of pointers in the array
/// </para>
/// </summary>

public uint len;
/// <summary>
/// <para>
/// Adds a pointer to the end of the pointer array. The array will grow
/// in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="data">
/// the pointer to add
/// </param>

	public static void Add(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_add(array, data);
	}

/// <summary>
/// <para>
/// Makes a full (deep) copy of a #GPtrArray.
/// </para>
/// <para>
/// @func, as a #GCopyFunc, takes two arguments, the data to be copied
/// and a @user_data pointer. On common processor architectures, it&apos;s safe to
/// pass %NULL as @user_data if the copy function takes only one argument. You
/// may get compiler warnings from this though if compiling with GCC’s
/// `-Wcast-function-type` warning.
/// </para>
/// <para>
/// If @func is %NULL, then only the pointers (and not what they are
/// pointing to) are copied to the new #GPtrArray.
/// </para>
/// <para>
/// The copy of @array will have the same #GDestroyNotify for its elements as
/// @array. The copy will also be %NULL terminated if (and only if) the source
/// array is.
/// </para>
/// </summary>

/// <param name="array">
/// #GPtrArray to duplicate
/// </param>
/// <param name="func">
/// a copy function used to copy every element in the array
/// </param>
/// <param name="user_data">
/// user data passed to the copy function @func, or %NULL
/// </param>
/// <return>
/// a deep copy of the initial #GPtrArray.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle Copy(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GPtrArrayExterns.g_ptr_array_copy(array, func, user_data);
	}

/// <summary>
/// <para>
/// Adds all pointers of @array to the end of the array @array_to_extend.
/// The array will grow in size automatically if needed. @array_to_extend is
/// modified in-place.
/// </para>
/// <para>
/// @func, as a #GCopyFunc, takes two arguments, the data to be copied
/// and a @user_data pointer. On common processor architectures, it&apos;s safe to
/// pass %NULL as @user_data if the copy function takes only one argument. You
/// may get compiler warnings from this though if compiling with GCC’s
/// `-Wcast-function-type` warning.
/// </para>
/// <para>
/// If @func is %NULL, then only the pointers (and not what they are
/// pointing to) are copied to the new #GPtrArray.
/// </para>
/// <para>
/// Whether @array_to_extend is %NULL terminated stays unchanged by this function.
/// </para>
/// </summary>

/// <param name="array_to_extend">
/// a #GPtrArray.
/// </param>
/// <param name="array">
/// a #GPtrArray to add to the end of @array_to_extend.
/// </param>
/// <param name="func">
/// a copy function used to copy every element in the array
/// </param>
/// <param name="user_data">
/// user data passed to the copy function @func, or %NULL
/// </param>

	public static void Extend(MentorLake.GLib.GPtrArrayHandle array_to_extend, MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_extend(array_to_extend, array, func, user_data);
	}

/// <summary>
/// <para>
/// Adds all the pointers in @array to the end of @array_to_extend, transferring
/// ownership of each element from @array to @array_to_extend and modifying
/// @array_to_extend in-place. @array is then freed.
/// </para>
/// <para>
/// As with g_ptr_array_free(), @array will be destroyed if its reference count
/// is 1. If its reference count is higher, it will be decremented and the
/// length of @array set to zero.
/// </para>
/// </summary>

/// <param name="array_to_extend">
/// a #GPtrArray.
/// </param>
/// <param name="array">
/// a #GPtrArray to add to the end of
///     @array_to_extend.
/// </param>

	public static void ExtendAndSteal(MentorLake.GLib.GPtrArrayHandle array_to_extend, MentorLake.GLib.GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_extend_and_steal(array_to_extend, array);
	}

/// <summary>
/// <para>
/// Checks whether @needle exists in @haystack. If the element is found, %TRUE is
/// returned and the element’s index is returned in @index_ (if non-%NULL).
/// Otherwise, %FALSE is returned and @index_ is undefined. If @needle exists
/// multiple times in @haystack, the index of the first instance is returned.
/// </para>
/// <para>
/// This does pointer comparisons only. If you want to use more complex equality
/// checks, such as string comparisons, use g_ptr_array_find_with_equal_func().
/// </para>
/// </summary>

/// <param name="haystack">
/// pointer array to be searched
/// </param>
/// <param name="needle">
/// pointer to look for
/// </param>
/// <param name="index_">
/// return location for the index of
///    the element, if found
/// </param>
/// <return>
/// %TRUE if @needle is one of the elements of @haystack
/// </return>

	public static bool Find(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find(haystack, needle, out index_);
	}

/// <summary>
/// <para>
/// Checks whether @needle exists in @haystack, using the given @equal_func.
/// If the element is found, %TRUE is returned and the element’s index is
/// returned in @index_ (if non-%NULL). Otherwise, %FALSE is returned and @index_
/// is undefined. If @needle exists multiple times in @haystack, the index of
/// the first instance is returned.
/// </para>
/// <para>
/// @equal_func is called with the element from the array as its first parameter,
/// and @needle as its second parameter. If @equal_func is %NULL, pointer
/// equality is used.
/// </para>
/// </summary>

/// <param name="haystack">
/// pointer array to be searched
/// </param>
/// <param name="needle">
/// pointer to look for
/// </param>
/// <param name="equal_func">
/// the function to call for each element, which should
///    return %TRUE when the desired element is found; or %NULL to use pointer
///    equality
/// </param>
/// <param name="index_">
/// return location for the index of
///    the element, if found
/// </param>
/// <return>
/// %TRUE if @needle is one of the elements of @haystack
/// </return>

	public static bool FindWithEqualFunc(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

/// <summary>
/// <para>
/// Calls a function for each element of a #GPtrArray. @func must not
/// add elements to or remove elements from the array.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="func">
/// the function to call for each array element
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Foreach(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_foreach(array, func, user_data);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GPtrArray. If @free_segment is %TRUE
/// it frees the memory block holding the elements as well. Pass %FALSE
/// if you want to free the #GPtrArray wrapper but preserve the
/// underlying array for use elsewhere. If the reference count of @array
/// is greater than one, the #GPtrArray wrapper is preserved but the
/// size of @array will be set to zero.
/// </para>
/// <para>
/// If array contents point to dynamically-allocated memory, they should
/// be freed separately if @free_segment is %TRUE and no #GDestroyNotify
/// function has been set for @array.
/// </para>
/// <para>
/// Note that if the array is %NULL terminated and @free_segment is %FALSE
/// then this will always return an allocated %NULL terminated buffer.
/// If pdata is previously %NULL, a new buffer will be allocated.
/// </para>
/// <para>
/// This function is not thread-safe. If using a #GPtrArray from multiple
/// threads, use only the atomic g_ptr_array_ref() and g_ptr_array_unref()
/// functions.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="free_segment">
/// if %TRUE the actual pointer array is freed as well
/// </param>
/// <return>
/// the pointer array if @free_segment is
///     %FALSE, otherwise %NULL. The pointer array should be freed using g_free().
/// </return>

	public static IntPtr Free(MentorLake.GLib.GPtrArrayHandle array, bool free_segment)
	{
		return GPtrArrayExterns.g_ptr_array_free(array, free_segment);
	}

/// <summary>
/// <para>
/// Inserts an element into the pointer array at the given index. The
/// array will grow in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="index_">
/// the index to place the new element at, or -1 to append
/// </param>
/// <param name="data">
/// the pointer to add.
/// </param>

	public static void Insert(MentorLake.GLib.GPtrArrayHandle array, int index_, IntPtr data)
	{
		GPtrArrayExterns.g_ptr_array_insert(array, index_, data);
	}

/// <summary>
/// <para>
/// Gets whether the @array was constructed as %NULL-terminated.
/// </para>
/// <para>
/// This will only return %TRUE for arrays constructed by passing %TRUE to the
/// `null_terminated` argument of g_ptr_array_new_null_terminated(). It will not
/// return %TRUE for normal arrays which have had a %NULL element appended to
/// them.
/// </para>
/// </summary>

/// <param name="array">
/// the #GPtrArray
/// </param>
/// <return>
/// %TRUE if the array is made to be %NULL terminated.
/// </return>

	public static bool IsNullTerminated(MentorLake.GLib.GPtrArrayHandle array)
	{
		return GPtrArrayExterns.g_ptr_array_is_null_terminated(array);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with a reference count of 1.
/// </para>
/// </summary>

/// <return>
/// the new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle New()
	{
		return GPtrArrayExterns.g_ptr_array_new();
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray, copying @len pointers from @data, and setting
/// the array’s reference count to 1.
/// </para>
/// <para>
/// This avoids having to manually add each element one by one.
/// </para>
/// <para>
/// If @copy_func is provided, then it is used to copy each element before
/// adding them to the new array. If it is %NULL then the pointers are copied
/// directly.
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of pointers,
/// or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of pointers in @data
/// </param>
/// <param name="copy_func">
/// a copy function used to copy every element in the
///   array or %NULL.
/// </param>
/// <param name="copy_func_user_data">
/// user data passed to @copy_func, or %NULL
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewFromArray(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_array(data, len, copy_func, copy_func_user_data, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray copying the pointers from @data after having
/// computed the length of it and with a reference count of 1.
/// This avoids having to manually add each element one by one.
/// If @copy_func is provided, then it is used to copy the data in the new
/// array.
/// It also set @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if the @data has more than %G_MAXUINT elements. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of
///   pointers, %NULL terminated; or %NULL for an empty array
/// </param>
/// <param name="copy_func">
/// a copy function used to copy every element in the
///   array or %NULL.
/// </param>
/// <param name="copy_func_user_data">
/// user data passed to @copy_func, or %NULL
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewFromNullTerminatedArray(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_from_null_terminated_array(data, copy_func, copy_func_user_data, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @reserved_size pointers preallocated
/// and a reference count of 1. This avoids frequent reallocation, if
/// you are going to add many pointers to the array. Note however that
/// the size of the array is still 0. It also set @element_free_func
/// for freeing each element when the array is destroyed either via
/// g_ptr_array_unref(), when g_ptr_array_free() is called with
/// @free_segment set to %TRUE or when removing elements.
/// </para>
/// </summary>

/// <param name="reserved_size">
/// number of pointers preallocated
/// </param>
/// <param name="element_free_func">
/// A function to free elements with
///     destroy @array or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewFull(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_full(reserved_size, element_free_func);
	}

/// <summary>
/// <para>
/// Like g_ptr_array_new_full() but also allows to set the array to
/// be %NULL terminated. A %NULL terminated pointer array has an
/// additional %NULL pointer after the last element, beyond the
/// current length.
/// </para>
/// <para>
/// #GPtrArray created by other constructors are not automatically %NULL
/// terminated.
/// </para>
/// <para>
/// Note that if the @array&apos;s length is zero and currently no
/// data array is allocated, then pdata will still be %NULL.
/// %GPtrArray will only %NULL terminate pdata, if an actual
/// array is allocated. It does not guarantee that an array
/// is always allocated. In other words, if the length is zero,
/// then pdata may either point to a %NULL terminated array of length
/// zero or be %NULL.
/// </para>
/// </summary>

/// <param name="reserved_size">
/// number of pointers preallocated.
///     If @null_terminated is %TRUE, the actually allocated
///     buffer size is @reserved_size plus 1, unless @reserved_size
///     is zero, in which case no initial buffer gets allocated.
/// </param>
/// <param name="element_free_func">
/// A function to free elements with
///     destroy @array or %NULL
/// </param>
/// <param name="null_terminated">
/// whether to make the array as %NULL terminated.
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewNullTerminated(uint reserved_size, MentorLake.GLib.GDestroyNotify element_free_func, bool null_terminated)
	{
		return GPtrArrayExterns.g_ptr_array_new_null_terminated(reserved_size, element_free_func, null_terminated);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @data as pointers, @len as length and a
/// reference count of 1.
/// </para>
/// <para>
/// This avoids having to copy such data manually.
/// After this call, @data belongs to the #GPtrArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of pointers,
///    or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of pointers in @data
/// </param>
/// <param name="element_free_func">
/// A function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewTake(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take(data, len, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @data as pointers, computing the length of it
/// and setting the reference count to 1.
/// </para>
/// <para>
/// This avoids having to copy such data manually.
/// After this call, @data belongs to the #GPtrArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// The length is calculated by iterating through @data until the first %NULL
/// element is found.
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if the @data length is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array
///  of pointers, %NULL terminated, or %NULL for an empty array
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewTakeNullTerminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_take_null_terminated(data, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with a reference count of 1 and use
/// @element_free_func for freeing each element when the array is destroyed
/// either via g_ptr_array_unref(), when g_ptr_array_free() is called with
/// @free_segment set to %TRUE or when removing elements.
/// </para>
/// </summary>

/// <param name="element_free_func">
/// A function to free elements with
///     destroy @array or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle NewWithFreeFunc(MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GPtrArrayExterns.g_ptr_array_new_with_free_func(element_free_func);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @array by one.
/// This function is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <return>
/// The passed in #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle Ref(MentorLake.GLib.GPtrArrayHandle array)
	{
		return GPtrArrayExterns.g_ptr_array_ref(array);
	}

/// <summary>
/// <para>
/// Removes the first occurrence of the given pointer from the pointer
/// array. The following elements are moved down one place. If @array
/// has a non-%NULL #GDestroyNotify function it is called for the
/// removed element.
/// </para>
/// <para>
/// It returns %TRUE if the pointer was removed, or %FALSE if the
/// pointer was not found.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="data">
/// the pointer to remove
/// </param>
/// <return>
/// %TRUE if the pointer is removed, %FALSE if the pointer
///     is not found in the array
/// </return>

	public static bool Remove(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove(array, data);
	}

/// <summary>
/// <para>
/// Removes the first occurrence of the given pointer from the pointer
/// array. The last element in the array is used to fill in the space,
/// so this function does not preserve the order of the array. But it
/// is faster than g_ptr_array_remove(). If @array has a non-%NULL
/// #GDestroyNotify function it is called for the removed element.
/// </para>
/// <para>
/// It returns %TRUE if the pointer was removed, or %FALSE if the
/// pointer was not found.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="data">
/// the pointer to remove
/// </param>
/// <return>
/// %TRUE if the pointer was found in the array
/// </return>

	public static bool RemoveFast(MentorLake.GLib.GPtrArrayHandle array, IntPtr data)
	{
		return GPtrArrayExterns.g_ptr_array_remove_fast(array, data);
	}

/// <summary>
/// <para>
/// Removes the pointer at the given index from the pointer array.
/// The following elements are moved down one place. If @array has
/// a non-%NULL #GDestroyNotify function it is called for the removed
/// element. If so, the return value from this function will potentially point
/// to freed memory (depending on the #GDestroyNotify implementation).
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="index_">
/// the index of the pointer to remove
/// </param>
/// <return>
/// the pointer which was removed
/// </return>

	public static IntPtr RemoveIndex(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index(array, index_);
	}

/// <summary>
/// <para>
/// Removes the pointer at the given index from the pointer array.
/// The last element in the array is used to fill in the space, so
/// this function does not preserve the order of the array. But it
/// is faster than g_ptr_array_remove_index(). If @array has a non-%NULL
/// #GDestroyNotify function it is called for the removed element. If so, the
/// return value from this function will potentially point to freed memory
/// (depending on the #GDestroyNotify implementation).
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="index_">
/// the index of the pointer to remove
/// </param>
/// <return>
/// the pointer which was removed
/// </return>

	public static IntPtr RemoveIndexFast(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_remove_index_fast(array, index_);
	}

/// <summary>
/// <para>
/// Removes the given number of pointers starting at the given index
/// from a #GPtrArray. The following elements are moved to close the
/// gap. If @array has a non-%NULL #GDestroyNotify function it is
/// called for the removed elements.
/// </para>
/// </summary>

/// <param name="array">
/// a @GPtrArray
/// </param>
/// <param name="index_">
/// the index of the first pointer to remove
/// </param>
/// <param name="length">
/// the number of pointers to remove
/// </param>
/// <return>
/// the @array
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle RemoveRange(MentorLake.GLib.GPtrArrayHandle array, uint index_, uint length)
	{
		return GPtrArrayExterns.g_ptr_array_remove_range(array, index_, length);
	}

/// <summary>
/// <para>
/// Sets a function for freeing each element when @array is destroyed
/// either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// </summary>

/// <param name="array">
/// A #GPtrArray
/// </param>
/// <param name="element_free_func">
/// A function to free elements with
///     destroy @array or %NULL
/// </param>

	public static void SetFreeFunc(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		GPtrArrayExterns.g_ptr_array_set_free_func(array, element_free_func);
	}

/// <summary>
/// <para>
/// Sets the size of the array. When making the array larger,
/// newly-added elements will be set to %NULL. When making it smaller,
/// if @array has a non-%NULL #GDestroyNotify function then it will be
/// called for the removed elements.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="length">
/// the new length of the pointer array
/// </param>

	public static void SetSize(MentorLake.GLib.GPtrArrayHandle array, int length)
	{
		GPtrArrayExterns.g_ptr_array_set_size(array, length);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @reserved_size pointers preallocated
/// and a reference count of 1. This avoids frequent reallocation, if
/// you are going to add many pointers to the array. Note however that
/// the size of the array is still 0.
/// </para>
/// </summary>

/// <param name="reserved_size">
/// number of pointers preallocated
/// </param>
/// <return>
/// the new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle SizedNew(uint reserved_size)
	{
		return GPtrArrayExterns.g_ptr_array_sized_new(reserved_size);
	}

/// <summary>
/// <para>
/// Sorts the array, using @compare_func which should be a qsort()-style
/// comparison function (returns less than zero for first arg is less
/// than second arg, zero for equal, greater than zero if first arg is
/// greater than second arg).
/// </para>
/// <para>
/// Note that the comparison function for g_ptr_array_sort() doesn&apos;t
/// take the pointers from the array as arguments, it takes pointers to
/// the pointers in the array.
/// </para>
/// <para>
/// Use g_ptr_array_sort_values() if you want to use normal
/// #GCompareFuncs, otherwise here is a full example of use:
/// </para>
/// <code>
/// typedef struct
/// typedef struct
/// {
///   gchar *name;
///   gint size;
/// } FileListEntry;
/// 
/// static gint
/// sort_filelist (gconstpointer a, gconstpointer b)
/// {
///   const FileListEntry *entry1 = *((FileListEntry **) a);
///   const FileListEntry *entry2 = *((FileListEntry **) b);
/// 
///   return g_ascii_strcasecmp (entry1-&amp;gt;name, entry2-&amp;gt;name);
/// }
/// 
/// …
/// g_autoptr (GPtrArray) file_list = NULL;
/// 
/// // initialize file_list array and load with many FileListEntry entries
/// ...
/// // now sort it with
/// g_ptr_array_sort (file_list, sort_filelist);
/// </code>
/// <para>
/// This is guaranteed to be a stable sort since version 2.32.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>

	public static void Sort(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort(array, compare_func);
	}

/// <summary>
/// <para>
/// Sorts the array, using @compare_func which should be a qsort()-style
/// comparison function (returns less than zero for first arg is less
/// than second arg, zero for equal, greater than zero if first arg is
/// greater than second arg).
/// </para>
/// <para>
/// This is guaranteed to be a stable sort.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="compare_func">
/// a #GCompareFunc comparison function
/// </param>

	public static void SortValues(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GPtrArrayExterns.g_ptr_array_sort_values(array, compare_func);
	}

/// <summary>
/// <para>
/// Like g_ptr_array_sort_values(), but the comparison function has an extra
/// user data argument.
/// </para>
/// <para>
/// This is guaranteed to be a stable sort.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="compare_func">
/// a #GCompareDataFunc comparison function
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void SortValuesWithData(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_values_with_data(array, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Like g_ptr_array_sort(), but the comparison function has an extra
/// user data argument.
/// </para>
/// <para>
/// Note that the comparison function for g_ptr_array_sort_with_data()
/// doesn&apos;t take the pointers from the array as arguments, it takes
/// pointers to the pointers in the array.
/// </para>
/// <para>
/// Use g_ptr_array_sort_values_with_data() if you want to use normal
/// #GCompareDataFuncs, otherwise here is a full example of use:
/// </para>
/// <code>
/// typedef enum { SORT_NAME, SORT_SIZE } SortMode;
/// typedef enum { SORT_NAME, SORT_SIZE } SortMode;
/// 
/// typedef struct
/// {
///   gchar *name;
///   gint size;
/// } FileListEntry;
/// 
/// static gint
/// sort_filelist (gconstpointer a, gconstpointer b, gpointer user_data)
/// {
///   gint order;
///   const SortMode sort_mode = GPOINTER_TO_INT (user_data);
///   const FileListEntry *entry1 = *((FileListEntry **) a);
///   const FileListEntry *entry2 = *((FileListEntry **) b);
/// 
///   switch (sort_mode)
///     {
///     case SORT_NAME:
///       order = g_ascii_strcasecmp (entry1-&amp;gt;name, entry2-&amp;gt;name);
///       break;
///     case SORT_SIZE:
///       order = entry1-&amp;gt;size - entry2-&amp;gt;size;
///       break;
///     default:
///       order = 0;
///       break;
///     }
///   return order;
/// }
/// 
/// ...
/// g_autoptr (GPtrArray) file_list = NULL;
/// SortMode sort_mode;
/// 
/// // initialize file_list array and load with many FileListEntry entries
/// ...
/// // now sort it with
/// sort_mode = SORT_NAME;
/// g_ptr_array_sort_with_data (file_list,
///                             sort_filelist,
///                             GINT_TO_POINTER (sort_mode));
/// </code>
/// <para>
/// This is guaranteed to be a stable sort since version 2.32.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void SortWithData(MentorLake.GLib.GPtrArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GPtrArrayExterns.g_ptr_array_sort_with_data(array, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Frees the data in the array and resets the size to zero, while
/// the underlying array is preserved for use elsewhere and returned
/// to the caller.
/// </para>
/// <para>
/// Note that if the array is %NULL terminated this may still return
/// %NULL if the length of the array was zero and pdata was not yet
/// allocated.
/// </para>
/// <para>
/// Even if set, the #GDestroyNotify function will never be called
/// on the current contents of the array and the caller is
/// responsible for freeing the array elements.
/// </para>
/// <para>
/// An example of use:
/// <code>
/// g_autoptr(GPtrArray) chunk_buffer = g_ptr_array_new_with_free_func (g_bytes_unref);
/// g_autoptr(GPtrArray) chunk_buffer = g_ptr_array_new_with_free_func (g_bytes_unref);
/// 
/// // Some part of your application appends a number of chunks to the pointer array.
/// g_ptr_array_add (chunk_buffer, g_bytes_new_static (&quot;hello&quot;, 5));
/// g_ptr_array_add (chunk_buffer, g_bytes_new_static (&quot;world&quot;, 5));
/// 
/// …
/// 
/// // Periodically, the chunks need to be sent as an array-and-length to some
/// // other part of the program.
/// GBytes **chunks;
/// gsize n_chunks;
/// 
/// chunks = g_ptr_array_steal (chunk_buffer, &amp;n_chunks);
/// for (gsize i = 0; i &amp;lt; n_chunks; i++)
///   {
///     // Do something with each chunk here, and then free them, since
///     // g_ptr_array_steal() transfers ownership of all the elements and the
///     // array to the caller.
///     …
/// 
///     g_bytes_unref (chunks[i]);
///   }
/// 
/// g_free (chunks);
/// 
/// // After calling g_ptr_array_steal(), the pointer array can be reused for the
/// // next set of chunks.
/// g_assert (chunk_buffer-&amp;gt;len == 0);
/// </code>
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray.
/// </param>
/// <param name="len">
/// pointer to retrieve the number of
///    elements of the original array
/// </param>
/// <return>
/// the element data, which should be
///     freed using g_free(). This may be %NULL if the array doesn’t have any
///     elements (i.e. if `*len` is zero).
/// </return>

	public static IntPtr Steal(MentorLake.GLib.GPtrArrayHandle array, out UIntPtr len)
	{
		return GPtrArrayExterns.g_ptr_array_steal(array, out len);
	}

/// <summary>
/// <para>
/// Removes the pointer at the given index from the pointer array.
/// The following elements are moved down one place. The #GDestroyNotify for
/// @array is *not* called on the removed element; ownership is transferred to
/// the caller of this function.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="index_">
/// the index of the pointer to steal
/// </param>
/// <return>
/// the pointer which was removed
/// </return>

	public static IntPtr StealIndex(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index(array, index_);
	}

/// <summary>
/// <para>
/// Removes the pointer at the given index from the pointer array.
/// The last element in the array is used to fill in the space, so
/// this function does not preserve the order of the array. But it
/// is faster than g_ptr_array_steal_index(). The #GDestroyNotify for @array is
/// *not* called on the removed element; ownership is transferred to the caller
/// of this function.
/// </para>
/// </summary>

/// <param name="array">
/// a #GPtrArray
/// </param>
/// <param name="index_">
/// the index of the pointer to steal
/// </param>
/// <return>
/// the pointer which was removed
/// </return>

	public static IntPtr StealIndexFast(MentorLake.GLib.GPtrArrayHandle array, uint index_)
	{
		return GPtrArrayExterns.g_ptr_array_steal_index_fast(array, index_);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @array by one. If the
/// reference count drops to 0, the effect is the same as calling
/// g_ptr_array_free() with @free_segment set to %TRUE. This function
/// is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GPtrArray
/// </param>

	public static void Unref(MentorLake.GLib.GPtrArrayHandle array)
	{
		GPtrArrayExterns.g_ptr_array_unref(array);
	}

}
