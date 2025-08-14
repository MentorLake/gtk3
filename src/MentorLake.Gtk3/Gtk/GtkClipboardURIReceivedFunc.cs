namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of
/// gtk_clipboard_request_uris() are received, or when the request
/// fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="uris">
/// the received URIs
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_uris().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardURIReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, string[] uris, IntPtr data);
