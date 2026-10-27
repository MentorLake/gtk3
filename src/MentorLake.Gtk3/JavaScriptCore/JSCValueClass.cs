namespace MentorLake.JavaScriptCore;


public class JSCValueClassHandle : BaseSafeHandle
{
}


public static class JSCValueClassExtensions
{

	public static JSCValueClass Dereference(this JSCValueClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCValueClass>(x.DangerousGetHandle());
}
internal class JSCValueClassExterns
{
}


public struct JSCValueClass
{
	
public GObjectClass parent_class;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
