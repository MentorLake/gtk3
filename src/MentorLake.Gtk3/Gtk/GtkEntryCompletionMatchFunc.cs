namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function which decides whether the row indicated by @iter matches
/// a given @key, and should be displayed as a possible completion for @key.
/// Note that @key is normalized and case-folded (see g_utf8_normalize()
/// and g_utf8_casefold()). If this is not appropriate, match functions
/// have access to the unmodified key via
/// `gtk_entry_get_text (GTK_ENTRY (gtk_entry_completion_get_entry ()))`.
/// </para>
/// </summary>

/// <param name="completion">
/// the #GtkEntryCompletion
/// </param>
/// <param name="key">
/// the string to match, normalized and case-folded
/// </param>
/// <param name="iter">
/// a #GtkTreeIter indicating the row to match
/// </param>
/// <param name="user_data">
/// user data given to gtk_entry_completion_set_match_func()
/// </param>
/// <return>
/// %TRUE if @iter should be displayed as a possible completion
///     for @key
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkEntryCompletionMatchFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);
