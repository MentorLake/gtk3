namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Specifies a preference for height-for-width or
/// width-for-height geometry management.
/// </para>
/// </summary>

[Flags]
public enum GtkSizeRequestMode
{
/// <summary>
/// <para>
/// Prefer height-for-width geometry management
/// </para>
/// </summary>

	GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH = 0,
/// <summary>
/// <para>
/// Prefer width-for-height geometry management
/// </para>
/// </summary>

	GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT = 1,
/// <summary>
/// <para>
/// Don’t trade height-for-width or width-for-height
/// </para>
/// </summary>

	GTK_SIZE_REQUEST_CONSTANT_SIZE = 2
}
