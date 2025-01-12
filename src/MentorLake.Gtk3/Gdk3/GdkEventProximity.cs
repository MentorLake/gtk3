namespace MentorLake.Gtk3.Gdk3;

public class GdkEventProximityHandle : BaseSafeHandle
{
}


public static class GdkEventProximityHandleExtensions
{
}
internal class GdkEventProximityExterns
{
}

public struct GdkEventProximity
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public GdkDeviceHandle device;
}
