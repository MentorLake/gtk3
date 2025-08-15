namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GSequence struct is an opaque data type representing a
/// [sequence][glib-Sequences] data type.
/// </para>
/// </summary>

public class GSequenceHandle : BaseSafeHandle
{
}


public static class GSequenceExtensions
{
/// <summary>
/// <para>
/// Adds a new item to the end of @seq.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// the data for the new item
/// </param>
/// <return>
/// an iterator pointing to the new item
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Append(this MentorLake.GLib.GSequenceHandle seq, IntPtr data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_append(seq, data);
	}

/// <summary>
/// <para>
/// Calls @func for each item in the sequence passing @user_data
/// to the function. @func must not modify the sequence itself.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="func">
/// the function to call for each item in @seq
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void Foreach(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_foreach(seq, func, user_data);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for @seq. If @seq has a data destroy
/// function associated with it, that function is called on all items
/// in @seq.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>

	public static void Free(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_free(seq);
	}

/// <summary>
/// <para>
/// Returns the begin iterator for @seq.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <return>
/// the begin iterator for @seq.
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle GetBeginIter(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_begin_iter(seq);
	}

/// <summary>
/// <para>
/// Returns the end iterator for @seg
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <return>
/// the end iterator for @seq
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle GetEndIter(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_end_iter(seq);
	}

/// <summary>
/// <para>
/// Returns the iterator at position @pos. If @pos is negative or larger
/// than the number of items in @seq, the end iterator is returned.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="pos">
/// a position in @seq, or -1 for the end
/// </param>
/// <return>
/// The #GSequenceIter at position @pos
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle GetIterAtPos(this MentorLake.GLib.GSequenceHandle seq, int pos)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_iter_at_pos(seq, pos);
	}

/// <summary>
/// <para>
/// Returns the positive length (&amp;gt;= 0) of @seq. Note that this method is
/// O(h) where `h&apos; is the height of the tree. It is thus more efficient
/// to use g_sequence_is_empty() when comparing the length to zero.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <return>
/// the length of @seq
/// </return>

