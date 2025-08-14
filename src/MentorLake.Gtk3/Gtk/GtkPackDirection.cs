namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Determines how widgets should be packed inside menubars
/// and menuitems contained in menubars.
/// </para>
/// </summary>

[Flags]
public enum GtkPackDirection
{
/// <summary>
/// <para>
/// Widgets are packed left-to-right
/// </para>
/// </summary>

	GTK_PACK_DIRECTION_LTR = 0,
/// <summary>
/// <para>
/// Widgets are packed right-to-left
/// </para>
/// </summary>

	GTK_PACK_DIRECTION_RTL = 1,
/// <summary>
/// <para>
/// Widgets are packed top-to-bottom
/// </para>
/// </summary>

	GTK_PACK_DIRECTION_TTB = 2,
/// <summary>
/// <para>
/// Widgets are packed bottom-to-top
/// </para>
/// </summary>

	GTK_PACK_DIRECTION_BTT = 3
}
