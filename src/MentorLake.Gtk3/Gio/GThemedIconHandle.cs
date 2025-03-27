namespace MentorLake.Gio;

public class GThemedIconHandle : GObjectHandle, GIconHandle
{
	public static MentorLake.Gio.GThemedIconHandle New(string iconname)
	{
		return GThemedIconHandleExterns.g_themed_icon_new(iconname);
	}

	public static MentorLake.Gio.GThemedIconHandle NewFromNames(string[] iconnames, int len)
	{
		return GThemedIconHandleExterns.g_themed_icon_new_from_names(iconnames, len);
	}

	public static MentorLake.Gio.GThemedIconHandle NewWithDefaultFallbacks(string iconname)
	{
		return GThemedIconHandleExterns.g_themed_icon_new_with_default_fallbacks(iconname);
	}

}

public static class GThemedIconHandleExtensions
{
	public static T AppendName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		GThemedIconHandleExterns.g_themed_icon_append_name(icon, iconname);
		return icon;
	}

	public static string[] GetNames(this MentorLake.Gio.GThemedIconHandle icon)
	{
		return GThemedIconHandleExterns.g_themed_icon_get_names(icon);
	}

	public static T PrependName<T>(this T icon, string iconname) where T : GThemedIconHandle
	{
		GThemedIconHandleExterns.g_themed_icon_prepend_name(icon, iconname);
		return icon;
	}

}

internal class GThemedIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new(string iconname);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new_from_names(string[] iconnames, int len);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GThemedIconHandle g_themed_icon_new_with_default_fallbacks(string iconname);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_themed_icon_append_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon, string iconname);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_themed_icon_get_names([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_themed_icon_prepend_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GThemedIconHandle>))] MentorLake.Gio.GThemedIconHandle icon, string iconname);

}
