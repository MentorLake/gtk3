namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GNode struct represents one node in a [n-ary tree][glib-N-ary-Trees].
/// </para>
/// </summary>

public class GNodeHandle : BaseSafeHandle
{
}


public static class GNodeExtensions
{
/// <summary>
/// <para>
/// Gets the position of the first child of a #GNode
/// which contains the given data.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the index of the child of @node which contains
///     @data, or -1 if the data is not found
/// </return>

	public static int ChildIndex(this MentorLake.GLib.GNodeHandle node, IntPtr data)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_child_index(node, data);
	}

/// <summary>
/// <para>
/// Gets the position of a #GNode with respect to its siblings.
/// @child must be a child of @node. The first child is numbered 0,
/// the second 1, and so on.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="child">
/// a child of @node
/// </param>
/// <return>
/// the position of @child with respect to its siblings
/// </return>

	public static int ChildPosition(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GNodeHandle child)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_child_position(node, child);
	}

/// <summary>
/// <para>
/// Calls a function for each of the children of a #GNode. Note that it
/// doesn't descend beneath the child nodes. @func must not do anything
/// that would modify the structure of the tree.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="flags">
/// which types of children are to be visited, one of
///     %G_TRAVERSE_ALL, %G_TRAVERSE_LEAVES and %G_TRAVERSE_NON_LEAVES
/// </param>
/// <param name="func">
/// the function to call for each visited node
/// </param>
/// <param name="data">
/// user data to pass to the function
/// </param>

	public static void ChildrenForeach(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, MentorLake.GLib.GNodeForeachFunc func, IntPtr data)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		GNodeExterns.g_node_children_foreach(node, flags, func, data);
	}

/// <summary>
/// <para>
/// Recursively copies a #GNode (but does not deep-copy the data inside the
/// nodes, see g_node_copy_deep() if you need that).
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// a new #GNode containing the same data pointers
/// </return>

	public static MentorLake.GLib.GNodeHandle Copy(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_copy(node);
	}

/// <summary>
/// <para>
/// Recursively copies a #GNode and its data.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="copy_func">
/// the function which is called to copy the data
///   inside each node, or %NULL to use the original data.
/// </param>
/// <param name="data">
/// data to pass to @copy_func
/// </param>
/// <return>
/// a new #GNode containing copies of the data in @node.
/// </return>

	public static MentorLake.GLib.GNodeHandle CopyDeep(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GCopyFunc copy_func, IntPtr data)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_copy_deep(node, copy_func, data);
	}

/// <summary>
/// <para>
/// Gets the depth of a #GNode.
/// </para>
/// <para>
/// If @node is %NULL the depth is 0. The root node has a depth of 1.
/// For the children of the root node the depth is 2. And so on.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// the depth of the #GNode
/// </return>

	public static uint Depth(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_depth(node);
	}

/// <summary>
/// <para>
/// Removes @root and its children from the tree, freeing any memory
/// allocated.
/// </para>
/// </summary>

/// <param name="root">
/// the root of the tree/subtree to destroy
/// </param>

	public static void Destroy(this MentorLake.GLib.GNodeHandle root)
	{
		if (root.IsInvalid) throw new Exception("Invalid handle (GNode)");
		GNodeExterns.g_node_destroy(root);
	}

/// <summary>
/// <para>
/// Finds a #GNode in a tree.
/// </para>
/// </summary>

/// <param name="root">
/// the root #GNode of the tree to search
/// </param>
/// <param name="order">
/// the order in which nodes are visited - %G_IN_ORDER,
///     %G_PRE_ORDER, %G_POST_ORDER, or %G_LEVEL_ORDER
/// </param>
/// <param name="flags">
/// which types of children are to be searched, one of
///     %G_TRAVERSE_ALL, %G_TRAVERSE_LEAVES and %G_TRAVERSE_NON_LEAVES
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the found #GNode, or %NULL if the data is not found
/// </return>

	public static MentorLake.GLib.GNodeHandle Find(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, IntPtr data)
	{
		if (root.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_find(root, order, flags, data);
	}

/// <summary>
/// <para>
/// Finds the first child of a #GNode with the given data.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="flags">
/// which types of children are to be searched, one of
///     %G_TRAVERSE_ALL, %G_TRAVERSE_LEAVES and %G_TRAVERSE_NON_LEAVES
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the found child #GNode, or %NULL if the data is not found
/// </return>

	public static MentorLake.GLib.GNodeHandle FindChild(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, IntPtr data)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_find_child(node, flags, data);
	}

/// <summary>
/// <para>
/// Gets the first sibling of a #GNode.
/// This could possibly be the node itself.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// the first sibling of @node
/// </return>

	public static MentorLake.GLib.GNodeHandle FirstSibling(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_first_sibling(node);
	}

