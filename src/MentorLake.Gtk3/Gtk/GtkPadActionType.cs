namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of a pad action.
/// </para>
/// </summary>

[Flags]
public enum GtkPadActionType
{
/// <summary>
/// <para>
/// Action is triggered by a pad button
/// </para>
/// </summary>

	GTK_PAD_ACTION_BUTTON = 0,
/// <summary>
/// <para>
/// Action is triggered by a pad ring
/// </para>
/// </summary>

	GTK_PAD_ACTION_RING = 1,
/// <summary>
/// <para>
/// Action is triggered by a pad strip
/// </para>
/// </summary>

	GTK_PAD_ACTION_STRIP = 2
}
