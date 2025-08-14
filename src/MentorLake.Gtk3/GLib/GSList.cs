namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GSList struct is used for each element in the singly-linked
/// list.
/// </para>
/// </summary>

public class GSListHandle : BaseSafeHandle
{
}


public static class GSListExtensions
{

	public static GSList Dereference(this GSListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSList>(x.DangerousGetHandle());
}
internal class GSListExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_alloc();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_concat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_delete_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_find_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free_1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_free_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_slist_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, int position);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle slist, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_insert_sorted_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_slist_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slist_nth_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_slist_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle llink);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_remove_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_slist_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

}

/// <summary>
/// <para>
/// The #GSList struct is used for each element in the singly-linked
/// list.
/// </para>
/// </summary>

public struct GSList
{
	/// <summary>
/// <para>
/// holds the element's data, which can be a pointer to any kind
///        of data, or any integer value using the
///        [Type Conversion Macros][glib-Type-Conversion-Macros]
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// contains the link to the next element in the list.
/// </para>
/// </summary>

public IntPtr next;
/// <summary>
/// <para>
/// Allocates space for one #GSList element. It is called by the
/// g_slist_append(), g_slist_prepend(), g_slist_insert() and
/// g_slist_insert_sorted() functions and so is rarely used on its own.
/// </para>
/// </summary>

/// <return>
/// a pointer to the newly-allocated #GSList element.
/// </return>

	public static MentorLake.GLib.GSListHandle Alloc()
	{
		return GSListExterns.g_slist_alloc();
	}

/// <summary>
/// <para>
/// Adds a new element on to the end of the list.
/// </para>
/// <para>
/// The return value is the new start of the list, which may
/// have changed, so make sure you store the new value.
/// </para>
/// <para>
/// Note that g_slist_append() has to traverse the entire list
/// to find the end, which is inefficient when adding multiple
/// elements. A common idiom to avoid the inefficiency is to prepend
/// the elements and reverse the list when all elements have been added.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // Notice that these are initialized to the empty list.
/// GSList *list = NULL, *number_list = NULL;
/// </para>
/// <para>
/// // This is a list of strings.
/// list = g_slist_append (list, "first");
/// list = g_slist_append (list, "second");
/// </para>
/// <para>
/// // This is a list of integers.
/// number_list = g_slist_append (number_list, GINT_TO_POINTER (27));
/// number_list = g_slist_append (number_list, GINT_TO_POINTER (14));
/// ]|
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Append(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_append(list, data);
	}

/// <summary>
/// <para>
/// Adds the second #GSList onto the end of the first #GSList.
/// Note that the elements of the second #GSList are not copied.
/// They are used directly.
/// </para>
/// </summary>

/// <param name="list1">
/// a #GSList
/// </param>
/// <param name="list2">
/// the #GSList to add to the end of the first #GSList
/// </param>
/// <return>
/// the start of the new #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Concat(MentorLake.GLib.GSListHandle list1, MentorLake.GLib.GSListHandle list2)
	{
		return GSListExterns.g_slist_concat(list1, list2);
	}

/// <summary>
/// <para>
/// Copies a #GSList.
/// </para>
/// <para>
/// Note that this is a "shallow" copy. If the list elements
/// consist of pointers to data, the pointers are copied but
/// the actual data isn't. See g_slist_copy_deep() if you need
/// to copy the data as well.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <return>
/// a copy of @list
/// </return>

