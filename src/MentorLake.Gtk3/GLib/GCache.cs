namespace MentorLake.GLib;

public class GCacheHandle : BaseSafeHandle
{
}


public static class GCacheExtensions
{
	public static void Destroy(this MentorLake.GLib.GCacheHandle cache)
	{
		GCacheExterns.g_cache_destroy(cache);
	}

	public static IntPtr Insert(this MentorLake.GLib.GCacheHandle cache, IntPtr key)
	{
		return GCacheExterns.g_cache_insert(cache, key);
	}

	public static void KeyForeach(this MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GCacheExterns.g_cache_key_foreach(cache, func, user_data);
	}

	public static void Remove(this MentorLake.GLib.GCacheHandle cache, IntPtr value)
	{
		GCacheExterns.g_cache_remove(cache, value);
	}

	public static void ValueForeach(this MentorLake.GLib.GCacheHandle cache, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
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
	internal static extern MentorLake.GLib.GCacheHandle g_cache_new(MentorLake.GLib.GCacheNewFunc value_new_func, MentorLake.GLib.GCacheDestroyFunc value_destroy_func, MentorLake.GLib.GCacheDupFunc key_dup_func, MentorLake.GLib.GCacheDestroyFunc key_destroy_func, MentorLake.GLib.GHashFunc hash_key_func, MentorLake.GLib.GHashFunc hash_value_func, MentorLake.GLib.GEqualFunc key_equal_func);

}

public struct GCache
{
	public static MentorLake.GLib.GCacheHandle New(MentorLake.GLib.GCacheNewFunc value_new_func, MentorLake.GLib.GCacheDestroyFunc value_destroy_func, MentorLake.GLib.GCacheDupFunc key_dup_func, MentorLake.GLib.GCacheDestroyFunc key_destroy_func, MentorLake.GLib.GHashFunc hash_key_func, MentorLake.GLib.GHashFunc hash_value_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		return GCacheExterns.g_cache_new(value_new_func, value_destroy_func, key_dup_func, key_destroy_func, hash_key_func, hash_value_func, key_equal_func);
	}

}
