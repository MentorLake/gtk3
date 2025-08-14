namespace MentorLake.Gio;

/// <summary>
/// <para>
/// GIOStreamSpliceFlags determine how streams should be spliced.
/// </para>
/// </summary>

[Flags]
public enum GIOStreamSpliceFlags : uint
{
/// <summary>
/// <para>
/// Do not close either stream.
/// </para>
/// </summary>

	G_IO_STREAM_SPLICE_NONE = 0,
/// <summary>
/// <para>
/// Close the first stream after
///     the splice.
/// </para>
/// </summary>

	G_IO_STREAM_SPLICE_CLOSE_STREAM1 = 1,
/// <summary>
/// <para>
/// Close the second stream after
///     the splice.
/// </para>
/// </summary>

	G_IO_STREAM_SPLICE_CLOSE_STREAM2 = 2,
/// <summary>
/// <para>
/// Wait for both splice operations to finish
///     before calling the callback.
/// </para>
/// </summary>

	G_IO_STREAM_SPLICE_WAIT_FOR_BOTH = 4
}
