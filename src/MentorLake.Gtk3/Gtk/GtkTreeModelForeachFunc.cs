namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Type of the callback passed to gtk_tree_model_foreach() to
/// iterate over the rows in a tree model.
/// </para>
/// </summary>

/// <param name="model">
/// the #GtkTreeModel being iterated
/// </param>
/// <param name="path">
/// the current #GtkTreePath
/// </param>
/// <param name="iter">
/// the current #GtkTreeIter
/// </param>
/// <param name="data">
/// The user data passed to gtk_tree_model_foreach()
/// </param>
/// <return>
/// %TRUE to stop iterating, %FALSE to continue
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeModelForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
