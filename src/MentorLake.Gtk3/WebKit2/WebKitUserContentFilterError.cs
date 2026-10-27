namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Errors that can occur while compiling content filters.
/// </para>
/// </summary>

[Flags]
public enum WebKitUserContentFilterError
{
/// <summary>
/// <para>
/// The JSON source for a content filter is invalid.
/// </para>
/// </summary>

	WEBKIT_USER_CONTENT_FILTER_ERROR_INVALID_SOURCE = 0,
/// <summary>
/// <para>
/// The requested content filter could not be found.
/// </para>
/// </summary>

	WEBKIT_USER_CONTENT_FILTER_ERROR_NOT_FOUND = 1
}
