namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GHashTable struct is an opaque data structure to represent a
/// [Hash Table][glib-Hash-Tables]. It should only be accessed via the
/// following functions.
/// </para>
/// </summary>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_hash_table_get_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr[] g_hash_table_get_keys_as_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, out uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_keys_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_hash_table_get_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_values_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_full(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle other_hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

}

/// <summary>
/// <para>
/// The #GHashTable struct is an opaque data structure to represent a
/// [Hash Table][glib-Hash-Tables]. It should only be accessed via the
/// following functions.
/// </para>
/// </summary>

public struct GHashTable
{
/// <summary>
/// <para>
/// This is a convenience function for using a #GHashTable as a set.  It
/// is equivalent to calling g_hash_table_replace() with @key as both the
/// key and the value.
/// </para>
/// <para>
/// In particular, this means that if @key already exists in the hash table, then
/// the old copy of @key in the hash table is freed and @key replaces it in the
/// table.
/// </para>
/// <para>
/// When a hash table only ever contains keys that have themselves as the
/// corresponding value it is able to be stored more efficiently.  See
/// the discussion in the section description.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool Add(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_add(hash_table, key);
	}

/// <summary>
/// <para>
/// Checks if @key is in @hash_table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to check
/// </param>
/// <return>
/// %TRUE if @key is in @hash_table, %FALSE otherwise.
/// </return>

	public static bool Contains(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_contains(hash_table, key);
	}

/// <summary>
/// <para>
/// Destroys all keys and values in the #GHashTable and decrements its
/// reference count by 1. If keys and/or values are dynamically allocated,
/// you should either free them first or create the #GHashTable with destroy
/// notifiers using g_hash_table_new_full(). In the latter case the destroy
/// functions you supplied will be called on all keys and values during the
/// destruction phase.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void Destroy(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_destroy(hash_table);
	}

/// <summary>
/// <para>
/// Calls the given function for key/value pairs in the #GHashTable
/// until @predicate returns %TRUE. The function is passed the key
/// and value of each pair, and the given @user_data parameter. The
/// hash table may not be modified while iterating over it (you can't
/// add/remove items).
/// </para>
/// <para>
/// Note, that hash tables are really only optimized for forward
/// lookups, i.e. g_hash_table_lookup(). So code that frequently issues
/// g_hash_table_find() or g_hash_table_foreach() (e.g. in the order of
/// once per every entry in a hash table) should probably be reworked
/// to use additional or different data structures for reverse lookups
/// (keep in mind that an O(n) find/foreach operation issued for all n
/// values in a hash table ends up needing O(n*n) operations).
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="predicate">
/// function to test the key/value pairs for a certain property
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// The value of the first key/value pair is returned,
///     for which @predicate evaluates to %TRUE. If no pair with the
///     requested property is found, %NULL is returned.
/// </return>

	public static IntPtr Find(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the key/value pairs in the
/// #GHashTable.  The function is passed the key and value of each
/// pair, and the given @user_data parameter.  The hash table may not
/// be modified while iterating over it (you can't add/remove
/// items). To remove all items matching a predicate, use
/// g_hash_table_foreach_remove().
/// </para>
/// <para>
/// The order in which g_hash_table_foreach() iterates over the keys/values in
/// the hash table is not defined.
/// </para>
/// <para>
/// See g_hash_table_find() for performance caveats for linear
/// order searches in contrast to g_hash_table_lookup().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void Foreach(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GHashTableExterns.g_hash_table_foreach(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each key/value pair in the
/// #GHashTable. If the function returns %TRUE, then the key/value
/// pair is removed from the #GHashTable. If you supplied key or
/// value destroy functions when creating the #GHashTable, they are
/// used to free the memory allocated for the removed keys and values.
/// </para>
/// <para>
/// See #GHashTableIter for an alternative way to loop over the
/// key/value pairs in the hash table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// the number of key/value pairs removed
/// </return>

	public static uint ForeachRemove(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each key/value pair in the
/// #GHashTable. If the function returns %TRUE, then the key/value
/// pair is removed from the #GHashTable, but no key or value
/// destroy functions are called.
/// </para>
/// <para>
/// See #GHashTableIter for an alternative way to loop over the
/// key/value pairs in the hash table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// the number of key/value pairs removed.
/// </return>

	public static uint ForeachSteal(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GHashTableExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Retrieves every key inside @hash_table. The returned data is valid
/// until changes to the hash release those keys.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GList containing all the keys
///     inside the hash table. The content of the list is owned by the
///     hash table and should not be modified or freed. Use g_list_free()
///     when done using the list.
/// </return>

	public static MentorLake.GLib.GListHandle GetKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys(hash_table);
	}

/// <summary>
/// <para>
/// Retrieves every key inside @hash_table, as an array.
/// </para>
/// <para>
/// The returned array is %NULL-terminated but may contain %NULL as a
/// key.  Use @length to determine the true length if it's possible that
/// %NULL was used as the value for a key.
/// </para>
/// <para>
/// Note: in the common case of a string-keyed #GHashTable, the return
/// value of this function can be conveniently cast to (const gchar **).
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// <para>
/// You should always free the return result with g_free().  In the
/// above-mentioned case of a string-keyed hash table, it may be
/// appropriate to use g_strfreev() if you call g_hash_table_steal_all()
/// first to transfer ownership of the keys.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="length">
/// the length of the returned array
/// </param>
/// <return>
/// a
///   %NULL-terminated array containing each key from the table.
/// </return>

	public static IntPtr[] GetKeysAsArray(MentorLake.GLib.GHashTableHandle hash_table, out uint length)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_array(hash_table, out length);
	}

/// <summary>
/// <para>
/// Retrieves every key inside @hash_table, as a #GPtrArray.
/// The returned data is valid until changes to the hash release those keys.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// <para>
/// You should always unref the returned array with g_ptr_array_unref().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each key from
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetKeysAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_keys_as_ptr_array(hash_table);
	}

