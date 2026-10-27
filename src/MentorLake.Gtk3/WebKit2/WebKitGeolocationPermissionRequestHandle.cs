namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for sharing the user&apos;s location.
/// </para>
/// <para>
/// WebKitGeolocationPermissionRequest represents a request for
/// permission to decide whether WebKit should provide the user&apos;s
/// location to a website when requested through the Geolocation API.
/// </para>
/// <para>
/// When a WebKitGeolocationPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// <para>
/// When embedding web views in your application, you *must* configure an
/// application identifier to allow web content to use geolocation services.
/// The identifier *must* match the name of the `.desktop` file which describes
/// the application, sans the suffix.
/// </para>
/// <para>
/// If your application uses #GApplication (or any subclass like
/// #GtkApplication), WebKit will automatically use the identifier returned by
/// g_application_get_application_id(). This is the recommended approach for
/// enabling geolocation in applications.
/// </para>
/// <para>
/// If an identifier cannot be obtained through #GApplication, the value
/// returned by g_get_prgname() will be used instead as a fallback. For
/// programs which cannot use #GApplication, calling g_set_prgname() early
/// during initialization is needed when the name of the executable on disk
/// does not match the name of a valid `.desktop` file.
/// </para>
/// </summary>

public class WebKitGeolocationPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitGeolocationPermissionRequestHandleExtensions
{
}

internal class WebKitGeolocationPermissionRequestHandleExterns
{
}
