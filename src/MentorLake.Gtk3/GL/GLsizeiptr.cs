namespace MentorLake.GL;


public class GLsizeiptrHandle : BaseSafeHandle
{
}


public static class GLsizeiptrExtensions
{

	public static GLsizeiptr Dereference(this GLsizeiptrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLsizeiptr>(x.DangerousGetHandle());
}
internal class GLsizeiptrExterns
{
}


public struct GLsizeiptr
{
}
