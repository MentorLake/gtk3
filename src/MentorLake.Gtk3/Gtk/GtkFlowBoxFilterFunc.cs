namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function that will be called whenrever a child changes
/// or is added. It lets you control if the child should be
/// visible or not.
/// </para>
/// </summary>

/// <param name="child">
/// a #GtkFlowBoxChild that may be filtered
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// %TRUE if the row should be visible, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkFlowBoxFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child, IntPtr user_data);
