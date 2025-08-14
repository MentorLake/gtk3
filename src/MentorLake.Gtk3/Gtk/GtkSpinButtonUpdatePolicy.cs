namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The spin button update policy determines whether the spin button displays
/// values even if they are outside the bounds of its adjustment.
/// See gtk_spin_button_set_update_policy().
/// </para>
/// </summary>

[Flags]
public enum GtkSpinButtonUpdatePolicy
{
/// <summary>
/// <para>
/// When refreshing your #GtkSpinButton, the value is
///     always displayed
/// </para>
/// </summary>

	GTK_UPDATE_ALWAYS = 0,
/// <summary>
/// <para>
/// When refreshing your #GtkSpinButton, the value is
///     only displayed if it is valid within the bounds of the spin button's
///     adjustment
/// </para>
/// </summary>

	GTK_UPDATE_IF_VALID = 1
}
