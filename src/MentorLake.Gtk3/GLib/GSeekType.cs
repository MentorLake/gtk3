namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An enumeration specifying the base position for a
/// g_io_channel_seek_position() operation.
/// </para>
/// </summary>

[Flags]
public enum GSeekType
{
/// <summary>
/// <para>
/// the current position in the file.
/// </para>
/// </summary>

	G_SEEK_CUR = 0,
/// <summary>
/// <para>
/// the start of the file.
/// </para>
/// </summary>

	G_SEEK_SET = 1,
/// <summary>
/// <para>
/// the end of the file.
/// </para>
/// </summary>

	G_SEEK_END = 2
}
