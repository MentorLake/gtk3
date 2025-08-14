namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Kinds of widget-specific help. Used by the ::show-help signal.
/// </para>
/// </summary>

[Flags]
public enum GtkWidgetHelpType
{
/// <summary>
/// <para>
/// Tooltip.
/// </para>
/// </summary>

	GTK_WIDGET_HELP_TOOLTIP = 0,
/// <summary>
/// <para>
/// What’s this.
/// </para>
/// </summary>

	GTK_WIDGET_HELP_WHATS_THIS = 1
}
