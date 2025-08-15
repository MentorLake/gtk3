namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Determines how the size should be computed to achieve the one of the
/// visibility mode for the scrollbars.
/// </para>
/// </summary>

[Flags]
public enum GtkPolicyType
{
/// <summary>
/// <para>
/// The scrollbar is always visible. The view size is
///  independent of the content.
/// </para>
/// </summary>

	GTK_POLICY_ALWAYS = 0,
/// <summary>
/// <para>
/// The scrollbar will appear and disappear as necessary.
///  For example, when all of a #GtkTreeView can not be seen.
/// </para>
/// </summary>

	GTK_POLICY_AUTOMATIC = 1,
/// <summary>
/// <para>
/// The scrollbar should never appear. In this mode the
///  content determines the size.
/// </para>
/// </summary>

	GTK_POLICY_NEVER = 2,
/// <summary>
/// <para>
/// Don&apos;t show a scrollbar, but don&apos;t force the
///  size to follow the content. This can be used e.g. to make multiple
///  scrolled windows share a scrollbar. Since: 3.16
/// </para>
/// </summary>

	GTK_POLICY_EXTERNAL = 3
}
