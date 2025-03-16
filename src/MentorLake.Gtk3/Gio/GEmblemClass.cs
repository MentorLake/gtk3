namespace MentorLake.Gio;

public class GEmblemClassHandle : BaseSafeHandle
{
}


public static class GEmblemClassExtensions
{

	public static GEmblemClass Dereference(this GEmblemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEmblemClass>(x.DangerousGetHandle());
}
internal class GEmblemClassExterns
{
}

public struct GEmblemClass
{
}
