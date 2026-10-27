namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the various errors related to the #WebKitFaviconDatabase.
/// </para>
/// </summary>

[Flags]
public enum WebKitFaviconDatabaseError
{
/// <summary>
/// <para>
/// The #WebKitFaviconDatabase is closed
/// </para>
/// </summary>

	WEBKIT_FAVICON_DATABASE_ERROR_NOT_INITIALIZED = 0,
/// <summary>
/// <para>
/// There is not an icon available for the requested URL
/// </para>
/// </summary>

	WEBKIT_FAVICON_DATABASE_ERROR_FAVICON_NOT_FOUND = 1,
/// <summary>
/// <para>
/// There might be an icon for the requested URL, but its data is unknown at the moment
/// </para>
/// </summary>

	WEBKIT_FAVICON_DATABASE_ERROR_FAVICON_UNKNOWN = 2
}
