namespace MentorLake.GObject;

public class GParameterHandle : BaseSafeHandle
{
}


public static class GParameterExtensions
{

	public static GParameter Dereference(this GParameterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParameter>(x.DangerousGetHandle());
}
internal class GParameterExterns
{
}

public struct GParameter
{
	public string name;
	public GValue value;
}
