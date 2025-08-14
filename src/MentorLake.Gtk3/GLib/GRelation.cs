namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GRelation` is a table of data which can be indexed on any number
/// of fields, rather like simple database tables. A `GRelation` contains
/// a number of records, called tuples. Each record contains a number of
/// fields. Records are not ordered, so it is not possible to find the
/// record at a particular index.
/// </para>
/// <para>
/// Note that `GRelation` tables are currently limited to 2 fields.
/// </para>
/// <para>
/// To create a `GRelation`, use [func@GLib.Relation.new].
/// </para>
/// <para>
/// To specify which fields should be indexed, use [method@GLib.Relation.index].
/// Note that this must be called before any tuples are added to the
/// `GRelation`.
/// </para>
/// <para>
/// To add records to a `GRelation` use [method@GLib.Relation.insert].
/// </para>
/// <para>
/// To determine if a given record appears in a `GRelation`, use
/// [method@GLib.Relation.exists]. Note that fields are compared directly, so
/// pointers must point to the exact same position (i.e. different
/// copies of the same string will not match.)
/// </para>
/// <para>
/// To count the number of records which have a particular value in a
/// given field, use [method@GLib.Relation.count].
/// </para>
/// <para>
/// To get all the records which have a particular value in a given
/// field, use [method@GLib.Relation.select]. To access fields of the resulting
/// records, use [method@GLib.Tuples.index]. To free the resulting records use
/// [method@GLib.Tuples.destroy].
/// </para>
/// <para>
/// To delete all records which have a particular value in a given
/// field, use [method@GLib.Relation.delete].
/// </para>
/// <para>
/// To destroy the `GRelation`, use [method@GLib.Relation.destroy].
/// </para>
/// <para>
/// To help debug `GRelation` objects, use [method@GLib.Relation.print].
/// </para>
/// <para>
/// `GRelation` has been marked as deprecated, since this API has never
/// been fully implemented, is not very actively maintained and rarely
/// used.
/// </para>
/// </summary>

public class GRelationHandle : BaseSafeHandle
{
}


public static class GRelationExtensions
{
/// <summary>
/// <para>
/// Returns the number of tuples in a #GRelation that have the given
/// value in the given field.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="key">
/// the value to compare with.
/// </param>
/// <param name="field">
/// the field of each record to match.
/// </param>
/// <return>
/// the number of matches.
/// </return>

	public static int Count(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		return GRelationExterns.g_relation_count(relation, key, field);
	}

/// <summary>
/// <para>
/// Deletes any records from a #GRelation that have the given key value
/// in the given field.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="key">
/// the value to compare with.
/// </param>
/// <param name="field">
/// the field of each record to match.
/// </param>
/// <return>
/// the number of records deleted.
/// </return>

	public static int Delete(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		return GRelationExterns.g_relation_delete(relation, key, field);
	}

/// <summary>
/// <para>
/// Destroys the #GRelation, freeing all memory allocated. However, it
/// does not free memory allocated for the tuple data, so you should
/// free that first if appropriate.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>

	public static void Destroy(this MentorLake.GLib.GRelationHandle relation)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		GRelationExterns.g_relation_destroy(relation);
	}

/// <summary>
/// <para>
/// Returns %TRUE if a record with the given values exists in a
/// #GRelation. Note that the values are compared directly, so that, for
/// example, two copies of the same string will not match.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="@__arglist">
/// the fields of the record to compare. The number must match
///       the number of fields in the #GRelation.
/// </param>
/// <return>
/// %TRUE if a record matches.
/// </return>

	public static bool Exists(this MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		return GRelationExterns.g_relation_exists(relation, @__arglist);
	}

/// <summary>
/// <para>
/// Creates an index on the given field. Note that this must be called
/// before any records are added to the #GRelation.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="field">
/// the field to index, counting from 0.
/// </param>
/// <param name="hash_func">
/// a function to produce a hash value from the field data.
/// </param>
/// <param name="key_equal_func">
/// a function to compare two values of the given field.
/// </param>

	public static void Index(this MentorLake.GLib.GRelationHandle relation, int field, MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		GRelationExterns.g_relation_index(relation, field, hash_func, key_equal_func);
	}

/// <summary>
/// <para>
/// Inserts a record into a #GRelation.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="@__arglist">
/// the fields of the record to add. These must match the
///       number of fields in the #GRelation, and of type #gpointer
///       or #gconstpointer.
/// </param>

	public static void Insert(this MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		GRelationExterns.g_relation_insert(relation, @__arglist);
	}

/// <summary>
/// <para>
/// Outputs information about all records in a #GRelation, as well as
/// the indexes. It is for debugging.
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>

	public static void Print(this MentorLake.GLib.GRelationHandle relation)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		GRelationExterns.g_relation_print(relation);
	}

/// <summary>
/// <para>
/// Returns all of the tuples which have the given key in the given
/// field. Use g_tuples_index() to access the returned records. The
/// returned records should be freed with g_tuples_destroy().
/// </para>
/// </summary>

/// <param name="relation">
/// a #GRelation.
/// </param>
/// <param name="key">
/// the value to compare with.
/// </param>
/// <param name="field">
/// the field of each record to match.
/// </param>
/// <return>
/// the records (tuples) that matched.
/// </return>

	public static MentorLake.GLib.GTuplesHandle Select(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (GRelation)");
		return GRelationExterns.g_relation_select(relation, key, field);
	}


	public static GRelation Dereference(this GRelationHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRelation>(x.DangerousGetHandle());
}
internal class GRelationExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_relation_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr key, int field);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_relation_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr key, int field);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_relation_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_relation_exists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_relation_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, int field, MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_relation_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_relation_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTuplesHandle>))]
	internal static extern MentorLake.GLib.GTuplesHandle g_relation_select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr key, int field);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))]
	internal static extern MentorLake.GLib.GRelationHandle g_relation_new(int fields);

}

/// <summary>
/// <para>
/// A `GRelation` is a table of data which can be indexed on any number
/// of fields, rather like simple database tables. A `GRelation` contains
/// a number of records, called tuples. Each record contains a number of
/// fields. Records are not ordered, so it is not possible to find the
/// record at a particular index.
/// </para>
/// <para>
/// Note that `GRelation` tables are currently limited to 2 fields.
/// </para>
/// <para>
/// To create a `GRelation`, use [func@GLib.Relation.new].
/// </para>
/// <para>
/// To specify which fields should be indexed, use [method@GLib.Relation.index].
/// Note that this must be called before any tuples are added to the
/// `GRelation`.
/// </para>
/// <para>
/// To add records to a `GRelation` use [method@GLib.Relation.insert].
/// </para>
/// <para>
/// To determine if a given record appears in a `GRelation`, use
/// [method@GLib.Relation.exists]. Note that fields are compared directly, so
/// pointers must point to the exact same position (i.e. different
/// copies of the same string will not match.)
/// </para>
/// <para>
/// To count the number of records which have a particular value in a
/// given field, use [method@GLib.Relation.count].
/// </para>
/// <para>
/// To get all the records which have a particular value in a given
/// field, use [method@GLib.Relation.select]. To access fields of the resulting
/// records, use [method@GLib.Tuples.index]. To free the resulting records use
/// [method@GLib.Tuples.destroy].
/// </para>
/// <para>
/// To delete all records which have a particular value in a given
/// field, use [method@GLib.Relation.delete].
/// </para>
/// <para>
/// To destroy the `GRelation`, use [method@GLib.Relation.destroy].
/// </para>
/// <para>
/// To help debug `GRelation` objects, use [method@GLib.Relation.print].
/// </para>
/// <para>
/// `GRelation` has been marked as deprecated, since this API has never
/// been fully implemented, is not very actively maintained and rarely
/// used.
/// </para>
/// </summary>

public struct GRelation
{
/// <summary>
/// <para>
/// Creates a new #GRelation with the given number of fields. Note that
/// currently the number of fields must be 2.
/// </para>
/// </summary>

/// <param name="fields">
/// the number of fields.
/// </param>
/// <return>
/// a new #GRelation.
/// </return>

	public static MentorLake.GLib.GRelationHandle New(int fields)
	{
		return GRelationExterns.g_relation_new(fields);
	}

}
