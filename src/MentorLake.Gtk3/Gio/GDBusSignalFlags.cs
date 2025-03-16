namespace MentorLake.Gio;

[Flags]
public enum GDBusSignalFlags : long
{
	G_DBUS_SIGNAL_FLAGS_NONE = 0,
	G_DBUS_SIGNAL_FLAGS_NO_MATCH_RULE = 1,
	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_NAMESPACE = 2,
	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_PATH = 4
}
