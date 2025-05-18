namespace MentorLake.GioUnix;

public interface GDesktopAppInfoLookupHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDesktopAppInfoLookupHandleImpl : BaseSafeHandle, GDesktopAppInfoLookupHandle
{
}

public static class GDesktopAppInfoLookupHandleExtensions
{
	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriScheme(MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		return GDesktopAppInfoLookupHandleExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

}

internal class GDesktopAppInfoLookupHandleExterns
{
	[DllImport(GioUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoLookupHandleImpl>))] MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme);

}
