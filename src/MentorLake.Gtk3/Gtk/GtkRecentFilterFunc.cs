namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of function that is used with custom filters,
/// see gtk_recent_filter_add_custom().
/// </para>
/// </summary>

/// <param name="filter_info">
/// a #GtkRecentFilterInfo that is filled according
///  to the @needed flags passed to gtk_recent_filter_add_custom()
/// </param>
/// <param name="user_data">
/// user data passed to gtk_recent_filter_add_custom()
/// </param>
/// <return>
/// %TRUE if the file should be displayed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkRecentFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentFilterInfoHandle>))] MentorLake.Gtk.GtkRecentFilterInfoHandle filter_info, IntPtr user_data);
