namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A user function supplied when calling gtk_menu_attach_to_widget() which
/// will be called when the menu is later detached from the widget.
/// </para>
/// </summary>

/// <param name="attach_widget">
/// the #GtkWidget that the menu is being detached from.
/// </param>
/// <param name="menu">
/// the #GtkMenu being detached.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkMenuDetachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle attach_widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu);
