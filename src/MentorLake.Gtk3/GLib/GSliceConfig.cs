namespace MentorLake.GLib;

[Flags]
public enum GSliceConfig
{
	G_SLICE_CONFIG_ALWAYS_MALLOC = 1,
	G_SLICE_CONFIG_BYPASS_MAGAZINES = 2,
	G_SLICE_CONFIG_WORKING_SET_MSECS = 3,
	G_SLICE_CONFIG_COLOR_INCREMENT = 4,
	G_SLICE_CONFIG_CHUNK_SIZES = 5,
	G_SLICE_CONFIG_CONTENTION_COUNTER = 6
}
