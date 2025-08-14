namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used for button press and button release events. The
/// @type field will be one of %GDK_BUTTON_PRESS,
/// %GDK_2BUTTON_PRESS, %GDK_3BUTTON_PRESS or %GDK_BUTTON_RELEASE,
/// </para>
/// <para>
/// Double and triple-clicks result in a sequence of events being received.
/// For double-clicks the order of events will be:
/// </para>
/// <para>
/// - %GDK_BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_2BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// </para>
/// <para>
/// Note that the first click is received just like a normal
/// button press, while the second click results in a %GDK_2BUTTON_PRESS
/// being received just after the %GDK_BUTTON_PRESS.
/// </para>
/// <para>
/// Triple-clicks are very similar to double-clicks, except that
/// %GDK_3BUTTON_PRESS is inserted after the third click. The order of the
/// events is:
/// </para>
/// <para>
/// - %GDK_BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_2BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_3BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// </para>
/// <para>
/// For a double click to occur, the second button press must occur within
/// 1/4 of a second of the first. For a triple click to occur, the third
/// button press must also occur within 1/2 second of the first button press.
/// </para>
/// </summary>

public class GdkEventButtonHandle : BaseSafeHandle
{
}


public static class GdkEventButtonExtensions
{

	public static GdkEventButton Dereference(this GdkEventButtonHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventButton>(x.DangerousGetHandle());
}
internal class GdkEventButtonExterns
{
}

/// <summary>
/// <para>
/// Used for button press and button release events. The
/// @type field will be one of %GDK_BUTTON_PRESS,
/// %GDK_2BUTTON_PRESS, %GDK_3BUTTON_PRESS or %GDK_BUTTON_RELEASE,
/// </para>
/// <para>
/// Double and triple-clicks result in a sequence of events being received.
/// For double-clicks the order of events will be:
/// </para>
/// <para>
/// - %GDK_BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_2BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// </para>
/// <para>
/// Note that the first click is received just like a normal
/// button press, while the second click results in a %GDK_2BUTTON_PRESS
/// being received just after the %GDK_BUTTON_PRESS.
/// </para>
/// <para>
/// Triple-clicks are very similar to double-clicks, except that
/// %GDK_3BUTTON_PRESS is inserted after the third click. The order of the
/// events is:
/// </para>
/// <para>
/// - %GDK_BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_2BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// - %GDK_BUTTON_PRESS
/// - %GDK_3BUTTON_PRESS
/// - %GDK_BUTTON_RELEASE
/// </para>
/// <para>
/// For a double click to occur, the second button press must occur within
/// 1/4 of a second of the first. For a triple click to occur, the third
/// button press must also occur within 1/2 second of the first button press.
/// </para>
/// </summary>

public struct GdkEventButton
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_BUTTON_PRESS, %GDK_2BUTTON_PRESS,
///   %GDK_3BUTTON_PRESS or %GDK_BUTTON_RELEASE).
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
/// the button which was pressed or released, numbered from 1 to 5.
///   Normally button 1 is the left mouse button, 2 is the middle button,
///   and 3 is the right button. On 2-button mice, the middle button can
///   often be simulated by pressing both mouse buttons together.
/// </para>
/// </summary>

public uint button;
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
