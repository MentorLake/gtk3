namespace MentorLake.Gtk3.Gdk3;

public class GdkEventPadButtonHandle : BaseSafeHandle
{
}


public static class GdkEventPadButtonHandleExtensions
{
}
internal class GdkEventPadButtonExterns
{
}

public struct GdkEventPadButton
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint button;
	public uint mode;
}
