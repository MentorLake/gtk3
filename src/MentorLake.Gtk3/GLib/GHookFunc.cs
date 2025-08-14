namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of a hook function that can be invoked
/// by g_hook_list_invoke().
/// </para>
/// </summary>

/// <param name="data">
/// the data field of the #GHook is passed to the hook function here
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookFunc(IntPtr data);
