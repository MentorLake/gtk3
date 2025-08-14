namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The GTree struct is an opaque data structure representing a
/// [balanced binary tree][glib-Balanced-Binary-Trees]. It should be
/// accessed only by using the following functions.
/// </para>
/// </summary>

public class GTreeHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GTree.
/// </para>
/// </summary>

/// <param name="key_compare_func">
/// the function used to order the nodes in the #GTree.
///   It should return values similar to the standard strcmp() function -
///   0 if the two arguments are equal, a negative value if the first argument
///   comes before the second, or a positive value if the first argument comes
///   after the second.
/// </param>
/// <return>
/// a newly allocated #GTree
/// </return>

	public static MentorLake.GLib.GTreeHandle New(MentorLake.GLib.GCompareFunc key_compare_func)
	{
		return GTreeExterns.g_tree_new(key_compare_func);
	}

/// <summary>
/// <para>
/// Creates a new #GTree like g_tree_new() and allows to specify functions
/// to free the memory allocated for the key and value that get called when
/// removing the entry from the #GTree.
/// </para>
/// </summary>

/// <param name="key_compare_func">
/// qsort()-style comparison function
/// </param>
/// <param name="key_compare_data">
/// data to pass to comparison function
/// </param>
/// <param name="key_destroy_func">
/// a function to free the memory allocated for the key
///   used when removing the entry from the #GTree or %NULL if you don't
///   want to supply such a function
/// </param>
/// <param name="value_destroy_func">
/// a function to free the memory allocated for the
///   value used when removing the entry from the #GTree or %NULL if you
///   don't want to supply such a function
/// </param>
/// <return>
/// a newly allocated #GTree
/// </return>

	public static MentorLake.GLib.GTreeHandle NewFull(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func)
	{
		return GTreeExterns.g_tree_new_full(key_compare_func, key_compare_data, key_destroy_func, value_destroy_func);
	}

/// <summary>
/// <para>
/// Creates a new #GTree with a comparison function that accepts user data.
/// See g_tree_new() for more details.
/// </para>
/// </summary>

/// <param name="key_compare_func">
/// qsort()-style comparison function
/// </param>
/// <param name="key_compare_data">
/// data to pass to comparison function
/// </param>
/// <return>
/// a newly allocated #GTree
/// </return>

	public static MentorLake.GLib.GTreeHandle NewWithData(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data)
	{
		return GTreeExterns.g_tree_new_with_data(key_compare_func, key_compare_data);
	}

}


public static class GTreeExtensions
{
/// <summary>
/// <para>
/// Removes all keys and values from the #GTree and decreases its
/// reference count by one. If keys and/or values are dynamically
/// allocated, you should either free them first or create the #GTree
/// using g_tree_new_full(). In the latter case the destroy functions
/// you supplied will be called on all keys and values before destroying
/// the #GTree.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>

	public static void Destroy(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_destroy(tree);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the key/value pairs in the #GTree.
/// The function is passed the key and value of each pair, and the given
/// @data parameter. The tree is traversed in sorted order.
/// </para>
/// <para>
/// The tree may not be modified while iterating over it (you can't
/// add/remove items). To remove all items matching a predicate, you need
/// to add each item to a list in your #GTraverseFunc as you walk over
/// the tree, then walk the list and remove each item.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="func">
/// the function to call for each node visited.
///     If this function returns %TRUE, the traversal is stopped.
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Foreach(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc func, IntPtr user_data)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_foreach(tree, func, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the nodes in the #GTree.
/// The function is passed the pointer to the particular node, and the given
/// @data parameter. The tree traversal happens in-order.
/// </para>
/// <para>
/// The tree may not be modified while iterating over it (you can't
/// add/remove items). To remove all items matching a predicate, you need
/// to add each item to a list in your #GTraverseFunc as you walk over
/// the tree, then walk the list and remove each item.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="func">
/// the function to call for each node visited.
///     If this function returns %TRUE, the traversal is stopped.
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void ForeachNode(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseNodeFunc func, IntPtr user_data)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_foreach_node(tree, func, user_data);
	}

/// <summary>
/// <para>
/// Gets the height of a #GTree.
/// </para>
/// <para>
/// If the #GTree contains no nodes, the height is 0.
/// If the #GTree contains only one root node the height is 1.
/// If the root node has children the height is 2, etc.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <return>
/// the height of @tree
/// </return>

	public static int Height(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_height(tree);
	}

/// <summary>
/// <para>
/// Inserts a key/value pair into a #GTree.
/// </para>
/// <para>
/// Inserts a new key and value into a #GTree as g_tree_insert_node() does,
/// only this function does not return the inserted or set node.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to insert
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>

	public static void Insert(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_insert(tree, key, value);
	}

/// <summary>
/// <para>
/// Inserts a key/value pair into a #GTree.
/// </para>
/// <para>
/// If the given key already exists in the #GTree its corresponding value
/// is set to the new value. If you supplied a @value_destroy_func when
/// creating the #GTree, the old value is freed using that function. If
/// you supplied a @key_destroy_func when creating the #GTree, the passed
/// key is freed using that function.
/// </para>
/// <para>
/// The tree is automatically 'balanced' as new key/value pairs are added,
/// so that the distance from the root to every leaf is as small as possible.
/// The cost of maintaining a balanced tree while inserting new key/value
/// result in a O(n log(n)) operation where most of the other operations
/// are O(log(n)).
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to insert
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>
/// <return>
/// the inserted (or set) node or %NULL
/// if insertion would overflow the tree node counter.
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle InsertNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_insert_node(tree, key, value);
	}

/// <summary>
/// <para>
/// Gets the value corresponding to the given key. Since a #GTree is
/// automatically balanced as key/value pairs are added, key lookup
/// is O(log n) (where n is the number of key/value pairs in the tree).
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// the value corresponding to the key, or %NULL
///     if the key was not found
/// </return>

