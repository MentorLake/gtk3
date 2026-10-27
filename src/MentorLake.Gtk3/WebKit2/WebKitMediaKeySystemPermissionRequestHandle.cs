namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for using an EME Content Decryption Module.
/// </para>
/// <para>
/// WebKitMediaKeySystemPermissionRequest represents a request for permission to decide whether
/// WebKit should use the given CDM to access protected media when requested through the
/// MediaKeySystem API.
/// </para>
/// <para>
/// When a WebKitMediaKeySystemPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// <para>
/// When handling this permission request the application may perform additional installation of the
/// requested CDM, unless it is already present on the host system.
/// </para>
/// </summary>

public class WebKitMediaKeySystemPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitMediaKeySystemPermissionRequestHandleExtensions
{
}

internal class WebKitMediaKeySystemPermissionRequestHandleExterns
{
}
