namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function which decides whether the row indicated by @iter is visible.
/// </para>
/// </summary>

/// <param name="model">
/// the child model of the #GtkTreeModelFilter
/// </param>
/// <param name="iter">
/// a #GtkTreeIter pointing to the row in @model whose visibility
///   is determined
/// </param>
/// <param name="data">
/// user data given to gtk_tree_model_filter_set_visible_func()
/// </param>
/// <return>
/// Whether the row indicated by @iter is visible.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeModelFilterVisibleFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
