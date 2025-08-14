namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to specify the placement of scroll arrows in scrolling menus.
/// </para>
/// </summary>

[Flags]
public enum GtkArrowPlacement
{
/// <summary>
/// <para>
/// Place one arrow on each end of the menu.
/// </para>
/// </summary>

	GTK_ARROWS_BOTH = 0,
/// <summary>
/// <para>
/// Place both arrows at the top of the menu.
/// </para>
/// </summary>

	GTK_ARROWS_START = 1,
/// <summary>
/// <para>
/// Place both arrows at the bottom of the menu.
/// </para>
/// </summary>

	GTK_ARROWS_END = 2
}
