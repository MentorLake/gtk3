namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing the XR session mode.
/// </para>
/// <para>
/// See &amp;lt;https://immersive-web.github.io/webxr/#xrsessionmode-enum&amp;gt;
/// </para>
/// </summary>

[Flags]
public enum WebKitXRSessionMode
{
/// <summary>
/// <para>
/// inline session mode.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_MODE_INLINE = 0,
/// <summary>
/// <para>
/// immersive-vr session mode.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_MODE_IMMERSIVE_VR = 1,
/// <summary>
/// <para>
/// immersive-ar session mode.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_MODE_IMMERSIVE_AR = 2
}
