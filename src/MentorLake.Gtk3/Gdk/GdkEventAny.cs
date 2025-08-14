namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Contains the fields which are common to all event structs.
/// Any event pointer can safely be cast to a pointer to a #GdkEventAny to
/// access these fields.
/// </para>
/// </summary>

public class GdkEventAnyHandle : BaseSafeHandle
{
}


public static class GdkEventAnyExtensions
{

	public static GdkEventAny Dereference(this GdkEventAnyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventAny>(x.DangerousGetHandle());
}
internal class GdkEventAnyExterns
{
}

/// <summary>
/// <para>
/// Contains the fields which are common to all event structs.
/// Any event pointer can safely be cast to a pointer to a #GdkEventAny to
/// access these fields.
/// </para>
/// </summary>

public struct GdkEventAny
{
	/// <summary>
/// <para>
/// the type of the event.
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
}
