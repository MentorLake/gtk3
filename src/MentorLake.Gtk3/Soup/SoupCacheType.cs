namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The type of cache; this affects what kinds of responses will be
/// saved.
/// </para>
/// </summary>

[Flags]
public enum SoupCacheType
{
/// <summary>
/// <para>
/// a single-user cache
/// </para>
/// </summary>

	SOUP_CACHE_SINGLE_USER = 0,
/// <summary>
/// <para>
/// a shared cache
/// </para>
/// </summary>

	SOUP_CACHE_SHARED = 1
}
