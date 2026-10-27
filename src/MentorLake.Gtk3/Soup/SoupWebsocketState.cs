namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The state of the WebSocket connection.
/// </para>
/// </summary>

[Flags]
public enum SoupWebsocketState
{
/// <summary>
/// <para>
/// the connection is ready to send messages
/// </para>
/// </summary>

	SOUP_WEBSOCKET_STATE_OPEN = 1,
/// <summary>
/// <para>
/// the connection is in the process of
///   closing down; messages may be received, but not sent
/// </para>
/// </summary>

	SOUP_WEBSOCKET_STATE_CLOSING = 2,
/// <summary>
/// <para>
/// the connection is completely closed down
/// </para>
/// </summary>

	SOUP_WEBSOCKET_STATE_CLOSED = 3
}
