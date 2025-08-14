namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when a pointer or keyboard grab is broken. On X11, this happens
/// when the grab window becomes unviewable (i.e. it or one of its ancestors
/// is unmapped), or if the same application grabs the pointer or keyboard
/// again. Note that implicit grabs (which are initiated by button presses)
/// can also cause #GdkEventGrabBroken events.
/// </para>
/// </summary>

public class GdkEventGrabBrokenHandle : BaseSafeHandle
{
}


public static class GdkEventGrabBrokenExtensions
{

	public static GdkEventGrabBroken Dereference(this GdkEventGrabBrokenHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventGrabBroken>(x.DangerousGetHandle());
}
internal class GdkEventGrabBrokenExterns
{
}

/// <summary>
/// <para>
/// Generated when a pointer or keyboard grab is broken. On X11, this happens
/// when the grab window becomes unviewable (i.e. it or one of its ancestors
/// is unmapped), or if the same application grabs the pointer or keyboard
/// again. Note that implicit grabs (which are initiated by button presses)
/// can also cause #GdkEventGrabBroken events.
/// </para>
/// </summary>

public struct GdkEventGrabBroken
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_GRAB_BROKEN)
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event, i.e. the window
///   that previously owned the grab
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
/// %TRUE if a keyboard grab was broken, %FALSE if a pointer
///   grab was broken
/// </para>
/// </summary>

public bool keyboard;
	/// <summary>
/// <para>
/// %TRUE if the broken grab was implicit
/// </para>
/// </summary>

public bool @implicit;
	/// <summary>
/// <para>
/// If this event is caused by another grab in the same
///   application, @grab_window contains the new grab window. Otherwise
///   @grab_window is %NULL.
/// </para>
/// </summary>

public IntPtr grab_window;
}
