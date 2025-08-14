namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Describes an event occurring on a #GSocketListener. See the
/// #GSocketListener::event signal for more details.
/// </para>
/// <para>
/// Additional values may be added to this type in the future.
/// </para>
/// </summary>

[Flags]
public enum GSocketListenerEvent
{
/// <summary>
/// <para>
/// The listener is about to bind a socket.
/// </para>
/// </summary>

	G_SOCKET_LISTENER_BINDING = 0,
/// <summary>
/// <para>
/// The listener has bound a socket.
/// </para>
/// </summary>

	G_SOCKET_LISTENER_BOUND = 1,
/// <summary>
/// <para>
/// The listener is about to start
///    listening on this socket.
/// </para>
/// </summary>

	G_SOCKET_LISTENER_LISTENING = 2,
/// <summary>
/// <para>
/// The listener is now listening on
///   this socket.
/// </para>
/// </summary>

	G_SOCKET_LISTENER_LISTENED = 3
}
