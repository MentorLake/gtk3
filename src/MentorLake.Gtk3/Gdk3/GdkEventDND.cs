namespace MentorLake.Gtk3.Gdk3;

public class GdkEventDNDHandle : BaseSafeHandle
{
}


public static class GdkEventDNDHandleExtensions
{
}
internal class GdkEventDNDExterns
{
}

public struct GdkEventDND
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkDragContextHandle context;
	public uint time;
	public short x_root;
	public short y_root;
}
