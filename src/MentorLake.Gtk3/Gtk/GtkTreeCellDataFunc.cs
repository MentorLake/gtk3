namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to set the properties of a cell instead of just using the
/// straight mapping between the cell and the model.  This is useful for
/// customizing the cell renderer.  For example, a function might get an
/// integer from the @tree_model, and render it to the “text” attribute of
/// “cell” by converting it to its written equivalent.  This is set by
/// calling gtk_tree_view_column_set_cell_data_func()
/// </para>
/// </summary>

/// <param name="tree_column">
/// A #GtkTreeViewColumn
/// </param>
/// <param name="cell">
/// The #GtkCellRenderer that is being rendered by @tree_column
/// </param>
/// <param name="tree_model">
/// The #GtkTreeModel being rendered
/// </param>
/// <param name="iter">
/// A #GtkTreeIter of the current row rendered
/// </param>
/// <param name="data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeCellDataFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewColumnHandle>))] MentorLake.Gtk.GtkTreeViewColumnHandle tree_column, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle cell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
