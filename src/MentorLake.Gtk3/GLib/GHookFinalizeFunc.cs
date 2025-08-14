namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of function to be called when a hook in a
/// list of hooks gets finalized.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the hook in @hook_list that gets finalized
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);
