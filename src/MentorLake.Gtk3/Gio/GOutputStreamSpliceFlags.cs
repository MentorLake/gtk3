namespace MentorLake.Gio;

[Flags]
public enum GOutputStreamSpliceFlags : uint
{
	G_OUTPUT_STREAM_SPLICE_NONE = 0,
	G_OUTPUT_STREAM_SPLICE_CLOSE_SOURCE = 1,
	G_OUTPUT_STREAM_SPLICE_CLOSE_TARGET = 2
}
