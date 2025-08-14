namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used to represent native events (XEvents for the X11
/// backend, MSGs for Win32).
/// </para>
/// </summary>

public struct GdkXEvent
{
}

public class GdkXEventHandle : BaseSafeHandle
{
}

public static class GdkXEventHandleExtensions
{
	public static GdkXEvent Dereference(this GdkXEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkXEvent>(x.DangerousGetHandle());
}
