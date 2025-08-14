namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Key snooper functions are called before normal event delivery.
/// They can be used to implement custom key event handling.
/// </para>
/// </summary>

/// <param name="grab_widget">
/// the widget to which the event will be delivered
/// </param>
/// <param name="@event">
/// the key event
/// </param>
/// <param name="func_data">
/// data supplied to gtk_key_snooper_install()
/// </param>
/// <return>
/// %TRUE to stop further processing of @event, %FALSE to continue.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkKeySnoopFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle grab_widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event, IntPtr func_data);
