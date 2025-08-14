namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to customize the appearance of a #GtkToolbar. Note that
/// setting the toolbar style overrides the user’s preferences
/// for the default toolbar style.  Note that if the button has only
/// a label set and GTK_TOOLBAR_ICONS is used, the label will be
/// visible, and vice versa.
/// </para>
/// </summary>

[Flags]
public enum GtkToolbarStyle
{
/// <summary>
/// <para>
/// Buttons display only icons in the toolbar.
/// </para>
/// </summary>

	GTK_TOOLBAR_ICONS = 0,
/// <summary>
/// <para>
/// Buttons display only text labels in the toolbar.
/// </para>
/// </summary>

	GTK_TOOLBAR_TEXT = 1,
/// <summary>
/// <para>
/// Buttons display text and icons in the toolbar.
/// </para>
/// </summary>

	GTK_TOOLBAR_BOTH = 2,
/// <summary>
/// <para>
/// Buttons display icons and text alongside each
///  other, rather than vertically stacked
/// </para>
/// </summary>

	GTK_TOOLBAR_BOTH_HORIZ = 3
}
