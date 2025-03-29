namespace MentorLake.GLib;

public class GNodeHandle : BaseSafeHandle
{
}


public static class GNodeExtensions
{
	public static int ChildIndex(this MentorLake.GLib.GNodeHandle node, IntPtr data)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_child_index(node, data);
	}

	public static int ChildPosition(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GNodeHandle child)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_child_position(node, child);
	}

	public static void ChildrenForeach(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, MentorLake.GLib.GNodeForeachFunc func, IntPtr data)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		GNodeExterns.g_node_children_foreach(node, flags, func, data);
	}

	public static MentorLake.GLib.GNodeHandle Copy(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_copy(node);
	}

	public static MentorLake.GLib.GNodeHandle CopyDeep(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GCopyFunc copy_func, IntPtr data)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_copy_deep(node, copy_func, data);
	}

	public static uint Depth(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_depth(node);
	}

	public static void Destroy(this MentorLake.GLib.GNodeHandle root)
	{
		if (root.IsInvalid || root.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		GNodeExterns.g_node_destroy(root);
	}

	public static MentorLake.GLib.GNodeHandle Find(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, IntPtr data)
	{
		if (root.IsInvalid || root.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_find(root, order, flags, data);
	}

	public static MentorLake.GLib.GNodeHandle FindChild(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, IntPtr data)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_find_child(node, flags, data);
	}

	public static MentorLake.GLib.GNodeHandle FirstSibling(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_first_sibling(node);
	}

	public static MentorLake.GLib.GNodeHandle GetRoot(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_get_root(node);
	}

	public static MentorLake.GLib.GNodeHandle Insert(this MentorLake.GLib.GNodeHandle parent, int position, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid || parent.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_insert(parent, position, node);
	}

	public static MentorLake.GLib.GNodeHandle InsertAfter(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle sibling, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid || parent.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_insert_after(parent, sibling, node);
	}

	public static MentorLake.GLib.GNodeHandle InsertBefore(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle sibling, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid || parent.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_insert_before(parent, sibling, node);
	}

	public static bool IsAncestor(this MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GNodeHandle descendant)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_is_ancestor(node, descendant);
	}

	public static MentorLake.GLib.GNodeHandle LastChild(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_last_child(node);
	}

	public static MentorLake.GLib.GNodeHandle LastSibling(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_last_sibling(node);
	}

	public static uint MaxHeight(this MentorLake.GLib.GNodeHandle root)
	{
		if (root.IsInvalid || root.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_max_height(root);
	}

	public static uint NChildren(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_n_children(node);
	}

	public static uint NNodes(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseFlags flags)
	{
		if (root.IsInvalid || root.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_n_nodes(root, flags);
	}

	public static MentorLake.GLib.GNodeHandle NthChild(this MentorLake.GLib.GNodeHandle node, uint n)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_nth_child(node, n);
	}

	public static MentorLake.GLib.GNodeHandle Prepend(this MentorLake.GLib.GNodeHandle parent, MentorLake.GLib.GNodeHandle node)
	{
		if (parent.IsInvalid || parent.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		return GNodeExterns.g_node_prepend(parent, node);
	}

	public static void ReverseChildren(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		GNodeExterns.g_node_reverse_children(node);
	}

	public static void Traverse(this MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, int max_depth, MentorLake.GLib.GNodeTraverseFunc func, IntPtr data)
	{
		if (root.IsInvalid || root.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
		GNodeExterns.g_node_traverse(root, order, flags, max_depth, func, data);
	}

	public static void Unlink(this MentorLake.GLib.GNodeHandle node)
	{
		if (node.IsInvalid || node.IsClosed) throw new Exception("Invalid or closed handle (GNode)");
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
	internal static extern MentorLake.GLib.GNodeHandle g_node_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_copy_deep([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GCopyFunc copy_func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_find_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, MentorLake.GLib.GTraverseFlags flags, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_first_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_get_root([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, int position, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_node_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle descendant);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_last_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_last_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_max_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_node_n_nodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_nth_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_reverse_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_traverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle root, MentorLake.GLib.GTraverseType order, MentorLake.GLib.GTraverseFlags flags, int max_depth, MentorLake.GLib.GNodeTraverseFunc func, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_unlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GNodeHandle g_node_new(IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

}

public struct GNode
{
	public IntPtr data;
	public IntPtr next;
	public IntPtr prev;
	public IntPtr parent;
	public IntPtr children;
	public static MentorLake.GLib.GNodeHandle New(IntPtr data)
	{
		return GNodeExterns.g_node_new(data);
	}

	public static void PopAllocator()
	{
		GNodeExterns.g_node_pop_allocator();
	}

	public static void PushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GNodeExterns.g_node_push_allocator(allocator);
	}

}
