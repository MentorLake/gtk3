namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Value passed to [ctor@MessageHeaders.new] to set certain default
/// behaviors.
/// </para>
/// </summary>

[Flags]
public enum SoupMessageHeadersType
{
/// <summary>
/// <para>
/// request headers
/// </para>
/// </summary>

	SOUP_MESSAGE_HEADERS_REQUEST = 0,
/// <summary>
/// <para>
/// response headers
/// </para>
/// </summary>

	SOUP_MESSAGE_HEADERS_RESPONSE = 1,
/// <summary>
/// <para>
/// multipart body part headers
/// </para>
/// </summary>

	SOUP_MESSAGE_HEADERS_MULTIPART = 2
}
