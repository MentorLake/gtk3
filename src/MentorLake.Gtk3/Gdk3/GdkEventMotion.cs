namespace MentorLake.Gtk3.Gdk3;

public class GdkEventMotionHandle : BaseSafeHandle
{
}


public static class GdkEventMotionHandleExtensions
{
}
internal class GdkEventMotionExterns
{
}

public struct GdkEventMotion
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public double[] axes;
	public IntPtr state;
	public short is_hint;
	public GdkDeviceHandle device;
	public double x_root;
	public double y_root;
}