	public static int GetLength(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_get_length(seq);
	}

/// <summary>
/// <para>
/// Inserts @data into @seq using @cmp_func to determine the new
/// position. The sequence must already be sorted according to @cmp_func;
/// otherwise the new position of @data is undefined.
/// </para>
/// <para>
/// @cmp_func is called with two items of the @seq, and @cmp_data.
/// It should return 0 if the items are equal, a negative value
/// if the first item comes before the second, and a positive value
/// if the second item comes before the first.
/// </para>
/// <para>
/// Note that when adding a large amount of data to a #GSequence,
/// it is more efficient to do unsorted insertions and then call
/// g_sequence_sort() or g_sequence_sort_iter().
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// the data to insert
/// </param>
/// <param name="cmp_func">
/// the function used to compare items in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func.
/// </param>
/// <return>
/// a #GSequenceIter pointing to the new item.
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle InsertSorted(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_insert_sorted(seq, data, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_insert_sorted(), but uses
/// a #GSequenceIterCompareFunc instead of a #GCompareDataFunc as
/// the compare function.
/// </para>
/// <para>
/// @iter_cmp is called with two iterators pointing into @seq.
/// It should return 0 if the iterators are equal, a negative
/// value if the first iterator comes before the second, and a
/// positive value if the second iterator comes before the first.
/// </para>
/// <para>
/// Note that when adding a large amount of data to a #GSequence,
/// it is more efficient to do unsorted insertions and then call
/// g_sequence_sort() or g_sequence_sort_iter().
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// data for the new item
/// </param>
/// <param name="iter_cmp">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @iter_cmp
/// </param>
/// <return>
/// a #GSequenceIter pointing to the new item
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle InsertSortedIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_insert_sorted_iter(seq, data, iter_cmp, cmp_data);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the sequence contains zero items.
/// </para>
/// <para>
/// This function is functionally identical to checking the result of
/// g_sequence_get_length() being equal to zero. However this function is
/// implemented in O(1) running time.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <return>
/// %TRUE if the sequence is empty, otherwise %FALSE.
/// </return>

	public static bool IsEmpty(this MentorLake.GLib.GSequenceHandle seq)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_is_empty(seq);
	}

/// <summary>
/// <para>
/// Returns an iterator pointing to the position of the first item found
/// equal to @data according to @cmp_func and @cmp_data. If more than one
/// item is equal, it is not guaranteed that it is the first which is
/// returned. In that case, you can use g_sequence_iter_next() and
/// g_sequence_iter_prev() to get others.
/// </para>
/// <para>
/// @cmp_func is called with two items of the @seq, and @cmp_data.
/// It should return 0 if the items are equal, a negative value if
/// the first item comes before the second, and a positive value if
/// the second item comes before the first.
/// </para>
/// <para>
/// This function will fail if the data contained in the sequence is
/// unsorted.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// data to look up
/// </param>
/// <param name="cmp_func">
/// the function used to compare items in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>
/// <return>
/// an #GSequenceIter pointing to the position of the
///     first item found equal to @data according to @cmp_func and
///     @cmp_data, or %NULL if no such item exists
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Lookup(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_lookup(seq, data, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_lookup(), but uses a #GSequenceIterCompareFunc
/// instead of a #GCompareDataFunc as the compare function.
/// </para>
/// <para>
/// @iter_cmp is called with two iterators pointing into @seq.
/// It should return 0 if the iterators are equal, a negative value
/// if the first iterator comes before the second, and a positive
/// value if the second iterator comes before the first.
/// </para>
/// <para>
/// This function will fail if the data contained in the sequence is
/// unsorted.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// data to look up
/// </param>
/// <param name="iter_cmp">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @iter_cmp
/// </param>
/// <return>
/// an #GSequenceIter pointing to the position of
///     the first item found equal to @data according to @iter_cmp
///     and @cmp_data, or %NULL if no such item exists
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle LookupIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_lookup_iter(seq, data, iter_cmp, cmp_data);
	}

/// <summary>
/// <para>
/// Adds a new item to the front of @seq
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// the data for the new item
/// </param>
/// <return>
/// an iterator pointing to the new item
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Prepend(this MentorLake.GLib.GSequenceHandle seq, IntPtr data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_prepend(seq, data);
	}

/// <summary>
/// <para>
/// Returns an iterator pointing to the position where @data would
/// be inserted according to @cmp_func and @cmp_data.
/// </para>
/// <para>
/// @cmp_func is called with two items of the @seq, and @cmp_data.
/// It should return 0 if the items are equal, a negative value if
/// the first item comes before the second, and a positive value if
/// the second item comes before the first.
/// </para>
/// <para>
/// If you are simply searching for an existing element of the sequence,
/// consider using g_sequence_lookup().
/// </para>
/// <para>
/// This function will fail if the data contained in the sequence is
/// unsorted.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// data for the new item
/// </param>
/// <param name="cmp_func">
/// the function used to compare items in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>
/// <return>
/// an #GSequenceIter pointing to the position where @data
///     would have been inserted according to @cmp_func and @cmp_data
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle Search(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_search(seq, data, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_search(), but uses a #GSequenceIterCompareFunc
/// instead of a #GCompareDataFunc as the compare function.
/// </para>
/// <para>
/// @iter_cmp is called with two iterators pointing into @seq.
/// It should return 0 if the iterators are equal, a negative value
/// if the first iterator comes before the second, and a positive
/// value if the second iterator comes before the first.
/// </para>
/// <para>
/// If you are simply searching for an existing element of the sequence,
/// consider using g_sequence_lookup_iter().
/// </para>
/// <para>
/// This function will fail if the data contained in the sequence is
/// unsorted.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="data">
/// data for the new item
/// </param>
/// <param name="iter_cmp">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @iter_cmp
/// </param>
/// <return>
/// a #GSequenceIter pointing to the position in @seq
///     where @data would have been inserted according to @iter_cmp
///     and @cmp_data
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle SearchIter(this MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		return GSequenceExterns.g_sequence_search_iter(seq, data, iter_cmp, cmp_data);
	}

/// <summary>
/// <para>
/// Sorts @seq using @cmp_func.
/// </para>
/// <para>
/// @cmp_func is passed two items of @seq and should
/// return 0 if they are equal, a negative value if the
/// first comes before the second, and a positive value
/// if the second comes before the first.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="cmp_func">
/// the function used to sort the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>

	public static void Sort(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_sort(seq, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_sort(), but uses a #GSequenceIterCompareFunc instead
/// of a #GCompareDataFunc as the compare function
/// </para>
/// <para>
/// @cmp_func is called with two iterators pointing into @seq. It should
/// return 0 if the iterators are equal, a negative value if the first
/// iterator comes before the second, and a positive value if the second
/// iterator comes before the first.
/// </para>
/// </summary>

/// <param name="seq">
/// a #GSequence
/// </param>
/// <param name="cmp_func">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>

	public static void SortIter(this MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GSequenceIterCompareFunc cmp_func, IntPtr cmp_data)
	{
		if (seq.IsInvalid) throw new Exception("Invalid handle (GSequence)");
		GSequenceExterns.g_sequence_sort_iter(seq, cmp_func, cmp_data);
	}


	public static GSequence Dereference(this GSequenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSequence>(x.DangerousGetHandle());
}
internal class GSequenceExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_begin_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_end_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_get_iter_at_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, int pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_sorted_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_lookup_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_search_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, IntPtr data, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))] MentorLake.GLib.GSequenceHandle seq, MentorLake.GLib.GSequenceIterCompareFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_sequence_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))]
	internal static extern MentorLake.GLib.GSequenceHandle g_sequence_new(MentorLake.GLib.GDestroyNotify data_destroy);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_range_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

}

