namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Indicates the HTTP protocol version being used.
/// </para>
/// </summary>

[Flags]
public enum SoupHTTPVersion
{
/// <summary>
/// <para>
/// HTTP 1.0 (RFC 1945)
/// </para>
/// </summary>

	SOUP_HTTP_1_0 = 0,
/// <summary>
/// <para>
/// HTTP 1.1 (RFC 2616)
/// </para>
/// </summary>

	SOUP_HTTP_1_1 = 1,
/// <summary>
/// <para>
/// HTTP 2.0 (RFC 7540)
/// </para>
/// </summary>

	SOUP_HTTP_2_0 = 2
}
