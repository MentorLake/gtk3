namespace MentorLake.Gtk;


/// <param name="tree_view">
/// </param>
/// <param name="path">
/// </param>
/// <param name="children">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkTreeDestroyCountFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeViewHandle>))] MentorLake.Gtk.GtkTreeViewHandle tree_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, int children, IntPtr user_data);
