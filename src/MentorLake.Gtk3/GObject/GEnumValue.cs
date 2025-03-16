namespace MentorLake.GObject;

public class GEnumValueHandle : BaseSafeHandle
{
}


public static class GEnumValueExtensions
{

	public static GEnumValue Dereference(this GEnumValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEnumValue>(x.DangerousGetHandle());
}
internal class GEnumValueExterns
{
}

public struct GEnumValue
{
	public int value;
	public string value_name;
	public string value_nick;
}
