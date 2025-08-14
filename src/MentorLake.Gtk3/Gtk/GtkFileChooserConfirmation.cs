namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used as a return value of handlers for the
/// #GtkFileChooser::confirm-overwrite signal of a #GtkFileChooser. This
/// value determines whether the file chooser will present the stock
/// confirmation dialog, accept the user’s choice of a filename, or
/// let the user choose another filename.
/// </para>
/// </summary>

[Flags]
public enum GtkFileChooserConfirmation
{
/// <summary>
/// <para>
/// The file chooser will present
///  its stock dialog to confirm about overwriting an existing file.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM = 0,
/// <summary>
/// <para>
/// The file chooser will
///  terminate and accept the user’s choice of a file name.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME = 1,
/// <summary>
/// <para>
/// The file chooser will
///  continue running, so as to let the user select another file name.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN = 2
}
