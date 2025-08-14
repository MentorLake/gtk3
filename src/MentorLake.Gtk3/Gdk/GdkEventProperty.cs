namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Describes a property change on a window.
/// </para>
/// </summary>

public class GdkEventPropertyHandle : BaseSafeHandle
{
}


public static class GdkEventPropertyExtensions
{

	public static GdkEventProperty Dereference(this GdkEventPropertyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventProperty>(x.DangerousGetHandle());
}
internal class GdkEventPropertyExterns
{
}

/// <summary>
/// <para>
/// Describes a property change on a window.
/// </para>
/// </summary>

public struct GdkEventProperty
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_PROPERTY_NOTIFY).
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
/// the property that was changed.
/// </para>
/// </summary>

public GdkAtom atom;
	/// <summary>
/// <para>
/// the time of the event in milliseconds.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// whether the property was changed
///   (%GDK_PROPERTY_NEW_VALUE) or deleted (%GDK_PROPERTY_DELETE).
/// </para>
/// </summary>

public GdkPropertyState state;
}
