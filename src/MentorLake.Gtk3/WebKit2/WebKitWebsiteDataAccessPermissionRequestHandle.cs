namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for accessing website data from third-party domains.
/// </para>
/// <para>
/// WebKitWebsiteDataAccessPermissionRequest represents a request for
/// permission to allow a third-party domain access its cookies.
/// </para>
/// <para>
/// When a WebKitWebsiteDataAccessPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// </summary>

public class WebKitWebsiteDataAccessPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitWebsiteDataAccessPermissionRequestHandleExtensions
{
/// <summary>
/// <para>
/// Get the current domain being browsed.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitWebsiteDataAccessPermissionRequest
/// </param>
/// <return>
/// the current domain name
/// </return>

	public static string GetCurrentDomain(this MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataAccessPermissionRequestHandle)");
		return WebKitWebsiteDataAccessPermissionRequestHandleExterns.webkit_website_data_access_permission_request_get_current_domain(request);
	}

/// <summary>
/// <para>
/// Get the domain requesting permission to access its cookies while browsing the current domain.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitWebsiteDataAccessPermissionRequest
/// </param>
/// <return>
/// the requesting domain name
/// </return>

	public static string GetRequestingDomain(this MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitWebsiteDataAccessPermissionRequestHandle)");
		return WebKitWebsiteDataAccessPermissionRequestHandleExterns.webkit_website_data_access_permission_request_get_requesting_domain(request);
	}

}

internal class WebKitWebsiteDataAccessPermissionRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_access_permission_request_get_current_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle>))] MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_website_data_access_permission_request_get_requesting_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle>))] MentorLake.WebKit2.WebKitWebsiteDataAccessPermissionRequestHandle request);

}
