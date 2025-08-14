namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of function used to compare #GHook elements in
/// g_hook_insert_sorted().
/// </para>
/// </summary>

/// <param name="new_hook">
/// the #GHook being inserted
/// </param>
/// <param name="sibling">
/// the #GHook to compare with @new_hook
/// </param>
/// <return>
/// a value <= 0 if @new_hook should be before @sibling
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GHookCompareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle new_hook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle sibling);
