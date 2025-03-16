namespace MentorLake.GObject;

public class GTypeFundamentalInfoHandle : BaseSafeHandle
{
}


public static class GTypeFundamentalInfoExtensions
{

	public static GTypeFundamentalInfo Dereference(this GTypeFundamentalInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeFundamentalInfo>(x.DangerousGetHandle());
}
internal class GTypeFundamentalInfoExterns
{
}

public struct GTypeFundamentalInfo
{
	public GTypeFundamentalFlags type_flags;
}
