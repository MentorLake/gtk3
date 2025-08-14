namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Indicates a hint from the file system whether files should be
/// previewed in a file manager. Returned as the value of the key
/// %G_FILE_ATTRIBUTE_FILESYSTEM_USE_PREVIEW.
/// </para>
/// </summary>

[Flags]
public enum GFilesystemPreviewType
{
/// <summary>
/// <para>
/// Only preview files if user has explicitly requested it.
/// </para>
/// </summary>

	G_FILESYSTEM_PREVIEW_TYPE_IF_ALWAYS = 0,
/// <summary>
/// <para>
/// Preview files if user has requested preview of "local" files.
/// </para>
/// </summary>

	G_FILESYSTEM_PREVIEW_TYPE_IF_LOCAL = 1,
/// <summary>
/// <para>
/// Never preview files.
/// </para>
/// </summary>

	G_FILESYSTEM_PREVIEW_TYPE_NEVER = 2
}
