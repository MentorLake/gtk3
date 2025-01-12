namespace MentorLake.Gtk3.Gdk3;

public class GdkEventFocusHandle : BaseSafeHandle
{
}


public static class GdkEventFocusHandleExtensions
{
}
internal class GdkEventFocusExterns
{
}

public struct GdkEventFocus
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public short @in;
}
