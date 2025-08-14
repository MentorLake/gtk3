namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A function of this signature is used to copy the node data
/// when doing a deep-copy of a tree.
/// </para>
/// </summary>

/// <param name="src">
/// A pointer to the data which should be copied
/// </param>
/// <param name="data">
/// Additional data
/// </param>
/// <return>
/// A pointer to the copy
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GCopyFunc(IntPtr src, IntPtr data);
