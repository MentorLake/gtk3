namespace MentorLake.Gtk3.Atk;

public class AtkKeyEventStructHandle : BaseSafeHandle
{
}


public static class AtkKeyEventStructHandleExtensions
{
}
internal class AtkKeyEventStructExterns
{
}

public struct AtkKeyEventStruct
{
	public int type;
	public uint state;
	public uint keyval;
	public int length;
	public string @string;
	public ushort keycode;
	public uint timestamp;
}
