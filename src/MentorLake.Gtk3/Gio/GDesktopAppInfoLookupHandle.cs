namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GDesktopAppInfoLookup is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets the default application for launching applications
/// using this URI scheme for a particular [iface@Gio.DesktopAppInfoLookup]
/// implementation.
/// </para>
/// <para>
/// The [iface@Gio.DesktopAppInfoLookup] interface and this function is used
/// to implement [func@Gio.AppInfo.get_default_for_uri_scheme] backends
/// in a GIO module. There is no reason for applications to use it
/// directly. Applications should use
/// [func@Gio.AppInfo.get_default_for_uri_scheme].
/// </para>
/// </summary>

/// <param name="lookup">
/// a [iface@Gio.DesktopAppInfoLookup]
/// </param>
/// <param name="uri_scheme">
/// a string containing a URI scheme.
/// </param>
/// <return>
/// [iface@Gio.AppInfo] for given
///   @uri_scheme or `NULL` on error.
/// </return>

	public static MentorLake.Gio.GAppInfoHandle GetDefaultForUriScheme(this MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme)
	{
		if (lookup.IsInvalid) throw new Exception("Invalid handle (GDesktopAppInfoLookupHandle)");
		return GDesktopAppInfoLookupHandleExterns.g_desktop_app_info_lookup_get_default_for_uri_scheme(lookup, uri_scheme);
	}

}

internal class GDesktopAppInfoLookupHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))]
	internal static extern MentorLake.Gio.GAppInfoHandle g_desktop_app_info_lookup_get_default_for_uri_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDesktopAppInfoLookupHandleImpl>))] MentorLake.Gio.GDesktopAppInfoLookupHandle lookup, string uri_scheme);

}
