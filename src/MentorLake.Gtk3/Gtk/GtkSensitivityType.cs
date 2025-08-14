namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Determines how GTK+ handles the sensitivity of stepper arrows
/// at the end of range widgets.
/// </para>
/// </summary>

[Flags]
public enum GtkSensitivityType
{
/// <summary>
/// <para>
/// The arrow is made insensitive if the
///   thumb is at the end
/// </para>
/// </summary>

	GTK_SENSITIVITY_AUTO = 0,
/// <summary>
/// <para>
/// The arrow is always sensitive
/// </para>
/// </summary>

	GTK_SENSITIVITY_ON = 1,
/// <summary>
/// <para>
/// The arrow is always insensitive
/// </para>
/// </summary>

	GTK_SENSITIVITY_OFF = 2
}
