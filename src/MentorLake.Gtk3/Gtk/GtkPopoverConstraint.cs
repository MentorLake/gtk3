namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes constraints to positioning of popovers. More values
/// may be added to this enumeration in the future.
/// </para>
/// </summary>

[Flags]
public enum GtkPopoverConstraint
{
/// <summary>
/// <para>
/// Don&apos;t constrain the popover position
///   beyond what is imposed by the implementation
/// </para>
/// </summary>

	GTK_POPOVER_CONSTRAINT_NONE = 0,
/// <summary>
/// <para>
/// Constrain the popover to the boundaries
///   of the window that it is attached to
/// </para>
/// </summary>

	GTK_POPOVER_CONSTRAINT_WINDOW = 1
}
