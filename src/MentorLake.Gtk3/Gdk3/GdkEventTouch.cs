namespace MentorLake.Gtk3.Gdk3;

public class GdkEventTouchHandle : BaseSafeHandle
{
}


public static class GdkEventTouchHandleExtensions
{
}
internal class GdkEventTouchExterns
{
}

public struct GdkEventTouch
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public double[] axes;
	public IntPtr state;
	public GdkEventSequenceHandle sequence;
	public bool emulating_pointer;
	public GdkDeviceHandle device;
	public double x_root;
	public double y_root;
}
