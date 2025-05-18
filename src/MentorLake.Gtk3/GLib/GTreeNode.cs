namespace MentorLake.GLib;

public class GTreeNodeHandle : BaseSafeHandle
{
}


public static class GTreeNodeExtensions
{
	public static IntPtr Key(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_key(node);
	}

	public static MentorLake.GLib.GTreeNodeHandle Next(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_next(node);
	}

	public static MentorLake.GLib.GTreeNodeHandle Previous(this MentorLake.GLib.GTreeNodeHandle node)
	{
		if (node.IsInvalid) throw new Exception("Invalid handle (GTreeNode)");
		return GTreeNodeExterns.g_tree_node_previous(node);
	}

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

public struct GTreeNode
{
}
