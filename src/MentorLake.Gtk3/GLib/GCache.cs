namespace MentorLake.Gtk3.GLib;

public class GCacheHandle : BaseSafeHandle
{
}


public static class GCacheHandleExtensions
{
	public static GCacheHandle Destroy(this GCacheHandle cache)
	{
		GCacheExterns.g_cache_destroy(cache);
		return cache;
	}

	public static IntPtr Insert(this GCacheHandle cache, IntPtr key)
	{
		return GCacheExterns.g_cache_insert(cache, key);
	}

	public static GCacheHandle KeyForeach(this GCacheHandle cache, GHFunc func, IntPtr user_data)
	{
		GCacheExterns.g_cache_key_foreach(cache, func, user_data);
		return cache;
	}

	public static GCacheHandle Remove(this GCacheHandle cache, IntPtr value)
	{
		GCacheExterns.g_cache_remove(cache, value);
		return cache;
	}

	public static GCacheHandle ValueForeach(this GCacheHandle cache, GHFunc func, IntPtr user_data)
	{
		GCacheExterns.g_cache_value_foreach(cache, func, user_data);
		return cache;
	}

	public static GCacheHandle New(GCacheNewFunc value_new_func, GCacheDestroyFunc value_destroy_func, GCacheDupFunc key_dup_func, GCacheDestroyFunc key_destroy_func, GHashFunc hash_key_func, GHashFunc hash_value_func, GEqualFunc key_equal_func)
	{
		return GCacheExterns.g_cache_new(value_new_func, value_destroy_func, key_dup_func, key_destroy_func, hash_key_func, hash_value_func, key_equal_func);
	}

}
internal class GCacheExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_destroy(GCacheHandle cache);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_cache_insert(GCacheHandle cache, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_key_foreach(GCacheHandle cache, GHFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_remove(GCacheHandle cache, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_cache_value_foreach(GCacheHandle cache, GHFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GCacheHandle g_cache_new(GCacheNewFunc value_new_func, GCacheDestroyFunc value_destroy_func, GCacheDupFunc key_dup_func, GCacheDestroyFunc key_destroy_func, GHashFunc hash_key_func, GHashFunc hash_value_func, GEqualFunc key_equal_func);

}

public struct GCache
{
}
