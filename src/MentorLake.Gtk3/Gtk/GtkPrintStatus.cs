namespace MentorLake.Gtk;

[Flags]
public enum GtkPrintStatus
{
	GTK_PRINT_STATUS_INITIAL = 0,
	GTK_PRINT_STATUS_PREPARING = 1,
	GTK_PRINT_STATUS_GENERATING_DATA = 2,
	GTK_PRINT_STATUS_SENDING_DATA = 3,
	GTK_PRINT_STATUS_PENDING = 4,
	GTK_PRINT_STATUS_PENDING_ISSUE = 5,
	GTK_PRINT_STATUS_PRINTING = 6,
	GTK_PRINT_STATUS_FINISHED = 7,
	GTK_PRINT_STATUS_FINISHED_ABORTED = 8
}