/// <summary>
/// <para>
/// The #GSequence struct is an opaque data type representing a
/// [sequence][glib-Sequences] data type.
/// </para>
/// </summary>

public struct GSequence
{
/// <summary>
/// <para>
/// Calls @func for each item in the range (@begin, @end) passing
/// @user_data to the function. @func must not modify the sequence
/// itself.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>
/// <param name="func">
/// a #GFunc
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void ForeachRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GSequenceExterns.g_sequence_foreach_range(begin, end, func, user_data);
	}

/// <summary>
/// <para>
/// Returns the data that @iter points to.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// the data that @iter points to
/// </return>

	public static IntPtr Get(MentorLake.GLib.GSequenceIterHandle iter)
	{
		return GSequenceExterns.g_sequence_get(iter);
	}

/// <summary>
/// <para>
/// Inserts a new item just before the item pointed to by @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="data">
/// the data for the new item
/// </param>
/// <return>
/// an iterator pointing to the new item
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle InsertBefore(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		return GSequenceExterns.g_sequence_insert_before(iter, data);
	}

/// <summary>
/// <para>
/// Moves the item pointed to by @src to the position indicated by @dest.
/// After calling this function @dest will point to the position immediately
/// after @src. It is allowed for @src and @dest to point into different
/// sequences.
/// </para>
/// </summary>

/// <param name="src">
/// a #GSequenceIter pointing to the item to move
/// </param>
/// <param name="dest">
/// a #GSequenceIter pointing to the position to which
///     the item is moved
/// </param>

	public static void Move(MentorLake.GLib.GSequenceIterHandle src, MentorLake.GLib.GSequenceIterHandle dest)
	{
		GSequenceExterns.g_sequence_move(src, dest);
	}

/// <summary>
/// <para>
/// Inserts the (@begin, @end) range at the destination pointed to by @dest.
/// The @begin and @end iters must point into the same sequence. It is
/// allowed for @dest to point to a different sequence than the one pointed
/// into by @begin and @end.
/// </para>
/// <para>
/// If @dest is %NULL, the range indicated by @begin and @end is
/// removed from the sequence. If @dest points to a place within
/// the (@begin, @end) range, the range does not move.
/// </para>
/// </summary>

