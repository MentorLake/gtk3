namespace MentorLake.Gio;

[Flags]
public enum GSocketType
{
	G_SOCKET_TYPE_INVALID = 0,
	G_SOCKET_TYPE_STREAM = 1,
	G_SOCKET_TYPE_DATAGRAM = 2,
	G_SOCKET_TYPE_SEQPACKET = 3
}