/// <summary>
/// <para>
/// Gets the root of a tree.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// the root of the tree
/// </return>

	public static MentorLake.GLib.GNodeHandle GetRoot(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_get_root(node);
	}

/// <summary>
/// <para>
/// Inserts a #GNode beneath the parent at the given position.
/// </para>
/// </summary>

/// <param name="parent">
/// the #GNode to place @node under
/// </param>
/// <param name="position">
/// the position to place @node at, with respect to its siblings
///     If position is -1, @node is inserted as the last child of @parent
/// </param>
/// <param name="node">
/// the #GNode to insert
/// </param>
/// <return>
/// the inserted #GNode
/// </return>

	public static MentorLake.GLib.GNodeHandle Insert(this MentorLake.GLib.GNodeHandle parent, int position, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_insert(parent, position, node);
	}

/// <summary>
/// <para>
/// Inserts a #GNode beneath the parent after the given sibling.
/// </para>
/// </summary>

/// <param name="parent">
/// the #GNode to place @node under
/// </param>
/// <param name="sibling">
/// the sibling #GNode to place @node after.
///     If sibling is %NULL, the node is inserted as the first child of @parent.
/// </param>
/// <param name="node">
/// the #GNode to insert
/// </param>
/// <return>
/// the inserted #GNode
/// </return>

	public static MentorLake.GLib.GNodeHandle InsertAfter(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle sibling, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_insert_after(parent, sibling, node);
	}

/// <summary>
/// <para>
/// Inserts a #GNode beneath the parent before the given sibling.
/// </para>
/// </summary>

/// <param name="parent">
/// the #GNode to place @node under
/// </param>
/// <param name="sibling">
/// the sibling #GNode to place @node before.
///     If sibling is %NULL, the node is inserted as the last child of @parent.
/// </param>
/// <param name="node">
/// the #GNode to insert
/// </param>
/// <return>
/// the inserted #GNode
/// </return>

	public static MentorLake.GLib.GNodeHandle InsertBefore(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle sibling, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_insert_before(parent, sibling, node);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @node is an ancestor of @descendant.
/// This is true if node is the parent of @descendant,
/// or if node is the grandparent of @descendant etc.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="descendant">
/// a #GNode
/// </param>
/// <return>
/// %TRUE if @node is an ancestor of @descendant
/// </return>

	public static bool IsAncestor(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GNodeHandle descendant)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_is_ancestor(node, descendant);
	}

/// <summary>
/// <para>
/// Gets the last child of a #GNode.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode (must not be %NULL)
/// </param>
/// <return>
/// the last child of @node, or %NULL if @node has no children
/// </return>

	public static MentorLake.GLib.GNodeHandle LastChild(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_last_child(node);
	}

/// <summary>
/// <para>
/// Gets the last sibling of a #GNode.
/// This could possibly be the node itself.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// the last sibling of @node
/// </return>

	public static MentorLake.GLib.GNodeHandle LastSibling(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_last_sibling(node);
	}

/// <summary>
/// <para>
/// Gets the maximum height of all branches beneath a #GNode.
/// This is the maximum distance from the #GNode to all leaf nodes.
/// </para>
/// <para>
/// If @root is %NULL, 0 is returned. If @root has no children,
/// 1 is returned. If @root has children, 2 is returned. And so on.
/// </para>
/// </summary>

/// <param name="root">
/// a #GNode
/// </param>
/// <return>
/// the maximum height of the tree beneath @root
/// </return>

	public static uint MaxHeight(this MentorLake.GLib.GNodeHandle root)
	{
		if (root.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_max_height(root);
	}

/// <summary>
/// <para>
/// Gets the number of children of a #GNode.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <return>
/// the number of children of @node
/// </return>

	public static uint NChildren(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_n_children(node);
	}

/// <summary>
/// <para>
/// Gets the number of nodes in a tree.
/// </para>
/// </summary>

/// <param name="root">
/// a #GNode
/// </param>
/// <param name="flags">
/// which types of children are to be counted, one of
///     %G_TRAVERSE_ALL, %G_TRAVERSE_LEAVES and %G_TRAVERSE_NON_LEAVES
/// </param>
/// <return>
/// the number of nodes in the tree
/// </return>

	public static uint NNodes(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseFlags flags)
	{
		if (root.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_n_nodes(root, flags);
	}

/// <summary>
/// <para>
/// Gets a child of a #GNode, using the given index.
/// The first child is at index 0. If the index is
/// too big, %NULL is returned.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode
/// </param>
/// <param name="n">
/// the index of the desired child
/// </param>
/// <return>
/// the child of @node at index @n
/// </return>

	public static MentorLake.GLib.GNodeHandle NthChild(this MentorLake.GLib.GNodeHandle node, uint n)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_nth_child(node, n);
	}

/// <summary>
/// <para>
/// Inserts a #GNode as the first child of the given parent.
/// </para>
/// </summary>

/// <param name="parent">
/// the #GNode to place the new #GNode under
/// </param>
/// <param name="node">
/// the #GNode to insert
/// </param>
/// <return>
/// the inserted #GNode
/// </return>

	public static MentorLake.GLib.GNodeHandle Prepend(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid) throw new Exception("Invalid handle (GNode)");
		return GNodeExterns.g_node_prepend(parent, node);
	}

