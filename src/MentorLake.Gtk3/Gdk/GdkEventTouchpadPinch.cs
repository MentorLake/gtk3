namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during touchpad swipe gestures.
/// </para>
/// </summary>

public class GdkEventTouchpadPinchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadPinchExtensions
{

	public static GdkEventTouchpadPinch Dereference(this GdkEventTouchpadPinchHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouchpadPinch>(x.DangerousGetHandle());
}
internal class GdkEventTouchpadPinchExterns
{
}

/// <summary>
/// <para>
/// Generated during touchpad swipe gestures.
/// </para>
/// </summary>

public struct GdkEventTouchpadPinch
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_TOUCHPAD_PINCH)
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
/// The number of fingers triggering the pinch
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
/// The angle change in radians, negative angles
///   denote counter-clockwise movements
/// </para>
/// </summary>

public double angle_delta;
	/// <summary>
/// <para>
/// The current scale, relative to that at the time of
///   the corresponding %GDK_TOUCHPAD_GESTURE_PHASE_BEGIN event
/// </para>
/// </summary>

public double scale;
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
