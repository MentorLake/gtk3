namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags that can be used with g_file_measure_disk_usage().
/// </para>
/// </summary>

[Flags]
public enum GFileMeasureFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_FILE_MEASURE_NONE = 0,
/// <summary>
/// <para>
/// Report any error encountered
///   while traversing the directory tree.  Normally errors are only
///   reported for the toplevel file.
/// </para>
/// </summary>

	G_FILE_MEASURE_REPORT_ANY_ERROR = 2,
/// <summary>
/// <para>
/// Tally usage based on apparent file
///   sizes.  Normally, the block-size is used, if available, as this is a
///   more accurate representation of disk space used.
///   Compare with `du --apparent-size`.
///   Since GLib 2.78. and similarly to `du` since GNU Coreutils 9.2, this will
///   ignore the sizes of file types other than regular files and links, as the
///   sizes of other file types are not specified in a standard way.
/// </para>
/// </summary>

	G_FILE_MEASURE_APPARENT_SIZE = 4,
/// <summary>
/// <para>
/// Do not cross mount point boundaries.
///   Compare with `du -x`.
/// </para>
/// </summary>

	G_FILE_MEASURE_NO_XDEV = 8
}
