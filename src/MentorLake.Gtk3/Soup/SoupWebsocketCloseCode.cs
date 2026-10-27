namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Pre-defined close codes that can be passed to
/// [method@WebsocketConnection.close] or received from
/// [method@WebsocketConnection.get_close_code].
/// </para>
/// <para>
/// However, other codes are also allowed.
/// </para>
/// </summary>

[Flags]
public enum SoupWebsocketCloseCode
{
/// <summary>
/// <para>
/// a normal, non-error close
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_NORMAL = 1000,
/// <summary>
/// <para>
/// the client/server is going away
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_GOING_AWAY = 1001,
/// <summary>
/// <para>
/// a protocol error occurred
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_PROTOCOL_ERROR = 1002,
/// <summary>
/// <para>
/// the endpoint received data
///   of a type that it does not support.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_UNSUPPORTED_DATA = 1003,
/// <summary>
/// <para>
/// reserved value indicating that
///   no close code was present; must not be sent.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_NO_STATUS = 1005,
/// <summary>
/// <para>
/// reserved value indicating that
///   the connection was closed abnormally; must not be sent.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_ABNORMAL = 1006,
/// <summary>
/// <para>
/// the endpoint received data that
///   was invalid (eg, non-UTF-8 data in a text message).
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_BAD_DATA = 1007,
/// <summary>
/// <para>
/// generic error code
///   indicating some sort of policy violation.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_POLICY_VIOLATION = 1008,
/// <summary>
/// <para>
/// the endpoint received a message
///   that is too big to process.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_TOO_BIG = 1009,
/// <summary>
/// <para>
/// the client is closing the
///   connection because the server failed to negotiate a required
///   extension.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_NO_EXTENSION = 1010,
/// <summary>
/// <para>
/// the server is closing the
///   connection because it was unable to fulfill the request.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_SERVER_ERROR = 1011,
/// <summary>
/// <para>
/// reserved value indicating that
///   the TLS handshake failed; must not be sent.
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CLOSE_TLS_HANDSHAKE = 1015
}
