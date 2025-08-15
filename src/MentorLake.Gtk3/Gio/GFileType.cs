namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Indicates the file&apos;s on-disk type.
/// </para>
/// <para>
/// On Windows systems a file will never have %G_FILE_TYPE_SYMBOLIC_LINK type;
/// use #GFileInfo and %G_FILE_ATTRIBUTE_STANDARD_IS_SYMLINK to determine
/// whether a file is a symlink or not. This is due to the fact that NTFS does
/// not have a single filesystem object type for symbolic links - it has
/// files that symlink to files, and directories that symlink to directories.
/// #GFileType enumeration cannot precisely represent this important distinction,
/// which is why all Windows symlinks will continue to be reported as
/// %G_FILE_TYPE_REGULAR or %G_FILE_TYPE_DIRECTORY.
/// </para>
/// </summary>

[Flags]
public enum GFileType
{
/// <summary>
/// <para>
/// File&apos;s type is unknown.
/// </para>
/// </summary>

	G_FILE_TYPE_UNKNOWN = 0,
/// <summary>
/// <para>
/// File handle represents a regular file.
/// </para>
/// </summary>

	G_FILE_TYPE_REGULAR = 1,
/// <summary>
/// <para>
/// File handle represents a directory.
/// </para>
/// </summary>

	G_FILE_TYPE_DIRECTORY = 2,
/// <summary>
/// <para>
/// File handle represents a symbolic link
///    (Unix systems).
/// </para>
/// </summary>

	G_FILE_TYPE_SYMBOLIC_LINK = 3,
/// <summary>
/// <para>
/// File is a &quot;special&quot; file, such as a socket, fifo,
///    block device, or character device.
/// </para>
/// </summary>

	G_FILE_TYPE_SPECIAL = 4,
/// <summary>
/// <para>
/// File is a shortcut (Windows systems).
/// </para>
/// </summary>

	G_FILE_TYPE_SHORTCUT = 5,
/// <summary>
/// <para>
/// File is a mountable location.
/// </para>
/// </summary>

	G_FILE_TYPE_MOUNTABLE = 6
}
