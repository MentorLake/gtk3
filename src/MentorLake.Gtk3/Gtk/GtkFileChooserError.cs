namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These identify the various errors that can occur while calling
/// #GtkFileChooser functions.
/// </para>
/// </summary>

[Flags]
public enum GtkFileChooserError
{
/// <summary>
/// <para>
/// Indicates that a file does not exist.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ERROR_NONEXISTENT = 0,
/// <summary>
/// <para>
/// Indicates a malformed filename.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ERROR_BAD_FILENAME = 1,
/// <summary>
/// <para>
/// Indicates a duplicate path (e.g. when
///  adding a bookmark).
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ERROR_ALREADY_EXISTS = 2,
/// <summary>
/// <para>
/// Indicates an incomplete hostname (e.g. &quot;http://foo&quot; without a slash after that).
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ERROR_INCOMPLETE_HOSTNAME = 3
}
