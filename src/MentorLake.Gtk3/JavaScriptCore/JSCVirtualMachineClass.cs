namespace MentorLake.JavaScriptCore;


public class JSCVirtualMachineClassHandle : BaseSafeHandle
{
}


public static class JSCVirtualMachineClassExtensions
{

	public static JSCVirtualMachineClass Dereference(this JSCVirtualMachineClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCVirtualMachineClass>(x.DangerousGetHandle());
}
internal class JSCVirtualMachineClassExterns
{
}


public struct JSCVirtualMachineClass
{
	
public GObjectClass parent_class;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
