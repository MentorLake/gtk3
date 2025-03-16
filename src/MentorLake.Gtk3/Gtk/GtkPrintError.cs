namespace MentorLake.Gtk;

[Flags]
public enum GtkPrintError
{
	GTK_PRINT_ERROR_GENERAL = 0,
	GTK_PRINT_ERROR_INTERNAL_ERROR = 1,
	GTK_PRINT_ERROR_NOMEM = 2,
	GTK_PRINT_ERROR_INVALID_FILE = 3
}
