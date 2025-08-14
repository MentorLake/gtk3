namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GCache` allows sharing of complex data structures, in order to
/// save system resources.
/// </para>
/// <para>
/// `GCache` uses keys and values. A `GCache` key describes the properties
/// of a particular resource. A `GCache` value is the actual resource.
/// </para>
/// <para>
/// `GCache` has been marked as deprecated, since this API is rarely
/// used and not very actively maintained.
/// </para>
/// </summary>

public class GCacheHandle : BaseSafeHandle
{
}


public static class GCacheExtensions
{
/// <summary>
/// <para>
/// Frees the memory allocated for the #GCache.
/// </para>
/// <para>
/// Note that it does not destroy the keys and values which were
/// contained in the #GCache.
/// </para>
/// </summary>

/// <param name="cache">
/// a #GCache
/// </param>

	public static void Destroy(this MentorLake.GLib.GCacheHandle cache)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (GCache)");
		GCacheExterns.g_cache_destroy(cache);
	}

/// <summary>
/// <para>
/// Gets the value corresponding to the given key, creating it if
/// necessary. It first checks if the value already exists in the
/// #GCache, by using the @key_equal_func function passed to
/// g_cache_new(). If it does already exist it is returned, and its
/// reference count is increased by one. If the value does not currently
/// exist, if is created by calling the @value_new_func. The key is
/// duplicated by calling @key_dup_func and the duplicated key and value
/// are inserted into the #GCache.
/// </para>
/// </summary>

/// <param name="cache">
/// a #GCache
/// </param>
/// <param name="key">
/// a key describing a #GCache object
/// </param>
/// <return>
/// a pointer to a #GCache value
/// </return>

	public static IntPtr Insert(this MentorLake.GLib.GCacheHandle cache, IntPtr key)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (GCache)");
		return GCacheExterns.g_cache_insert(cache, key);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the keys in the #GCache.
/// </para>
/// <para>
/// NOTE @func is passed three parameters, the value and key of a cache
/// entry and the @user_data. The order of value and key is different
/// from the order in which g_hash_table_foreach() passes key-value
/// pairs to its callback function !
/// </para>
/// </summary>

/// <param name="cache">
/// a #GCache
/// </param>
/// <param name="func">
/// the function to call with each #GCache key
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void KeyForeach(this MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (GCache)");
		GCacheExterns.g_cache_key_foreach(cache, func, user_data);
	}

/// <summary>
/// <para>
/// Decreases the reference count of the given value. If it drops to 0
/// then the value and its corresponding key are destroyed, using the
/// @value_destroy_func and @key_destroy_func passed to g_cache_new().
/// </para>
/// </summary>

/// <param name="cache">
/// a #GCache
/// </param>
/// <param name="value">
/// the value to remove
/// </param>

	public static void Remove(this MentorLake.GLib.GCacheHandle cache, IntPtr value)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (GCache)");
		GCacheExterns.g_cache_remove(cache, value);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the values in the #GCache.
/// </para>
/// </summary>

/// <param name="cache">
/// a #GCache
/// </param>
/// <param name="func">
/// the function to call with each #GCache value
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void ValueForeach(this MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		if (cache.IsInvalid) throw new Exception("Invalid handle (GCache)");
		GCacheExterns.g_cache_value_foreach(cache, func, user_data);
	}


	public static GCache Dereference(this GCacheHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCache>(x.DangerousGetHandle());
}
internal class GCacheExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cache_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))] MentorLake.GLib.GCacheHandle cache);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_cache_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))] MentorLake.GLib.GCacheHandle cache, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cache_key_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))] MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cache_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))] MentorLake.GLib.GCacheHandle cache, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_cache_value_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))] MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCacheHandle>))]
	internal static extern MentorLake.GLib.GCacheHandle g_cache_new(MentorLake.GLib.GCacheNewFunc value_new_func, MentorLake.GLib.GCacheDestroyFunc value_destroy_func, MentorLake.GLib.GCacheDupFunc key_dup_func, MentorLake.GLib.GCacheDestroyFunc key_destroy_func, MentorLake.GLib.GHashFunc hash_key_func, MentorLake.GLib.GHashFunc hash_value_func, MentorLake.GLib.GEqualFunc key_equal_func);

}

/// <summary>
/// <para>
/// A `GCache` allows sharing of complex data structures, in order to
/// save system resources.
/// </para>
/// <para>
/// `GCache` uses keys and values. A `GCache` key describes the properties
/// of a particular resource. A `GCache` value is the actual resource.
/// </para>
/// <para>
/// `GCache` has been marked as deprecated, since this API is rarely
/// used and not very actively maintained.
/// </para>
/// </summary>

public struct GCache
{
/// <summary>
/// <para>
/// Creates a new #GCache.
/// </para>
/// </summary>

/// <param name="value_new_func">
/// a function to create a new object given a key.
///                  This is called by g_cache_insert() if an object
///                  with the given key does not already exist
/// </param>
/// <param name="value_destroy_func">
/// a function to destroy an object. It is called
///                      by g_cache_remove() when the object is no
///                      longer needed (i.e. its reference count drops
///                      to 0)
/// </param>
/// <param name="key_dup_func">
/// a function to copy a key. It is called by
///                g_cache_insert() if the key does not already exist in
///                the #GCache
/// </param>
/// <param name="key_destroy_func">
/// a function to destroy a key. It is called by
///                    g_cache_remove() when the object is no longer
///                    needed (i.e. its reference count drops to 0)
/// </param>
/// <param name="hash_key_func">
/// a function to create a hash value from a key
/// </param>
/// <param name="hash_value_func">
/// a function to create a hash value from a value
/// </param>
/// <param name="key_equal_func">
/// a function to compare two keys. It should return
///                  %TRUE if the two keys are equivalent
/// </param>
/// <return>
/// a new #GCache
/// </return>

	public static MentorLake.GLib.GCacheHandle New(MentorLake.GLib.GCacheNewFunc value_new_func, MentorLake.GLib.GCacheDestroyFunc value_destroy_func, MentorLake.GLib.GCacheDupFunc key_dup_func, MentorLake.GLib.GCacheDestroyFunc key_destroy_func, MentorLake.GLib.GHashFunc hash_key_func, MentorLake.GLib.GHashFunc hash_value_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		return GCacheExterns.g_cache_new(value_new_func, value_destroy_func, key_dup_func, key_destroy_func, hash_key_func, hash_value_func, key_equal_func);
	}

}