	public static MentorLake.GLib.GSListHandle Copy(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_copy(list);
	}

/// <summary>
/// <para>
/// Makes a full (deep) copy of a #GSList.
/// </para>
/// <para>
/// In contrast with g_slist_copy(), this function uses @func to make a copy of
/// each list element, in addition to copying the list container itself.
/// </para>
/// <para>
/// @func, as a #GCopyFunc, takes two arguments, the data to be copied
/// and a @user_data pointer. On common processor architectures, it's safe to
/// pass %NULL as @user_data if the copy function takes only one argument. You
/// may get compiler warnings from this though if compiling with GCC’s
/// `-Wcast-function-type` warning.
/// </para>
/// <para>
/// For instance, if @list holds a list of GObjects, you can do:
/// |[<!-- language="C" -->
/// another_list = g_slist_copy_deep (list, (GCopyFunc) g_object_ref, NULL);
/// ]|
/// </para>
/// <para>
/// And, to entirely free the new list, you could do:
/// |[<!-- language="C" -->
/// g_slist_free_full (another_list, g_object_unref);
/// ]|
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="func">
/// a copy function used to copy every element in the list
/// </param>
/// <param name="user_data">
/// user data passed to the copy function @func, or #NULL
/// </param>
/// <return>
/// a full copy of @list, use g_slist_free_full() to free it
/// </return>

	public static MentorLake.GLib.GSListHandle CopyDeep(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCopyFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_copy_deep(list, func, user_data);
	}

/// <summary>
/// <para>
/// Removes the node link_ from the list and frees it.
/// Compare this to g_slist_remove_link() which removes the node
/// without freeing it.
/// </para>
/// <para>
/// Removing arbitrary nodes from a singly-linked list requires time
/// that is proportional to the length of the list (ie. O(n)). If you
/// find yourself using g_slist_delete_link() frequently, you should
/// consider a different data structure, such as the doubly-linked
/// #GList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="link_">
/// node to delete
/// </param>
/// <return>
/// the new head of @list
/// </return>

	public static MentorLake.GLib.GSListHandle DeleteLink(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle link_)
	{
		return GSListExterns.g_slist_delete_link(list, link_);
	}

/// <summary>
/// <para>
/// Finds the element in a #GSList which
/// contains the given data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the element data to find
/// </param>
/// <return>
/// the found #GSList element,
///     or %NULL if it is not found
/// </return>

	public static MentorLake.GLib.GSListHandle Find(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_find(list, data);
	}

/// <summary>
/// <para>
/// Finds an element in a #GSList, using a supplied function to
/// find the desired element. It iterates over the list, calling
/// the given function which should return 0 when the desired
/// element is found. The function takes two #gconstpointer arguments,
/// the #GSList element's data as the first argument and the
/// given user data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// user data passed to the function
/// </param>
/// <param name="func">
/// the function to call for each element.
///     It should return 0 when the desired element is found
/// </param>
/// <return>
/// the found #GSList element, or %NULL if it is not found
/// </return>

	public static MentorLake.GLib.GSListHandle FindCustom(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GSListExterns.g_slist_find_custom(list, data, func);
	}

/// <summary>
/// <para>
/// Calls a function for each element of a #GSList.
/// </para>
/// <para>
/// It is safe for @func to remove the element from @list, but it must
/// not modify any part of the list after that element.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="func">
/// the function to call with each element's data
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Foreach(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GSListExterns.g_slist_foreach(list, func, user_data);
	}

/// <summary>
/// <para>
/// Frees all of the memory used by a #GSList.
/// The freed elements are returned to the slice allocator.
/// </para>
/// <para>
/// If list elements contain dynamically-allocated memory,
/// you should either use g_slist_free_full() or free them manually
/// first.
/// </para>
/// <para>
/// It can be combined with g_steal_pointer() to ensure the list head pointer
/// is not left dangling:
/// |[<!-- language="C" -->
/// GSList *list_of_borrowed_things = …;  /<!-- -->* (transfer container) *<!-- -->/
/// g_slist_free (g_steal_pointer (&list_of_borrowed_things));
/// ]|
/// </para>
/// </summary>

/// <param name="list">
/// the first link of a #GSList
/// </param>

	public static void Free(MentorLake.GLib.GSListHandle list)
	{
		GSListExterns.g_slist_free(list);
	}

/// <summary>
/// <para>
/// Frees one #GSList element.
/// It is usually used after g_slist_remove_link().
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList element
/// </param>

