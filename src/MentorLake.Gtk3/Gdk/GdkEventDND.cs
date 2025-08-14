namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during DND operations.
/// </para>
/// </summary>

public class GdkEventDNDHandle : BaseSafeHandle
{
}


public static class GdkEventDNDExtensions
{

	public static GdkEventDND Dereference(this GdkEventDNDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventDND>(x.DangerousGetHandle());
}
internal class GdkEventDNDExterns
{
}

/// <summary>
/// <para>
/// Generated during DND operations.
/// </para>
/// </summary>

public struct GdkEventDND
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_DRAG_ENTER, %GDK_DRAG_LEAVE,
///   %GDK_DRAG_MOTION, %GDK_DRAG_STATUS, %GDK_DROP_START or
///   %GDK_DROP_FINISHED).
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
/// the #GdkDragContext for the current DND operation.
/// </para>
/// </summary>

public IntPtr context;
	/// <summary>
/// <para>
/// the time of the event in milliseconds.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// the x coordinate of the pointer relative to the root of the
///   screen, only set for %GDK_DRAG_MOTION and %GDK_DROP_START.
/// </para>
/// </summary>

public short x_root;
	/// <summary>
/// <para>
/// the y coordinate of the pointer relative to the root of the
///   screen, only set for %GDK_DRAG_MOTION and %GDK_DROP_START.
/// </para>
/// </summary>

public short y_root;
}
