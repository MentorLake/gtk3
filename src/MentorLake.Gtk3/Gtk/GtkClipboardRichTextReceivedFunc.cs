namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of
/// gtk_clipboard_request_rich_text() are received, or when the request
/// fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="format">
/// The format of the rich text
/// </param>
/// <param name="text">
/// the rich text received, as
///   a UTF-8 encoded string, or %NULL if retrieving the data failed.
/// </param>
/// <param name="length">
/// Length of the text.
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_rich_text().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardRichTextReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom format, string text, UIntPtr length, IntPtr data);
