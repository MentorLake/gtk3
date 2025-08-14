namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of the function passed to g_hook_find().
/// </para>
/// </summary>

/// <param name="hook">
/// a #GHook
/// </param>
/// <param name="data">
/// user data passed to g_hook_find_func()
/// </param>
/// <return>
/// %TRUE if the required #GHook has been found
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHookFindFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, IntPtr data);
