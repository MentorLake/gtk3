namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Function type for determining whether the row pointed to by @iter should
/// be rendered as a separator. A common way to implement this is to have a
/// boolean column in the model, whose values the #GtkTreeViewRowSeparatorFunc
/// returns.
/// </para>
/// </summary>

/// <param name="model">
/// the #GtkTreeModel
/// </param>
/// <param name="iter">
/// a #GtkTreeIter pointing at a row in @model
/// </param>
/// <param name="data">
/// user data
/// </param>
/// <return>
/// %TRUE if the row is a separator
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTreeViewRowSeparatorFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr data);
