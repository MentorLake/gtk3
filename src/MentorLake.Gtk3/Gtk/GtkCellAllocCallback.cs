namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of the callback functions used for iterating over the
/// cell renderers and their allocated areas inside a #GtkCellArea,
/// see gtk_cell_area_foreach_alloc().
/// </para>
/// </summary>

/// <param name="renderer">
/// the cell renderer to operate on
/// </param>
/// <param name="cell_area">
/// the area allocated to @renderer inside the rectangle
///     provided to gtk_cell_area_foreach_alloc().
/// </param>
/// <param name="cell_background">
/// the background area for @renderer inside the
///     background area provided to gtk_cell_area_foreach_alloc().
/// </param>
/// <param name="data">
/// user-supplied data
/// </param>
/// <return>
/// %TRUE to stop iterating over cells.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkCellAllocCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle cell_background, IntPtr data);
