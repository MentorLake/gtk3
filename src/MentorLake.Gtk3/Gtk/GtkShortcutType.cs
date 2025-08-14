namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkShortcutType specifies the kind of shortcut that is being described.
/// More values may be added to this enumeration over time.
/// </para>
/// </summary>

[Flags]
public enum GtkShortcutType
{
/// <summary>
/// <para>
/// The shortcut is a keyboard accelerator. The #GtkShortcutsShortcut:accelerator
///   property will be used.
/// </para>
/// </summary>

	GTK_SHORTCUT_ACCELERATOR = 0,
/// <summary>
/// <para>
/// The shortcut is a pinch gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_PINCH = 1,
/// <summary>
/// <para>
/// The shortcut is a stretch gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_STRETCH = 2,
/// <summary>
/// <para>
/// The shortcut is a clockwise rotation gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_ROTATE_CLOCKWISE = 3,
/// <summary>
/// <para>
/// The shortcut is a counterclockwise rotation gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_ROTATE_COUNTERCLOCKWISE = 4,
/// <summary>
/// <para>
/// The shortcut is a two-finger swipe gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_TWO_FINGER_SWIPE_LEFT = 5,
/// <summary>
/// <para>
/// The shortcut is a two-finger swipe gesture. GTK+ provides an icon and subtitle.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE_TWO_FINGER_SWIPE_RIGHT = 6,
/// <summary>
/// <para>
/// The shortcut is a gesture. The #GtkShortcutsShortcut:icon property will be
///   used.
/// </para>
/// </summary>

	GTK_SHORTCUT_GESTURE = 7
}
