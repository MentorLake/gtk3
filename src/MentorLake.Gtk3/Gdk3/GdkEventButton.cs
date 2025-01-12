namespace MentorLake.Gtk3.Gdk3;

public class GdkEventButtonHandle : BaseSafeHandle
{
}


public static class GdkEventButtonHandleExtensions
{
}
internal class GdkEventButtonExterns
{
}

public struct GdkEventButton
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public double[] axes;
	public IntPtr state;
	public uint button;
	public GdkDeviceHandle device;
	public double x_root;
	public double y_root;
}
