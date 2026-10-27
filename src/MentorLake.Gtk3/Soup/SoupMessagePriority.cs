namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Priorities that can be set on a [class@Message] to instruct the message queue
/// to process it before any other message with lower priority.
/// </para>
/// </summary>

[Flags]
public enum SoupMessagePriority
{
/// <summary>
/// <para>
/// The lowest priority, the messages
///   with this priority will be the last ones to be attended.
/// </para>
/// </summary>

	SOUP_MESSAGE_PRIORITY_VERY_LOW = 0,
/// <summary>
/// <para>
/// Use this for low priority messages, a
///   [class@Message] with the default priority will be processed first.
/// </para>
/// </summary>

	SOUP_MESSAGE_PRIORITY_LOW = 1,
/// <summary>
/// <para>
/// The default priotity, this is the
///   priority assigned to the [class@Message] by default.
/// </para>
/// </summary>

	SOUP_MESSAGE_PRIORITY_NORMAL = 2,
/// <summary>
/// <para>
/// High priority, a [class@Message] with
///   this priority will be processed before the ones with the default
///   priority.
/// </para>
/// </summary>

	SOUP_MESSAGE_PRIORITY_HIGH = 3,
/// <summary>
/// <para>
/// The highest priority, use this
///   for very urgent [class@Message] as they will be the first ones to be
///   attended.
/// </para>
/// </summary>

	SOUP_MESSAGE_PRIORITY_VERY_HIGH = 4
}
