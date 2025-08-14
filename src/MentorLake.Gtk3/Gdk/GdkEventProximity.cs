namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Proximity events are generated when using GDK’s wrapper for the
/// XInput extension. The XInput extension is an add-on for standard X
/// that allows you to use nonstandard devices such as graphics tablets.
/// A proximity event indicates that the stylus has moved in or out of
/// contact with the tablet, or perhaps that the user’s finger has moved
/// in or out of contact with a touch screen.
/// </para>
/// <para>
/// This event type will be used pretty rarely. It only is important for
/// XInput aware programs that are drawing their own cursor.
/// </para>
/// </summary>

public class GdkEventProximityHandle : BaseSafeHandle
{
}


public static class GdkEventProximityExtensions
{

	public static GdkEventProximity Dereference(this GdkEventProximityHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventProximity>(x.DangerousGetHandle());
}
internal class GdkEventProximityExterns
{
}

/// <summary>
/// <para>
/// Proximity events are generated when using GDK’s wrapper for the
/// XInput extension. The XInput extension is an add-on for standard X
/// that allows you to use nonstandard devices such as graphics tablets.
/// A proximity event indicates that the stylus has moved in or out of
/// contact with the tablet, or perhaps that the user’s finger has moved
/// in or out of contact with a touch screen.
/// </para>
/// <para>
/// This event type will be used pretty rarely. It only is important for
/// XInput aware programs that are drawing their own cursor.
/// </para>
/// </summary>

public struct GdkEventProximity
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_PROXIMITY_IN or %GDK_PROXIMITY_OUT).
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
/// the master device that the event originated from. Use
/// gdk_event_get_source_device() to get the slave device.
/// </para>
/// </summary>

public IntPtr device;
}
