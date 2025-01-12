namespace MentorLake.Gtk3.Gdk3;

public class GdkEventPropertyHandle : BaseSafeHandle
{
}


public static class GdkEventPropertyHandleExtensions
{
}
internal class GdkEventPropertyExterns
{
}

public struct GdkEventProperty
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkAtom atom;
	public uint time;
	public None state;
}
