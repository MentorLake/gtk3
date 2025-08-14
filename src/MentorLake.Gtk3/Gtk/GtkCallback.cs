namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of the callback functions used for e.g. iterating over
/// the children of a container, see gtk_container_foreach().
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to operate on
/// </param>
/// <param name="data">
/// user-supplied data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr data);
