namespace MentorLake.Gtk3.Gio;

public class GThemedIconHandle : GObjectHandle, GIconHandle
{
	public static GThemedIconHandle New(string iconname)
	{
		return GThemedIconExterns.g_themed_icon_new(iconname);
	}

	public static GThemedIconHandle NewFromNames(string[] iconnames, int len)
	{
		return GThemedIconExterns.g_themed_icon_new_from_names(iconnames, len);
	}

	public static GThemedIconHandle NewWithDefaultFallbacks(string iconname)
	{
		return GThemedIconExterns.g_themed_icon_new_with_default_fallbacks(iconname);
	}

}

public static class GThemedIconHandleExtensions
{
	public static T AppendName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		GThemedIconExterns.g_themed_icon_append_name(icon, iconname);
		return icon;
	}

	public static IntPtr GetNames(this GThemedIconHandle icon)
	{
		return GThemedIconExterns.g_themed_icon_get_names(icon);
	}

	public static T PrependName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		GThemedIconExterns.g_themed_icon_prepend_name(icon, iconname);
		return icon;
	}

}

internal class GThemedIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new(string iconname);

	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new_from_names(string[] iconnames, int len);

	[DllImport(Libraries.Gio)]
	internal static extern GThemedIconHandle g_themed_icon_new_with_default_fallbacks(string iconname);

	[DllImport(Libraries.Gio)]
	internal static extern void g_themed_icon_append_name(GThemedIconHandle icon, string iconname);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_themed_icon_get_names(GThemedIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_themed_icon_prepend_name(GThemedIconHandle icon, string iconname);

}
