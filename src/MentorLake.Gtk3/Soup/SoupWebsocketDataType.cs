namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The type of data contained in a [signal@WebsocketConnection::message] signal.
/// </para>
/// </summary>

[Flags]
public enum SoupWebsocketDataType
{
/// <summary>
/// <para>
/// UTF-8 text
/// </para>
/// </summary>

	SOUP_WEBSOCKET_DATA_TEXT = 1,
/// <summary>
/// <para>
/// binary data
/// </para>
/// </summary>

	SOUP_WEBSOCKET_DATA_BINARY = 2
}
