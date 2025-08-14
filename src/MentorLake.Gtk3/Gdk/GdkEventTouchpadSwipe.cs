namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during touchpad swipe gestures.
/// </para>
/// </summary>

public class GdkEventTouchpadSwipeHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadSwipeExtensions
{

	public static GdkEventTouchpadSwipe Dereference(this GdkEventTouchpadSwipeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouchpadSwipe>(x.DangerousGetHandle());
}
internal class GdkEventTouchpadSwipeExterns
{
}

/// <summary>
/// <para>
/// Generated during touchpad swipe gestures.
/// </para>
/// </summary>

public struct GdkEventTouchpadSwipe
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_TOUCHPAD_SWIPE)
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event
/// </para>
/// </summary>

public IntPtr window;
	/// <summary>
/// <para>
/// %TRUE if the event was sent explicitly
/// </para>
/// </summary>

public byte send_event;
	/// <summary>
/// <para>
/// the current phase of the gesture
/// </para>
/// </summary>

public byte phase;
	/// <summary>
/// <para>
/// The number of fingers triggering the swipe
/// </para>
/// </summary>

public byte n_fingers;
	/// <summary>
/// <para>
/// the time of the event in milliseconds
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// The X coordinate of the pointer
/// </para>
/// </summary>

public double x;
	/// <summary>
/// <para>
/// The Y coordinate of the pointer
/// </para>
/// </summary>

public double y;
	/// <summary>
/// <para>
/// Movement delta in the X axis of the swipe focal point
/// </para>
/// </summary>

public double dx;
	/// <summary>
/// <para>
/// Movement delta in the Y axis of the swipe focal point
/// </para>
/// </summary>

public double dy;
	/// <summary>
/// <para>
/// The X coordinate of the pointer, relative to the
///   root of the screen.
/// </para>
/// </summary>

public double x_root;
	/// <summary>
/// <para>
/// The Y coordinate of the pointer, relative to the
///   root of the screen.
/// </para>
/// </summary>

public double y_root;
	/// <summary>
/// <para>
/// a bit-mask representing the state of
///   the modifier keys (e.g. Control, Shift and Alt) and the pointer
///   buttons. See #GdkModifierType.
/// </para>
/// </summary>

public GdkModifierType state;
}
