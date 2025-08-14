namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_tree_selection_set_select_function() to filter
/// whether or not a row may be selected.  It is called whenever a row's
/// state might change.  A return value of %TRUE indicates to @selection
/// that it is okay to change the selection.
/// </para>
/// </summary>

/// <param name="selection">
/// A #GtkTreeSelection
/// </param>
/// <param name="model">
/// A #GtkTreeModel being viewed
/// </param>
/// <param name="path">
/// The #GtkTreePath of the row in question
/// </param>
/// <param name="path_currently_selected">
/// %TRUE, if the path is currently selected
/// </param>
/// <param name="data">
/// user data
/// </param>
/// <return>
/// %TRUE, if the selection state of the row can be toggled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeSelectionFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, bool path_currently_selected, IntPtr data);
