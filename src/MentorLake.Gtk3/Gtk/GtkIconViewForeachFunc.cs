namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_icon_view_selected_foreach() to map all
/// selected rows.  It will be called on every selected row in the view.
/// </para>
/// </summary>

/// <param name="icon_view">
/// a #GtkIconView
/// </param>
/// <param name="path">
/// The #GtkTreePath of a selected row
/// </param>
/// <param name="data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkIconViewForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr data);
