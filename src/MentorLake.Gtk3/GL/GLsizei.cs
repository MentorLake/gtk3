namespace MentorLake.GL;

public class GLsizeiHandle : BaseSafeHandle
{
}


public static class GLsizeiExtensions
{

	public static GLsizei Dereference(this GLsizeiHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLsizei>(x.DangerousGetHandle());
}
internal class GLsizeiExterns
{
}

public struct GLsizei
{
}
