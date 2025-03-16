namespace MentorLake.Gio;

public class GZlibDecompressorClassHandle : BaseSafeHandle
{
}


public static class GZlibDecompressorClassExtensions
{

	public static GZlibDecompressorClass Dereference(this GZlibDecompressorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GZlibDecompressorClass>(x.DangerousGetHandle());
}
internal class GZlibDecompressorClassExterns
{
}

public struct GZlibDecompressorClass
{
	public GObjectClass parent_class;
}
