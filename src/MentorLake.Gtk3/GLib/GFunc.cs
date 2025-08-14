namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of functions passed to g_list_foreach() and
/// g_slist_foreach().
/// </para>
/// </summary>

/// <param name="data">
/// the element's data
/// </param>
/// <param name="user_data">
/// user data passed to g_list_foreach() or g_slist_foreach()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFunc(IntPtr data, IntPtr user_data);
