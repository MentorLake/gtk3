namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify options when taking a snapshot
/// from a #WebKitWebView.
/// </para>
/// </summary>

[Flags]
public enum WebKitSnapshotOptions : uint
{
/// <summary>
/// <para>
/// Do not include any special options.
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_OPTIONS_NONE = 0,
/// <summary>
/// <para>
/// Whether to include in the
/// snapshot the highlight of the selected content.
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_OPTIONS_INCLUDE_SELECTION_HIGHLIGHTING = 1,
/// <summary>
/// <para>
/// Do not fill the background with white before
/// rendering the snapshot. Since 2.8
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_OPTIONS_TRANSPARENT_BACKGROUND = 2
}
