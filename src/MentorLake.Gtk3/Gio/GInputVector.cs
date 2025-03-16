namespace MentorLake.Gio;

public class GInputVectorHandle : BaseSafeHandle
{
}


public static class GInputVectorExtensions
{

	public static GInputVector Dereference(this GInputVectorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInputVector>(x.DangerousGetHandle());
}
internal class GInputVectorExterns
{
}

public struct GInputVector
{
	public IntPtr buffer;
	public UIntPtr size;
}
