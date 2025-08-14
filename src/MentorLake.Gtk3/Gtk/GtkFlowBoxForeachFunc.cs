namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_flow_box_selected_foreach().
/// It will be called on every selected child of the @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkFlowBox
/// </param>
/// <param name="child">
/// a #GtkFlowBoxChild
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkFlowBoxForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxHandle>))] MentorLake.Gtk.GtkFlowBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child, IntPtr user_data);
