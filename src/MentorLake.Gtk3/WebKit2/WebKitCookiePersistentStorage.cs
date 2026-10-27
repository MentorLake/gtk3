namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the cookie persistent storage types.
/// </para>
/// </summary>

[Flags]
public enum WebKitCookiePersistentStorage
{
/// <summary>
/// <para>
/// Cookies are stored in a text
///  file in the Mozilla &quot;cookies.txt&quot; format.
/// </para>
/// </summary>

	WEBKIT_COOKIE_PERSISTENT_STORAGE_TEXT = 0,
/// <summary>
/// <para>
/// Cookies are stored in a SQLite
///  file in the current Mozilla format.
/// </para>
/// </summary>

	WEBKIT_COOKIE_PERSISTENT_STORAGE_SQLITE = 1
}