	public static IntPtr Lookup(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_lookup(tree, key);
	}

/// <summary>
/// <para>
/// Looks up a key in the #GTree, returning the original key and the
/// associated value. This is useful if you need to free the memory
/// allocated for the original key, for example before calling
/// g_tree_remove().
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="lookup_key">
/// the key to look up
/// </param>
/// <param name="orig_key">
/// returns the original key
/// </param>
/// <param name="value">
/// returns the value associated with the key
/// </param>
/// <return>
/// %TRUE if the key was found in the #GTree
/// </return>

	public static bool LookupExtended(this MentorLake.GLib.GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_lookup_extended(tree, lookup_key, out orig_key, out value);
	}

/// <summary>
/// <para>
/// Gets the tree node corresponding to the given key. Since a #GTree is
/// automatically balanced as key/value pairs are added, key lookup
/// is O(log n) (where n is the number of key/value pairs in the tree).
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// the tree node corresponding to
///          the key, or %NULL if the key was not found
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle LookupNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_lookup_node(tree, key);
	}

/// <summary>
/// <para>
/// Gets the lower bound node corresponding to the given key,
/// or %NULL if the tree is empty or all the nodes in the tree
/// have keys that are strictly lower than the searched key.
/// </para>
/// <para>
/// The lower bound is the first node that has its key greater
/// than or equal to the searched key.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to calculate the lower bound for
/// </param>
/// <return>
/// the tree node corresponding to
///          the lower bound, or %NULL if the tree is empty or has only
///          keys strictly lower than the searched key.
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle LowerBound(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_lower_bound(tree, key);
	}

/// <summary>
/// <para>
/// Gets the number of nodes in a #GTree.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <return>
/// the number of nodes in @tree
/// 
/// The node counter value type is really a #guint,
/// but it is returned as a #gint due to backward
/// compatibility issues (can be cast back to #guint to
/// support its full range of values).
/// </return>

	public static int Nnodes(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_nnodes(tree);
	}

/// <summary>
/// <para>
/// Returns the first in-order node of the tree, or %NULL
/// for an empty tree.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <return>
/// the first node in the tree
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle NodeFirst(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_node_first(tree);
	}

/// <summary>
/// <para>
/// Returns the last in-order node of the tree, or %NULL
/// for an empty tree.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <return>
/// the last node in the tree
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle NodeLast(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_node_last(tree);
	}

/// <summary>
/// <para>
/// Increments the reference count of @tree by one.
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <return>
/// the passed in #GTree
/// </return>

	public static MentorLake.GLib.GTreeHandle Ref(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_ref(tree);
	}

