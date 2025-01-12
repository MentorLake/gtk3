namespace MentorLake.Gtk3.Gtk3;

[Flags]
public enum GtkRecentFilterFlags
{
	GTK_RECENT_FILTER_URI = 0,
	GTK_RECENT_FILTER_DISPLAY_NAME = 1,
	GTK_RECENT_FILTER_MIME_TYPE = 2,
	GTK_RECENT_FILTER_APPLICATION = 4,
	GTK_RECENT_FILTER_GROUP = 8,
	GTK_RECENT_FILTER_AGE = 16
}
