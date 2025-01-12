namespace MentorLake.Gtk3.Gdk3;

public class GdkEventTouchpadSwipeHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadSwipeHandleExtensions
{
}
internal class GdkEventTouchpadSwipeExterns
{
}

public struct GdkEventTouchpadSwipe
{
	public GdkEventType type;
	public GdkWindowHandle window;
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
	public IntPtr state;
}