/// <summary>
/// <para>
/// Retrieves every value inside @hash_table. The returned data
/// is valid until @hash_table is modified.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GList containing all the values
///     inside the hash table. The content of the list is owned by the
///     hash table and should not be modified or freed. Use g_list_free()
///     when done using the list.
/// </return>

	public static MentorLake.GLib.GListHandle GetValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values(hash_table);
	}

/// <summary>
/// <para>
/// Retrieves every value inside @hash_table, as a #GPtrArray.
/// The returned data is valid until changes to the hash release those values.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// <para>
/// You should always unref the returned array with g_ptr_array_unref().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each value from
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetValuesAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_get_values_as_ptr_array(hash_table);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GHashTable.
/// </para>
/// <para>
/// If the key already exists in the #GHashTable its current
/// value is replaced with the new value. If you supplied a
/// @value_destroy_func when creating the #GHashTable, the old
/// value is freed using that function. If you supplied a
/// @key_destroy_func when creating the #GHashTable, the passed
/// key is freed using that function.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <param name="value">
/// the value to associate with the key
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool Insert(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_insert(hash_table, key, value);
	}

/// <summary>
/// <para>
/// Looks up a key in a #GHashTable. Note that this function cannot
/// distinguish between a key that is not present and one which is present
/// and has the value %NULL. If you need this distinction, use
/// g_hash_table_lookup_extended().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// the associated value, or %NULL if the key is not found
/// </return>

	public static IntPtr Lookup(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_lookup(hash_table, key);
	}

/// <summary>
/// <para>
/// Looks up a key in the #GHashTable, returning the original key and the
/// associated value and a #gboolean which is %TRUE if the key was found. This
/// is useful if you need to free the memory allocated for the original key,
/// for example before calling g_hash_table_remove().
/// </para>
/// <para>
/// You can actually pass %NULL for @lookup_key to test
/// whether the %NULL key exists, provided the hash and equal functions
/// of @hash_table are %NULL-safe.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="lookup_key">
/// the key to look up
/// </param>
/// <param name="orig_key">
/// return location for the original key
/// </param>
/// <param name="value">
/// return location for the value associated
/// with the key
/// </param>
/// <return>
/// %TRUE if the key was found in the #GHashTable
/// </return>

	public static bool LookupExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GHashTableExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

/// <summary>
/// <para>
/// Creates a new #GHashTable with a reference count of 1.
/// </para>
/// <para>
/// Hash values returned by @hash_func are used to determine where keys
/// are stored within the #GHashTable data structure. The g_direct_hash(),
/// g_int_hash(), g_int64_hash(), g_double_hash() and g_str_hash()
/// functions are provided for some common types of keys.
/// If @hash_func is %NULL, g_direct_hash() is used.
/// </para>
/// <para>
/// @key_equal_func is used when looking up keys in the #GHashTable.
/// The g_direct_equal(), g_int_equal(), g_int64_equal(), g_double_equal()
/// and g_str_equal() functions are provided for the most common types
/// of keys. If @key_equal_func is %NULL, keys are compared directly in
/// a similar fashion to g_direct_equal(), but without the overhead of
/// a function call. @key_equal_func is called with the key from the hash table
/// as its first parameter, and the user-provided key to check against as
/// its second.
/// </para>
/// </summary>

/// <param name="hash_func">
/// a function to create a hash value from a key
/// </param>
/// <param name="key_equal_func">
/// a function to check two keys for equality
/// </param>
/// <return>
/// a new #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle New(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		return GHashTableExterns.g_hash_table_new(hash_func, key_equal_func);
	}

/// <summary>
/// <para>
/// Creates a new #GHashTable like g_hash_table_new() with a reference
/// count of 1 and allows to specify functions to free the memory
/// allocated for the key and value that get called when removing the
/// entry from the #GHashTable.
/// </para>
/// <para>
/// Since version 2.42 it is permissible for destroy notify functions to
/// recursively remove further items from the hash table. This is only
/// permissible if the application still holds a reference to the hash table.
/// This means that you may need to ensure that the hash table is empty by
/// calling g_hash_table_remove_all() before releasing the last reference using
/// g_hash_table_unref().
/// </para>
/// </summary>

