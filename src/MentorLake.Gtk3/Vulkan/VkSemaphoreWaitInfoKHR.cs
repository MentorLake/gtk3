namespace MentorLake.Vulkan;


public class VkSemaphoreWaitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitInfoKHRExtensions
{

	public static VkSemaphoreWaitInfoKHR Dereference(this VkSemaphoreWaitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitInfoKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitInfoKHRExterns
{
}


public struct VkSemaphoreWaitInfoKHR
{
}
