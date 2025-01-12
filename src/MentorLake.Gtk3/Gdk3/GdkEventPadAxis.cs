namespace MentorLake.Gtk3.Gdk3;

public class GdkEventPadAxisHandle : BaseSafeHandle
{
}


public static class GdkEventPadAxisHandleExtensions
{
}
internal class GdkEventPadAxisExterns
{
}

public struct GdkEventPadAxis
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint index;
	public uint mode;
	public double value;
}
