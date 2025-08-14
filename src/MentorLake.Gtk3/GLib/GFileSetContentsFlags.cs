namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags to pass to g_file_set_contents_full() to affect its safety and
/// performance.
/// </para>
/// </summary>

[Flags]
public enum GFileSetContentsFlags : uint
{
/// <summary>
/// <para>
/// No guarantees about file consistency or durability.
///   The most dangerous setting, which is slightly faster than other settings.
/// </para>
/// </summary>

	G_FILE_SET_CONTENTS_NONE = 0,
/// <summary>
/// <para>
/// Guarantee file consistency: after a crash,
///   either the old version of the file or the new version of the file will be
///   available, but not a mixture. On Unix systems this equates to an `fsync()`
///   on the file and use of an atomic `rename()` of the new version of the file
///   over the old.
/// </para>
/// </summary>

	G_FILE_SET_CONTENTS_CONSISTENT = 1,
/// <summary>
/// <para>
/// Guarantee file durability: after a crash, the
///   new version of the file will be available. On Unix systems this equates to
///   an `fsync()` on the file (if %G_FILE_SET_CONTENTS_CONSISTENT is unset), or
///   the effects of %G_FILE_SET_CONTENTS_CONSISTENT plus an `fsync()` on the
///   directory containing the file after calling `rename()`.
/// </para>
/// </summary>

	G_FILE_SET_CONTENTS_DURABLE = 2,
/// <summary>
/// <para>
/// Only apply consistency and durability
///   guarantees if the file already exists. This may speed up file operations
///   if the file doesn’t currently exist, but may result in a corrupted version
///   of the new file if the system crashes while writing it.
/// </para>
/// </summary>

	G_FILE_SET_CONTENTS_ONLY_EXISTING = 4
}
