namespace MentorLake.GLib;

public class GHashTableIterHandle : BaseSafeHandle
{
}


public static class GHashTableIterExtensions
{
	public static MentorLake.GLib.GHashTableHandle GetHashTable(this MentorLake.GLib.GHashTableIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		return GHashTableIterExterns.g_hash_table_iter_get_hash_table(iter);
	}

	public static void Init(this MentorLake.GLib.GHashTableIterHandle iter, MentorLake.GLib.GHashTableHandle hash_table)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_init(iter, hash_table);
	}

	public static bool Next(this MentorLake.GLib.GHashTableIterHandle iter, out IntPtr key, out IntPtr value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		return GHashTableIterExterns.g_hash_table_iter_next(iter, out key, out value);
	}

	public static void Remove(this MentorLake.GLib.GHashTableIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_remove(iter);
	}

	public static void Replace(this MentorLake.GLib.GHashTableIterHandle iter, IntPtr value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GHashTableIter)");
		GHashTableIterExterns.g_hash_table_iter_replace(iter, value);
	}

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

public struct GHashTableIter
{
}
