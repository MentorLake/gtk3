namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// JSCVirtualMachine represents a group of JSCContext&amp;lt;!-- --&amp;gt;s. It allows
/// concurrent JavaScript execution by creating a different instance of
/// JSCVirtualMachine in each thread.
/// </para>
/// <para>
/// To create a group of JSCContext&amp;lt;!-- --&amp;gt;s pass the same JSCVirtualMachine
/// instance to every JSCContext constructor.
/// </para>
/// </summary>

public class JSCVirtualMachineHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #JSCVirtualMachine.
/// </para>
/// </summary>

/// <return>
/// the newly created #JSCVirtualMachine.
/// </return>

	public static MentorLake.JavaScriptCore.JSCVirtualMachineHandle New()
	{
		return JSCVirtualMachineHandleExterns.jsc_virtual_machine_new();
	}

}

public static class JSCVirtualMachineHandleExtensions
{
}

internal class JSCVirtualMachineHandleExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCVirtualMachineHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCVirtualMachineHandle jsc_virtual_machine_new();

}
