namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Determines a window edge or corner.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowEdge
{
/// <summary>
/// <para>
/// the top left corner.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_NORTH_WEST = 0,
/// <summary>
/// <para>
/// the top edge.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_NORTH = 1,
/// <summary>
/// <para>
/// the top right corner.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_NORTH_EAST = 2,
/// <summary>
/// <para>
/// the left edge.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_WEST = 3,
/// <summary>
/// <para>
/// the right edge.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_EAST = 4,
/// <summary>
/// <para>
/// the lower left corner.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_SOUTH_WEST = 5,
/// <summary>
/// <para>
/// the lower edge.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_SOUTH = 6,
/// <summary>
/// <para>
/// the lower right corner.
/// </para>
/// </summary>

	GDK_WINDOW_EDGE_SOUTH_EAST = 7
}
