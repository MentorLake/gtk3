namespace MentorLake.Gio;

[Flags]
public enum GDBusPropertyInfoFlags : uint
{
	G_DBUS_PROPERTY_INFO_FLAGS_NONE = 0,
	G_DBUS_PROPERTY_INFO_FLAGS_READABLE = 1,
	G_DBUS_PROPERTY_INFO_FLAGS_WRITABLE = 2
}
