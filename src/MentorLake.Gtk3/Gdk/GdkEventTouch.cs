namespace MentorLake.Gdk;

public class GdkEventTouchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchExtensions
{

	public static GdkEventTouch Dereference(this GdkEventTouchHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouch>(x.DangerousGetHandle());
}
internal class GdkEventTouchExterns
{
}

public struct GdkEventTouch
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public IntPtr axes;
	public GdkModifierType state;
	public IntPtr sequence;
	public bool emulating_pointer;
	public IntPtr device;
	public double x_root;
	public double y_root;
}
