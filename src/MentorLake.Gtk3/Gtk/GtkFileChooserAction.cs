namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes whether a #GtkFileChooser is being used to open existing files
/// or to save to a possibly new file.
/// </para>
/// </summary>

[Flags]
public enum GtkFileChooserAction
{
/// <summary>
/// <para>
/// Indicates open mode.  The file chooser
///  will only let the user pick an existing file.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ACTION_OPEN = 0,
/// <summary>
/// <para>
/// Indicates save mode.  The file chooser
///  will let the user pick an existing file, or type in a new
///  filename.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ACTION_SAVE = 1,
/// <summary>
/// <para>
/// Indicates an Open mode for
///  selecting folders.  The file chooser will let the user pick an
///  existing folder.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER = 2,
/// <summary>
/// <para>
/// Indicates a mode for creating a
///  new folder.  The file chooser will let the user name an existing or
///  new folder.
/// </para>
/// </summary>

	GTK_FILE_CHOOSER_ACTION_CREATE_FOLDER = 3
}
