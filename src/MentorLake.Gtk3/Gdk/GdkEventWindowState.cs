namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when the state of a toplevel window changes.
/// </para>
/// </summary>

public class GdkEventWindowStateHandle : BaseSafeHandle
{
}


public static class GdkEventWindowStateExtensions
{

	public static GdkEventWindowState Dereference(this GdkEventWindowStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventWindowState>(x.DangerousGetHandle());
}
internal class GdkEventWindowStateExterns
{
}

/// <summary>
/// <para>
/// Generated when the state of a toplevel window changes.
/// </para>
/// </summary>

public struct GdkEventWindowState
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_WINDOW_STATE).
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
/// mask specifying what flags have changed.
/// </para>
/// </summary>

public GdkWindowState changed_mask;
	/// <summary>
/// <para>
/// the new window state, a combination of
///   #GdkWindowState bits.
/// </para>
/// </summary>

public GdkWindowState new_window_state;
}
