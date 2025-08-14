namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when the pointer enters or leaves a window.
/// </para>
/// </summary>

public class GdkEventCrossingHandle : BaseSafeHandle
{
}


public static class GdkEventCrossingExtensions
{

	public static GdkEventCrossing Dereference(this GdkEventCrossingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventCrossing>(x.DangerousGetHandle());
}
internal class GdkEventCrossingExterns
{
}

/// <summary>
/// <para>
/// Generated when the pointer enters or leaves a window.
/// </para>
/// </summary>

public struct GdkEventCrossing
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_ENTER_NOTIFY or %GDK_LEAVE_NOTIFY).
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
/// the window that was entered or left.
/// </para>
/// </summary>

public IntPtr subwindow;
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
/// the x coordinate of the pointer relative to the root of the screen.
/// </para>
/// </summary>

public double x_root;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the root of the screen.
/// </para>
/// </summary>

public double y_root;
	/// <summary>
/// <para>
/// the crossing mode (%GDK_CROSSING_NORMAL, %GDK_CROSSING_GRAB,
///  %GDK_CROSSING_UNGRAB, %GDK_CROSSING_GTK_GRAB, %GDK_CROSSING_GTK_UNGRAB or
///  %GDK_CROSSING_STATE_CHANGED).  %GDK_CROSSING_GTK_GRAB, %GDK_CROSSING_GTK_UNGRAB,
///  and %GDK_CROSSING_STATE_CHANGED were added in 2.14 and are always synthesized,
///  never native.
/// </para>
/// </summary>

public GdkCrossingMode mode;
	/// <summary>
/// <para>
/// the kind of crossing that happened (%GDK_NOTIFY_INFERIOR,
///  %GDK_NOTIFY_ANCESTOR, %GDK_NOTIFY_VIRTUAL, %GDK_NOTIFY_NONLINEAR or
///  %GDK_NOTIFY_NONLINEAR_VIRTUAL).
/// </para>
/// </summary>

public GdkNotifyType detail;
	/// <summary>
/// <para>
/// %TRUE if @window is the focus window or an inferior.
/// </para>
/// </summary>

public bool focus;
	/// <summary>
/// <para>
/// a bit-mask representing the state of
///   the modifier keys (e.g. Control, Shift and Alt) and the pointer
///   buttons. See #GdkModifierType.
/// </para>
/// </summary>

public GdkModifierType state;
}
