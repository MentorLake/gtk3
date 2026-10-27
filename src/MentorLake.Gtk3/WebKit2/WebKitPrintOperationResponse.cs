namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing the response of the print dialog shown with
/// webkit_print_operation_run_dialog().
/// </para>
/// </summary>

[Flags]
public enum WebKitPrintOperationResponse
{
/// <summary>
/// <para>
/// Print button was clicked in print dialog
/// </para>
/// </summary>

	WEBKIT_PRINT_OPERATION_RESPONSE_PRINT = 0,
/// <summary>
/// <para>
/// Print dialog was cancelled
/// </para>
/// </summary>

	WEBKIT_PRINT_OPERATION_RESPONSE_CANCEL = 1
}
