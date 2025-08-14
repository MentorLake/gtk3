namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Describes an event occurring on a #GSocketClient. See the
/// #GSocketClient::event signal for more details.
/// </para>
/// <para>
/// Additional values may be added to this type in the future.
/// </para>
/// </summary>

[Flags]
public enum GSocketClientEvent
{
/// <summary>
/// <para>
/// The client is doing a DNS lookup.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_RESOLVING = 0,
/// <summary>
/// <para>
/// The client has completed a DNS lookup.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_RESOLVED = 1,
/// <summary>
/// <para>
/// The client is connecting to a remote
///   host (either a proxy or the destination server).
/// </para>
/// </summary>

	G_SOCKET_CLIENT_CONNECTING = 2,
/// <summary>
/// <para>
/// The client has connected to a remote
///   host.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_CONNECTED = 3,
/// <summary>
/// <para>
/// The client is negotiating
///   with a proxy to connect to the destination server.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_PROXY_NEGOTIATING = 4,
/// <summary>
/// <para>
/// The client has negotiated
///   with the proxy server.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_PROXY_NEGOTIATED = 5,
/// <summary>
/// <para>
/// The client is performing a
///   TLS handshake.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_TLS_HANDSHAKING = 6,
/// <summary>
/// <para>
/// The client has performed a
///   TLS handshake.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_TLS_HANDSHAKED = 7,
/// <summary>
/// <para>
/// The client is done with a particular
///   #GSocketConnectable.
/// </para>
/// </summary>

	G_SOCKET_CLIENT_COMPLETE = 8
}
