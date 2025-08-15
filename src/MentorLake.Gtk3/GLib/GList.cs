namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GList struct is used for each element in a doubly-linked list.
/// </para>
/// </summary>

public class GListHandle : BaseSafeHandle
{
}


public static class GListExtensions
{

	public static GList Dereference(this GListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GList>(x.DangerousGetHandle());
}
internal class GListExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_alloc();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_concat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_delete_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_find_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free_1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_free_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_list_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, int position);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_before_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_insert_sorted_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_list_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_list_nth_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_nth_prev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_list_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle llink);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_remove_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle llink);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_list_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

/// <summary>
/// <para>
/// The #GList struct is used for each element in a doubly-linked list.
/// </para>
/// </summary>

public struct GList
{
	/// <summary>
/// <para>
/// holds the element&apos;s data, which can be a pointer to any kind
///        of data, or any integer value using the
///        [Type Conversion Macros][glib-Type-Conversion-Macros]
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// contains the link to the next element in the list
/// </para>
/// </summary>

public IntPtr next;
	/// <summary>
/// <para>
/// contains the link to the previous element in the list
/// </para>
/// </summary>

public IntPtr prev;
/// <summary>
/// <para>
/// Allocates space for one #GList element. It is called by
/// g_list_append(), g_list_prepend(), g_list_insert() and
/// g_list_insert_sorted() and so is rarely used on its own.
/// </para>
/// </summary>

/// <return>
/// a pointer to the newly-allocated #GList element
/// </return>

	public static MentorLake.GLib.GListHandle Alloc()
	{
		return GListExterns.g_list_alloc();
	}

/// <summary>
/// <para>
/// Adds a new element on to the end of the list.
/// </para>
/// <para>
/// Note that the return value is the new start of the list,
/// if @list was empty; make sure you store the new value.
/// </para>
/// <para>
/// g_list_append() has to traverse the entire list to find the end,
/// which is inefficient when adding multiple elements. A common idiom
/// to avoid the inefficiency is to use g_list_prepend() and reverse
/// the list with g_list_reverse() when all elements have been added.
/// </para>
/// <code>
/// // Notice that these are initialized to the empty list.
/// // Notice that these are initialized to the empty list.
/// GList *string_list = NULL, *number_list = NULL;
/// 
/// // This is a list of strings.
/// string_list = g_list_append (string_list, &quot;first&quot;);
/// string_list = g_list_append (string_list, &quot;second&quot;);
/// 
/// // This is a list of integers.
/// number_list = g_list_append (number_list, GINT_TO_POINTER (27));
/// number_list = g_list_append (number_list, GINT_TO_POINTER (14));
/// </code>
/// </summary>

/// <param name="list">
/// a pointer to a #GList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <return>
/// either @list or the new start of the #GList if @list was %NULL
/// </return>

	public static MentorLake.GLib.GListHandle Append(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_append(list, data);
	}

/// <summary>
/// <para>
/// Adds the second #GList onto the end of the first #GList.
/// Note that the elements of the second #GList are not copied.
/// They are used directly.
/// </para>
/// <para>
/// This function is for example used to move an element in the list.
/// The following example moves an element to the top of the list:
/// <code>
/// list = g_list_remove_link (list, llink);
/// list = g_list_remove_link (list, llink);
/// list = g_list_concat (llink, list);
/// </code>
/// </para>
/// </summary>

/// <param name="list1">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="list2">
/// the #GList to add to the end of the first #GList,
///     this must point  to the top of the list
/// </param>
/// <return>
/// the start of the new #GList, which equals @list1 if not %NULL
/// </return>

	public static MentorLake.GLib.GListHandle Concat(MentorLake.GLib.GListHandle list1, MentorLake.GLib.GListHandle list2)
	{
		return GListExterns.g_list_concat(list1, list2);
	}

/// <summary>
/// <para>
/// Copies a #GList.
/// </para>
/// <para>
/// Note that this is a &quot;shallow&quot; copy. If the list elements
/// consist of pointers to data, the pointers are copied but
/// the actual data is not. See g_list_copy_deep() if you need
/// to copy the data as well.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <return>
/// the start of the new list that holds the same data as @list
/// </return>

