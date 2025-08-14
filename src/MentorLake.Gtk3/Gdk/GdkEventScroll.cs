namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated from button presses for the buttons 4 to 7. Wheel mice are
/// usually configured to generate button press events for buttons 4 and 5
/// when the wheel is turned.
/// </para>
/// <para>
/// Some GDK backends can also generate “smooth” scroll events, which
/// can be recognized by the %GDK_SCROLL_SMOOTH scroll direction. For
/// these, the scroll deltas can be obtained with
/// gdk_event_get_scroll_deltas().
/// </para>
/// </summary>

public class GdkEventScrollHandle : BaseSafeHandle
{
}


public static class GdkEventScrollExtensions
{

	public static GdkEventScroll Dereference(this GdkEventScrollHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventScroll>(x.DangerousGetHandle());
}
internal class GdkEventScrollExterns
{
}

/// <summary>
/// <para>
/// Generated from button presses for the buttons 4 to 7. Wheel mice are
/// usually configured to generate button press events for buttons 4 and 5
/// when the wheel is turned.
/// </para>
/// <para>
/// Some GDK backends can also generate “smooth” scroll events, which
/// can be recognized by the %GDK_SCROLL_SMOOTH scroll direction. For
/// these, the scroll deltas can be obtained with
/// gdk_event_get_scroll_deltas().
/// </para>
/// </summary>

public struct GdkEventScroll
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_SCROLL).
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
/// a bit-mask representing the state of
///   the modifier keys (e.g. Control, Shift and Alt) and the pointer
///   buttons. See #GdkModifierType.
/// </para>
/// </summary>

public GdkModifierType state;
	/// <summary>
/// <para>
/// the direction to scroll to (one of %GDK_SCROLL_UP,
///   %GDK_SCROLL_DOWN, %GDK_SCROLL_LEFT, %GDK_SCROLL_RIGHT or
///   %GDK_SCROLL_SMOOTH).
/// </para>
/// </summary>

public GdkScrollDirection direction;
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
	/// <summary>
/// <para>
/// the x coordinate of the scroll delta
/// </para>
/// </summary>

public double delta_x;
	/// <summary>
/// <para>
/// the y coordinate of the scroll delta
/// </para>
/// </summary>

public double delta_y;
	
public uint is_stop;
}