/// <param name="dest">
/// a #GSequenceIter
/// </param>
/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>

	public static void MoveRange(MentorLake.GLib.GSequenceIterHandle dest, MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_move_range(dest, begin, end);
	}

/// <summary>
/// <para>
/// Creates a new GSequence. The @data_destroy function, if non-%NULL will
/// be called on all items when the sequence is destroyed and on items that
/// are removed from the sequence.
/// </para>
/// </summary>

/// <param name="data_destroy">
/// a #GDestroyNotify function, or %NULL
/// </param>
/// <return>
/// a new #GSequence
/// </return>

	public static MentorLake.GLib.GSequenceHandle New(MentorLake.GLib.GDestroyNotify data_destroy)
	{
		return GSequenceExterns.g_sequence_new(data_destroy);
	}

/// <summary>
/// <para>
/// Finds an iterator somewhere in the range (@begin, @end). This
/// iterator will be close to the middle of the range, but is not
/// guaranteed to be exactly in the middle.
/// </para>
/// <para>
/// The @begin and @end iterators must both point to the same sequence
/// and @begin must come before or be equal to @end in the sequence.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>
/// <return>
/// a #GSequenceIter pointing somewhere in the
///    (@begin, @end) range
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle RangeGetMidpoint(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		return GSequenceExterns.g_sequence_range_get_midpoint(begin, end);
	}

/// <summary>
/// <para>
/// Removes the item pointed to by @iter. It is an error to pass the
/// end iterator to this function.
/// </para>
/// <para>
/// If the sequence has a data destroy function associated with it, this
/// function is called on the data for the removed item.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>

	public static void Remove(MentorLake.GLib.GSequenceIterHandle iter)
	{
		GSequenceExterns.g_sequence_remove(iter);
	}

/// <summary>
/// <para>
/// Removes all items in the (@begin, @end) range.
/// </para>
/// <para>
/// If the sequence has a data destroy function associated with it, this
/// function is called on the data for the removed items.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>

	public static void RemoveRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GSequenceExterns.g_sequence_remove_range(begin, end);
	}

/// <summary>
/// <para>
/// Changes the data for the item pointed to by @iter to be @data. If
/// the sequence has a data destroy function associated with it, that
/// function is called on the existing data that @iter pointed to.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="data">
/// new data for the item
/// </param>

	public static void Set(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		GSequenceExterns.g_sequence_set(iter, data);
	}

/// <summary>
/// <para>
/// Moves the data pointed to by @iter to a new position as indicated by
/// @cmp_func. This
/// function should be called for items in a sequence already sorted according
/// to @cmp_func whenever some aspect of an item changes so that @cmp_func
/// may return different values for that item.
/// </para>
/// <para>
/// @cmp_func is called with two items of the @seq, and @cmp_data.
/// It should return 0 if the items are equal, a negative value if
/// the first item comes before the second, and a positive value if
/// the second item comes before the first.
/// </para>
/// </summary>

/// <param name="iter">
/// A #GSequenceIter
/// </param>
/// <param name="cmp_func">
/// the function used to compare items in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func.
/// </param>

	public static void SortChanged(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_sort_changed(), but uses
/// a #GSequenceIterCompareFunc instead of a #GCompareDataFunc as
/// the compare function.
/// </para>
/// <para>
/// @iter_cmp is called with two iterators pointing into the #GSequence that
/// @iter points into. It should
/// return 0 if the iterators are equal, a negative value if the first
/// iterator comes before the second, and a positive value if the second
/// iterator comes before the first.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="iter_cmp">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>

	public static void SortChangedIter(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		GSequenceExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
	}

/// <summary>
/// <para>
/// Swaps the items pointed to by @a and @b. It is allowed for @a and @b
/// to point into difference sequences.
/// </para>
/// </summary>

/// <param name="a">
/// a #GSequenceIter
/// </param>
/// <param name="b">
/// a #GSequenceIter
/// </param>

	public static void Swap(MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		GSequenceExterns.g_sequence_swap(a, b);
	}

}
