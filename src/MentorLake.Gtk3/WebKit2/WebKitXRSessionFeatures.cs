namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values representing the XR session features.
/// </para>
/// <para>
/// See &amp;lt;https://immersive-web.github.io/webxr/#xrreferencespace-interface&amp;gt;.
/// And, see &amp;lt;https://immersive-web.github.io/webxr-hand-input/&amp;gt; for hand tracking.
/// </para>
/// </summary>

[Flags]
public enum WebKitXRSessionFeatures : uint
{
/// <summary>
/// <para>
/// viewer feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_VIEWER = 1,
/// <summary>
/// <para>
/// local feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_LOCAL = 2,
/// <summary>
/// <para>
/// local-floor feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_LOCAL_FLOOR = 4,
/// <summary>
/// <para>
/// bounded-floor feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_BOUNDED_FLOOR = 8,
/// <summary>
/// <para>
/// unbounded feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_UNBOUNDED = 16,
/// <summary>
/// <para>
/// hand tracking feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_HAND_TRACKING = 32,
/// <summary>
/// <para>
/// hit test feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_HIT_TEST = 64,
/// <summary>
/// <para>
/// WebXR Layers feature.
/// </para>
/// </summary>

	WEBKIT_XR_SESSION_FEATURES_LAYERS = 128
}
