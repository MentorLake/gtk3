namespace MentorLake.Gtk3.Gdk3;

public class GdkEventConfigureHandle : BaseSafeHandle
{
}


public static class GdkEventConfigureHandleExtensions
{
}
internal class GdkEventConfigureExterns
{
}

public struct GdkEventConfigure
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public int x;
	public int y;
	public int width;
	public int height;
}
