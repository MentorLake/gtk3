namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for accessing virtual reality (VR) and
/// augmented reality (AR) devices, including sensors and head-mounted
/// displays.
/// </para>
/// <para>
/// WebKitXRPermissionRequest represents a request for permission to
/// decide whether WebKit can initialize an XR session through the
/// WebXR API.
/// </para>
/// <para>
/// When a WebKitXRPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// </summary>

public class WebKitXRPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitXRPermissionRequestHandleExtensions
{
/// <summary>
/// <para>
/// Gets the optional features that need user consent.
/// </para>
/// <para>
/// These features can be granted by calling
/// webkit_xr_permission_request_set_granted_optional_features()
/// before allowing the request with webkit_permission_request_allow().
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionFeatures flag combination
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionFeatures GetConsentOptionalFeatures(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_consent_optional_features(request);
	}

/// <summary>
/// <para>
/// Gets the required features that need user consent.
/// </para>
/// <para>
/// These features are automatically granted if the request is allowed with
/// webkit_permission_request_allow().
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionFeatures flag combination
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionFeatures GetConsentRequiredFeatures(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_consent_required_features(request);
	}

/// <summary>
/// <para>
/// Gets the features requested by the origin for the XR device, which
/// are either granted by default or have been explicitly granted by
/// the user.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionFeatures flag combination
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionFeatures GetGrantedFeatures(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_granted_features(request);
	}

/// <summary>
/// <para>
/// Gets the full set of optional features requested by the web application.
/// </para>
/// <para>
/// This includes both already granted features and those requiring consent.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionFeatures flag combination
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionFeatures GetOptionalFeaturesRequested(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_optional_features_requested(request);
	}

/// <summary>
/// <para>
/// Gets the full set of required features requested by the web application.
/// </para>
/// <para>
/// This includes both already granted features and those requiring consent.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionFeatures flag combination
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionFeatures GetRequiredFeaturesRequested(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_required_features_requested(request);
	}

/// <summary>
/// <para>
/// Gets the security origin that initiated the permission request.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// the #WebKitSecurityOrigin that initiated the request
/// </return>

	public static MentorLake.WebKit2.WebKitSecurityOriginHandle GetSecurityOrigin(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_security_origin(request);
	}

/// <summary>
/// <para>
/// Gets the session mode for which permission is being requested.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <return>
/// a #WebKitXRSessionMode
/// </return>

	public static MentorLake.WebKit2.WebKitXRSessionMode GetSessionMode(this MentorLake.WebKit2.WebKitXRPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		return WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_get_session_mode(request);
	}

/// <summary>
/// <para>
/// Sets which optional features should be granted if the permission request is allowed.
/// </para>
/// <para>
/// This function should be called with a subset of the features from
/// webkit_xr_permission_request_get_consent_optional_features() before calling
/// webkit_permission_request_allow(). If the request is denied, no features are
/// granted, regardless of what is set here.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitXRPermissionRequest
/// </param>
/// <param name="granted">
/// granted features
/// </param>

	public static T SetGrantedOptionalFeatures<T>(this T request, MentorLake.WebKit2.WebKitXRSessionFeatures granted) where T : WebKitXRPermissionRequestHandle
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitXRPermissionRequestHandle)");
		WebKitXRPermissionRequestHandleExterns.webkit_xr_permission_request_set_granted_optional_features(request, granted);
		return request;
	}

}

internal class WebKitXRPermissionRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionFeatures webkit_xr_permission_request_get_consent_optional_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionFeatures webkit_xr_permission_request_get_consent_required_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionFeatures webkit_xr_permission_request_get_granted_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionFeatures webkit_xr_permission_request_get_optional_features_requested([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionFeatures webkit_xr_permission_request_get_required_features_requested([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitSecurityOriginHandle>))]
	internal static extern MentorLake.WebKit2.WebKitSecurityOriginHandle webkit_xr_permission_request_get_security_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitXRSessionMode webkit_xr_permission_request_get_session_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_xr_permission_request_set_granted_optional_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitXRPermissionRequestHandle>))] MentorLake.WebKit2.WebKitXRPermissionRequestHandle request, MentorLake.WebKit2.WebKitXRSessionFeatures granted);

}
