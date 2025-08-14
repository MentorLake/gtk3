namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Whenever @row changes or which row is before @row changes this
/// is called, which lets you update the header on @row. You may
/// remove or set a new one via gtk_list_box_row_set_header() or
/// just change the state of the current header widget.
/// </para>
/// </summary>

/// <param name="row">
/// the row to update
/// </param>
/// <param name="before">
/// the row before @row, or %NULL if it is first
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkListBoxUpdateHeaderFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle row, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkListBoxRowHandle>))] MentorLake.Gtk.GtkListBoxRowHandle before, IntPtr user_data);
