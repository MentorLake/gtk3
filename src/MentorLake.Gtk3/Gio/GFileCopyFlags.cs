namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when copying or moving files.
/// </para>
/// </summary>

[Flags]
public enum GFileCopyFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_FILE_COPY_NONE = 0,
/// <summary>
/// <para>
/// Overwrite any existing files
/// </para>
/// </summary>

	G_FILE_COPY_OVERWRITE = 1,
/// <summary>
/// <para>
/// Make a backup of any existing files.
/// </para>
/// </summary>

	G_FILE_COPY_BACKUP = 2,
/// <summary>
/// <para>
/// Don&apos;t follow symlinks.
/// </para>
/// </summary>

	G_FILE_COPY_NOFOLLOW_SYMLINKS = 4,
/// <summary>
/// <para>
/// Copy all file metadata instead of just default set used for copy (see #GFileInfo).
/// </para>
/// </summary>

	G_FILE_COPY_ALL_METADATA = 8,
/// <summary>
/// <para>
/// Don&apos;t use copy and delete fallback if native move not supported.
/// </para>
/// </summary>

	G_FILE_COPY_NO_FALLBACK_FOR_MOVE = 16,
/// <summary>
/// <para>
/// Leaves target file with default perms, instead of setting the source file perms.
/// </para>
/// </summary>

	G_FILE_COPY_TARGET_DEFAULT_PERMS = 32,
/// <summary>
/// <para>
/// Use default modification
///     timestamps instead of copying them from the source file. Since 2.80
/// </para>
/// </summary>

	G_FILE_COPY_TARGET_DEFAULT_MODIFIED_TIME = 64
}
