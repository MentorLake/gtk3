namespace MentorLake.Gio;

[Flags]
public enum GSocketProtocol
{
	G_SOCKET_PROTOCOL_UNKNOWN = -1,
	G_SOCKET_PROTOCOL_DEFAULT = 0,
	G_SOCKET_PROTOCOL_TCP = 6,
	G_SOCKET_PROTOCOL_UDP = 17,
	G_SOCKET_PROTOCOL_SCTP = 132
}
