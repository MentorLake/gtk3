namespace MentorLake.Gtk;

[Flags]
public enum GtkEventSequenceState
{
	GTK_EVENT_SEQUENCE_NONE = 0,
	GTK_EVENT_SEQUENCE_CLAIMED = 1,
	GTK_EVENT_SEQUENCE_DENIED = 2
}
