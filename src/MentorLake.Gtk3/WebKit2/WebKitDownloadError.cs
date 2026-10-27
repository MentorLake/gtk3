namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various download errors.
/// </para>
/// </summary>

[Flags]
public enum WebKitDownloadError
{
/// <summary>
/// <para>
/// Download failure due to network error
/// </para>
/// </summary>

	WEBKIT_DOWNLOAD_ERROR_NETWORK = 499,
/// <summary>
/// <para>
/// Download was cancelled by user
/// </para>
/// </summary>

	WEBKIT_DOWNLOAD_ERROR_CANCELLED_BY_USER = 400,
/// <summary>
/// <para>
/// Download failure due to destination error
/// </para>
/// </summary>

	WEBKIT_DOWNLOAD_ERROR_DESTINATION = 401
}
