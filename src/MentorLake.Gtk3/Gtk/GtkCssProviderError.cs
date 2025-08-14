namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Error codes for %GTK_CSS_PROVIDER_ERROR.
/// </para>
/// </summary>

[Flags]
public enum GtkCssProviderError
{
/// <summary>
/// <para>
/// Failed.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// Syntax error.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_SYNTAX = 1,
/// <summary>
/// <para>
/// Import error.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_IMPORT = 2,
/// <summary>
/// <para>
/// Name error.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_NAME = 3,
/// <summary>
/// <para>
/// Deprecation error.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_DEPRECATED = 4,
/// <summary>
/// <para>
/// Unknown value.
/// </para>
/// </summary>

	GTK_CSS_PROVIDER_ERROR_UNKNOWN_VALUE = 5
}
