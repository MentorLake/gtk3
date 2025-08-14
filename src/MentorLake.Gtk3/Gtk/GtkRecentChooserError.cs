namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These identify the various errors that can occur while calling
/// #GtkRecentChooser functions.
/// </para>
/// </summary>

[Flags]
public enum GtkRecentChooserError
{
/// <summary>
/// <para>
/// Indicates that a file does not exist
/// </para>
/// </summary>

	GTK_RECENT_CHOOSER_ERROR_NOT_FOUND = 0,
/// <summary>
/// <para>
/// Indicates a malformed URI
/// </para>
/// </summary>

	GTK_RECENT_CHOOSER_ERROR_INVALID_URI = 1
}
