namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A multihead-aware GTK+ module may have a gtk_module_display_init() function
/// with this prototype. GTK+ calls this function for each opened display.
/// </para>
/// </summary>

/// <param name="display">
/// an open #GdkDisplay
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkModuleDisplayInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);
