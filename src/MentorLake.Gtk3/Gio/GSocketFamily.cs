namespace MentorLake.Gio;

[Flags]
public enum GSocketFamily
{
	G_SOCKET_FAMILY_INVALID = 0,
	G_SOCKET_FAMILY_UNIX = 1,
	G_SOCKET_FAMILY_IPV4 = 2,
	G_SOCKET_FAMILY_IPV6 = 10
}
