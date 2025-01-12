namespace MentorLake.Gtk3.GLib;

public class GStaticRWLockHandle : BaseSafeHandle
{
}


public static class GStaticRWLockHandleExtensions
{
	public static T GStaticRwLockFree<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_free(@lock);
		return @lock;
	}

	public static T GStaticRwLockInit<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_init(@lock);
		return @lock;
	}

	public static T GStaticRwLockReaderLock<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_reader_lock(@lock);
		return @lock;
	}

	public static bool GStaticRwLockReaderTrylock(this GStaticRWLockHandle @lock)
	{
		return GStaticRWLockExterns.g_static_rw_lock_reader_trylock(@lock);
	}

	public static T GStaticRwLockReaderUnlock<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_reader_unlock(@lock);
		return @lock;
	}

	public static T GStaticRwLockWriterLock<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_writer_lock(@lock);
		return @lock;
	}

	public static bool GStaticRwLockWriterTrylock(this GStaticRWLockHandle @lock)
	{
		return GStaticRWLockExterns.g_static_rw_lock_writer_trylock(@lock);
	}

	public static T GStaticRwLockWriterUnlock<T>(this T @lock) where T : GStaticRWLockHandle
	{
		GStaticRWLockExterns.g_static_rw_lock_writer_unlock(@lock);
		return @lock;
	}

}
internal class GStaticRWLockExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_free(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_init(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_reader_lock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_static_rw_lock_reader_trylock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_reader_unlock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_writer_lock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_static_rw_lock_writer_trylock(GStaticRWLockHandle @lock);

	[DllImport(Libraries.GLib)]
	internal static extern void g_static_rw_lock_writer_unlock(GStaticRWLockHandle @lock);

}

public struct GStaticRWLock
{
}
