namespace MentorLake.Gtk3.Gdk3;

public class GdkEventScrollHandle : BaseSafeHandle
{
}


public static class GdkEventScrollHandleExtensions
{
}
internal class GdkEventScrollExterns
{
}

public struct GdkEventScroll
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public double x;
	public double y;
	public IntPtr state;
	public GdkScrollDirection direction;
	public GdkDeviceHandle device;
	public double x_root;
	public double y_root;
	public double delta_x;
	public double delta_y;
	public uint is_stop;
}
