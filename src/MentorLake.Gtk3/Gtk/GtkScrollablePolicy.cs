namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Defines the policy to be used in a scrollable widget when updating
/// the scrolled window adjustments in a given orientation.
/// </para>
/// </summary>

[Flags]
public enum GtkScrollablePolicy
{
/// <summary>
/// <para>
/// Scrollable adjustments are based on the minimum size
/// </para>
/// </summary>

	GTK_SCROLL_MINIMUM = 0,
/// <summary>
/// <para>
/// Scrollable adjustments are based on the natural size
/// </para>
/// </summary>

	GTK_SCROLL_NATURAL = 1
}
