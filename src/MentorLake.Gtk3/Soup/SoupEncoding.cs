namespace MentorLake.Soup;

/// <summary>
/// <para>
/// How a message body is encoded for transport
/// </para>
/// </summary>

[Flags]
public enum SoupEncoding
{
/// <summary>
/// <para>
/// unknown / error
/// </para>
/// </summary>

	SOUP_ENCODING_UNRECOGNIZED = 0,
/// <summary>
/// <para>
/// no body is present (which is not the same as a
///   0-length body, and only occurs in certain places)
/// </para>
/// </summary>

	SOUP_ENCODING_NONE = 1,
/// <summary>
/// <para>
/// Content-Length encoding
/// </para>
/// </summary>

	SOUP_ENCODING_CONTENT_LENGTH = 2,
/// <summary>
/// <para>
/// Response body ends when the connection is closed
/// </para>
/// </summary>

	SOUP_ENCODING_EOF = 3,
/// <summary>
/// <para>
/// chunked encoding (currently only supported
///   for response)
/// </para>
/// </summary>

	SOUP_ENCODING_CHUNKED = 4,
/// <summary>
/// <para>
/// multipart/byteranges (Reserved for future
///   use: NOT CURRENTLY IMPLEMENTED)
/// </para>
/// </summary>

	SOUP_ENCODING_BYTERANGES = 5
}
