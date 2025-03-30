namespace MentorLake.Gtk;

[Flags]
public enum GtkFileFilterFlags : uint
{
	GTK_FILE_FILTER_FILENAME = 1,
	GTK_FILE_FILTER_URI = 2,
	GTK_FILE_FILTER_DISPLAY_NAME = 4,
	GTK_FILE_FILTER_MIME_TYPE = 8
}
