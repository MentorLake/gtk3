namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Previously, a permission request for installing missing media plugins.
/// </para>
/// <para>
/// WebKitInstallMissingMediaPluginsPermissionRequest will no longer ever be created, so
/// you can remove any code that attempts to handle it.
/// </para>
/// </summary>

public class WebKitInstallMissingMediaPluginsPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitInstallMissingMediaPluginsPermissionRequestHandleExtensions
{
/// <summary>
/// <para>
/// This function returns an empty string.
/// </para>
/// </summary>

/// <param name="request">
/// a #WebKitInstallMissingMediaPluginsPermissionRequest
/// </param>
/// <return>
/// an empty string
/// </return>

	public static string GetDescription(this MentorLake.WebKit2.WebKitInstallMissingMediaPluginsPermissionRequestHandle request)
	{
		if (request.IsInvalid) throw new Exception("Invalid handle (WebKitInstallMissingMediaPluginsPermissionRequestHandle)");
		return WebKitInstallMissingMediaPluginsPermissionRequestHandleExterns.webkit_install_missing_media_plugins_permission_request_get_description(request);
	}

}

internal class WebKitInstallMissingMediaPluginsPermissionRequestHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_install_missing_media_plugins_permission_request_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitInstallMissingMediaPluginsPermissionRequestHandle>))] MentorLake.WebKit2.WebKitInstallMissingMediaPluginsPermissionRequestHandle request);

}
