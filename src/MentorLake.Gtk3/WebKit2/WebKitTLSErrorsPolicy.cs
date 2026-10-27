namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the TLS errors policy.
/// </para>
/// </summary>

[Flags]
public enum WebKitTLSErrorsPolicy
{
/// <summary>
/// <para>
/// Ignore TLS errors.
/// </para>
/// </summary>

	WEBKIT_TLS_ERRORS_POLICY_IGNORE = 0,
/// <summary>
/// <para>
/// TLS errors will emit
///   #WebKitWebView::load-failed-with-tls-errors and, if the signal is handled,
///   finish the load. In case the signal is not handled,
///   #WebKitWebView::load-failed is emitted before the load finishes.
/// </para>
/// </summary>

	WEBKIT_TLS_ERRORS_POLICY_FAIL = 1
}
