namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_node_traverse(). The
/// function is called with each of the nodes visited, together with the
/// user data passed to g_node_traverse(). If the function returns
/// %TRUE, then the traversal is stopped.
/// </para>
/// </summary>

/// <param name="node">
/// a #GNode.
/// </param>
/// <param name="data">
/// user data passed to g_node_traverse().
/// </param>
/// <return>
/// %TRUE to stop the traversal.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GNodeTraverseFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GNodeHandle>))] MentorLake.GLib.GNodeHandle node, IntPtr data);
