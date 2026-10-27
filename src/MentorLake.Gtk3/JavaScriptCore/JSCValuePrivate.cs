namespace MentorLake.JavaScriptCore;


public class JSCValuePrivateHandle : BaseSafeHandle
{
}


public static class JSCValuePrivateExtensions
{

	public static JSCValuePrivate Dereference(this JSCValuePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCValuePrivate>(x.DangerousGetHandle());
}
internal class JSCValuePrivateExterns
{
}


public struct JSCValuePrivate
{
}
