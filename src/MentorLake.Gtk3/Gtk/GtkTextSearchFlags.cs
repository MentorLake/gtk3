namespace MentorLake.Gtk;

[Flags]
public enum GtkTextSearchFlags : uint
{
	GTK_TEXT_SEARCH_VISIBLE_ONLY = 1,
	GTK_TEXT_SEARCH_TEXT_ONLY = 2,
	GTK_TEXT_SEARCH_CASE_INSENSITIVE = 4
}
