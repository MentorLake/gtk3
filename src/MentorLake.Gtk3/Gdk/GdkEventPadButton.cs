namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD button presses and releases.
/// </para>
/// </summary>

public class GdkEventPadButtonHandle : BaseSafeHandle
{
}


public static class GdkEventPadButtonExtensions
{

	public static GdkEventPadButton Dereference(this GdkEventPadButtonHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventPadButton>(x.DangerousGetHandle());
}
internal class GdkEventPadButtonExterns
{
}

/// <summary>
/// <para>
/// Generated during %GDK_SOURCE_TABLET_PAD button presses and releases.
/// </para>
/// </summary>

public struct GdkEventPadButton
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_PAD_BUTTON_PRESS or %GDK_PAD_BUTTON_RELEASE).
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
/// the pad group the button belongs to. A %GDK_SOURCE_TABLET_PAD device
///   may have one or more groups containing a set of buttons/rings/strips each.
/// </para>
/// </summary>

public uint group;
	/// <summary>
/// <para>
/// The pad button that was pressed.
/// </para>
/// </summary>

public uint button;
	/// <summary>
/// <para>
/// The current mode of @group. Different groups in a %GDK_SOURCE_TABLET_PAD
///   device may have different current modes.
/// </para>
/// </summary>

public uint mode;
}
