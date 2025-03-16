namespace MentorLake.GObject;

public class GFlagsValueHandle : BaseSafeHandle
{
}


public static class GFlagsValueExtensions
{

	public static GFlagsValue Dereference(this GFlagsValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFlagsValue>(x.DangerousGetHandle());
}
internal class GFlagsValueExterns
{
}

public struct GFlagsValue
{
	public uint value;
	public string value_name;
	public string value_nick;
}