	public static MentorLake.GLib.GListHandle Copy(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_copy(list);
	}

/// <summary>
/// <para>
/// Makes a full (deep) copy of a #GList.
/// </para>
/// <para>
/// In contrast with g_list_copy(), this function uses @func to make
/// a copy of each list element, in addition to copying the list
/// container itself.
/// </para>
/// <para>
/// @func, as a #GCopyFunc, takes two arguments, the data to be copied
/// and a @user_data pointer. On common processor architectures, it&apos;s safe to
/// pass %NULL as @user_data if the copy function takes only one argument. You
/// may get compiler warnings from this though if compiling with GCC’s
/// `-Wcast-function-type` warning.
/// </para>
/// <para>
/// For instance, if @list holds a list of GObjects, you can do:
/// <code>
/// another_list = g_list_copy_deep (list, (GCopyFunc) g_object_ref, NULL);
/// another_list = g_list_copy_deep (list, (GCopyFunc) g_object_ref, NULL);
/// </code>
/// And, to entirely free the new list, you could do:
/// <code>
/// g_list_free_full (another_list, g_object_unref);
/// g_list_free_full (another_list, g_object_unref);
/// </code>
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="func">
/// a copy function used to copy every element in the list
/// </param>
/// <param name="user_data">
/// user data passed to the copy function @func, or %NULL
/// </param>
/// <return>
/// the start of the new list that holds a full copy of @list,
///     use g_list_free_full() to free it
/// </return>

	public static MentorLake.GLib.GListHandle CopyDeep(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_copy_deep(list, func, user_data);
	}

/// <summary>
/// <para>
/// Removes the node link_ from the list and frees it.
/// Compare this to g_list_remove_link() which removes the node
/// without freeing it.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="link_">
/// node to delete from @list
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle DeleteLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle link_)
	{
		return GListExterns.g_list_delete_link(list, link_);
	}

/// <summary>
/// <para>
/// Finds the element in a #GList which contains the given data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// the element data to find
/// </param>
/// <return>
/// the found #GList element, or %NULL if it is not found
/// </return>

	public static MentorLake.GLib.GListHandle Find(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_find(list, data);
	}

/// <summary>
/// <para>
/// Finds an element in a #GList, using a supplied function to
/// find the desired element. It iterates over the list, calling
/// the given function which should return 0 when the desired
/// element is found. The function takes two #gconstpointer arguments,
/// the #GList element&apos;s data as the first argument and the
/// given user data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// user data passed to the function
/// </param>
/// <param name="func">
/// the function to call for each element.
///     It should return 0 when the desired element is found
/// </param>
/// <return>
/// the found #GList element, or %NULL if it is not found
/// </return>

	public static MentorLake.GLib.GListHandle FindCustom(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GListExterns.g_list_find_custom(list, data, func);
	}

/// <summary>
/// <para>
/// Gets the first element in a #GList.
/// </para>
/// </summary>

/// <param name="list">
/// any #GList element
/// </param>
/// <return>
/// the first element in the #GList,
///     or %NULL if the #GList has no elements
/// </return>

	public static MentorLake.GLib.GListHandle First(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_first(list);
	}

/// <summary>
/// <para>
/// Calls a function for each element of a #GList.
/// </para>
/// <para>
/// It is safe for @func to remove the element from @list, but it must
/// not modify any part of the list after that element.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="func">
/// the function to call with each element&apos;s data
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Foreach(MentorLake.GLib.GListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GListExterns.g_list_foreach(list, func, user_data);
	}

/// <summary>
/// <para>
/// Frees all of the memory used by a #GList.
/// The freed elements are returned to the slice allocator.
/// </para>
/// <para>
/// If list elements contain dynamically-allocated memory, you should
/// either use g_list_free_full() or free them manually first.
/// </para>
/// <para>
/// It can be combined with g_steal_pointer() to ensure the list head pointer
/// is not left dangling:
/// <code>
/// GList *list_of_borrowed_things = …;  /&amp;lt;!-- --&amp;gt;* (transfer container) *&amp;lt;!-- --&amp;gt;/
/// GList *list_of_borrowed_things = …;  /&amp;lt;!-- --&amp;gt;* (transfer container) *&amp;lt;!-- --&amp;gt;/
/// g_list_free (g_steal_pointer (&amp;list_of_borrowed_things));
/// </code>
/// </para>
/// </summary>

/// <param name="list">
/// the first link of a #GList
/// </param>

	public static void Free(MentorLake.GLib.GListHandle list)
	{
		GListExterns.g_list_free(list);
	}

/// <summary>
/// <para>
/// Frees one #GList element, but does not update links from the next and
/// previous elements in the list, so you should not call this function on an
/// element that is currently part of a list.
/// </para>
/// <para>
/// It is usually used after g_list_remove_link().
/// </para>
/// </summary>

/// <param name="list">
/// a #GList element
/// </param>

	public static void Free1(MentorLake.GLib.GListHandle list)
	{
		GListExterns.g_list_free_1(list);
	}

