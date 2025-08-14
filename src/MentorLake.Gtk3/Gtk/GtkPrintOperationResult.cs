namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A value of this type is returned by gtk_print_operation_run().
/// </para>
/// </summary>

[Flags]
public enum GtkPrintOperationResult
{
/// <summary>
/// <para>
/// An error has occurred.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_RESULT_ERROR = 0,
/// <summary>
/// <para>
/// The print settings should be stored.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_RESULT_APPLY = 1,
/// <summary>
/// <para>
/// The print operation has been canceled,
///     the print settings should not be stored.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_RESULT_CANCEL = 2,
/// <summary>
/// <para>
/// The print operation is not complete
///     yet. This value will only be returned when running asynchronously.
/// </para>
/// </summary>

	GTK_PRINT_OPERATION_RESULT_IN_PROGRESS = 3
}
