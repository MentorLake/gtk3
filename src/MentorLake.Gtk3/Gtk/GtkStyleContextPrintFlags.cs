namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Flags that modify the behavior of gtk_style_context_to_string().
/// New values may be added to this enumeration.
/// </para>
/// </summary>

[Flags]
public enum GtkStyleContextPrintFlags : uint
{

	GTK_STYLE_CONTEXT_PRINT_NONE = 0,
/// <summary>
/// <para>
/// Print the entire tree of
///     CSS nodes starting at the style context&apos;s node
/// </para>
/// </summary>

	GTK_STYLE_CONTEXT_PRINT_RECURSE = 1,
/// <summary>
/// <para>
/// Show the values of the
///     CSS properties for each node
/// </para>
/// </summary>

	GTK_STYLE_CONTEXT_PRINT_SHOW_STYLE = 2
}