/// <param name="hash_func">
/// a function to create a hash value from a key
/// </param>
/// <param name="key_equal_func">
/// a function to check two keys for equality
/// </param>
/// <param name="key_destroy_func">
/// a function to free the memory allocated for the key
///     used when removing the entry from the #GHashTable, or %NULL
///     if you don't want to supply such a function.
/// </param>
/// <param name="value_destroy_func">
/// a function to free the memory allocated for the
///     value used when removing the entry from the #GHashTable, or %NULL
///     if you don't want to supply such a function.
/// </param>
/// <return>
/// a new #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle NewFull(MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func)
	{
		return GHashTableExterns.g_hash_table_new_full(hash_func, key_equal_func, key_destroy_func, value_destroy_func);
	}

/// <summary>
/// <para>
/// Creates a new #GHashTable like g_hash_table_new_full() with a reference
/// count of 1.
/// </para>
/// <para>
/// It inherits the hash function, the key equal function, the key destroy function,
/// as well as the value destroy function, from @other_hash_table.
/// </para>
/// <para>
/// The returned hash table will be empty; it will not contain the keys
/// or values from @other_hash_table.
/// </para>
/// </summary>

/// <param name="other_hash_table">
/// Another #GHashTable
/// </param>
/// <return>
/// a new #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle NewSimilar(MentorLake.GLib.GHashTableHandle other_hash_table)
	{
		return GHashTableExterns.g_hash_table_new_similar(other_hash_table);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @hash_table by one.
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a valid #GHashTable
/// </param>
/// <return>
/// the passed in #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle Ref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_ref(hash_table);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GHashTable.
/// </para>
/// <para>
/// If the #GHashTable was created using g_hash_table_new_full(), the
/// key and value are freed using the supplied destroy functions, otherwise
/// you have to make sure that any dynamically allocated values are freed
/// yourself.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found and removed from the #GHashTable
/// </return>

	public static bool Remove(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_remove(hash_table, key);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable.
/// </para>
/// <para>
/// If the #GHashTable was created using g_hash_table_new_full(),
/// the keys and values are freed using the supplied destroy functions,
/// otherwise you have to make sure that any dynamically allocated
/// values are freed yourself.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void RemoveAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_remove_all(hash_table);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GHashTable similar to
/// g_hash_table_insert(). The difference is that if the key
/// already exists in the #GHashTable, it gets replaced by the
/// new key. If you supplied a @value_destroy_func when creating
/// the #GHashTable, the old value is freed using that function.
/// If you supplied a @key_destroy_func when creating the
/// #GHashTable, the old key is freed using that function.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <param name="value">
/// the value to associate with the key
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool Replace(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GHashTableExterns.g_hash_table_replace(hash_table, key, value);
	}

/// <summary>
/// <para>
/// Returns the number of elements contained in the #GHashTable.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// the number of key/value pairs in the #GHashTable.
/// </return>

	public static uint Size(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_size(hash_table);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GHashTable without
/// calling the key and value destroy functions.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found and removed from the #GHashTable
/// </return>

	public static bool Steal(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GHashTableExterns.g_hash_table_steal(hash_table, key);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the key and value destroy functions.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void StealAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_steal_all(hash_table);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the key destroy functions, returning the keys
/// as a #GPtrArray with the free func set to the @hash_table key
/// destroy function.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each key of
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle StealAllKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_keys(hash_table);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the value destroy functions, returning the values
/// as a #GPtrArray with the free func set to the @hash_table value
/// destroy function.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each value of
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle StealAllValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GHashTableExterns.g_hash_table_steal_all_values(hash_table);
	}

/// <summary>
/// <para>
/// Looks up a key in the #GHashTable, stealing the original key and the
/// associated value and returning %TRUE if the key was found. If the key was
/// not found, %FALSE is returned.
/// </para>
/// <para>
/// If found, the stolen key and value are removed from the hash table without
/// calling the key and value destroy functions, and ownership is transferred to
/// the caller of this method, as with g_hash_table_steal(). That is the case
/// regardless whether @stolen_key or @stolen_value output parameters are
/// requested.
/// </para>
/// <para>
/// You can pass %NULL for @lookup_key, provided the hash and equal functions
/// of @hash_table are %NULL-safe.
/// </para>
/// <para>
/// The dictionary implementation optimizes for having all values identical to
/// their keys, for example by using g_hash_table_add(). Before 2.82, when
/// stealing both the key and the value from such a dictionary, the value was
/// %NULL. Since 2.82, the returned value and key will be the same.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="lookup_key">
/// the key to look up
/// </param>
/// <param name="stolen_key">
/// return location for the
///    original key
/// </param>
/// <param name="stolen_value">
/// return location
///    for the value associated with the key
/// </param>
/// <return>
/// %TRUE if the key was found in the #GHashTable
/// </return>

	public static bool StealExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GHashTableExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @hash_table by one.
/// If the reference count drops to 0, all keys and values will be
/// destroyed, and all memory allocated by the hash table is released.
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a valid #GHashTable
/// </param>

	public static void Unref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GHashTableExterns.g_hash_table_unref(hash_table);
	}

}
