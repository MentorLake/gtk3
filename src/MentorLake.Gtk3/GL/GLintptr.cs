namespace MentorLake.GL;


public class GLintptrHandle : BaseSafeHandle
{
}


public static class GLintptrExtensions
{

	public static GLintptr Dereference(this GLintptrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLintptr>(x.DangerousGetHandle());
}
internal class GLintptrExterns
{
}


public struct GLintptr
{
}
