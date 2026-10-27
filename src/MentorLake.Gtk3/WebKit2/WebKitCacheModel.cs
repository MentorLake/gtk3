namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the #WebKitWebContext cache model.
/// </para>
/// </summary>

[Flags]
public enum WebKitCacheModel
{
/// <summary>
/// <para>
/// Disable the cache completely, which
///   substantially reduces memory usage. Useful for applications that only
///   access a single local file, with no navigation to other pages. No remote
///   resources will be cached.
/// </para>
/// </summary>

	WEBKIT_CACHE_MODEL_DOCUMENT_VIEWER = 0,
/// <summary>
/// <para>
/// Improve document load speed substantially
///   by caching a very large number of resources and previously viewed content.
/// </para>
/// </summary>

	WEBKIT_CACHE_MODEL_WEB_BROWSER = 1,
/// <summary>
/// <para>
/// A cache model optimized for viewing
///   a series of local files -- for example, a documentation viewer or a website
///   designer. WebKit will cache a moderate number of resources.
/// </para>
/// </summary>

	WEBKIT_CACHE_MODEL_DOCUMENT_BROWSER = 2
}
