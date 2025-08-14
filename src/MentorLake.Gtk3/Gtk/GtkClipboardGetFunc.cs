namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function that will be called to provide the contents of the selection.
/// If multiple types of data were advertised, the requested type can
/// be determined from the @info parameter or by checking the target field
/// of @selection_data. If the data could successfully be converted into
/// then it should be stored into the @selection_data object by
/// calling gtk_selection_data_set() (or related functions such
/// as gtk_selection_data_set_text()). If no data is set, the requestor
/// will be informed that the attempt to get the data failed.
/// </para>
/// </summary>

/// <param name="clipboard">
/// the #GtkClipboard
/// </param>
/// <param name="selection_data">
/// a #GtkSelectionData argument in which the requested
///   data should be stored.
/// </param>
/// <param name="info">
/// the info field corresponding to the requested target from the
///   #GtkTargetEntry array passed to gtk_clipboard_set_with_data() or
///   gtk_clipboard_set_with_owner().
/// </param>
/// <param name="user_data_or_owner">
/// the @user_data argument passed to
///   gtk_clipboard_set_with_data(), or the @owner argument passed to
///   gtk_clipboard_set_with_owner()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardGetFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkClipboardHandle>))] MentorLake.Gtk.GtkClipboardHandle clipboard, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, uint info, IntPtr user_data_or_owner);
