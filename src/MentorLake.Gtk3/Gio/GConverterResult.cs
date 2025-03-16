namespace MentorLake.Gio;

[Flags]
public enum GConverterResult
{
	G_CONVERTER_ERROR = 0,
	G_CONVERTER_CONVERTED = 1,
	G_CONVERTER_FINISHED = 2,
	G_CONVERTER_FLUSHED = 3
}
