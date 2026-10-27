namespace MentorLake.JavaScriptCore;


public class JSCContextPrivateHandle : BaseSafeHandle
{
}


public static class JSCContextPrivateExtensions
{

	public static JSCContextPrivate Dereference(this JSCContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCContextPrivate>(x.DangerousGetHandle());
}
internal class JSCContextPrivateExterns
{
}


public struct JSCContextPrivate
{
}
