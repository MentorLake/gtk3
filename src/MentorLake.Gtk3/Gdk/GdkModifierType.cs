namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A set of bit-flags to indicate the state of modifier keys and mouse buttons
/// in various event types. Typical modifier keys are Shift, Control, Meta,
/// Super, Hyper, Alt, Compose, Apple, CapsLock or ShiftLock.
/// </para>
/// <para>
/// Like the X Window System, GDK supports 8 modifier keys and 5 mouse buttons.
/// </para>
/// <para>
/// Since 2.10, GDK recognizes which of the Meta, Super or Hyper keys are mapped
/// to Mod2 - Mod5, and indicates this by setting %GDK_SUPER_MASK,
/// %GDK_HYPER_MASK or %GDK_META_MASK in the state field of key events.
/// </para>
/// <para>
/// Note that GDK may add internal values to events which include
/// reserved values such as %GDK_MODIFIER_RESERVED_13_MASK.  Your code
/// should preserve and ignore them.  You can use %GDK_MODIFIER_MASK to
/// remove all reserved values.
/// </para>
/// <para>
/// Also note that the GDK X backend interprets button press events for button
/// 4-7 as scroll events, so %GDK_BUTTON4_MASK and %GDK_BUTTON5_MASK will never
/// be set.
/// </para>
/// </summary>

[Flags]
public enum GdkModifierType : uint
{
/// <summary>
/// <para>
/// the Shift key.
/// </para>
/// </summary>

	GDK_SHIFT_MASK = 1,
/// <summary>
/// <para>
/// a Lock key (depending on the modifier mapping of the
///  X server this may either be CapsLock or ShiftLock).
/// </para>
/// </summary>

	GDK_LOCK_MASK = 2,
/// <summary>
/// <para>
/// the Control key.
/// </para>
/// </summary>

	GDK_CONTROL_MASK = 4,
/// <summary>
/// <para>
/// the fourth modifier key (it depends on the modifier
///  mapping of the X server which key is interpreted as this modifier, but
///  normally it is the Alt key).
/// </para>
/// </summary>

	GDK_MOD1_MASK = 8,
/// <summary>
/// <para>
/// the fifth modifier key (it depends on the modifier
///  mapping of the X server which key is interpreted as this modifier).
/// </para>
/// </summary>

	GDK_MOD2_MASK = 16,
/// <summary>
/// <para>
/// the sixth modifier key (it depends on the modifier
///  mapping of the X server which key is interpreted as this modifier).
/// </para>
/// </summary>

	GDK_MOD3_MASK = 32,
/// <summary>
/// <para>
/// the seventh modifier key (it depends on the modifier
///  mapping of the X server which key is interpreted as this modifier).
/// </para>
/// </summary>

	GDK_MOD4_MASK = 64,
/// <summary>
/// <para>
/// the eighth modifier key (it depends on the modifier
///  mapping of the X server which key is interpreted as this modifier).
/// </para>
/// </summary>

	GDK_MOD5_MASK = 128,
/// <summary>
/// <para>
/// the first mouse button.
/// </para>
/// </summary>

	GDK_BUTTON1_MASK = 256,
/// <summary>
/// <para>
/// the second mouse button.
/// </para>
/// </summary>

	GDK_BUTTON2_MASK = 512,
/// <summary>
/// <para>
/// the third mouse button.
/// </para>
/// </summary>

	GDK_BUTTON3_MASK = 1024,
/// <summary>
/// <para>
/// the fourth mouse button.
/// </para>
/// </summary>

	GDK_BUTTON4_MASK = 2048,
/// <summary>
/// <para>
/// the fifth mouse button.
/// </para>
/// </summary>

	GDK_BUTTON5_MASK = 4096,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_13_MASK = 8192,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_14_MASK = 16384,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_15_MASK = 32768,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_16_MASK = 65536,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_17_MASK = 131072,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_18_MASK = 262144,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_19_MASK = 524288,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_20_MASK = 1048576,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_21_MASK = 2097152,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_22_MASK = 4194304,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_23_MASK = 8388608,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_24_MASK = 16777216,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_25_MASK = 33554432,
/// <summary>
/// <para>
/// the Super modifier. Since 2.10
/// </para>
/// </summary>

	GDK_SUPER_MASK = 67108864,
/// <summary>
/// <para>
/// the Hyper modifier. Since 2.10
/// </para>
/// </summary>

	GDK_HYPER_MASK = 134217728,
/// <summary>
/// <para>
/// the Meta modifier. Since 2.10
/// </para>
/// </summary>

	GDK_META_MASK = 268435456,
/// <summary>
/// <para>
/// A reserved bit flag; do not use in your own code
/// </para>
/// </summary>

	GDK_MODIFIER_RESERVED_29_MASK = 536870912,
/// <summary>
/// <para>
/// not used in GDK itself. GTK+ uses it to differentiate
///  between (keyval, modifiers) pairs from key press and release events.
/// </para>
/// </summary>

	GDK_RELEASE_MASK = 1073741824,
/// <summary>
/// <para>
/// a mask covering all modifier types.
/// </para>
/// </summary>

	GDK_MODIFIER_MASK = 1543512063
}
