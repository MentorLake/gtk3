namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of gtk_clipboard_request_image()
/// are received, or when the request fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="pixbuf">
/// the received image
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_image().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardImageReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, IntPtr data);
