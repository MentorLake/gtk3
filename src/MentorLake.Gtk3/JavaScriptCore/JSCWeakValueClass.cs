namespace MentorLake.JavaScriptCore;


public class JSCWeakValueClassHandle : BaseSafeHandle
{
}


public static class JSCWeakValueClassExtensions
{

	public static JSCWeakValueClass Dereference(this JSCWeakValueClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCWeakValueClass>(x.DangerousGetHandle());
}
internal class JSCWeakValueClassExterns
{
}


public struct JSCWeakValueClass
{
	
public GObjectClass parent_class;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
