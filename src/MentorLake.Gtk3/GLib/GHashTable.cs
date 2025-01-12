namespace MentorLake.Gtk3.GLib;

public class GHashTableHandle : BaseSafeHandle
{
}


public static class GHashTableHandleExtensions
{
	public static bool Add(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_add(hash_table, key);
	}

	public static bool Contains(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_contains(hash_table, key);
	}

	public static GHashTableHandle Destroy(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_destroy(hash_table);
		return hash_table;
	}

	public static IntPtr Find(this GHashTableHandle hash_table, GHRFunc predicate, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

	public static GHashTableHandle Foreach(this GHashTableHandle hash_table, GHFunc func, IntPtr user_data)
	{
		GHashTableExterns.g_hash_table_foreach(hash_table, func, user_data);
		return hash_table;
	}

	public static uint ForeachRemove(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

	public static uint ForeachSteal(this GHashTableHandle hash_table, GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

	public static GListHandle GetKeys(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys(hash_table);
	}

	public static IntPtr GetKeysAsArray(this GHashTableHandle hash_table, out uint length)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_array(hash_table, out length);
	}

	public static IntPtr GetKeysAsPtrArray(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_ptr_array(hash_table);
	}

	public static GListHandle GetValues(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values(hash_table);
	}

	public static IntPtr GetValuesAsPtrArray(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values_as_ptr_array(hash_table);
	}

	public static bool Insert(this GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_insert(hash_table, key, value);
	}

	public static IntPtr Lookup(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_lookup(hash_table, key);
	}

	public static bool LookupExtended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GHashTableExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

	public static GHashTableHandle New(GHashFunc hash_func, GEqualFunc key_equal_func)
	{
		return GHashTableExterns.g_hash_table_new(hash_func, key_equal_func);
	}

	public static GHashTableHandle NewFull(GHashFunc hash_func, GEqualFunc key_equal_func, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GHashTableExterns.g_hash_table_new_full(hash_func, key_equal_func, key_destroy_func, value_destroy_func);
	}

	public static GHashTableHandle NewSimilar(this GHashTableHandle other_hash_table)
	{
		return GHashTableExterns.g_hash_table_new_similar(other_hash_table);
	}

	public static GHashTableHandle Ref(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_ref(hash_table);
	}

	public static bool Remove(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_remove(hash_table, key);
	}

	public static GHashTableHandle RemoveAll(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_remove_all(hash_table);
		return hash_table;
	}

	public static bool Replace(this GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_replace(hash_table, key, value);
	}

	public static uint Size(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_size(hash_table);
	}

	public static bool Steal(this GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_steal(hash_table, key);
	}

	public static GHashTableHandle StealAll(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_steal_all(hash_table);
		return hash_table;
	}

	public static IntPtr StealAllKeys(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_keys(hash_table);
	}

	public static IntPtr StealAllValues(this GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_values(hash_table);
	}

	public static bool StealExtended(this GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GHashTableExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

	public static GHashTableHandle Unref(this GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_unref(hash_table);
		return hash_table;
	}

}
internal class GHashTableExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_add(GHashTableHandle hash_table, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_contains(GHashTableHandle hash_table, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_destroy(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_find(GHashTableHandle hash_table, GHRFunc predicate, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_foreach(GHashTableHandle hash_table, GHFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_hash_table_foreach_remove(GHashTableHandle hash_table, GHRFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_hash_table_foreach_steal(GHashTableHandle hash_table, GHRFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_hash_table_get_keys(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_get_keys_as_array(GHashTableHandle hash_table, out uint length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_get_keys_as_ptr_array(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_hash_table_get_values(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_get_values_as_ptr_array(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_insert(GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_lookup(GHashTableHandle hash_table, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_lookup_extended(GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_hash_table_new(GHashFunc hash_func, GEqualFunc key_equal_func);

	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_hash_table_new_full(GHashFunc hash_func, GEqualFunc key_equal_func, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func);

	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_hash_table_new_similar(GHashTableHandle other_hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_hash_table_ref(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_remove(GHashTableHandle hash_table, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_remove_all(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_replace(GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_hash_table_size(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_steal(GHashTableHandle hash_table, IntPtr key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_steal_all(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_steal_all_keys(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_hash_table_steal_all_values(GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_steal_extended(GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_unref(GHashTableHandle hash_table);

}

public struct GHashTable
{
}
