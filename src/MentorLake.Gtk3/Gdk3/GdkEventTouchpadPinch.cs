namespace MentorLake.Gtk3.Gdk3;

public class GdkEventTouchpadPinchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchpadPinchHandleExtensions
{
}
internal class GdkEventTouchpadPinchExterns
{
}

public struct GdkEventTouchpadPinch
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
	public double angle_delta;
	public double scale;
	public double x_root;
	public double y_root;
	public IntPtr state;
}
