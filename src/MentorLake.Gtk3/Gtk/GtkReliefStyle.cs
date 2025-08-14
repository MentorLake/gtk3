namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Indicated the relief to be drawn around a #GtkButton.
/// </para>
/// </summary>

[Flags]
public enum GtkReliefStyle
{
/// <summary>
/// <para>
/// Draw a normal relief.
/// </para>
/// </summary>

	GTK_RELIEF_NORMAL = 0,
/// <summary>
/// <para>
/// A half relief. Deprecated in 3.14, does the same as @GTK_RELIEF_NORMAL
/// </para>
/// </summary>

	GTK_RELIEF_HALF = 1,
/// <summary>
/// <para>
/// No relief.
/// </para>
/// </summary>

	GTK_RELIEF_NONE = 2
}
