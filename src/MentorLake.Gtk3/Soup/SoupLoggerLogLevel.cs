namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Describes the level of logging output to provide.
/// </para>
/// </summary>

[Flags]
public enum SoupLoggerLogLevel
{
/// <summary>
/// <para>
/// No logging
/// </para>
/// </summary>

	SOUP_LOGGER_LOG_NONE = 0,
/// <summary>
/// <para>
/// Log the Request-Line or Status-Line and
///   the Soup-Debug pseudo-headers
/// </para>
/// </summary>

	SOUP_LOGGER_LOG_MINIMAL = 1,
/// <summary>
/// <para>
/// Log the full request/response headers
/// </para>
/// </summary>

	SOUP_LOGGER_LOG_HEADERS = 2,
/// <summary>
/// <para>
/// Log the full headers and request/response bodies
/// </para>
/// </summary>

	SOUP_LOGGER_LOG_BODY = 3
}
