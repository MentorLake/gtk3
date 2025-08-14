namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Error codes that identify various errors that can occur while
/// using the GTK+ printing support.
/// </para>
/// </summary>

[Flags]
public enum GtkPrintError
{
/// <summary>
/// <para>
/// An unspecified error occurred.
/// </para>
/// </summary>

	GTK_PRINT_ERROR_GENERAL = 0,
/// <summary>
/// <para>
/// An internal error occurred.
/// </para>
/// </summary>

	GTK_PRINT_ERROR_INTERNAL_ERROR = 1,
/// <summary>
/// <para>
/// A memory allocation failed.
/// </para>
/// </summary>

	GTK_PRINT_ERROR_NOMEM = 2,
/// <summary>
/// <para>
/// An error occurred while loading a page setup
///     or paper size from a key file.
/// </para>
/// </summary>

	GTK_PRINT_ERROR_INVALID_FILE = 3
}
