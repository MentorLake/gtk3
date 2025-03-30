namespace MentorLake.GLib;

[Flags]
public enum GUriHideFlags : uint
{
	G_URI_HIDE_NONE = 0,
	G_URI_HIDE_USERINFO = 1,
	G_URI_HIDE_PASSWORD = 2,
	G_URI_HIDE_AUTH_PARAMS = 4,
	G_URI_HIDE_QUERY = 8,
	G_URI_HIDE_FRAGMENT = 16
}
