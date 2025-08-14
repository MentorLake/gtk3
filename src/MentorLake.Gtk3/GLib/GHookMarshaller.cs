namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of function used by g_hook_list_marshal().
/// </para>
/// </summary>

/// <param name="hook">
/// a #GHook
/// </param>
/// <param name="marshal_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GHookMarshaller([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, IntPtr marshal_data);
