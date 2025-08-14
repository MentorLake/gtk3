namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function which calculates display values from raw values in the model.
/// It must fill @value with the display value for the column @column in the
/// row indicated by @iter.
/// </para>
/// <para>
/// Since this function is called for each data access, it’s not a
/// particularly efficient operation.
/// </para>
/// </summary>

/// <param name="model">
/// the #GtkTreeModelFilter
/// </param>
/// <param name="iter">
/// a #GtkTreeIter pointing to the row whose display values are determined
/// </param>
/// <param name="value">
/// A #GValue which is already initialized for
///  with the correct type for the column @column.
/// </param>
/// <param name="column">
/// the column whose display value is determined
/// </param>
/// <param name="data">
/// user data given to gtk_tree_model_filter_set_modify_func()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeModelFilterModifyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, out MentorLake.GObject.GValue value, int column, IntPtr data);
