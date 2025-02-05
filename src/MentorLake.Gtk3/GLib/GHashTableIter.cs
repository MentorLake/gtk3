namespace MentorLake.Gtk3.GLib;

public class GHashTableIterHandle : BaseSafeHandle
{
}


public static class GHashTableIterHandleExtensions
{
	public static GHashTableHandle GetHashTable(this GHashTableIterHandle iter)
	{
		return GHashTableIterExterns.g_hash_table_iter_get_hash_table(iter);
	}

	public static T Init<T>(this T iter, GHashTableHandle hash_table) where T : GHashTableIterHandle
	{
		GHashTableIterExterns.g_hash_table_iter_init(iter, hash_table);
		return iter;
	}

	public static bool Next(this GHashTableIterHandle iter, out IntPtr key, out IntPtr value)
	{
		return GHashTableIterExterns.g_hash_table_iter_next(iter, out key, out value);
	}

	public static T Remove<T>(this T iter) where T : GHashTableIterHandle
	{
		GHashTableIterExterns.g_hash_table_iter_remove(iter);
		return iter;
	}

	public static T Replace<T>(this T iter, IntPtr value) where T : GHashTableIterHandle
	{
		GHashTableIterExterns.g_hash_table_iter_replace(iter, value);
		return iter;
	}

	public static T Steal<T>(this T iter) where T : GHashTableIterHandle
	{
		GHashTableIterExterns.g_hash_table_iter_steal(iter);
		return iter;
	}

}
internal class GHashTableIterExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GHashTableHandle g_hash_table_iter_get_hash_table(GHashTableIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_iter_init(GHashTableIterHandle iter, GHashTableHandle hash_table);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_hash_table_iter_next(GHashTableIterHandle iter, out IntPtr key, out IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_iter_remove(GHashTableIterHandle iter);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_iter_replace(GHashTableIterHandle iter, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_hash_table_iter_steal(GHashTableIterHandle iter);

}

public struct GHashTableIter
{
}
