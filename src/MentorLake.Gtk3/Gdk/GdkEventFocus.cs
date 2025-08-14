namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Describes a change of keyboard focus.
/// </para>
/// </summary>

public class GdkEventFocusHandle : BaseSafeHandle
{
}


public static class GdkEventFocusExtensions
{

	public static GdkEventFocus Dereference(this GdkEventFocusHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventFocus>(x.DangerousGetHandle());
}
internal class GdkEventFocusExterns
{
}

/// <summary>
/// <para>
/// Describes a change of keyboard focus.
/// </para>
/// </summary>

public struct GdkEventFocus
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_FOCUS_CHANGE).
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
/// %TRUE if the window has gained the keyboard focus, %FALSE if
///   it has lost the focus.
/// </para>
/// </summary>

public short @in;
}
