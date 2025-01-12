namespace MentorLake.Gtk3.Gdk3;

public class GdkEventGrabBrokenHandle : BaseSafeHandle
{
}


public static class GdkEventGrabBrokenHandleExtensions
{
}
internal class GdkEventGrabBrokenExterns
{
}

public struct GdkEventGrabBroken
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public bool keyboard;
	public bool @implicit;
	public GdkWindowHandle grab_window;
}
