namespace MentorLake.Atk;

public class AtkKeyEventStructHandle : BaseSafeHandle
{
}


public static class AtkKeyEventStructExtensions
{

	public static AtkKeyEventStruct Dereference(this AtkKeyEventStructHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkKeyEventStruct>(x.DangerousGetHandle());
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
