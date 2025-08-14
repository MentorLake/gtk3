namespace MentorLake.Vulkan;


public class VkDeferredOperationKHRHandle : BaseSafeHandle
{
}


public static class VkDeferredOperationKHRExtensions
{

	public static VkDeferredOperationKHR Dereference(this VkDeferredOperationKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeferredOperationKHR>(x.DangerousGetHandle());
}
internal class VkDeferredOperationKHRExterns
{
}


public struct VkDeferredOperationKHR
{
}
