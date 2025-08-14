namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function to be called when the results of gtk_clipboard_request_targets()
/// are received, or when the request fails.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="atoms">
/// the supported targets,
///   as array of #GdkAtom, or %NULL if retrieving the data failed.
/// </param>
/// <param name="n_atoms">
/// the length of the @atoms array.
/// </param>
/// <param name="data">
/// the @user_data supplied to
///   gtk_clipboard_request_targets().
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardTargetsReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, MentorLake.Gdk.GdkAtom[] atoms, int n_atoms, IntPtr data);
