namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The status gives a rough indication of the completion of a running
/// print operation.
/// </para>
/// </summary>

[Flags]
public enum GtkPrintStatus
{
/// <summary>
/// <para>
/// The printing has not started yet; this
///     status is set initially, and while the print dialog is shown.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_INITIAL = 0,
/// <summary>
/// <para>
/// This status is set while the begin-print
///     signal is emitted and during pagination.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_PREPARING = 1,
/// <summary>
/// <para>
/// This status is set while the
///     pages are being rendered.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_GENERATING_DATA = 2,
/// <summary>
/// <para>
/// The print job is being sent off to the
///     printer.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_SENDING_DATA = 3,
/// <summary>
/// <para>
/// The print job has been sent to the printer,
///     but is not printed for some reason, e.g. the printer may be stopped.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_PENDING = 4,
/// <summary>
/// <para>
/// Some problem has occurred during
///     printing, e.g. a paper jam.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_PENDING_ISSUE = 5,
/// <summary>
/// <para>
/// The printer is processing the print job.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_PRINTING = 6,
/// <summary>
/// <para>
/// The printing has been completed successfully.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_FINISHED = 7,
/// <summary>
/// <para>
/// The printing has been aborted.
/// </para>
/// </summary>

	GTK_PRINT_STATUS_FINISHED_ABORTED = 8
}
