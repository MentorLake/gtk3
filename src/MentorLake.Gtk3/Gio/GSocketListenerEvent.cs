namespace MentorLake.Gio;

[Flags]
public enum GSocketListenerEvent
{
	G_SOCKET_LISTENER_BINDING = 0,
	G_SOCKET_LISTENER_BOUND = 1,
	G_SOCKET_LISTENER_LISTENING = 2,
	G_SOCKET_LISTENER_LISTENED = 3
}
