namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Defines how device grabs interact with other devices.
/// </para>
/// </summary>

[Flags]
public enum GdkGrabOwnership
{
/// <summary>
/// <para>
/// All other devices’ events are allowed.
/// </para>
/// </summary>

	GDK_OWNERSHIP_NONE = 0,
/// <summary>
/// <para>
/// Other devices’ events are blocked for the grab window.
/// </para>
/// </summary>

	GDK_OWNERSHIP_WINDOW = 1,
/// <summary>
/// <para>
/// Other devices’ events are blocked for the whole application.
/// </para>
/// </summary>

	GDK_OWNERSHIP_APPLICATION = 2
}
