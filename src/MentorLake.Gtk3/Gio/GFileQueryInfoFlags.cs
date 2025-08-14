namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when querying a #GFileInfo.
/// </para>
/// </summary>

[Flags]
public enum GFileQueryInfoFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_FILE_QUERY_INFO_NONE = 0,
/// <summary>
/// <para>
/// Don't follow symlinks.
/// </para>
/// </summary>

	G_FILE_QUERY_INFO_NOFOLLOW_SYMLINKS = 1
}
