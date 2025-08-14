namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The @action parameter to gtk_print_operation_run()
/// determines what action the print operation should perform.
/// </para>
/// </summary>

[Flags]
public enum GtkPrintOperationAction
{
/// <summary>
/// <para>
/// Show the print dialog.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_ACTION_PRINT_DIALOG = 0,
/// <summary>
/// <para>
/// Start to print without showing
///     the print dialog, based on the current print settings.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_ACTION_PRINT = 1,
/// <summary>
/// <para>
/// Show the print preview.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_ACTION_PREVIEW = 2,
/// <summary>
/// <para>
/// Export to a file. This requires
///     the export-filename property to be set.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_ACTION_EXPORT = 3
}
