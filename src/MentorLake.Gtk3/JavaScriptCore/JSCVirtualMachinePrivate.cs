namespace MentorLake.JavaScriptCore;


public class JSCVirtualMachinePrivateHandle : BaseSafeHandle
{
}


public static class JSCVirtualMachinePrivateExtensions
{

	public static JSCVirtualMachinePrivate Dereference(this JSCVirtualMachinePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCVirtualMachinePrivate>(x.DangerousGetHandle());
}
internal class JSCVirtualMachinePrivateExterns
{
}


public struct JSCVirtualMachinePrivate
{
}
