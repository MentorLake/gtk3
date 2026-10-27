namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// A permission request for reading clipboard contents.
/// </para>
/// <para>
/// WebKitClipboardPermissionRequest represents a request for
/// permission to decide whether WebKit can access the clipboard to read
/// its contents through the Async Clipboard API.
/// </para>
/// <para>
/// When a WebKitClipboardPermissionRequest is not handled by the user,
/// it is denied by default.
/// </para>
/// </summary>

public class WebKitClipboardPermissionRequestHandle : GObjectHandle, WebKitPermissionRequestHandle
{
}

public static class WebKitClipboardPermissionRequestHandleExtensions
{
}

internal class WebKitClipboardPermissionRequestHandleExterns
{
}
