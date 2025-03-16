namespace MentorLake.Gtk;

[Flags]
public enum GtkPropagationPhase
{
	GTK_PHASE_NONE = 0,
	GTK_PHASE_CAPTURE = 1,
	GTK_PHASE_BUBBLE = 2,
	GTK_PHASE_TARGET = 3
}
