namespace MentorLake.Gtk;

[Flags]
public enum GtkMessageType
{
	GTK_MESSAGE_INFO = 0,
	GTK_MESSAGE_WARNING = 1,
	GTK_MESSAGE_QUESTION = 2,
	GTK_MESSAGE_ERROR = 3,
	GTK_MESSAGE_OTHER = 4
}
