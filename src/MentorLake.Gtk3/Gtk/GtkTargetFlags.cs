namespace MentorLake.Gtk;

[Flags]
public enum GtkTargetFlags : long
{
	GTK_TARGET_SAME_APP = 1,
	GTK_TARGET_SAME_WIDGET = 2,
	GTK_TARGET_OTHER_APP = 4,
	GTK_TARGET_OTHER_WIDGET = 8
}
