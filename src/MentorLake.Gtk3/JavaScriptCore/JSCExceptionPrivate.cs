namespace MentorLake.JavaScriptCore;


public class JSCExceptionPrivateHandle : BaseSafeHandle
{
}


public static class JSCExceptionPrivateExtensions
{

	public static JSCExceptionPrivate Dereference(this JSCExceptionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCExceptionPrivate>(x.DangerousGetHandle());
}
internal class JSCExceptionPrivateExterns
{
}


public struct JSCExceptionPrivate
{
}
