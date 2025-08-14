namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Whenever a container has some form of natural row it may align
/// children in that row along a common typographical baseline. If
/// the amount of verical space in the row is taller than the total
/// requested height of the baseline-aligned children then it can use a
/// #GtkBaselinePosition to select where to put the baseline inside the
/// extra availible space.
/// </para>
/// </summary>

[Flags]
public enum GtkBaselinePosition
{
/// <summary>
/// <para>
/// Align the baseline at the top
/// </para>
/// </summary>

	GTK_BASELINE_POSITION_TOP = 0,
/// <summary>
/// <para>
/// Center the baseline
/// </para>
/// </summary>

	GTK_BASELINE_POSITION_CENTER = 1,
/// <summary>
/// <para>
/// Align the baseline at the bottom
/// </para>
/// </summary>

	GTK_BASELINE_POSITION_BOTTOM = 2
}
