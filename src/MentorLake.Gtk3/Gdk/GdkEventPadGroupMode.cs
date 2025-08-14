namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD mode switches in a group.
/// </para>
/// </summary>

public class GdkEventPadGroupModeHandle : BaseSafeHandle
{
}


public static class GdkEventPadGroupModeExtensions
{

	public static GdkEventPadGroupMode Dereference(this GdkEventPadGroupModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadGroupMode>(x.DangerousGetHandle());
}
internal class GdkEventPadGroupModeExterns
{
}

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD mode switches in a group.
/// </para>
/// </summary>

public struct GdkEventPadGroupMode
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_PAD_GROUP_MODE).
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
/// the pad group that is switching mode. A %GDK_SOURCE_TABLET_PAD
///   device may have one or more groups containing a set of buttons/rings/strips
///   each.
/// </para>
/// </summary>

public uint group;
	/// <summary>
/// <para>
/// The new mode of @group. Different groups in a %GDK_SOURCE_TABLET_PAD
///   device may have different current modes.
/// </para>
/// </summary>

public uint mode;
}
