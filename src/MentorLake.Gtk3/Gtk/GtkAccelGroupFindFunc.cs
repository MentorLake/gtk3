namespace MentorLake.Gtk;


/// <param name="key">
/// </param>
/// <param name="closure">
/// </param>
/// <param name="data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkAccelGroupFindFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelKeyHandle>))] MentorLake.Gtk.GtkAccelKeyHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr data);
