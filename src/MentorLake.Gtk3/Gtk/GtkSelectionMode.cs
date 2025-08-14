namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to control what selections users are allowed to make.
/// </para>
/// </summary>

[Flags]
public enum GtkSelectionMode
{
/// <summary>
/// <para>
/// No selection is possible.
/// </para>
/// </summary>

	GTK_SELECTION_NONE = 0,
/// <summary>
/// <para>
/// Zero or one element may be selected.
/// </para>
/// </summary>

	GTK_SELECTION_SINGLE = 1,
/// <summary>
/// <para>
/// Exactly one element is selected.
///     In some circumstances, such as initially or during a search
///     operation, it’s possible for no element to be selected with
///     %GTK_SELECTION_BROWSE. What is really enforced is that the user
///     can’t deselect a currently selected element except by selecting
///     another element.
/// </para>
/// </summary>

	GTK_SELECTION_BROWSE = 2,
/// <summary>
/// <para>
/// Any number of elements may be selected.
///      The Ctrl key may be used to enlarge the selection, and Shift
///      key to select between the focus and the child pointed to.
///      Some widgets may also allow Click-drag to select a range of elements.
/// </para>
/// </summary>

	GTK_SELECTION_MULTIPLE = 3
}
