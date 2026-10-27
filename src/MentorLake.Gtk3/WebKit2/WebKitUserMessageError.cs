namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote errors happening when sending user messages.
/// </para>
/// </summary>

[Flags]
public enum WebKitUserMessageError
{
/// <summary>
/// <para>
/// The message was not handled by the receiver.
/// </para>
/// </summary>

	WEBKIT_USER_MESSAGE_UNHANDLED_MESSAGE = 0
}
