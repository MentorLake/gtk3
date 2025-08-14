namespace MentorLake.GL;


public class GLhandleARBHandle : BaseSafeHandle
{
}


public static class GLhandleARBExtensions
{

	public static GLhandleARB Dereference(this GLhandleARBHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLhandleARB>(x.DangerousGetHandle());
}
internal class GLhandleARBExterns
{
}


public struct GLhandleARB
{
}
