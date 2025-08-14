namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function that will be called when the contents of the clipboard are changed
/// or cleared. Once this has called, the @user_data_or_owner argument
/// will not be used again.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="user_data_or_owner">
/// the @user_data argument passed to gtk_clipboard_set_with_data(),
///   or the @owner argument passed to gtk_clipboard_set_with_owner()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardClearFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, IntPtr user_data_or_owner);
