namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of gtk_clipboard_request_text()
/// are received, or when the request fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="text">
/// the text received, as a UTF-8 encoded string, or
///   %NULL if retrieving the data failed.
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_text().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardTextReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, string text, IntPtr data);
