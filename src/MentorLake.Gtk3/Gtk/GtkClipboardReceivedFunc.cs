namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of gtk_clipboard_request_contents()
/// are received, or when the request fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="selection_data">
/// a #GtkSelectionData containing the data was received.
///   If retrieving the data failed, then then length field
///   of @selection_data will be negative.
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_contents().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, IntPtr data);
