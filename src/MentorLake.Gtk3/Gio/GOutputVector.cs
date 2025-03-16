namespace MentorLake.Gio;

public class GOutputVectorHandle : BaseSafeHandle
{
}


public static class GOutputVectorExtensions
{

	public static GOutputVector Dereference(this GOutputVectorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOutputVector>(x.DangerousGetHandle());
}
internal class GOutputVectorExterns
{
}

public struct GOutputVector
{
	public IntPtr buffer;
	public UIntPtr size;
}
