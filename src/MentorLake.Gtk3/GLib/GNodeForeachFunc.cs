namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_node_children_foreach().
/// The function is called with each child node, together with the user
/// data passed to g_node_children_foreach().
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode.
/// </param>
/// <param name="data">
/// user data passed to g_node_children_foreach().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GNodeForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, IntPtr data);
