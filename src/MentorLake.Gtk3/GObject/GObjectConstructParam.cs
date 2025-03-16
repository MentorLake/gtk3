namespace MentorLake.GObject;

public class GObjectConstructParamHandle : BaseSafeHandle
{
}


public static class GObjectConstructParamExtensions
{

	public static GObjectConstructParam Dereference(this GObjectConstructParamHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GObjectConstructParam>(x.DangerousGetHandle());
}
internal class GObjectConstructParamExterns
{
}

public struct GObjectConstructParam
{
	public IntPtr pspec;
	public IntPtr value;
}
