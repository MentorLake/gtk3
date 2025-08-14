namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when the pointer moves.
/// </para>
/// </summary>

public class GdkEventMotionHandle : BaseSafeHandle
{
}


public static class GdkEventMotionExtensions
{

	public static GdkEventMotion Dereference(this GdkEventMotionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventMotion>(x.DangerousGetHandle());
}
internal class GdkEventMotionExterns
{
}

/// <summary>
/// <para>
/// Generated when the pointer moves.
/// </para>
/// </summary>

public struct GdkEventMotion
{
	/// <summary>
/// <para>
/// the type of the event.
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
/// the x coordinate of the pointer relative to the window.
/// </para>
/// </summary>

public double x;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the window.
/// </para>
/// </summary>

public double y;
	/// <summary>
/// <para>
/// @x, @y translated to the axes of @device, or %NULL if @device is
///   the mouse.
/// </para>
/// </summary>

public IntPtr axes;
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
/// set to 1 if this event is just a hint, see the
///   %GDK_POINTER_MOTION_HINT_MASK value of #GdkEventMask.
/// </para>
/// </summary>

public short is_hint;
	/// <summary>
/// <para>
/// the master device that the event originated from. Use
/// gdk_event_get_source_device() to get the slave device.
/// </para>
/// </summary>

public IntPtr device;
	/// <summary>
/// <para>
/// the x coordinate of the pointer relative to the root of the
///   screen.
/// </para>
/// </summary>

public double x_root;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the root of the
///   screen.
/// </para>
/// </summary>

public double y_root;
}
