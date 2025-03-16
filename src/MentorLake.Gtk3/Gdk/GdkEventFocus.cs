namespace MentorLake.Gdk;

public class GdkEventFocusHandle : BaseSafeHandle
{
}


public static class GdkEventFocusExtensions
{

	public static GdkEventFocus Dereference(this GdkEventFocusHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventFocus>(x.DangerousGetHandle());
}
internal class GdkEventFocusExterns
{
}

public struct GdkEventFocus
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public short @in;
}
