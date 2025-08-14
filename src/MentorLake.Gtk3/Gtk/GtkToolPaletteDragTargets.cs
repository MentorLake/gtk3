namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Flags used to specify the supported drag targets.
/// </para>
/// </summary>

[Flags]
public enum GtkToolPaletteDragTargets : uint
{
/// <summary>
/// <para>
/// Support drag of items.
/// </para>
/// </summary>

	GTK_TOOL_PALETTE_DRAG_ITEMS = 1,
/// <summary>
/// <para>
/// Support drag of groups.
/// </para>
/// </summary>

	GTK_TOOL_PALETTE_DRAG_GROUPS = 2
}
