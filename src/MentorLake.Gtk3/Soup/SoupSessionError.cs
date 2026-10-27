namespace MentorLake.Soup;

/// <summary>
/// <para>
/// A [class@Session] error.
/// </para>
/// </summary>

[Flags]
public enum SoupSessionError
{
/// <summary>
/// <para>
/// the server&apos;s response could not
///   be parsed
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_PARSING = 0,
/// <summary>
/// <para>
/// the server&apos;s response was in an
///   unsupported format
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_ENCODING = 1,
/// <summary>
/// <para>
/// the message has been redirected
///   too many times
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_TOO_MANY_REDIRECTS = 2,
/// <summary>
/// <para>
/// the message has been restarted
///   too many times
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_TOO_MANY_RESTARTS = 3,
/// <summary>
/// <para>
/// failed to redirect message because
///   Location header was missing or empty in response
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_REDIRECT_NO_LOCATION = 4,
/// <summary>
/// <para>
/// failed to redirect message because
///   Location header contains an invalid URI
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_REDIRECT_BAD_URI = 5,
/// <summary>
/// <para>
/// the message is already in the
///   session queue. Messages can only be reused after unqueued.
/// </para>
/// </summary>

	SOUP_SESSION_ERROR_MESSAGE_ALREADY_IN_QUEUE = 6
}
