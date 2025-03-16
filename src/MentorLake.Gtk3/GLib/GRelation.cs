namespace MentorLake.GLib;

public class GRelationHandle : BaseSafeHandle
{
}


public static class GRelationExtensions
{
	public static int Count(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_count(relation, key, field);
	}

	public static int Delete(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
		return GRelationExterns.g_relation_delete(relation, key, field);
	}

	public static void Destroy(this MentorLake.GLib.GRelationHandle relation)
	{
		GRelationExterns.g_relation_destroy(relation);
	}

	public static bool Exists(this MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist)
	{
		return GRelationExterns.g_relation_exists(relation, @__arglist);
	}

	public static void Index(this MentorLake.GLib.GRelationHandle relation, int field, MentorLake.GLib.GHashFunc hash_func, MentorLake.GLib.GEqualFunc key_equal_func)
	{
		GRelationExterns.g_relation_index(relation, field, hash_func, key_equal_func);
	}

	public static void Insert(this MentorLake.GLib.GRelationHandle relation, IntPtr @__arglist)
	{
		GRelationExterns.g_relation_insert(relation, @__arglist);
	}

	public static void Print(this MentorLake.GLib.GRelationHandle relation)
	{
		GRelationExterns.g_relation_print(relation);
	}

	public static MentorLake.GLib.GTuplesHandle Select(this MentorLake.GLib.GRelationHandle relation, IntPtr key, int field)
	{
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
	internal static extern MentorLake.GLib.GTuplesHandle g_relation_select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRelationHandle>))] MentorLake.GLib.GRelationHandle relation, IntPtr key, int field);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GRelationHandle g_relation_new(int fields);

}

public struct GRelation
{
	public static MentorLake.GLib.GRelationHandle New(int fields)
	{
		return GRelationExterns.g_relation_new(fields);
	}

}
