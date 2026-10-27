namespace MentorLake.JavaScriptCore;


public class JSCContextClassHandle : BaseSafeHandle
{
}


public static class JSCContextClassExtensions
{

	public static JSCContextClass Dereference(this JSCContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCContextClass>(x.DangerousGetHandle());
}
internal class JSCContextClassExterns
{
}


public struct JSCContextClass
{
	
public GObjectClass parent_class;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
