namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Specifies the type of a keyboard evemt.
/// </para>
/// </summary>

[Flags]
public enum AtkKeyEventType
{
/// <summary>
/// <para>
/// specifies a key press event
/// </para>
/// </summary>

	ATK_KEY_EVENT_PRESS = 0,
/// <summary>
/// <para>
/// specifies a key release event
/// </para>
/// </summary>

	ATK_KEY_EVENT_RELEASE = 1,
/// <summary>
/// <para>
/// Not a valid value; specifies end of enumeration
/// </para>
/// </summary>

	ATK_KEY_EVENT_LAST_DEFINED = 2
}
