namespace MentorLake.Gio;

public interface GDesktopAppInfoLookupHandle
{
}

internal class GDesktopAppInfoLookupHandleImpl : BaseSafeHandle, GDesktopAppInfoLookupHandle
{
}

public static class GDesktopAppInfoLookupHandleExtensions
{
	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriScheme(this MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GDesktopAppInfoLookupHandleExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

}

internal class GDesktopAppInfoLookupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoLookupHandleImpl>))] MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme);

}
