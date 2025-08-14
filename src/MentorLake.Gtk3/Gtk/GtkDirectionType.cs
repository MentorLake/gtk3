namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Focus movement types.
/// </para>
/// </summary>

[Flags]
public enum GtkDirectionType
{
/// <summary>
/// <para>
/// Move forward.
/// </para>
/// </summary>

	GTK_DIR_TAB_FORWARD = 0,
/// <summary>
/// <para>
/// Move backward.
/// </para>
/// </summary>

	GTK_DIR_TAB_BACKWARD = 1,
/// <summary>
/// <para>
/// Move up.
/// </para>
/// </summary>

	GTK_DIR_UP = 2,
/// <summary>
/// <para>
/// Move down.
/// </para>
/// </summary>

	GTK_DIR_DOWN = 3,
/// <summary>
/// <para>
/// Move left.
/// </para>
/// </summary>

	GTK_DIR_LEFT = 4,
/// <summary>
/// <para>
/// Move right.
/// </para>
/// </summary>

	GTK_DIR_RIGHT = 5
}