/// <summary>
/// <para>
/// Removes a key/value pair from a #GTree.
/// </para>
/// <para>
/// If the #GTree was created using g_tree_new_full(), the key and value
/// are freed using the supplied destroy functions, otherwise you have to
/// make sure that any dynamically allocated values are freed yourself.
/// If the key does not exist in the #GTree, the function does nothing.
/// </para>
/// <para>
/// The cost of maintaining a balanced tree while removing a key/value
/// result in a O(n log(n)) operation where most of the other operations
/// are O(log(n)).
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found (prior to 2.8, this function
///     returned nothing)
/// </return>

	public static bool Remove(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_remove(tree, key);
	}

/// <summary>
/// <para>
/// Removes all nodes from a #GTree and destroys their keys and values,
/// then resets the #GTree’s root to %NULL.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>

	public static void RemoveAll(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_remove_all(tree);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GTree as g_tree_replace_node() does,
/// only this function does not return the inserted or set node.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to insert
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>

	public static void Replace(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_replace(tree, key, value);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GTree similar to g_tree_insert_node().
/// The difference is that if the key already exists in the #GTree, it gets
/// replaced by the new key. If you supplied a @value_destroy_func when
/// creating the #GTree, the old value is freed using that function. If you
/// supplied a @key_destroy_func when creating the #GTree, the old key is
/// freed using that function.
/// </para>
/// <para>
/// The tree is automatically 'balanced' as new key/value pairs are added,
/// so that the distance from the root to every leaf is as small as possible.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to insert
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>
/// <return>
/// the inserted (or set) node or %NULL
/// if insertion would overflow the tree node counter.
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle ReplaceNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_replace_node(tree, key, value);
	}

/// <summary>
/// <para>
/// Searches a #GTree using @search_func.
/// </para>
/// <para>
/// The @search_func is called with a pointer to the key of a key/value
/// pair in the tree, and the passed in @user_data. If @search_func returns
/// 0 for a key/value pair, then the corresponding value is returned as
/// the result of g_tree_search(). If @search_func returns -1, searching
/// will proceed among the key/value pairs that have a smaller key; if
/// @search_func returns 1, searching will proceed among the key/value
/// pairs that have a larger key.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="search_func">
/// a function used to search the #GTree
/// </param>
/// <param name="user_data">
/// the data passed as the second argument to @search_func
/// </param>
/// <return>
/// the value corresponding to the found key, or %NULL
///     if the key was not found
/// </return>

	public static IntPtr Search(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_search(tree, search_func, user_data);
	}

/// <summary>
/// <para>
/// Searches a #GTree using @search_func.
/// </para>
/// <para>
/// The @search_func is called with a pointer to the key of a key/value
/// pair in the tree, and the passed in @user_data. If @search_func returns
/// 0 for a key/value pair, then the corresponding node is returned as
/// the result of g_tree_search(). If @search_func returns -1, searching
/// will proceed among the key/value pairs that have a smaller key; if
/// @search_func returns 1, searching will proceed among the key/value
/// pairs that have a larger key.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="search_func">
/// a function used to search the #GTree
/// </param>
/// <param name="user_data">
/// the data passed as the second argument to @search_func
/// </param>
/// <return>
/// the node corresponding to the
///          found key, or %NULL if the key was not found
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle SearchNode(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_search_node(tree, search_func, user_data);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GTree without calling
/// the key and value destroy functions.
/// </para>
/// <para>
/// If the key does not exist in the #GTree, the function does nothing.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found (prior to 2.8, this function
///     returned nothing)
/// </return>

	public static bool Steal(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_steal(tree, key);
	}

/// <summary>
/// <para>
/// Calls the given function for each node in the #GTree.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="traverse_func">
/// the function to call for each node visited. If this
///   function returns %TRUE, the traversal is stopped.
/// </param>
/// <param name="traverse_type">
/// the order in which nodes are visited, one of %G_IN_ORDER,
///   %G_PRE_ORDER and %G_POST_ORDER
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Traverse(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc traverse_func, MentorLake.GLib.GTraverseType traverse_type, IntPtr user_data)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_traverse(tree, traverse_func, traverse_type, user_data);
	}

/// <summary>
/// <para>
/// Decrements the reference count of @tree by one.
/// If the reference count drops to 0, all keys and values will
/// be destroyed (if destroy functions were specified) and all
/// memory allocated by @tree will be released.
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>

	public static void Unref(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		GTreeExterns.g_tree_unref(tree);
	}

/// <summary>
/// <para>
/// Gets the upper bound node corresponding to the given key,
/// or %NULL if the tree is empty or all the nodes in the tree
/// have keys that are lower than or equal to the searched key.
/// </para>
/// <para>
/// The upper bound is the first node that has its key strictly greater
/// than the searched key.
/// </para>
/// </summary>

/// <param name="tree">
/// a #GTree
/// </param>
/// <param name="key">
/// the key to calculate the upper bound for
/// </param>
/// <return>
/// the tree node corresponding to the
///          upper bound, or %NULL if the tree is empty or has only keys
///          lower than or equal to the searched key.
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle UpperBound(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid) throw new Exception("Invalid handle (GTree)");
		return GTreeExterns.g_tree_upper_bound(tree, key);
	}


	public static GTree Dereference(this GTreeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTree>(x.DangerousGetHandle());
}
internal class GTreeExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new(MentorLake.GLib.GCompareFunc key_compare_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new_full(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new_with_data(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_foreach_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseNodeFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_tree_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_insert_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_lookup_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_lower_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_tree_nnodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_replace_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_search_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_traverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc traverse_func, MentorLake.GLib.GTraverseType traverse_type, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_upper_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

}

/// <summary>
/// <para>
/// The GTree struct is an opaque data structure representing a
/// [balanced binary tree][glib-Balanced-Binary-Trees]. It should be
/// accessed only by using the following functions.
/// </para>
/// </summary>

public struct GTree
{
}
