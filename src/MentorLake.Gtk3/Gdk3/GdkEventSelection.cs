namespace MentorLake.Gtk3.Gdk3;

public class GdkEventSelectionHandle : BaseSafeHandle
{
}


public static class GdkEventSelectionHandleExtensions
{
}
internal class GdkEventSelectionExterns
{
}

public struct GdkEventSelection
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkAtom selection;
	public GdkAtom target;
	public GdkAtom property;
	public uint time;
	public GdkWindowHandle requestor;
}
