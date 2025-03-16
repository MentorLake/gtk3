namespace MentorLake.GdkPixbuf;

public class GdkPixbufModulePatternHandle : BaseSafeHandle
{
}


public static class GdkPixbufModulePatternExtensions
{

	public static GdkPixbufModulePattern Dereference(this GdkPixbufModulePatternHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufModulePattern>(x.DangerousGetHandle());
}
internal class GdkPixbufModulePatternExterns
{
}

public struct GdkPixbufModulePattern
{
	public string prefix;
	public string mask;
	public int relevance;
}
