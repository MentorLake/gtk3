namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Enumeration describing how a drive can be started/stopped.
/// </para>
/// </summary>

[Flags]
public enum GDriveStartStopType
{
/// <summary>
/// <para>
/// Unknown or drive doesn&apos;t support
///    start/stop.
/// </para>
/// </summary>

	G_DRIVE_START_STOP_TYPE_UNKNOWN = 0,
/// <summary>
/// <para>
/// The stop method will physically
///    shut down the drive and e.g. power down the port the drive is
///    attached to.
/// </para>
/// </summary>

	G_DRIVE_START_STOP_TYPE_SHUTDOWN = 1,
/// <summary>
/// <para>
/// The start/stop methods are used
///    for connecting/disconnect to the drive over the network.
/// </para>
/// </summary>

	G_DRIVE_START_STOP_TYPE_NETWORK = 2,
/// <summary>
/// <para>
/// The start/stop methods will
///    assemble/disassemble a virtual drive from several physical
///    drives.
/// </para>
/// </summary>

	G_DRIVE_START_STOP_TYPE_MULTIDISK = 3,
/// <summary>
/// <para>
/// The start/stop methods will
///    unlock/lock the disk (for example using the ATA `SECURITY UNLOCK
///    DEVICE` command)
/// </para>
/// </summary>

	G_DRIVE_START_STOP_TYPE_PASSWORD = 4
}
