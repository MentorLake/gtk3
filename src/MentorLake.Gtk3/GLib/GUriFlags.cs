namespace MentorLake.GLib;

[Flags]
public enum GUriFlags : long
{
	G_URI_FLAGS_NONE = 0,
	G_URI_FLAGS_PARSE_RELAXED = 1,
	G_URI_FLAGS_HAS_PASSWORD = 2,
	G_URI_FLAGS_HAS_AUTH_PARAMS = 4,
	G_URI_FLAGS_ENCODED = 8,
	G_URI_FLAGS_NON_DNS = 16,
	G_URI_FLAGS_ENCODED_QUERY = 32,
	G_URI_FLAGS_ENCODED_PATH = 64,
	G_URI_FLAGS_ENCODED_FRAGMENT = 128,
	G_URI_FLAGS_SCHEME_NORMALIZE = 256
}
