namespace MentorLake.GL;

public class GLbooleanHandle : BaseSafeHandle
{
}


public static class GLbooleanExtensions
{

	public static GLboolean Dereference(this GLbooleanHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLboolean>(x.DangerousGetHandle());
}
internal class GLbooleanExterns
{
}

public struct GLboolean
{
}
