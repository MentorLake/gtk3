namespace MentorLake.Gdk;

public class GdkEventGrabBrokenHandle : BaseSafeHandle
{
}


public static class GdkEventGrabBrokenExtensions
{

	public static GdkEventGrabBroken Dereference(this GdkEventGrabBrokenHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventGrabBroken>(x.DangerousGetHandle());
}
internal class GdkEventGrabBrokenExterns
{
}

public struct GdkEventGrabBroken
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public bool keyboard;
	public bool @implicit;
	public IntPtr grab_window;
}
