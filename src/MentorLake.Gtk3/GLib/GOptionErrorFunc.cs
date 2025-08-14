namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of function to be used as callback when a parse error occurs.
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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GOptionErrorFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, IntPtr data);
