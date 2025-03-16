namespace MentorLake.Gdk;

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

public struct GdkEventAny
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
}
