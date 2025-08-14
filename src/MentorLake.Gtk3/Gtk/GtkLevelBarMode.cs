namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes how #GtkLevelBar contents should be rendered.
/// Note that this enumeration could be extended with additional modes
/// in the future.
/// </para>
/// </summary>

[Flags]
public enum GtkLevelBarMode
{
/// <summary>
/// <para>
/// the bar has a continuous mode
/// </para>
/// </summary>

	GTK_LEVEL_BAR_MODE_CONTINUOUS = 0,
/// <summary>
/// <para>
/// the bar has a discrete mode
/// </para>
/// </summary>

	GTK_LEVEL_BAR_MODE_DISCRETE = 1
}
