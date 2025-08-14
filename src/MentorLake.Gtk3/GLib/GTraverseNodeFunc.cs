namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_tree_foreach_node(). It is
/// passed each node, together with the @user_data parameter passed to
/// g_tree_foreach_node(). If the function returns %TRUE, the traversal is
/// stopped.
/// </para>
/// </summary>

/// <param name="node">
/// a #GTreeNode
/// </param>
/// <param name="data">
/// user data passed to g_tree_foreach_node()
/// </param>
/// <return>
/// %TRUE to stop the traversal
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTraverseNodeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeNodeHandle>))] MentorLake.GLib.GTreeNodeHandle node, IntPtr data);
