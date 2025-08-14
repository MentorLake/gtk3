namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Describes a key press or key release event.
/// </para>
/// </summary>

public class GdkEventKeyHandle : BaseSafeHandle
{
}


public static class GdkEventKeyExtensions
{

	public static GdkEventKey Dereference(this GdkEventKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventKey>(x.DangerousGetHandle());
}
internal class GdkEventKeyExterns
{
}

/// <summary>
/// <para>
/// Describes a key press or key release event.
/// </para>
/// </summary>

public struct GdkEventKey
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_KEY_PRESS or %GDK_KEY_RELEASE).
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event.
/// </para>
/// </summary>

public IntPtr window;
	/// <summary>
/// <para>
/// %TRUE if the event was sent explicitly.
/// </para>
/// </summary>

public byte send_event;
	/// <summary>
/// <para>
/// the time of the event in milliseconds.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// a bit-mask representing the state of
///   the modifier keys (e.g. Control, Shift and Alt) and the pointer
///   buttons. See #GdkModifierType.
/// </para>
/// </summary>

public GdkModifierType state;
	/// <summary>
/// <para>
/// the key that was pressed or released. See the
///   `gdk/gdkkeysyms.h` header file for a
///   complete list of GDK key codes.
/// </para>
/// </summary>

public uint keyval;
	/// <summary>
/// <para>
/// the length of @string.
/// </para>
/// </summary>

public int length;
	/// <summary>
/// <para>
/// a string containing an approximation of the text that
///   would result from this keypress. The only correct way to handle text
///   input of text is using input methods (see #GtkIMContext), so this
///   field is deprecated and should never be used.
///   (gdk_unicode_to_keyval() provides a non-deprecated way of getting
///   an approximate translation for a key.) The string is encoded in the
///   encoding of the current locale (Note: this for backwards compatibility:
///   strings in GTK+ and GDK are typically in UTF-8.) and NUL-terminated.
///   In some cases, the translation of the key code will be a single
///   NUL byte, in which case looking at @length is necessary to distinguish
///   it from the an empty translation.
/// </para>
/// </summary>

public string @string;
	/// <summary>
/// <para>
/// the raw code of the key that was pressed or released.
/// </para>
/// </summary>

public ushort hardware_keycode;
	/// <summary>
/// <para>
/// the keyboard group.
/// </para>
/// </summary>

public byte group;
	/// <summary>
/// <para>
/// a flag that indicates if @hardware_keycode is mapped to a
///   modifier. Since 2.10
/// </para>
/// </summary>

public uint is_modifier;
}
