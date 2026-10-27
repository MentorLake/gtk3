namespace MentorLake.JavaScriptCore;


public class JSCClassPrivateHandle : BaseSafeHandle
{
}


public static class JSCClassPrivateExtensions
{

	public static JSCClassPrivate Dereference(this JSCClassPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCClassPrivate>(x.DangerousGetHandle());
}
internal class JSCClassPrivateExterns
{
}


public struct JSCClassPrivate
{
}
