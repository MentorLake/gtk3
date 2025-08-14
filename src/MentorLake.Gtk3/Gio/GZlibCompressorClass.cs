namespace MentorLake.Gio;


public class GZlibCompressorClassHandle : BaseSafeHandle
{
}


public static class GZlibCompressorClassExtensions
{

	public static GZlibCompressorClass Dereference(this GZlibCompressorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GZlibCompressorClass>(x.DangerousGetHandle());
}
internal class GZlibCompressorClassExterns
{
}


public struct GZlibCompressorClass
{
	
public GObjectClass parent_class;
}
