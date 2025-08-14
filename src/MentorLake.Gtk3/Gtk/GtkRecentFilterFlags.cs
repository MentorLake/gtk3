namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These flags indicate what parts of a #GtkRecentFilterInfo struct
/// are filled or need to be filled.
/// </para>
/// </summary>

[Flags]
public enum GtkRecentFilterFlags : uint
{
/// <summary>
/// <para>
/// the URI of the file being tested
/// </para>
/// </summary>

	GTK_RECENT_FILTER_URI = 1,
/// <summary>
/// <para>
/// the string that will be used to
///  display the file in the recent chooser
/// </para>
/// </summary>

	GTK_RECENT_FILTER_DISPLAY_NAME = 2,
/// <summary>
/// <para>
/// the mime type of the file
/// </para>
/// </summary>

	GTK_RECENT_FILTER_MIME_TYPE = 4,
/// <summary>
/// <para>
/// the list of applications that have
///  registered the file
/// </para>
/// </summary>

	GTK_RECENT_FILTER_APPLICATION = 8,
/// <summary>
/// <para>
/// the groups to which the file belongs to
/// </para>
/// </summary>

	GTK_RECENT_FILTER_GROUP = 16,
/// <summary>
/// <para>
/// the number of days elapsed since the file
///  has been registered
/// </para>
/// </summary>

	GTK_RECENT_FILTER_AGE = 32
}
