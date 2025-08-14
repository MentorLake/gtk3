namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD interaction with tactile sensors.
/// </para>
/// </summary>

public class GdkEventPadAxisHandle : BaseSafeHandle
{
}


public static class GdkEventPadAxisExtensions
{

	public static GdkEventPadAxis Dereference(this GdkEventPadAxisHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadAxis>(x.DangerousGetHandle());
}
internal class GdkEventPadAxisExterns
{
}

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD interaction with tactile sensors.
/// </para>
/// </summary>

public struct GdkEventPadAxis
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_PAD_RING or %GDK_PAD_STRIP).
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
/// the pad group the ring/strip belongs to. A %GDK_SOURCE_TABLET_PAD
///   device may have one or more groups containing a set of buttons/rings/strips
///   each.
/// </para>
/// </summary>

public uint group;
	/// <summary>
/// <para>
/// number of strip/ring that was interacted. This number is 0-indexed.
/// </para>
/// </summary>

public uint index;
	/// <summary>
/// <para>
/// The current mode of @group. Different groups in a %GDK_SOURCE_TABLET_PAD
///   device may have different current modes.
/// </para>
/// </summary>

public uint mode;
	/// <summary>
/// <para>
/// The current value for the given axis.
/// </para>
/// </summary>

public double value;
}
