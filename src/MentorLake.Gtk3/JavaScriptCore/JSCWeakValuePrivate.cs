namespace MentorLake.JavaScriptCore;


public class JSCWeakValuePrivateHandle : BaseSafeHandle
{
}


public static class JSCWeakValuePrivateExtensions
{

	public static JSCWeakValuePrivate Dereference(this JSCWeakValuePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCWeakValuePrivate>(x.DangerousGetHandle());
}
internal class JSCWeakValuePrivateExterns
{
}


public struct JSCWeakValuePrivate
{
}
