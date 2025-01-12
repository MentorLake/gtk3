namespace MentorLake.Gtk3.GLib;

public class GMutexHandle : BaseSafeHandle
{
}


public static class GMutexHandleExtensions
{
	public static T Clear<T>(this T mutex) where T : GMutexHandle
	{
		GMutexExterns.g_mutex_clear(mutex);
		return mutex;
	}

	public static T Free<T>(this T mutex) where T : GMutexHandle
	{
		GMutexExterns.g_mutex_free(mutex);
		return mutex;
	}

	public static T Init<T>(this T mutex) where T : GMutexHandle
	{
		GMutexExterns.g_mutex_init(mutex);
		return mutex;
	}

	public static T Lock<T>(this T mutex) where T : GMutexHandle
	{
		GMutexExterns.g_mutex_lock(mutex);
		return mutex;
	}

	public static bool Trylock(this GMutexHandle mutex)
	{
		return GMutexExterns.g_mutex_trylock(mutex);
	}

	public static T Unlock<T>(this T mutex) where T : GMutexHandle
	{
		GMutexExterns.g_mutex_unlock(mutex);
		return mutex;
	}

	public static GMutexHandle New()
	{
		return GMutexExterns.g_mutex_new();
	}

}
internal class GMutexExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_clear(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_free(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_init(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_lock(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_mutex_trylock(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mutex_unlock(GMutexHandle mutex);

	[DllImport(Libraries.GLib)]
	internal static extern GMutexHandle g_mutex_new();

}

public struct GMutex
{
}
