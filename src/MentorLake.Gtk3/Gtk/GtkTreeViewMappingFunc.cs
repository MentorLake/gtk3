namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Function used for gtk_tree_view_map_expanded_rows().
/// </para>
/// </summary>

/// <param name="tree_view">
/// A #GtkTreeView
/// </param>
/// <param name="path">
/// The path that’s expanded
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeViewMappingFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr user_data);
