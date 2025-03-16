namespace MentorLake.GL;

public class GLfloatHandle : BaseSafeHandle
{
}


public static class GLfloatExtensions
{

	public static GLfloat Dereference(this GLfloatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLfloat>(x.DangerousGetHandle());
}
internal class GLfloatExterns
{
}

public struct GLfloat
{
}
