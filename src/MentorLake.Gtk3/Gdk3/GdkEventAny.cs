namespace MentorLake.Gtk3.Gdk3;

public class GdkEventAnyHandle : BaseSafeHandle
{
}


public static class GdkEventAnyHandleExtensions
{
}
internal class GdkEventAnyExterns
{
}

public struct GdkEventAny
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
}
