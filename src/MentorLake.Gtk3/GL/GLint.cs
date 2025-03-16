namespace MentorLake.GL;

public class GLintHandle : BaseSafeHandle
{
}


public static class GLintExtensions
{

	public static GLint Dereference(this GLintHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLint>(x.DangerousGetHandle());
}
internal class GLintExterns
{
}

public struct GLint
{
}
