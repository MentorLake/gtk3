namespace MentorLake.JavaScriptCore;


public class JSCClassClassHandle : BaseSafeHandle
{
}


public static class JSCClassClassExtensions
{

	public static JSCClassClass Dereference(this JSCClassClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCClassClass>(x.DangerousGetHandle());
}
internal class JSCClassClassExterns
{
}


public struct JSCClassClass
{
}
