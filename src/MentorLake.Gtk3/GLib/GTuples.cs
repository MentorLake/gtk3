namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GTuples struct is used to return records (or tuples) from the
/// #GRelation by g_relation_select(). It only contains one public
/// member - the number of records that matched. To access the matched
/// records, you must use g_tuples_index().
/// </para>
/// </summary>

public class GTuplesHandle : BaseSafeHandle
{
}


public static class GTuplesExtensions
{
/// <summary>
/// <para>
/// Frees the records which were returned by g_relation_select(). This
/// should always be called after g_relation_select() when you are
/// finished with the records. The records are not removed from the
/// #GRelation.
/// </para>
/// </summary>

/// <param name="tuples">
/// the tuple data to free.
/// </param>

	public static void Destroy(this MentorLake.GLib.GTuplesHandle tuples)
	{
		if (tuples.IsInvalid) throw new Exception("Invalid handle (GTuples)");
		GTuplesExterns.g_tuples_destroy(tuples);
	}

/// <summary>
/// <para>
/// Gets a field from the records returned by g_relation_select(). It
/// returns the given field of the record at the given index. The
/// returned value should not be changed.
/// </para>
/// </summary>

/// <param name="tuples">
/// the tuple data, returned by g_relation_select().
/// </param>
/// <param name="index_">
/// the index of the record.
/// </param>
/// <param name="field">
/// the field to return.
/// </param>
/// <return>
/// the field of the record.
/// </return>

	public static IntPtr Index(this MentorLake.GLib.GTuplesHandle tuples, int index_, int field)
	{
		if (tuples.IsInvalid) throw new Exception("Invalid handle (GTuples)");
		return GTuplesExterns.g_tuples_index(tuples, index_, field);
	}


	public static GTuples Dereference(this GTuplesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTuples>(x.DangerousGetHandle());
}
internal class GTuplesExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tuples_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTuplesHandle>))] MentorLake.GLib.GTuplesHandle tuples);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tuples_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTuplesHandle>))] MentorLake.GLib.GTuplesHandle tuples, int index_, int field);

}

/// <summary>
/// <para>
/// The #GTuples struct is used to return records (or tuples) from the
/// #GRelation by g_relation_select(). It only contains one public
/// member - the number of records that matched. To access the matched
/// records, you must use g_tuples_index().
/// </para>
/// </summary>

public struct GTuples
{
	/// <summary>
/// <para>
/// the number of records that matched.
/// </para>
/// </summary>

public uint len;
}
