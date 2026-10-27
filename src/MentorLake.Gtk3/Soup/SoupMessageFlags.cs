namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Various flags that can be set on a [class@Message] to alter its behavior.
/// </para>
/// </summary>

[Flags]
public enum SoupMessageFlags : uint
{
/// <summary>
/// <para>
/// The session should not follow redirect
///   (3xx) responses received by this message.
/// </para>
/// </summary>

	SOUP_MESSAGE_NO_REDIRECT = 2,
/// <summary>
/// <para>
/// Requests that the message should be
///   sent on a newly-created connection, not reusing an existing
///   persistent connection. Note that messages with non-idempotent
///   [property@Message:method]s behave this way by default, unless
///   #SOUP_MESSAGE_IDEMPOTENT is set.
/// </para>
/// </summary>

	SOUP_MESSAGE_NEW_CONNECTION = 4,
/// <summary>
/// <para>
/// The message is considered idempotent,
///   regardless its [property@Message:method], and allows reuse of existing
///   idle connections, instead of always requiring a new one, unless
///   #SOUP_MESSAGE_NEW_CONNECTION is set.
/// </para>
/// </summary>

	SOUP_MESSAGE_IDEMPOTENT = 8,
/// <summary>
/// <para>
/// The [class@AuthManager] should not use
///   the credentials cache for this message, neither to use cached credentials
///   to automatically authenticate this message nor to cache the credentials
///   after the message is successfully authenticated. This applies to both server
///   and proxy authentication. Note that [signal@Message::authenticate] signal will
///   be emitted, if you want to disable authentication for a message use
///   [method@Message.disable_feature] passing #SOUP_TYPE_AUTH_MANAGER instead.
/// </para>
/// </summary>

	SOUP_MESSAGE_DO_NOT_USE_AUTH_CACHE = 16,
/// <summary>
/// <para>
/// Metrics will be collected for this message.
/// </para>
/// </summary>

	SOUP_MESSAGE_COLLECT_METRICS = 32
}
