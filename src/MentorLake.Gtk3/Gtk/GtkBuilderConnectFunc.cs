namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This is the signature of a function used to connect signals.  It is used
/// by the gtk_builder_connect_signals() and gtk_builder_connect_signals_full()
/// methods.  It is mainly intended for interpreted language bindings, but
/// could be useful where the programmer wants more control over the signal
/// connection process. Note that this function can only be called once,
/// subsequent calls will do nothing.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="@object">
/// object to connect a signal to
/// </param>
/// <param name="signal_name">
/// name of the signal
/// </param>
/// <param name="handler_name">
/// name of the handler
/// </param>
/// <param name="connect_object">
/// a #GObject, if non-%NULL, use g_signal_connect_object()
/// </param>
/// <param name="flags">
/// #GConnectFlags to use
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkBuilderConnectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_name, string handler_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle connect_object, MentorLake.GObject.GConnectFlags flags, IntPtr user_data);
