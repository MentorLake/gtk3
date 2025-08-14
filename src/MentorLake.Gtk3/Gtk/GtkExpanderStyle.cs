namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to specify the style of the expanders drawn by a #GtkTreeView.
/// </para>
/// </summary>

[Flags]
public enum GtkExpanderStyle
{
/// <summary>
/// <para>
/// The style used for a collapsed subtree.
/// </para>
/// </summary>

	GTK_EXPANDER_COLLAPSED = 0,
/// <summary>
/// <para>
/// Intermediate style used during animation.
/// </para>
/// </summary>

	GTK_EXPANDER_SEMI_COLLAPSED = 1,
/// <summary>
/// <para>
/// Intermediate style used during animation.
/// </para>
/// </summary>

	GTK_EXPANDER_SEMI_EXPANDED = 2,
/// <summary>
/// <para>
/// The style used for an expanded subtree.
/// </para>
/// </summary>

	GTK_EXPANDER_EXPANDED = 3
}
