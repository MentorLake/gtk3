namespace MentorLake.Gtk3.Gdk3;

public class GdkEventWindowStateHandle : BaseSafeHandle
{
}


public static class GdkEventWindowStateHandleExtensions
{
}
internal class GdkEventWindowStateExterns
{
}

public struct GdkEventWindowState
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkWindowState changed_mask;
	public GdkWindowState new_window_state;
}
