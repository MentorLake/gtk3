namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines the type of function used by g_hook_list_marshal_check().
/// </para>
/// </summary>

/// <param name="hook">
/// a #GHook
/// </param>
/// <param name="marshal_data">
/// user data
/// </param>
/// <return>
/// %FALSE if @hook should be destroyed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHookCheckMarshaller([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, IntPtr marshal_data);
