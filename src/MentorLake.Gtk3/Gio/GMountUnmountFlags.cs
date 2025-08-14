namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when an unmounting a mount.
/// </para>
/// </summary>

[Flags]
public enum GMountUnmountFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_MOUNT_UNMOUNT_NONE = 0,
/// <summary>
/// <para>
/// Unmount even if there are outstanding
///  file operations on the mount.
/// </para>
/// </summary>

	G_MOUNT_UNMOUNT_FORCE = 1
}
