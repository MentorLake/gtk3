namespace MentorLake.JavaScriptCore;


public class JSCExceptionClassHandle : BaseSafeHandle
{
}


public static class JSCExceptionClassExtensions
{

	public static JSCExceptionClass Dereference(this JSCExceptionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCExceptionClass>(x.DangerousGetHandle());
}
internal class JSCExceptionClassExterns
{
}


public struct JSCExceptionClass
{
	
public GObjectClass parent_class;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
