namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote errors happening when creating snapshots of #WebKitWebView
/// </para>
/// </summary>

[Flags]
public enum WebKitSnapshotError
{
/// <summary>
/// <para>
/// An error occurred when creating a webpage snapshot.
/// </para>
/// </summary>

	WEBKIT_SNAPSHOT_ERROR_FAILED_TO_CREATE = 799
}