/// <summary>
/// <para>
/// Convenience method, which frees all the memory used by a #GList,
/// and calls @free_func on every element&apos;s data.
/// </para>
/// <para>
/// @free_func must not modify the list (eg, by removing the freed
/// element from it).
/// </para>
/// <para>
/// It can be combined with g_steal_pointer() to ensure the list head pointer
/// is not left dangling ­— this also has the nice property that the head pointer
/// is cleared before any of the list elements are freed, to prevent double frees
/// from @free_func:
/// <code>
/// GList *list_of_owned_things = …;  /&amp;lt;!-- --&amp;gt;* (transfer full) (element-type GObject) *&amp;lt;!-- --&amp;gt;/
/// GList *list_of_owned_things = …;  /&amp;lt;!-- --&amp;gt;* (transfer full) (element-type GObject) *&amp;lt;!-- --&amp;gt;/
/// g_list_free_full (g_steal_pointer (&amp;list_of_owned_things), g_object_unref);
/// </code>
/// </para>
/// </summary>

/// <param name="list">
/// the first link of a #GList
/// </param>
/// <param name="free_func">
/// the function to be called to free each element&apos;s data
/// </param>

	public static void FreeFull(MentorLake.GLib.GListHandle list, MentorLake.GLib.GDestroyNotify free_func)
	{
		GListExterns.g_list_free_full(list, free_func);
	}

/// <summary>
/// <para>
/// Gets the position of the element containing
/// the given data (starting from 0).
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the index of the element containing the data,
///     or -1 if the data is not found
/// </return>

	public static int Index(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_index(list, data);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list at the given position.
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="position">
/// the position to insert the element. If this is
///     negative, or is larger than the number of elements in the
///     list, the new element is added on to the end of the list.
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle Insert(MentorLake.GLib.GListHandle list, IntPtr data, int position)
	{
		return GListExterns.g_list_insert(list, data, position);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list before the given position.
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the list
/// </param>
/// <param name="sibling">
/// the list element before which the new element
///     is inserted or %NULL to insert at the end of the list
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle InsertBefore(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		return GListExterns.g_list_insert_before(list, sibling, data);
	}

/// <summary>
/// <para>
/// Inserts @link_ into the list before the given position.
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the list
/// </param>
/// <param name="sibling">
/// the list element before which the new element
///     is inserted or %NULL to insert at the end of the list
/// </param>
/// <param name="link_">
/// the list element to be added, which must not be part of
///     any other list
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle InsertBeforeLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		return GListExterns.g_list_insert_before_link(list, sibling, link_);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list, using the given comparison
/// function to determine its position.
/// </para>
/// <para>
/// If you are adding many new elements to a list, and the number of
/// new elements is much larger than the length of the list, use
/// g_list_prepend() to add the new items and sort the list afterwards
/// with g_list_sort().
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the
///     already sorted list
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="func">
/// the function to compare elements in the list. It should
///     return a number &amp;gt; 0 if the first parameter comes after the
///     second parameter in the sort order.
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle InsertSorted(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GListExterns.g_list_insert_sorted(list, data, func);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list, using the given comparison
/// function to determine its position.
/// </para>
/// <para>
/// If you are adding many new elements to a list, and the number of
/// new elements is much larger than the length of the list, use
/// g_list_prepend() to add the new items and sort the list afterwards
/// with g_list_sort().
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the
///     already sorted list
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="func">
/// the function to compare elements in the list. It should
///     return a number &amp;gt; 0 if the first parameter  comes after the
///     second parameter in the sort order.
/// </param>
/// <param name="user_data">
/// user data to pass to comparison function
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle InsertSortedWithData(MentorLake.GLib.GListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		return GListExterns.g_list_insert_sorted_with_data(list, data, func, user_data);
	}

/// <summary>
/// <para>
/// Gets the last element in a #GList.
/// </para>
/// </summary>

/// <param name="list">
/// any #GList element
/// </param>
/// <return>
/// the last element in the #GList,
///     or %NULL if the #GList has no elements
/// </return>

	public static MentorLake.GLib.GListHandle Last(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_last(list);
	}

/// <summary>
/// <para>
/// Gets the number of elements in a #GList.
/// </para>
/// <para>
/// This function iterates over the whole list to count its elements.
/// Use a #GQueue instead of a GList if you regularly need the number
/// of items. To check whether the list is non-empty, it is faster to check
/// @list against %NULL.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <return>
/// the number of elements in the #GList
/// </return>

	public static uint Length(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_length(list);
	}

/// <summary>
/// <para>
/// Gets the element at the given position in a #GList.
/// </para>
/// <para>
/// This iterates over the list until it reaches the @n-th position. If you
/// intend to iterate over every element, it is better to use a for-loop as
/// described in the #GList introduction.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="n">
/// the position of the element, counting from 0
/// </param>
/// <return>
/// the element, or %NULL if the position is off
///     the end of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle Nth(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth(list, n);
	}

/// <summary>
/// <para>
/// Gets the data of the element at the given position.
/// </para>
/// <para>
/// This iterates over the list until it reaches the @n-th position. If you
/// intend to iterate over every element, it is better to use a for-loop as
/// described in the #GList introduction.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="n">
/// the position of the element
/// </param>
/// <return>
/// the element&apos;s data, or %NULL if the position
///     is off the end of the #GList
/// </return>

	public static IntPtr NthData(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_data(list, n);
	}

/// <summary>
/// <para>
/// Gets the element @n places before @list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList
/// </param>
/// <param name="n">
/// the position of the element, counting from 0
/// </param>
/// <return>
/// the element, or %NULL if the position is
///     off the end of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle NthPrev(MentorLake.GLib.GListHandle list, uint n)
	{
		return GListExterns.g_list_nth_prev(list, n);
	}



	public static void PopAllocator()
	{
		GListExterns.g_list_pop_allocator();
	}

/// <summary>
/// <para>
/// Gets the position of the given element
/// in the #GList (starting from 0).
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="llink">
/// an element in the #GList
/// </param>
/// <return>
/// the position of the element in the #GList,
///     or -1 if the element is not found
/// </return>

	public static int Position(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle llink)
	{
		return GListExterns.g_list_position(list, llink);
	}

/// <summary>
/// <para>
/// Prepends a new element on to the start of the list.
/// </para>
/// <para>
/// Note that the return value is the new start of the list,
/// which will have changed, so make sure you store the new value.
/// </para>
/// <code>
/// // Notice that it is initialized to the empty list.
/// // Notice that it is initialized to the empty list.
/// GList *list = NULL;
/// 
/// list = g_list_prepend (list, &quot;last&quot;);
/// list = g_list_prepend (list, &quot;first&quot;);
/// </code>
/// <para>
/// Do not use this function to prepend a new element to a different
/// element than the start of the list. Use g_list_insert_before() instead.
/// </para>
/// </summary>

/// <param name="list">
/// a pointer to a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <return>
/// a pointer to the newly prepended element, which is the new
///     start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle Prepend(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_prepend(list, data);
	}


/// <param name="allocator">
/// </param>

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GListExterns.g_list_push_allocator(allocator);
	}

