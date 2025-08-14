namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These flags indicate what parts of a #GtkFileFilterInfo struct
/// are filled or need to be filled.
/// </para>
/// </summary>

[Flags]
public enum GtkFileFilterFlags : uint
{
/// <summary>
/// <para>
/// the filename of the file being tested
/// </para>
/// </summary>

	GTK_FILE_FILTER_FILENAME = 1,
/// <summary>
/// <para>
/// the URI for the file being tested
/// </para>
/// </summary>

	GTK_FILE_FILTER_URI = 2,
/// <summary>
/// <para>
/// the string that will be used to
///   display the file in the file chooser
/// </para>
/// </summary>

	GTK_FILE_FILTER_DISPLAY_NAME = 4,
/// <summary>
/// <para>
/// the mime type of the file
/// </para>
/// </summary>

	GTK_FILE_FILTER_MIME_TYPE = 8
}
