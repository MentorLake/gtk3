namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when the window visibility status has changed.
/// </para>
/// </summary>

public class GdkEventVisibilityHandle : BaseSafeHandle
{
}


public static class GdkEventVisibilityExtensions
{

	public static GdkEventVisibility Dereference(this GdkEventVisibilityHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventVisibility>(x.DangerousGetHandle());
}
internal class GdkEventVisibilityExterns
{
}

/// <summary>
/// <para>
/// Generated when the window visibility status has changed.
/// </para>
/// </summary>

public struct GdkEventVisibility
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_VISIBILITY_NOTIFY).
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
/// the new visibility state (%GDK_VISIBILITY_FULLY_OBSCURED,
///   %GDK_VISIBILITY_PARTIAL or %GDK_VISIBILITY_UNOBSCURED).
/// </para>
/// </summary>

public GdkVisibilityState state;
}
