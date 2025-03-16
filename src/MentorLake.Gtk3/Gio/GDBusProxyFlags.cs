namespace MentorLake.Gio;

[Flags]
public enum GDBusProxyFlags : long
{
	G_DBUS_PROXY_FLAGS_NONE = 0,
	G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES = 1,
	G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS = 2,
	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START = 4,
	G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES = 8,
	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION = 16,
	G_DBUS_PROXY_FLAGS_NO_MATCH_RULE = 32
}
