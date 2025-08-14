namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Granularity types that extend the text selection. Use the
/// #GtkTextView::extend-selection signal to customize the selection.
/// </para>
/// </summary>

[Flags]
public enum GtkTextExtendSelection
{
/// <summary>
/// <para>
/// Selects the current word. It is triggered by
///   a double-click for example.
/// </para>
/// </summary>

	GTK_TEXT_EXTEND_SELECTION_WORD = 0,
/// <summary>
/// <para>
/// Selects the current line. It is triggered by
///   a triple-click for example.
/// </para>
/// </summary>

	GTK_TEXT_EXTEND_SELECTION_LINE = 1
}