	public static void Free1(MentorLake.GLib.GSListHandle list)
	{
		GSListExterns.g_slist_free_1(list);
	}

/// <summary>
/// <para>
/// Convenience method, which frees all the memory used by a #GSList, and
/// calls the specified destroy function on every element's data.
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
/// |[<!-- language="C" -->
/// GSList *list_of_owned_things = …;  /<!-- -->* (transfer full) (element-type GObject) *<!-- -->/
/// g_slist_free_full (g_steal_pointer (&list_of_owned_things), g_object_unref);
/// ]|
/// </para>
/// </summary>

/// <param name="list">
/// the first link of a #GSList
/// </param>
/// <param name="free_func">
/// the function to be called to free each element's data
/// </param>

	public static void FreeFull(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GDestroyNotify free_func)
	{
		GSListExterns.g_slist_free_full(list, free_func);
	}

/// <summary>
/// <para>
/// Gets the position of the element containing
/// the given data (starting from 0).
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the index of the element containing the data,
///     or -1 if the data is not found
/// </return>

	public static int Index(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_index(list, data);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list at the given position.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="position">
/// the position to insert the element.
///     If this is negative, or is larger than the number
///     of elements in the list, the new element is added on
///     to the end of the list.
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Insert(MentorLake.GLib.GSListHandle list, IntPtr data, int position)
	{
		return GSListExterns.g_slist_insert(list, data, position);
	}

/// <summary>
/// <para>
/// Inserts a node before @sibling containing @data.
/// </para>
/// </summary>

/// <param name="slist">
/// a #GSList
/// </param>
/// <param name="sibling">
/// node to insert @data before
/// </param>
/// <param name="data">
/// data to put in the newly-inserted node
/// </param>
/// <return>
/// the new head of the list.
/// </return>

	public static MentorLake.GLib.GSListHandle InsertBefore(MentorLake.GLib.GSListHandle slist, MentorLake.GLib.GSListHandle sibling, IntPtr data)
	{
		return GSListExterns.g_slist_insert_before(slist, sibling, data);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list, using the given
/// comparison function to determine its position.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="func">
/// the function to compare elements in the list.
///     It should return a number > 0 if the first parameter
///     comes after the second parameter in the sort order.
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle InsertSorted(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		return GSListExterns.g_slist_insert_sorted(list, data, func);
	}

/// <summary>
/// <para>
/// Inserts a new element into the list, using the given
/// comparison function to determine its position.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="func">
/// the function to compare elements in the list.
///     It should return a number > 0 if the first parameter
///     comes after the second parameter in the sort order.
/// </param>
/// <param name="user_data">
/// data to pass to comparison function
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle InsertSortedWithData(MentorLake.GLib.GSListHandle list, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		return GSListExterns.g_slist_insert_sorted_with_data(list, data, func, user_data);
	}

/// <summary>
/// <para>
/// Gets the last element in a #GSList.
/// </para>
/// <para>
/// This function iterates over the whole list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <return>
/// the last element in the #GSList,
///     or %NULL if the #GSList has no elements
/// </return>

	public static MentorLake.GLib.GSListHandle Last(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_last(list);
	}

/// <summary>
/// <para>
/// Gets the number of elements in a #GSList.
/// </para>
/// <para>
/// This function iterates over the whole list to
/// count its elements. To check whether the list is non-empty, it is faster to
/// check @list against %NULL.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <return>
/// the number of elements in the #GSList
/// </return>

	public static uint Length(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_length(list);
	}

/// <summary>
/// <para>
/// Gets the element at the given position in a #GSList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="n">
/// the position of the element, counting from 0
/// </param>
/// <return>
/// the element, or %NULL if the position is off
///     the end of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Nth(MentorLake.GLib.GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth(list, n);
	}

/// <summary>
/// <para>
/// Gets the data of the element at the given position.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="n">
/// the position of the element
/// </param>
/// <return>
/// the element's data, or %NULL if the position
///     is off the end of the #GSList
/// </return>

	public static IntPtr NthData(MentorLake.GLib.GSListHandle list, uint n)
	{
		return GSListExterns.g_slist_nth_data(list, n);
	}



	public static void PopAllocator()
	{
		GSListExterns.g_slist_pop_allocator();
	}

/// <summary>
/// <para>
/// Gets the position of the given element
/// in the #GSList (starting from 0).
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="llink">
/// an element in the #GSList
/// </param>
/// <return>
/// the position of the element in the #GSList,
///     or -1 if the element is not found
/// </return>

	public static int Position(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle llink)
	{
		return GSListExterns.g_slist_position(list, llink);
	}

/// <summary>
/// <para>
/// Adds a new element on to the start of the list.
/// </para>
/// <para>
/// The return value is the new start of the list, which
/// may have changed, so make sure you store the new value.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // Notice that it is initialized to the empty list.
/// GSList *list = NULL;
/// list = g_slist_prepend (list, "last");
/// list = g_slist_prepend (list, "first");
/// ]|
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Prepend(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_prepend(list, data);
	}


/// <param name="allocator">
/// </param>

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GSListExterns.g_slist_push_allocator(allocator);
	}

/// <summary>
/// <para>
/// Removes an element from a #GSList.
/// If two elements contain the same data, only the first is removed.
/// If none of the elements contain the data, the #GSList is unchanged.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// the data of the element to remove
/// </param>
/// <return>
/// the new start of the #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Remove(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove(list, data);
	}

