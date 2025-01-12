namespace MentorLake.Gtk3.Gdk3;

public class GdkEventOwnerChangeHandle : BaseSafeHandle
{
}


public static class GdkEventOwnerChangeHandleExtensions
{
}
internal class GdkEventOwnerChangeExterns
{
}

public struct GdkEventOwnerChange
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkWindowHandle owner;
	public GdkOwnerChange reason;
	public GdkAtom selection;
	public uint time;
	public uint selection_time;
}
