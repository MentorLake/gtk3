namespace MentorLake.Gtk3.GLib;

public class GPrivateHandle : BaseSafeHandle
{
}


public static class GPrivateHandleExtensions
{
	public static IntPtr Get(this GPrivateHandle key)
	{
		return GPrivateExterns.g_private_get(key);
	}

	public static T Replace<T>(this T key, IntPtr value) where T : GPrivateHandle
	{
		GPrivateExterns.g_private_replace(key, value);
		return key;
	}

	public static T Set<T>(this T key, IntPtr value) where T : GPrivateHandle
	{
		GPrivateExterns.g_private_set(key, value);
		return key;
	}

	public static GPrivateHandle New(GDestroyNotify notify)
	{
		return GPrivateExterns.g_private_new(notify);
	}

}
internal class GPrivateExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_private_get(GPrivateHandle key);

	[DllImport(Libraries.GLib)]
	internal static extern void g_private_replace(GPrivateHandle key, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_private_set(GPrivateHandle key, IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern GPrivateHandle g_private_new(GDestroyNotify notify);

}

public struct GPrivate
{
}
