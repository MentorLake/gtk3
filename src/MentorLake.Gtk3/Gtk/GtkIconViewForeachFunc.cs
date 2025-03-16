namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkIconViewForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconViewHandle>))] MentorLake.Gtk.GtkIconViewHandle icon_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, IntPtr data);
