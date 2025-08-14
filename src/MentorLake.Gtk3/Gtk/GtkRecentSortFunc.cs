namespace MentorLake.Gtk;


/// <param name="a">
/// </param>
/// <param name="b">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkRecentSortFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentInfoHandle>))] MentorLake.Gtk.GtkRecentInfoHandle b, IntPtr user_data);
