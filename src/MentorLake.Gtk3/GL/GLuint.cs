namespace MentorLake.GL;

public class GLuintHandle : BaseSafeHandle
{
}


public static class GLuintExtensions
{

	public static GLuint Dereference(this GLuintHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLuint>(x.DangerousGetHandle());
}
internal class GLuintExterns
{
}

public struct GLuint
{
}
