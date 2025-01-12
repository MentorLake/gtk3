namespace MentorLake.Gtk3.Gdk3;

public class GdkEventExposeHandle : BaseSafeHandle
{
}


public static class GdkEventExposeHandleExtensions
{
}
internal class GdkEventExposeExterns
{
}

public struct GdkEventExpose
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkRectangle area;
	public cairo_region_tHandle region;
	public int count;
}
