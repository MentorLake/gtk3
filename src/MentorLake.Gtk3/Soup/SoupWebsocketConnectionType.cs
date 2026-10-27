namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The type of a [class@WebsocketConnection].
/// </para>
/// </summary>

[Flags]
public enum SoupWebsocketConnectionType
{
/// <summary>
/// <para>
/// unknown/invalid connection
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CONNECTION_UNKNOWN = 0,
/// <summary>
/// <para>
/// a client-side connection
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CONNECTION_CLIENT = 1,
/// <summary>
/// <para>
/// a server-side connection
/// </para>
/// </summary>

	SOUP_WEBSOCKET_CONNECTION_SERVER = 2
}
