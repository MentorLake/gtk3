namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The role specifies the desired appearance of a #GtkModelButton.
/// </para>
/// </summary>

[Flags]
public enum GtkButtonRole
{
/// <summary>
/// <para>
/// A plain button
/// </para>
/// </summary>

	GTK_BUTTON_ROLE_NORMAL = 0,
/// <summary>
/// <para>
/// A check button
/// </para>
/// </summary>

	GTK_BUTTON_ROLE_CHECK = 1,
/// <summary>
/// <para>
/// A radio button
/// </para>
/// </summary>

	GTK_BUTTON_ROLE_RADIO = 2
}
