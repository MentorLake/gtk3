namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function which should set the value of @cell_layout’s cell renderer(s)
/// as appropriate.
/// </para>
/// </summary>

/// <param name="cell_layout">
/// a #GtkCellLayout
/// </param>
/// <param name="cell">
/// the cell renderer whose value is to be set
/// </param>
/// <param name="tree_model">
/// the model
/// </param>
/// <param name="iter">
/// a #GtkTreeIter indicating the row to set the value for
/// </param>
/// <param name="data">
/// user data passed to gtk_cell_layout_set_cell_data_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkCellLayoutDataFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellLayoutHandleImpl>))] MentorLake.Gtk.GtkCellLayoutHandle cell_layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
