namespace MentorLake.Gtk;

[Flags]
public enum GtkPrintOperationResult
{
	GTK_PRINT_OPERATION_RESULT_ERROR = 0,
	GTK_PRINT_OPERATION_RESULT_APPLY = 1,
	GTK_PRINT_OPERATION_RESULT_CANCEL = 2,
	GTK_PRINT_OPERATION_RESULT_IN_PROGRESS = 3
}
