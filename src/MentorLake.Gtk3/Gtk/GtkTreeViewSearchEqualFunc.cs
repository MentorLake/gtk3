namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used for checking whether a row in @model matches
/// a search key string entered by the user. Note the return value
/// is reversed from what you would normally expect, though it
/// has some similarity to strcmp() returning 0 for equal strings.
/// </para>
/// </summary>

/// <param name="model">
/// the #GtkTreeModel being searched
/// </param>
/// <param name="column">
/// the search column set by gtk_tree_view_set_search_column()
/// </param>
/// <param name="key">
/// the key string to compare with
/// </param>
/// <param name="iter">
/// a #GtkTreeIter pointing the row of @model that should be compared
///  with @key.
/// </param>
/// <param name="search_data">
/// user data from gtk_tree_view_set_search_equal_func()
/// </param>
/// <return>
/// %FALSE if the row matches, %TRUE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeViewSearchEqualFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, int column, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr search_data);
