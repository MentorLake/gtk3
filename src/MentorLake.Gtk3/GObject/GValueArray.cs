namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A `GValueArray` is a container structure to hold an array of generic values.
/// </para>
/// <para>
/// The prime purpose of a `GValueArray` is for it to be used as an
/// object property that holds an array of values. A `GValueArray` wraps
/// an array of `GValue` elements in order for it to be used as a boxed
/// type through `G_TYPE_VALUE_ARRAY`.
/// </para>
/// <para>
/// `GValueArray` is deprecated in favour of `GArray` since GLib 2.32.
/// It is possible to create a `GArray` that behaves like a `GValueArray`
/// by using the size of `GValue` as the element size, and by setting
/// [method@GObject.Value.unset] as the clear function using
/// [func@GLib.Array.set_clear_func], for instance, the following code:
/// </para>
/// <para>
/// ```c
///   GValueArray *array = g_value_array_new (10);
/// ```
/// </para>
/// <para>
/// can be replaced by:
/// </para>
/// <para>
/// ```c
///   GArray *array = g_array_sized_new (FALSE, TRUE, sizeof (GValue), 10);
///   g_array_set_clear_func (array, (GDestroyNotify) g_value_unset);
/// ```
/// </para>
/// </summary>

public class GValueArrayHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocate and initialize a new #GValueArray, optionally preserve space
/// for @n_prealloced elements. New arrays always contain 0 elements,
/// regardless of the value of @n_prealloced.
/// </para>
/// </summary>

/// <param name="n_prealloced">
/// number of values to preallocate space for
/// </param>
/// <return>
/// a newly allocated #GValueArray with 0 values
/// </return>

	public static MentorLake.GObject.GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}

}


public static class GValueArrayExtensions
{
/// <summary>
/// <para>
/// Insert a copy of @value as last element of @value_array. If @value is
/// %NULL, an uninitialized value is appended.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to add an element to
/// </param>
/// <param name="value">
/// #GValue to copy into #GValueArray, or %NULL
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Append(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GObject.GValueHandle value)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_append(value_array, value);
	}

/// <summary>
/// <para>
/// Construct an exact copy of a #GValueArray by duplicating all its
/// contents.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to copy
/// </param>
/// <return>
/// Newly allocated copy of #GValueArray
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Copy(this MentorLake.GObject.GValueArrayHandle value_array)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_copy(value_array);
	}

/// <summary>
/// <para>
/// Free a #GValueArray including its contents.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to free
/// </param>

	public static void Free(this MentorLake.GObject.GValueArrayHandle value_array)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		GValueArrayExterns.g_value_array_free(value_array);
	}

/// <summary>
/// <para>
/// Return a pointer to the value at @index_ contained in @value_array.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to get a value from
/// </param>
/// <param name="index_">
/// index of the value of interest
/// </param>
/// <return>
/// pointer to a value at @index_ in @value_array
/// </return>

	public static MentorLake.GObject.GValueHandle GetNth(this MentorLake.GObject.GValueArrayHandle value_array, uint index_)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_get_nth(value_array, index_);
	}

/// <summary>
/// <para>
/// Insert a copy of @value at specified position into @value_array. If @value
/// is %NULL, an uninitialized value is inserted.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to add an element to
/// </param>
/// <param name="index_">
/// insertion position, must be <= value_array->;n_values
/// </param>
/// <param name="value">
/// #GValue to copy into #GValueArray, or %NULL
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Insert(this MentorLake.GObject.GValueArrayHandle value_array, uint index_, MentorLake.GObject.GValueHandle value)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_insert(value_array, index_, value);
	}

/// <summary>
/// <para>
/// Insert a copy of @value as first element of @value_array. If @value is
/// %NULL, an uninitialized value is prepended.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to add an element to
/// </param>
/// <param name="value">
/// #GValue to copy into #GValueArray, or %NULL
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Prepend(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GObject.GValueHandle value)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_prepend(value_array, value);
	}

/// <summary>
/// <para>
/// Remove the value at position @index_ from @value_array.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to remove an element from
/// </param>
/// <param name="index_">
/// position of value to remove, which must be less than
///     @value_array->n_values
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Remove(this MentorLake.GObject.GValueArrayHandle value_array, uint index_)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_remove(value_array, index_);
	}

/// <summary>
/// <para>
/// Sort @value_array using @compare_func to compare the elements according to
/// the semantics of #GCompareFunc.
/// </para>
/// <para>
/// The current implementation uses the same sorting algorithm as standard
/// C qsort() function.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to sort
/// </param>
/// <param name="compare_func">
/// function to compare elements
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle Sort(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareFunc compare_func)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_sort(value_array, compare_func);
	}

/// <summary>
/// <para>
/// Sort @value_array using @compare_func to compare the elements according
/// to the semantics of #GCompareDataFunc.
/// </para>
/// <para>
/// The current implementation uses the same sorting algorithm as standard
/// C qsort() function.
/// </para>
/// </summary>

/// <param name="value_array">
/// #GValueArray to sort
/// </param>
/// <param name="compare_func">
/// function to compare elements
/// </param>
/// <param name="user_data">
/// extra data argument provided for @compare_func
/// </param>
/// <return>
/// the #GValueArray passed in as @value_array
/// </return>

	public static MentorLake.GObject.GValueArrayHandle SortWithData(this MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		if (value_array.IsInvalid) throw new Exception("Invalid handle (GValueArray)");
		return GValueArrayExterns.g_value_array_sort_with_data(value_array, compare_func, user_data);
	}


	public static GValueArray Dereference(this GValueArrayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GValueArray>(x.DangerousGetHandle());
}
internal class GValueArrayExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_new(uint n_prealloced);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_value_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))]
	internal static extern MentorLake.GObject.GValueHandle g_value_array_get_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, uint index_);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))]
	internal static extern MentorLake.GObject.GValueArrayHandle g_value_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueArrayHandle>))] MentorLake.GObject.GValueArrayHandle value_array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

/// <summary>
/// <para>
/// A `GValueArray` is a container structure to hold an array of generic values.
/// </para>
/// <para>
/// The prime purpose of a `GValueArray` is for it to be used as an
/// object property that holds an array of values. A `GValueArray` wraps
/// an array of `GValue` elements in order for it to be used as a boxed
/// type through `G_TYPE_VALUE_ARRAY`.
/// </para>
/// <para>
/// `GValueArray` is deprecated in favour of `GArray` since GLib 2.32.
/// It is possible to create a `GArray` that behaves like a `GValueArray`
/// by using the size of `GValue` as the element size, and by setting
/// [method@GObject.Value.unset] as the clear function using
/// [func@GLib.Array.set_clear_func], for instance, the following code:
/// </para>
/// <para>
/// ```c
///   GValueArray *array = g_value_array_new (10);
/// ```
/// </para>
/// <para>
/// can be replaced by:
/// </para>
/// <para>
/// ```c
///   GArray *array = g_array_sized_new (FALSE, TRUE, sizeof (GValue), 10);
///   g_array_set_clear_func (array, (GDestroyNotify) g_value_unset);
/// ```
/// </para>
/// </summary>

public struct GValueArray
{
	/// <summary>
/// <para>
/// number of values contained in the array
/// </para>
/// </summary>

public uint n_values;
	/// <summary>
/// <para>
/// array of values
/// </para>
/// </summary>

public IntPtr values;
}
