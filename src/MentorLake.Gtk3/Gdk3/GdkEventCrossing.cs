namespace MentorLake.Gtk3.Gdk3;

public class GdkEventCrossingHandle : BaseSafeHandle
{
}


public static class GdkEventCrossingHandleExtensions
{
}
internal class GdkEventCrossingExterns
{
}

public struct GdkEventCrossing
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkWindowHandle subwindow;
	public uint time;
	public double x;
	public double y;
	public double x_root;
	public double y_root;
	public GdkCrossingMode mode;
	public GdkNotifyType detail;
	public bool focus;
	public IntPtr state;
}
