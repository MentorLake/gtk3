namespace MentorLake.GL;


public class GLcharARBHandle : BaseSafeHandle
{
}


public static class GLcharARBExtensions
{

	public static GLcharARB Dereference(this GLcharARBHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLcharARB>(x.DangerousGetHandle());
}
internal class GLcharARBExterns
{
}


public struct GLcharARB
{
}
