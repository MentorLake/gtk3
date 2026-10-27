namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for setting if a #WebKitWebView is intended for
/// WebExtensions.
/// </para>
/// </summary>

[Flags]
public enum WebKitWebExtensionMode
{
/// <summary>
/// <para>
/// Not for an extension.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MODE_NONE = 0,
/// <summary>
/// <para>
/// For a ManifestV2 extension.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MODE_MANIFESTV2 = 1,
/// <summary>
/// <para>
/// For a ManifestV3 extension.
/// </para>
/// </summary>

	WEBKIT_WEB_EXTENSION_MODE_MANIFESTV3 = 2
}
