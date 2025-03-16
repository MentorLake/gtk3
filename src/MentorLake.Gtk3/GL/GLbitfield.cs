namespace MentorLake.GL;

public class GLbitfieldHandle : BaseSafeHandle
{
}


public static class GLbitfieldExtensions
{

	public static GLbitfield Dereference(this GLbitfieldHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLbitfield>(x.DangerousGetHandle());
}
internal class GLbitfieldExterns
{
}

public struct GLbitfield
{
}
