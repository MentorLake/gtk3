namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request.
/// </para>
/// <para>
/// There are situations where an embedder would need to ask the user
/// for permission to do certain types of operations, such as switching
/// to fullscreen mode or reporting the user&apos;s location through the
/// standard Geolocation API. In those cases, WebKit will emit a
/// #WebKitWebView::permission-request signal with a
/// #WebKitPermissionRequest object attached to it.
/// </para>
/// </summary>

public interface WebKitPermissionRequestHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class WebKitPermissionRequestHandleImpl : BaseSafeHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitPermissionRequestHandleExtensions
{
/// <summary>
/// <para>
/// Allow the action which triggered this request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitPermissionRequest
/// </param>

	public static T Allow<T>(this T request) where T : WebKitPermissionRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionRequestHandle)");
		WebKitPermissionRequestHandleExterns.webkit_permission_request_allow(request);
		return request;
	}

/// <summary>
/// <para>
/// Deny the action which triggered this request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitPermissionRequest
/// </param>

	public static T Deny<T>(this T request) where T : WebKitPermissionRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitPermissionRequestHandle)");
		WebKitPermissionRequestHandleExterns.webkit_permission_request_deny(request);
		return request;
	}

}

internal class WebKitPermissionRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_permission_request_allow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionRequestHandleImpl>))] MentorLake.WebKit2.WebKitPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_permission_request_deny([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPermissionRequestHandleImpl>))] MentorLake.WebKit2.WebKitPermissionRequestHandle request);

}
