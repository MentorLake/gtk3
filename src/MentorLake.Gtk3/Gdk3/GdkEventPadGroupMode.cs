namespace MentorLake.Gtk3.Gdk3;

public class GdkEventPadGroupModeHandle : BaseSafeHandle
{
}


public static class GdkEventPadGroupModeHandleExtensions
{
}
internal class GdkEventPadGroupModeExterns
{
}

public struct GdkEventPadGroupMode
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public uint group;
	public uint mode;
}
