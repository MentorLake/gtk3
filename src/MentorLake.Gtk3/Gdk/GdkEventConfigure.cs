namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when a window size or position has changed.
/// </para>
/// </summary>

public class GdkEventConfigureHandle : BaseSafeHandle
{
}


public static class GdkEventConfigureExtensions
{

	public static GdkEventConfigure Dereference(this GdkEventConfigureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventConfigure>(x.DangerousGetHandle());
}
internal class GdkEventConfigureExterns
{
}

/// <summary>
/// <para>
/// Generated when a window size or position has changed.
/// </para>
/// </summary>

public struct GdkEventConfigure
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_CONFIGURE).
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
/// the new x coordinate of the window, relative to its parent.
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// the new y coordinate of the window, relative to its parent.
/// </para>
/// </summary>

public int y;
	/// <summary>
/// <para>
/// the new width of the window.
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// the new height of the window.
/// </para>
/// </summary>

public int height;
}
