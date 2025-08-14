namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Specifies the side of the entry at which an icon is placed.
/// </para>
/// </summary>

[Flags]
public enum GtkEntryIconPosition
{
/// <summary>
/// <para>
/// At the beginning of the entry (depending on the text direction).
/// </para>
/// </summary>

	GTK_ENTRY_ICON_PRIMARY = 0,
/// <summary>
/// <para>
/// At the end of the entry (depending on the text direction).
/// </para>
/// </summary>

	GTK_ENTRY_ICON_SECONDARY = 1
}
