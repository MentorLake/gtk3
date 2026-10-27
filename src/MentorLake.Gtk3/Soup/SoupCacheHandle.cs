namespace MentorLake.Soup;

/// <summary>
/// <para>
/// File-based cache for HTTP resources.
/// </para>
/// </summary>

public class SoupCacheHandle : GObjectHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a new #SoupCache.
/// </para>
/// </summary>

/// <param name="cache_dir">
/// the directory to store the cached data, or %NULL
///   to use the default one. Note that since the cache isn&apos;t safe to access for
///   multiple processes at once, and the default directory isn&apos;t namespaced by
///   process, clients are strongly discouraged from passing %NULL.
/// </param>
/// <param name="cache_type">
/// the #SoupCacheType of the cache
/// </param>
/// <return>
/// a new #SoupCache
/// </return>

	public static MentorLake.Soup.SoupCacheHandle New(string cache_dir, MentorLake.Soup.SoupCacheType cache_type)
	{
		return SoupCacheHandleExterns.soup_cache_new(cache_dir, cache_type);
	}

}

public static class SoupCacheHandleExtensions
{
/// <summary>
/// <para>
/// Will remove all entries in the @cache plus all the cache files.
/// </para>
/// <para>
/// This is not thread safe and must be called only from the thread that created the [class@Cache]
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>

	public static T Clear<T>(this T cache) where T : SoupCacheHandle
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		SoupCacheHandleExterns.soup_cache_clear(cache);
		return cache;
	}

/// <summary>
/// <para>
/// Synchronously writes the cache index out to disk.
/// </para>
/// <para>
/// Contrast with [method@Cache.flush], which writes pending cache *entries* to
/// disk.
/// </para>
/// <para>
/// You must call this before exiting if you want your cache data to
/// persist between sessions.
/// </para>
/// <para>
/// This is not thread safe and must be called only from the thread that created the [class@Cache]
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>

	public static T Dump<T>(this T cache) where T : SoupCacheHandle
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		SoupCacheHandleExterns.soup_cache_dump(cache);
		return cache;
	}

/// <summary>
/// <para>
/// Forces all pending writes in the @cache to be
/// committed to disk.
/// </para>
/// <para>
/// For doing so it will iterate the [struct@GLib.MainContext] associated with
/// @cache&apos;s session as long as needed.
/// </para>
/// <para>
/// Contrast with [method@Cache.dump], which writes out the cache index file.
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>

	public static T Flush<T>(this T cache) where T : SoupCacheHandle
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		SoupCacheHandleExterns.soup_cache_flush(cache);
		return cache;
	}

/// <summary>
/// <para>
/// Gets the maximum size of the cache.
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>
/// <return>
/// the maximum size of the cache, in bytes.
/// </return>

	public static uint GetMaxSize(this MentorLake.Soup.SoupCacheHandle cache)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		return SoupCacheHandleExterns.soup_cache_get_max_size(cache);
	}

/// <summary>
/// <para>
/// Loads the contents of @cache&apos;s index into memory.
/// </para>
/// <para>
/// This is not thread safe and must be called only from the thread that created the [class@Cache]
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>

	public static T Load<T>(this T cache) where T : SoupCacheHandle
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		SoupCacheHandleExterns.soup_cache_load(cache);
		return cache;
	}

/// <summary>
/// <para>
/// Sets the maximum size of the cache.
/// </para>
/// </summary>

/// <param name="cache">
/// a #SoupCache
/// </param>
/// <param name="max_size">
/// the maximum size of the cache, in bytes
/// </param>

	public static T SetMaxSize<T>(this T cache, uint max_size) where T : SoupCacheHandle
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (SoupCacheHandle)");
		SoupCacheHandleExterns.soup_cache_set_max_size(cache, max_size);
		return cache;
	}

}

internal class SoupCacheHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))]
	internal static extern MentorLake.Soup.SoupCacheHandle soup_cache_new(string cache_dir, MentorLake.Soup.SoupCacheType cache_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cache_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cache_dump([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cache_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_cache_get_max_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cache_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cache_set_max_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCacheHandle>))] MentorLake.Soup.SoupCacheHandle cache, uint max_size);

}
