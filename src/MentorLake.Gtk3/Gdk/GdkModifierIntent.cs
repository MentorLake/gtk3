namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// This enum is used with gdk_keymap_get_modifier_mask()
/// in order to determine what modifiers the
/// currently used windowing system backend uses for particular
/// purposes. For example, on X11/Windows, the Control key is used for
/// invoking menu shortcuts (accelerators), whereas on Apple computers
/// it’s the Command key (which correspond to %GDK_CONTROL_MASK and
/// %GDK_MOD2_MASK, respectively).
/// </para>
/// </summary>

[Flags]
public enum GdkModifierIntent
{
/// <summary>
/// <para>
/// the primary modifier used to invoke
///  menu accelerators.
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_PRIMARY_ACCELERATOR = 0,
/// <summary>
/// <para>
/// the modifier used to invoke context menus.
///  Note that mouse button 3 always triggers context menus. When this modifier
///  is not 0, it additionally triggers context menus when used with mouse button 1.
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_CONTEXT_MENU = 1,
/// <summary>
/// <para>
/// the modifier used to extend selections
///  using `modifier`-click or `modifier`-cursor-key
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_EXTEND_SELECTION = 2,
/// <summary>
/// <para>
/// the modifier used to modify selections,
///  which in most cases means toggling the clicked item into or out of the selection.
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_MODIFY_SELECTION = 3,
/// <summary>
/// <para>
/// when any of these modifiers is pressed, the
///  key event cannot produce a symbol directly. This is meant to be used for
///  input methods, and for use cases like typeahead search.
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_NO_TEXT_INPUT = 4,
/// <summary>
/// <para>
/// the modifier that switches between keyboard
///  groups (AltGr on X11/Windows and Option/Alt on OS X).
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_SHIFT_GROUP = 5,
/// <summary>
/// <para>
/// The set of modifier masks accepted
/// as modifiers in accelerators. Needed because Command is mapped to MOD2 on
/// OSX, which is widely used, but on X11 MOD2 is NumLock and using that for a
/// mod key is problematic at best.
/// Ref: https://bugzilla.gnome.org/show_bug.cgi?id=736125.
/// </para>
/// </summary>

	GDK_MODIFIER_INTENT_DEFAULT_MOD_MASK = 6
}
