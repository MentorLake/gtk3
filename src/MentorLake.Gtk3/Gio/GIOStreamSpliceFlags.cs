namespace MentorLake.Gio;

[Flags]
public enum GIOStreamSpliceFlags : uint
{
	G_IO_STREAM_SPLICE_NONE = 0,
	G_IO_STREAM_SPLICE_CLOSE_STREAM1 = 1,
	G_IO_STREAM_SPLICE_CLOSE_STREAM2 = 2,
	G_IO_STREAM_SPLICE_WAIT_FOR_BOTH = 4
}
