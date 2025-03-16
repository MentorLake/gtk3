namespace MentorLake.GLib;

public class GHashTableHandle : BaseSafeHandle
{
}


public static class GHashTableExtensions
{

	public static GHashTable Dereference(this GHashTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHashTable>(x.DangerousGetHandle());
}
internal class GHashTableExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_hash_table_get_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr[] g_hash_table_get_keys_as_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, out uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_keys_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle g_hash_table_get_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_values_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_full(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle other_hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_steal_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

}

public struct GHashTable
{
	public static bool Add(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_add(hash_table, key);
	}

	public static bool Contains(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_contains(hash_table, key);
	}

	public static void Destroy(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_destroy(hash_table);
	}

	public static IntPtr Find(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

	public static void Foreach(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GHashTableExterns.g_hash_table_foreach(hash_table, func, user_data);
	}

	public static uint ForeachRemove(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

	public static uint ForeachSteal(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

	public static MentorLake.GLib.GListHandle GetKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys(hash_table);
	}

	public static IntPtr[] GetKeysAsArray(MentorLake.GLib.GHashTableHandle hash_table, out uint length)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_array(hash_table, out length);
	}

	public static MentorLake.GLib.GPtrArrayHandle GetKeysAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_ptr_array(hash_table);
	}

	public static MentorLake.GLib.GListHandle GetValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle GetValuesAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values_as_ptr_array(hash_table);
	}

	public static bool Insert(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_insert(hash_table, key, value);
	}

	public static IntPtr Lookup(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_lookup(hash_table, key);
	}

	public static bool LookupExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GHashTableExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

	public static MentorLake.GLib.GHashTableHandle New(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		return GHashTableExterns.g_hash_table_new(hash_func, key_equal_func);
	}

	public static MentorLake.GLib.GHashTableHandle NewFull(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func)
	{
		return GHashTableExterns.g_hash_table_new_full(hash_func, key_equal_func, key_destroy_func, value_destroy_func);
	}

	public static MentorLake.GLib.GHashTableHandle NewSimilar(MentorLake.GLib.GHashTableHandle other_hash_table)
	{
		return GHashTableExterns.g_hash_table_new_similar(other_hash_table);
	}

	public static MentorLake.GLib.GHashTableHandle Ref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_ref(hash_table);
	}

	public static bool Remove(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_remove(hash_table, key);
	}

	public static void RemoveAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_remove_all(hash_table);
	}

	public static bool Replace(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_replace(hash_table, key, value);
	}

	public static uint Size(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_size(hash_table);
	}

	public static bool Steal(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_steal(hash_table, key);
	}

	public static void StealAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_steal_all(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle StealAllKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_keys(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle StealAllValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_values(hash_table);
	}

	public static bool StealExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GHashTableExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

	public static void Unref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_unref(hash_table);
	}

}
