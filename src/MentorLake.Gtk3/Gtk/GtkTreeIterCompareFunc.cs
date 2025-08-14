namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkTreeIterCompareFunc should return a negative integer, zero, or a positive
/// integer if @a sorts before @b, @a sorts with @b, or @a sorts after @b
/// respectively. If two iters compare as equal, their order in the sorted model
/// is undefined. In order to ensure that the #GtkTreeSortable behaves as
/// expected, the GtkTreeIterCompareFunc must define a partial order on
/// the model, i.e. it must be reflexive, antisymmetric and transitive.
/// </para>
/// <para>
/// For example, if @model is a product catalogue, then a compare function
/// for the “price” column could be one which returns
/// `price_of(@a) - price_of(@b)`.
/// </para>
/// </summary>

/// <param name="model">
/// The #GtkTreeModel the comparison is within
/// </param>
/// <param name="a">
/// A #GtkTreeIter in @model
/// </param>
/// <param name="b">
/// Another #GtkTreeIter in @model
/// </param>
/// <param name="user_data">
/// Data passed when the compare func is assigned e.g. by
///  gtk_tree_sortable_set_sort_func()
/// </param>
/// <return>
/// a negative integer, zero or a positive integer depending on whether
///   @a sorts before, with or after @b
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkTreeIterCompareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle b, IntPtr user_data);
