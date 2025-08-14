namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes how a rendered element connects to adjacent elements.
/// </para>
/// </summary>

[Flags]
public enum GtkJunctionSides : uint
{
/// <summary>
/// <para>
/// No junctions.
/// </para>
/// </summary>

	GTK_JUNCTION_NONE = 0,
/// <summary>
/// <para>
/// Element connects on the top-left corner.
/// </para>
/// </summary>

	GTK_JUNCTION_CORNER_TOPLEFT = 1,
/// <summary>
/// <para>
/// Element connects on the top-right corner.
/// </para>
/// </summary>

	GTK_JUNCTION_CORNER_TOPRIGHT = 2,
/// <summary>
/// <para>
/// Element connects on the bottom-left corner.
/// </para>
/// </summary>

	GTK_JUNCTION_CORNER_BOTTOMLEFT = 4,
/// <summary>
/// <para>
/// Element connects on the bottom-right corner.
/// </para>
/// </summary>

	GTK_JUNCTION_CORNER_BOTTOMRIGHT = 8,
/// <summary>
/// <para>
/// Element connects on the top side.
/// </para>
/// </summary>

	GTK_JUNCTION_TOP = 3,
/// <summary>
/// <para>
/// Element connects on the bottom side.
/// </para>
/// </summary>

	GTK_JUNCTION_BOTTOM = 12,
/// <summary>
/// <para>
/// Element connects on the left side.
/// </para>
/// </summary>

	GTK_JUNCTION_LEFT = 5,
/// <summary>
/// <para>
/// Element connects on the right side.
/// </para>
/// </summary>

	GTK_JUNCTION_RIGHT = 10
}
