namespace MentorLake.GL;

public class GLvoidHandle : BaseSafeHandle
{
}


public static class GLvoidExtensions
{

	public static GLvoid Dereference(this GLvoidHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLvoid>(x.DangerousGetHandle());
}
internal class GLvoidExterns
{
}

public struct GLvoid
{
}
