namespace MentorLake.Soup;

/// <summary>
/// <para>
/// WebSocket-related errors.
/// </para>
/// </summary>

[Flags]
public enum SoupWebsocketError
{
/// <summary>
/// <para>
/// a generic error
/// </para>
/// </summary>

	SOUP_WEBSOCKET_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// attempted to handshake with a
///   server that does not appear to understand WebSockets.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_ERROR_NOT_WEBSOCKET = 1,
/// <summary>
/// <para>
/// the WebSocket handshake failed
///   because some detail was invalid (eg, incorrect accept key).
/// </para>
/// </summary>

	SOUP_WEBSOCKET_ERROR_BAD_HANDSHAKE = 2,
/// <summary>
/// <para>
/// the WebSocket handshake failed
///   because the &quot;Origin&quot; header was not an allowed value.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_ERROR_BAD_ORIGIN = 3
}
