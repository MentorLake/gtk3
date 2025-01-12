namespace MentorLake.Gtk3.Gdk3;

public class GdkEventVisibilityHandle : BaseSafeHandle
{
}


public static class GdkEventVisibilityHandleExtensions
{
}
internal class GdkEventVisibilityExterns
{
}

public struct GdkEventVisibility
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkVisibilityState state;
}
