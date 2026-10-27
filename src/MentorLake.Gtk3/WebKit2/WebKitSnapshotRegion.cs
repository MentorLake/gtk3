namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify the region from which to get a #WebKitWebView
/// snapshot
/// </para>
/// </summary>

[Flags]
public enum WebKitSnapshotRegion
{
/// <summary>
/// <para>
/// Specifies a snapshot only for the area that is
/// visible in the webview
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_REGION_VISIBLE = 0,
/// <summary>
/// <para>
/// A snapshot of the entire document.
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_REGION_FULL_DOCUMENT = 1
}
