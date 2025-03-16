namespace MentorLake.Gtk;

[Flags]
public enum GtkDestDefaults : long
{
	GTK_DEST_DEFAULT_MOTION = 1,
	GTK_DEST_DEFAULT_HIGHLIGHT = 2,
	GTK_DEST_DEFAULT_DROP = 4,
	GTK_DEST_DEFAULT_ALL = 7
}
