namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when a selection is requested or ownership of a selection
/// is taken over by another client application.
/// </para>
/// </summary>

public class GdkEventSelectionHandle : BaseSafeHandle
{
}


public static class GdkEventSelectionExtensions
{

	public static GdkEventSelection Dereference(this GdkEventSelectionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventSelection>(x.DangerousGetHandle());
}
internal class GdkEventSelectionExterns
{
}

/// <summary>
/// <para>
/// Generated when a selection is requested or ownership of a selection
/// is taken over by another client application.
/// </para>
/// </summary>

public struct GdkEventSelection
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_SELECTION_CLEAR,
///   %GDK_SELECTION_NOTIFY or %GDK_SELECTION_REQUEST).
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
/// the selection.
/// </para>
/// </summary>

public GdkAtom selection;
	/// <summary>
/// <para>
/// the target to which the selection should be converted.
/// </para>
/// </summary>

public GdkAtom target;
	/// <summary>
/// <para>
/// the property in which to place the result of the conversion.
/// </para>
/// </summary>

public GdkAtom property;
	/// <summary>
/// <para>
/// the time of the event in milliseconds.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// the window on which to place @property or %NULL if none.
/// </para>
/// </summary>

public IntPtr requestor;
}
