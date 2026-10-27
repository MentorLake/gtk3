namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various print errors.
/// </para>
/// </summary>

[Flags]
public enum WebKitPrintError
{
/// <summary>
/// <para>
/// Unspecified error during a print operation
/// </para>
/// </summary>

	WEBKIT_PRINT_ERROR_GENERAL = 599,
/// <summary>
/// <para>
/// Selected printer cannot be found
/// </para>
/// </summary>

	WEBKIT_PRINT_ERROR_PRINTER_NOT_FOUND = 500,
/// <summary>
/// <para>
/// Invalid page range
/// </para>
/// </summary>

	WEBKIT_PRINT_ERROR_INVALID_PAGE_RANGE = 501
}
