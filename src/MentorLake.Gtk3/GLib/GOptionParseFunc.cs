namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of function that can be called before and after parsing.
/// </para>
/// </summary>

/// <param name="context">
/// The active #GOptionContext
/// </param>
/// <param name="group">
/// The group to which the function belongs
/// </param>
/// <param name="data">
/// User data added to the #GOptionGroup containing the option when it
///  was created with g_option_group_new()
/// </param>
/// <return>
/// %TRUE if the function completed successfully, %FALSE if an error
///  occurred, in which case @error should be set with g_set_error()
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GOptionParseFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, IntPtr data);
