namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Encapsulates information about a key event.
/// </para>
/// </summary>

public class AtkKeyEventStructHandle : BaseSafeHandle
{
}


public static class AtkKeyEventStructExtensions
{

	public static AtkKeyEventStruct Dereference(this AtkKeyEventStructHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkKeyEventStruct>(x.DangerousGetHandle());
}
internal class AtkKeyEventStructExterns
{
}

/// <summary>
/// <para>
/// Encapsulates information about a key event.
/// </para>
/// </summary>

public struct AtkKeyEventStruct
{
	/// <summary>
/// <para>
/// An AtkKeyEventType, generally one of ATK_KEY_EVENT_PRESS or ATK_KEY_EVENT_RELEASE
/// </para>
/// </summary>

public int type;
	/// <summary>
/// <para>
/// A bitmask representing the state of the modifier keys immediately after the event takes place.
/// The meaning of the bits is currently defined to match the bitmask used by GDK in
/// GdkEventType.state, see
/// http://developer.gnome.org/doc/API/2.0/gdk/gdk-Event-Structures.html#GdkEventKey
/// </para>
/// </summary>

public uint state;
	/// <summary>
/// <para>
/// A guint representing a keysym value corresponding to those used by GDK and X11: see
/// /usr/X11/include/keysymdef.h.
/// </para>
/// </summary>

public uint keyval;
	/// <summary>
/// <para>
/// The length of member #string.
/// </para>
/// </summary>

public int length;
	/// <summary>
/// <para>
/// A string containing one of the following: either a string approximating the text that would
/// result from this keypress, if the key is a control or graphic character, or a symbolic name for this keypress.
/// Alphanumeric and printable keys will have the symbolic key name in this string member, for instance "A". "0",
/// "semicolon", "aacute".  Keypad keys have the prefix "KP".
/// </para>
/// </summary>

public string @string;
	/// <summary>
/// <para>
/// The raw hardware code that generated the key event.  This field is raraly useful.
/// </para>
/// </summary>

public ushort keycode;
	/// <summary>
/// <para>
/// A timestamp in milliseconds indicating when the event occurred.
/// These timestamps are relative to a starting point which should be considered arbitrary,
/// and only used to compare the dispatch times of events to one another.
/// </para>
/// </summary>

public uint timestamp;
}
