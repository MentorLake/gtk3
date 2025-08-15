namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A GHashTableIter structure represents an iterator that can be used
/// to iterate over the elements of a #GHashTable. GHashTableIter
/// structures are typically allocated on the stack and then initialized
/// with g_hash_table_iter_init().
/// </para>
/// <para>
/// The iteration order of a #GHashTableIter over the keys/values in a hash
/// table is not defined.
/// </para>
/// </summary>

public class GHashTableIterHandle : BaseSafeHandle
{
}


public static class GHashTableIterExtensions
{
/// <summary>
/// <para>
/// Returns the #GHashTable associated with @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GHashTableIter
/// </param>
/// <return>
/// the #GHashTable associated with @iter.
/// </return>

	public static MentorLake.GLib.GHashTableHandle GetHashTable(this MentorLake.GLib.GHashTableIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		return GHashTableIterExterns.g_hash_table_iter_get_hash_table(iter);
	}

/// <summary>
/// <para>
/// Initializes a key/value pair iterator and associates it with
/// @hash_table. Modifying the hash table after calling this function
/// invalidates the returned iterator.
/// </para>
/// <para>
/// The iteration order of a #GHashTableIter over the keys/values in a hash
/// table is not defined.
/// </para>
/// <code>
/// GHashTableIter iter;
/// GHashTableIter iter;
/// gpointer key, value;
/// 
/// g_hash_table_iter_init (&amp;iter, hash_table);
/// while (g_hash_table_iter_next (&amp;iter, &amp;key, &amp;value))
///   {
///     // do something with key and value
///   }
/// </code>
/// </summary>

/// <param name="iter">
/// an uninitialized #GHashTableIter
/// </param>
/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void Init(this MentorLake.GLib.GHashTableIterHandle iter, MentorLake.GLib.GHashTableHandle hash_table)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_init(iter, hash_table);
	}

/// <summary>
/// <para>
/// Advances @iter and retrieves the key and/or value that are now
/// pointed to as a result of this advancement. If %FALSE is returned,
/// @key and @value are not set, and the iterator becomes invalid.
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GHashTableIter
/// </param>
/// <param name="key">
/// a location to store the key
/// </param>
/// <param name="value">
/// a location to store the value
/// </param>
/// <return>
/// %FALSE if the end of the #GHashTable has been reached.
/// </return>

	public static bool Next(this MentorLake.GLib.GHashTableIterHandle iter, out IntPtr key, out IntPtr value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		return GHashTableIterExterns.g_hash_table_iter_next(iter, out key, out value);
	}

/// <summary>
/// <para>
/// Removes the key/value pair currently pointed to by the iterator
/// from its associated #GHashTable. Can only be called after
/// g_hash_table_iter_next() returned %TRUE, and cannot be called
/// more than once for the same key/value pair.
/// </para>
/// <para>
/// If the #GHashTable was created using g_hash_table_new_full(),
/// the key and value are freed using the supplied destroy functions,
/// otherwise you have to make sure that any dynamically allocated
/// values are freed yourself.
/// </para>
/// <para>
/// It is safe to continue iterating the #GHashTable afterward:
/// <code>
/// while (g_hash_table_iter_next (&amp;iter, &amp;key, &amp;value))
/// while (g_hash_table_iter_next (&amp;iter, &amp;key, &amp;value))
///   {
///     if (condition)
///       g_hash_table_iter_remove (&amp;iter);
///   }
/// </code>
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GHashTableIter
/// </param>

	public static void Remove(this MentorLake.GLib.GHashTableIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_remove(iter);
	}

/// <summary>
/// <para>
/// Replaces the value currently pointed to by the iterator
/// from its associated #GHashTable. Can only be called after
/// g_hash_table_iter_next() returned %TRUE.
/// </para>
/// <para>
/// If you supplied a @value_destroy_func when creating the
/// #GHashTable, the old value is freed using that function.
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GHashTableIter
/// </param>
/// <param name="value">
/// the value to replace with
/// </param>

	public static void Replace(this MentorLake.GLib.GHashTableIterHandle iter, IntPtr value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_replace(iter, value);
	}

/// <summary>
/// <para>
/// Removes the key/value pair currently pointed to by the
/// iterator from its associated #GHashTable, without calling
/// the key and value destroy functions. Can only be called
/// after g_hash_table_iter_next() returned %TRUE, and cannot
/// be called more than once for the same key/value pair.
/// </para>
/// </summary>

/// <param name="iter">
/// an initialized #GHashTableIter
/// </param>

	public static void Steal(this MentorLake.GLib.GHashTableIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_steal(iter);
	}


	public static GHashTableIter Dereference(this GHashTableIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GHashTableIter>(x.DangerousGetHandle());
}
internal class GHashTableIterExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_iter_get_hash_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_iter_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter, out IntPtr key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_iter_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_iter_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_iter_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableIterHandle>))] MentorLake.GLib.GHashTableIterHandle iter);

}

/// <summary>
/// <para>
/// A GHashTableIter structure represents an iterator that can be used
/// to iterate over the elements of a #GHashTable. GHashTableIter
/// structures are typically allocated on the stack and then initialized
/// with g_hash_table_iter_init().
/// </para>
/// <para>
/// The iteration order of a #GHashTableIter over the keys/values in a hash
/// table is not defined.
/// </para>
/// </summary>

public struct GHashTableIter
{
}