/// <summary>
/// <para>
/// Reverses the order of the children of a #GNode.
/// (It doesn't change the order of the grandchildren.)
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode.
/// </param>

	public static void ReverseChildren(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		GNodeExterns.g_node_reverse_children(node);
	}

/// <summary>
/// <para>
/// Traverses a tree starting at the given root #GNode.
/// It calls the given function for each node visited.
/// The traversal can be halted at any point by returning %TRUE from @func.
/// @func must not do anything that would modify the structure of the tree.
/// </para>
/// </summary>

/// <param name="root">
/// the root #GNode of the tree to traverse
/// </param>
/// <param name="order">
/// the order in which nodes are visited - %G_IN_ORDER,
///     %G_PRE_ORDER, %G_POST_ORDER, or %G_LEVEL_ORDER.
/// </param>
/// <param name="flags">
/// which types of children are to be visited, one of
///     %G_TRAVERSE_ALL, %G_TRAVERSE_LEAVES and %G_TRAVERSE_NON_LEAVES
/// </param>
/// <param name="max_depth">
/// the maximum depth of the traversal. Nodes below this
///     depth will not be visited. If max_depth is -1 all nodes in
///     the tree are visited. If depth is 1, only the root is visited.
///     If depth is 2, the root and its children are visited. And so on.
/// </param>
/// <param name="func">
/// the function to call for each visited #GNode
/// </param>
/// <param name="data">
/// user data to pass to the function
/// </param>

	public static void Traverse(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, int max_depth, MentorLake.GLib.GNodeTraverseFunc func, IntPtr data)
	{
		if (root.IsInvalid) throw new Exception("Invalid handle (GNode)");
		GNodeExterns.g_node_traverse(root, order, flags, max_depth, func, data);
	}

/// <summary>
/// <para>
/// Unlinks a #GNode from a tree, resulting in two separate trees.
/// </para>
/// </summary>

/// <param name="node">
/// the #GNode to unlink, which becomes the root of a new tree
/// </param>

	public static void Unlink(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GNode)");
		GNodeExterns.g_node_unlink(node);
	}


	public static GNode Dereference(this GNodeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNode>(x.DangerousGetHandle());
}
internal class GNodeExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_node_child_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_node_child_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle child);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_children_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, MentorLake.GLib.GNodeForeachFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GCopyFunc copy_func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_find_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_first_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_get_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, int position, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_node_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle descendant);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_last_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_last_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_max_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_n_nodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseFlags flags);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_nth_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_reverse_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_traverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, int max_depth, MentorLake.GLib.GNodeTraverseFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_unlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))]
	internal static extern MentorLake.GLib.GNodeHandle g_node_new(IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

}

/// <summary>
/// <para>
/// The #GNode struct represents one node in a [n-ary tree][glib-N-ary-Trees].
/// </para>
/// </summary>

public struct GNode
{
	/// <summary>
/// <para>
/// contains the actual data of the node.
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// points to the node's next sibling (a sibling is another
///        #GNode with the same parent).
/// </para>
/// </summary>

public IntPtr next;
	/// <summary>
/// <para>
/// points to the node's previous sibling.
/// </para>
/// </summary>

public IntPtr prev;
	/// <summary>
/// <para>
/// points to the parent of the #GNode, or is %NULL if the
///          #GNode is the root of the tree.
/// </para>
/// </summary>

public IntPtr parent;
	/// <summary>
/// <para>
/// points to the first child of the #GNode.  The other
///            children are accessed by using the @next pointer of each
///            child.
/// </para>
/// </summary>

public IntPtr children;
/// <summary>
/// <para>
/// Creates a new #GNode containing the given data.
/// Used to create the first node in a tree.
/// </para>
/// </summary>

/// <param name="data">
/// the data of the new node
/// </param>
/// <return>
/// a new #GNode
/// </return>

	public static MentorLake.GLib.GNodeHandle New(IntPtr data)
	{
		return GNodeExterns.g_node_new(data);
	}



	public static void PopAllocator()
	{
		GNodeExterns.g_node_pop_allocator();
	}


/// <param name="allocator">
/// </param>

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GNodeExterns.g_node_push_allocator(allocator);
	}

}
