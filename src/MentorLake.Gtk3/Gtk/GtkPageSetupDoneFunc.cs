namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of function that is passed to
/// gtk_print_run_page_setup_dialog_async().
/// </para>
/// <para>
/// This function will be called when the page setup dialog
/// is dismissed, and also serves as destroy notify for @data.
/// </para>
/// </summary>

/// <param name="page_setup">
/// the #GtkPageSetup that has been
/// </param>
/// <param name="data">
/// user data that has been passed to
///     gtk_print_run_page_setup_dialog_async()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPageSetupDoneFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup, IntPtr data);
