namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Determines the direction of a sort.
/// </para>
/// </summary>

[Flags]
public enum GtkSortType
{
/// <summary>
/// <para>
/// Sorting is in ascending order.
/// </para>
/// </summary>

	GTK_SORT_ASCENDING = 0,
/// <summary>
/// <para>
/// Sorting is in descending order.
/// </para>
/// </summary>

	GTK_SORT_DESCENDING = 1
}
