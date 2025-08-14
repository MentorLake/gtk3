namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes a region within a widget.
/// </para>
/// </summary>

[Flags]
public enum GtkRegionFlags : uint
{
/// <summary>
/// <para>
/// Region has an even number within a set.
/// </para>
/// </summary>

	GTK_REGION_EVEN = 1,
/// <summary>
/// <para>
/// Region has an odd number within a set.
/// </para>
/// </summary>

	GTK_REGION_ODD = 2,
/// <summary>
/// <para>
/// Region is the first one within a set.
/// </para>
/// </summary>

	GTK_REGION_FIRST = 4,
/// <summary>
/// <para>
/// Region is the last one within a set.
/// </para>
/// </summary>

	GTK_REGION_LAST = 8,
/// <summary>
/// <para>
/// Region is the only one within a set.
/// </para>
/// </summary>

	GTK_REGION_ONLY = 16,
/// <summary>
/// <para>
/// Region is part of a sorted area.
/// </para>
/// </summary>

	GTK_REGION_SORTED = 32
}
