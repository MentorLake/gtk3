namespace MentorLake.Gtk;


/// <param name="accel_group">
/// </param>
/// <param name="acceleratable">
/// </param>
/// <param name="keyval">
/// </param>
/// <param name="modifier">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkAccelGroupActivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle acceleratable, uint keyval, MentorLake.Gdk.GdkModifierType modifier);
