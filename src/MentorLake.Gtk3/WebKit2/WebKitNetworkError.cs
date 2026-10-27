namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various network errors.
/// </para>
/// </summary>

[Flags]
public enum WebKitNetworkError
{
/// <summary>
/// <para>
/// Generic load failure
/// </para>
/// </summary>

	WEBKIT_NETWORK_ERROR_FAILED = 399,
/// <summary>
/// <para>
/// Load failure due to transport error
/// </para>
/// </summary>

	WEBKIT_NETWORK_ERROR_TRANSPORT = 300,
/// <summary>
/// <para>
/// Load failure due to unknown protocol
/// </para>
/// </summary>

	WEBKIT_NETWORK_ERROR_UNKNOWN_PROTOCOL = 301,
/// <summary>
/// <para>
/// Load failure due to cancellation
/// </para>
/// </summary>

	WEBKIT_NETWORK_ERROR_CANCELLED = 302,
/// <summary>
/// <para>
/// Load failure due to missing file
/// </para>
/// </summary>

	WEBKIT_NETWORK_ERROR_FILE_DOES_NOT_EXIST = 303
}