/// <summary>
/// <para>
/// Removes all list nodes with data equal to @data.
/// Returns the new head of the list. Contrast with
/// g_slist_remove() which removes only the first node
/// matching the given data.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="data">
/// data to remove
/// </param>
/// <return>
/// new head of @list
/// </return>

	public static MentorLake.GLib.GSListHandle RemoveAll(MentorLake.GLib.GSListHandle list, IntPtr data)
	{
		return GSListExterns.g_slist_remove_all(list, data);
	}

/// <summary>
/// <para>
/// Removes an element from a #GSList, without
/// freeing the element. The removed element's next
/// link is set to %NULL, so that it becomes a
/// self-contained list with one element.
/// </para>
/// <para>
/// Removing arbitrary nodes from a singly-linked list
/// requires time that is proportional to the length of the list
/// (ie. O(n)). If you find yourself using g_slist_remove_link()
/// frequently, you should consider a different data structure,
/// such as the doubly-linked #GList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="link_">
/// an element in the #GSList
/// </param>
/// <return>
/// the new start of the #GSList, without the element
/// </return>

	public static MentorLake.GLib.GSListHandle RemoveLink(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GSListHandle link_)
	{
		return GSListExterns.g_slist_remove_link(list, link_);
	}

/// <summary>
/// <para>
/// Reverses a #GSList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <return>
/// the start of the reversed #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Reverse(MentorLake.GLib.GSListHandle list)
	{
		return GSListExterns.g_slist_reverse(list);
	}

/// <summary>
/// <para>
/// Sorts a #GSList using the given comparison function. The algorithm
/// used is a stable sort.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="compare_func">
/// the comparison function used to sort the #GSList.
///     This function is passed the data from 2 elements of the #GSList
///     and should return 0 if they are equal, a negative value if the
///     first element comes before the second, or a positive value if
///     the first element comes after the second.
/// </param>
/// <return>
/// the start of the sorted #GSList
/// </return>

	public static MentorLake.GLib.GSListHandle Sort(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareFunc compare_func)
	{
		return GSListExterns.g_slist_sort(list, compare_func);
	}

/// <summary>
/// <para>
/// Like g_slist_sort(), but the sort function accepts a user data argument.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// data to pass to comparison function
/// </param>
/// <return>
/// new head of the list
/// </return>

	public static MentorLake.GLib.GSListHandle SortWithData(MentorLake.GLib.GSListHandle list, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GSListExterns.g_slist_sort_with_data(list, compare_func, user_data);
	}

}
