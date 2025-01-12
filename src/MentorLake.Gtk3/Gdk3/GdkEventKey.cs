namespace MentorLake.Gtk3.Gdk3;

public class GdkEventKeyHandle : BaseSafeHandle
{
}


public static class GdkEventKeyHandleExtensions
{
}
internal class GdkEventKeyExterns
{
}

public struct GdkEventKey
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public uint time;
	public IntPtr state;
	public uint keyval;
	public int length;
	public string @string;
	public ushort hardware_keycode;
	public byte group;
	public uint is_modifier;
}
