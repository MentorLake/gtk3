namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of function that is used with custom filters, see
/// gtk_file_filter_add_custom().
/// </para>
/// </summary>

/// <param name="filter_info">
/// a #GtkFileFilterInfo that is filled according
///   to the @needed flags passed to gtk_file_filter_add_custom()
/// </param>
/// <param name="data">
/// user data passed to gtk_file_filter_add_custom()
/// </param>
/// <return>
/// %TRUE if the file should be displayed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkFileFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileFilterInfoHandle>))] MentorLake.Gtk.GtkFileFilterInfoHandle filter_info, IntPtr data);
