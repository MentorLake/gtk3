namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The values of the GtkSpinType enumeration are used to specify the
/// change to make in gtk_spin_button_spin().
/// </para>
/// </summary>

[Flags]
public enum GtkSpinType
{
/// <summary>
/// <para>
/// Increment by the adjustments step increment.
/// </para>
/// </summary>

	GTK_SPIN_STEP_FORWARD = 0,
/// <summary>
/// <para>
/// Decrement by the adjustments step increment.
/// </para>
/// </summary>

	GTK_SPIN_STEP_BACKWARD = 1,
/// <summary>
/// <para>
/// Increment by the adjustments page increment.
/// </para>
/// </summary>

	GTK_SPIN_PAGE_FORWARD = 2,
/// <summary>
/// <para>
/// Decrement by the adjustments page increment.
/// </para>
/// </summary>

	GTK_SPIN_PAGE_BACKWARD = 3,
/// <summary>
/// <para>
/// Go to the adjustments lower bound.
/// </para>
/// </summary>

	GTK_SPIN_HOME = 4,
/// <summary>
/// <para>
/// Go to the adjustments upper bound.
/// </para>
/// </summary>

	GTK_SPIN_END = 5,
/// <summary>
/// <para>
/// Change by a specified amount.
/// </para>
/// </summary>

	GTK_SPIN_USER_DEFINED = 6
}
