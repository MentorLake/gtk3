namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for enumerating the user&apos;s media devices
/// </para>
/// <para>
/// WebKitDeviceInfoPermissionRequest represents a request for
/// permission to whether WebKit should be allowed to access the user&apos;s
/// devices information when requested through the MediaDevices.enumerateDevices
/// API.
/// </para>
/// <para>
/// When a WebKitDeviceInfoPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// </summary>

public class WebKitDeviceInfoPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitDeviceInfoPermissionRequestHandleExtensions
{
}

internal class WebKitDeviceInfoPermissionRequestHandleExterns
{
}
