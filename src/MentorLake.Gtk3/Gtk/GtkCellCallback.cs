namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of the callback functions used for iterating over
/// the cell renderers of a #GtkCellArea, see gtk_cell_area_foreach().
/// </para>
/// </summary>

/// <param name="renderer">
/// the cell renderer to operate on
/// </param>
/// <param name="data">
/// user-supplied data
/// </param>
/// <return>
/// %TRUE to stop iterating over cells.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkCellCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererHandle>))] MentorLake.Gtk.GtkCellRendererHandle renderer, IntPtr data);
