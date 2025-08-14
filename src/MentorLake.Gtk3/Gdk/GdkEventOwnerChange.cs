namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when the owner of a selection changes. On X11, this
/// information is only available if the X server supports the XFIXES
/// extension.
/// </para>
/// </summary>

public class GdkEventOwnerChangeHandle : BaseSafeHandle
{
}


public static class GdkEventOwnerChangeExtensions
{

	public static GdkEventOwnerChange Dereference(this GdkEventOwnerChangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventOwnerChange>(x.DangerousGetHandle());
}
internal class GdkEventOwnerChangeExterns
{
}

/// <summary>
/// <para>
/// Generated when the owner of a selection changes. On X11, this
/// information is only available if the X server supports the XFIXES
/// extension.
/// </para>
/// </summary>

public struct GdkEventOwnerChange
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_OWNER_CHANGE).
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event
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
/// the new owner of the selection, or %NULL if there is none
/// </para>
/// </summary>

public IntPtr owner;
	/// <summary>
/// <para>
/// the reason for the ownership change as a #GdkOwnerChange value
/// </para>
/// </summary>

public GdkOwnerChange reason;
	/// <summary>
/// <para>
/// the atom identifying the selection
/// </para>
/// </summary>

public GdkAtom selection;
	/// <summary>
/// <para>
/// the timestamp of the event
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// the time at which the selection ownership was taken
///   over
/// </para>
/// </summary>

public uint selection_time;
}
