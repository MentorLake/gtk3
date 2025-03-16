namespace MentorLake.Gdk;

public class GdkEventTouchpadSwipeHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadSwipeExtensions
{

	public static GdkEventTouchpadSwipe Dereference(this GdkEventTouchpadSwipeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventTouchpadSwipe>(x.DangerousGetHandle());
}
internal class GdkEventTouchpadSwipeExterns
{
}

public struct GdkEventTouchpadSwipe
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public byte phase;
	public byte n_fingers;
	public uint time;
	public double x;
	public double y;
	public double dx;
	public double dy;
	public double x_root;
	public double y_root;
	public GdkModifierType state;
}
