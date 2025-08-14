namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_tree_traverse(). It is
/// passed the key and value of each node, together with the @user_data
/// parameter passed to g_tree_traverse(). If the function returns
/// %TRUE, the traversal is stopped.
/// </para>
/// </summary>

/// <param name="key">
/// a key of a #GTree node
/// </param>
/// <param name="value">
/// the value corresponding to the key
/// </param>
/// <param name="data">
/// user data passed to g_tree_traverse()
/// </param>
/// <return>
/// %TRUE to stop the traversal
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTraverseFunc(IntPtr key, IntPtr value, IntPtr data);
