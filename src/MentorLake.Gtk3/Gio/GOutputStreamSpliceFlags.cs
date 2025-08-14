namespace MentorLake.Gio;

/// <summary>
/// <para>
/// GOutputStreamSpliceFlags determine how streams should be spliced.
/// </para>
/// </summary>

[Flags]
public enum GOutputStreamSpliceFlags : uint
{
/// <summary>
/// <para>
/// Do not close either stream.
/// </para>
/// </summary>

	G_OUTPUT_STREAM_SPLICE_NONE = 0,
/// <summary>
/// <para>
/// Close the source stream after
///     the splice.
/// </para>
/// </summary>

	G_OUTPUT_STREAM_SPLICE_CLOSE_SOURCE = 1,
/// <summary>
/// <para>
/// Close the target stream after
///     the splice.
/// </para>
/// </summary>

	G_OUTPUT_STREAM_SPLICE_CLOSE_TARGET = 2
}
