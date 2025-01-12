namespace MentorLake.Gtk3.GLib;

public class GRecMutexHandle : BaseSafeHandle
{
}


public static class GRecMutexHandleExtensions
{
	public static T Clear<T>(this T rec_mutex) where T : GRecMutexHandle
	{
		GRecMutexExterns.g_rec_mutex_clear(rec_mutex);
		return rec_mutex;
	}

	public static T Init<T>(this T rec_mutex) where T : GRecMutexHandle
	{
		GRecMutexExterns.g_rec_mutex_init(rec_mutex);
		return rec_mutex;
	}

	public static T Lock<T>(this T rec_mutex) where T : GRecMutexHandle
	{
		GRecMutexExterns.g_rec_mutex_lock(rec_mutex);
		return rec_mutex;
	}

	public static bool Trylock(this GRecMutexHandle rec_mutex)
	{
		return GRecMutexExterns.g_rec_mutex_trylock(rec_mutex);
	}

	public static T Unlock<T>(this T rec_mutex) where T : GRecMutexHandle
	{
		GRecMutexExterns.g_rec_mutex_unlock(rec_mutex);
		return rec_mutex;
	}

}
internal class GRecMutexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_rec_mutex_clear(GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rec_mutex_init(GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rec_mutex_lock(GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_rec_mutex_trylock(GRecMutexHandle rec_mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_rec_mutex_unlock(GRecMutexHandle rec_mutex);

}

public struct GRecMutex
{
}