/// <summary>
/// <para>
/// Removes an element from a #GList.
/// If two elements contain the same data, only the first is removed.
/// If none of the elements contain the data, the #GList is unchanged.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// the data of the element to remove
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle Remove(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove(list, data);
	}

/// <summary>
/// <para>
/// Removes all list nodes with data equal to @data.
/// Returns the new head of the list. Contrast with
/// g_list_remove() which removes only the first node
/// matching the given data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="data">
/// data to remove
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle RemoveAll(MentorLake.GLib.GListHandle list, IntPtr data)
	{
		return GListExterns.g_list_remove_all(list, data);
	}

/// <summary>
/// <para>
/// Removes an element from a #GList, without freeing the element.
/// The removed element&apos;s prev and next links are set to %NULL, so
/// that it becomes a self-contained list with one element.
/// </para>
/// <para>
/// This function is for example used to move an element in the list
/// (see the example for g_list_concat()) or to remove an element in
/// the list before freeing its data:
/// <code>
/// list = g_list_remove_link (list, llink);
/// list = g_list_remove_link (list, llink);
/// free_some_data_that_may_access_the_list_again (llink-&amp;gt;data);
/// g_list_free (llink);
/// </code>
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="llink">
/// an element in the #GList
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle RemoveLink(MentorLake.GLib.GListHandle list, MentorLake.GLib.GListHandle llink)
	{
		return GListExterns.g_list_remove_link(list, llink);
	}

/// <summary>
/// <para>
/// Reverses a #GList.
/// It simply switches the next and prev pointers of each element.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <return>
/// the start of the reversed #GList
/// </return>

	public static MentorLake.GLib.GListHandle Reverse(MentorLake.GLib.GListHandle list)
	{
		return GListExterns.g_list_reverse(list);
	}

/// <summary>
/// <para>
/// Sorts a #GList using the given comparison function. The algorithm
/// used is a stable sort.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="compare_func">
/// the comparison function used to sort the #GList.
///     This function is passed the data from 2 elements of the #GList
///     and should return 0 if they are equal, a negative value if the
///     first element comes before the second, or a positive value if
///     the first element comes after the second.
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle Sort(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareFunc compare_func)
	{
		return GListExterns.g_list_sort(list, compare_func);
	}

/// <summary>
/// <para>
/// Like g_list_sort(), but the comparison function accepts
/// a user data argument.
/// </para>
/// </summary>

/// <param name="list">
/// a #GList, this must point to the top of the list
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// user data to pass to comparison function
/// </param>
/// <return>
/// the (possibly changed) start of the #GList
/// </return>

	public static MentorLake.GLib.GListHandle SortWithData(MentorLake.GLib.GListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GListExterns.g_list_sort_with_data(list, compare_func, user_data);
	}

}
