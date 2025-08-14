namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_list_box_selected_foreach().
/// It will be called on every selected child of the @box.
/// </para>
/// </summary>

/// <param name="box">
/// a #GtkListBox
/// </param>
/// <param name="row">
/// a #GtkListBoxRow
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkListBoxForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxHandle>))] MentorLake.Gtk.GtkListBoxHandle box, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, IntPtr user_data);
