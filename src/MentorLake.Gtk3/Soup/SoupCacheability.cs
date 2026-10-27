namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Indicates if a message should or shouldn&apos;t be cached.
/// </para>
/// </summary>

[Flags]
public enum SoupCacheability : uint
{
/// <summary>
/// <para>
/// The message should be cached
/// </para>
/// </summary>

	SOUP_CACHE_CACHEABLE = 1,
/// <summary>
/// <para>
/// The message shouldn&apos;t be cached
/// </para>
/// </summary>

	SOUP_CACHE_UNCACHEABLE = 2,
/// <summary>
/// <para>
/// The messages cache should be invalidated
/// </para>
/// </summary>

	SOUP_CACHE_INVALIDATES = 4,
/// <summary>
/// <para>
/// The messages cache should be updated
/// </para>
/// </summary>

	SOUP_CACHE_VALIDATES = 8
}
