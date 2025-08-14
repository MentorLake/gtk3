namespace MentorLake.GL;


public class GLclampfHandle : BaseSafeHandle
{
}


public static class GLclampfExtensions
{

	public static GLclampf Dereference(this GLclampfHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLclampf>(x.DangerousGetHandle());
}
internal class GLclampfExterns
{
}


public struct GLclampf
{
}
