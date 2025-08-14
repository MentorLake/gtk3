namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the function passed to g_completion_new(). It
/// should return the string corresponding to the given target item.
/// This is used when you use data structures as #GCompletion items.
/// </para>
/// </summary>

/// <param name="item">
/// the completion item.
/// </param>
/// <return>
/// the string corresponding to the item.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GCompletionFunc(IntPtr item);
