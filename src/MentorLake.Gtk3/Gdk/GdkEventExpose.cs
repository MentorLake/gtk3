namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when all or part of a window becomes visible and needs to be
/// redrawn.
/// </para>
/// </summary>

public class GdkEventExposeHandle : BaseSafeHandle
{
}


public static class GdkEventExposeExtensions
{

	public static GdkEventExpose Dereference(this GdkEventExposeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventExpose>(x.DangerousGetHandle());
}
internal class GdkEventExposeExterns
{
}

/// <summary>
/// <para>
/// Generated when all or part of a window becomes visible and needs to be
/// redrawn.
/// </para>
/// </summary>

public struct GdkEventExpose
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_EXPOSE or %GDK_DAMAGE).
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
/// bounding box of @region.
/// </para>
/// </summary>

public GdkRectangle area;
	/// <summary>
/// <para>
/// the region that needs to be redrawn.
/// </para>
/// </summary>

public IntPtr region;
	/// <summary>
/// <para>
/// the number of contiguous %GDK_EXPOSE events following this one.
///   The only use for this is “exposure compression”, i.e. handling all
///   contiguous %GDK_EXPOSE events in one go, though GDK performs some
///   exposure compression so this is not normally needed.
/// </para>
/// </summary>

public int count;
}
