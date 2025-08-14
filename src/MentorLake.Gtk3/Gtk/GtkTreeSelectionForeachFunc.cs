namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_tree_selection_selected_foreach() to map all
/// selected rows.  It will be called on every selected row in the view.
/// </para>
/// </summary>

/// <param name="model">
/// The #GtkTreeModel being viewed
/// </param>
/// <param name="path">
/// The #GtkTreePath of a selected row
/// </param>
/// <param name="iter">
/// A #GtkTreeIter pointing to a selected row
/// </param>
/// <param name="data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeSelectionForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
