namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque type which identifies a specific node in a #GTree.
/// </para>
/// </summary>

public class GTreeNodeHandle : BaseSafeHandle
{
}


public static class GTreeNodeExtensions
{
/// <summary>
/// <para>
/// Gets the key stored at a particular tree node.
/// </para>
/// </summary>

/// <param name="node">
/// a #GTree node
/// </param>
/// <return>
/// the key at the node.
/// </return>

	public static IntPtr Key(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_key(node);
	}

/// <summary>
/// <para>
/// Returns the next in-order node of the tree, or %NULL
/// if the passed node was already the last one.
/// </para>
/// </summary>

/// <param name="node">
/// a #GTree node
/// </param>
/// <return>
/// the next node in the tree
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle Next(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_next(node);
	}

/// <summary>
/// <para>
/// Returns the previous in-order node of the tree, or %NULL
/// if the passed node was already the first one.
/// </para>
/// </summary>

/// <param name="node">
/// a #GTree node
/// </param>
/// <return>
/// the previous node in the tree
/// </return>

	public static MentorLake.GLib.GTreeNodeHandle Previous(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_previous(node);
	}

/// <summary>
/// <para>
/// Gets the value stored at a particular tree node.
/// </para>
/// </summary>

/// <param name="node">
/// a #GTree node
/// </param>
/// <return>
/// the value at the node.
/// </return>

	public static IntPtr Value(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_value(node);
	}


	public static GTreeNode Dereference(this GTreeNodeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTreeNode>(x.DangerousGetHandle());
}
internal class GTreeNodeExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_node_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))] MentorLake.GLib.GTreeNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))] MentorLake.GLib.GTreeNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_previous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))] MentorLake.GLib.GTreeNodeHandle node);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_node_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))] MentorLake.GLib.GTreeNodeHandle node);

}

/// <summary>
/// <para>
/// An opaque type which identifies a specific node in a #GTree.
/// </para>
/// </summary>

public struct GTreeNode
{
}
