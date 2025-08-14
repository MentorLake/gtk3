namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Accelerator flags used with gtk_accel_group_connect().
/// </para>
/// </summary>

[Flags]
public enum GtkAccelFlags : uint
{
/// <summary>
/// <para>
/// Accelerator is visible
/// </para>
/// </summary>

	GTK_ACCEL_VISIBLE = 1,
/// <summary>
/// <para>
/// Accelerator not removable
/// </para>
/// </summary>

	GTK_ACCEL_LOCKED = 2,
/// <summary>
/// <para>
/// Mask
/// </para>
/// </summary>

	GTK_ACCEL_MASK = 7
}
